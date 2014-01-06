using OpenQuant.API;
using FreeQuant.Optimization;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace OpenQuant.Trading
{
  public class StrategyOptimizer : IOptimizable
  {
    private Optimizer optimizer;
    private EOptimizerType optimizerType;
    private ObjectiveType objectiveType;
    private SolutionRunner solutionRunner;
    private Dictionary<string, Dictionary<string, OptimizationParameter>> parameters;
    private List<OptimizationParameter> parameterList;

    public Dictionary<string, Dictionary<string, OptimizationParameter>> Parameters
    {
      get
      {
        return this.parameters;
      }
    }

    public List<OptimizationParameter> ParameterList
    {
      get
      {
        return this.parameterList;
      }
    }

    public SolutionRunner SolutionRunner
    {
      get
      {
        return this.solutionRunner;
      }
    }

    public Optimizer Optimizer
    {
      get
      {
        return this.optimizer;
      }
    }

    public EOptimizerType OptimizerType
    {
      get
      {
        return this.optimizerType;
      }
      set
      {
        if (this.optimizerType == value)
          return;
        this.optimizerType = value;
        switch (this.optimizerType - 3)
        {
          case 0:
            this.optimizer = (Optimizer) new SimulatedAnnealing((IOptimizable) this);
            break;
          case 1:
            this.optimizer = (Optimizer) new BruteForce((IOptimizable) this);
            break;
          default:
            throw new NotSupportedException(((object) this.optimizerType).ToString() + " Optimizer Type is not supported");
        }
      }
    }

    public ObjectiveType ObjectiveType
    {
      get
      {
        return this.objectiveType;
      }
      set
      {
        this.objectiveType = value;
      }
    }

    public int TotalLoops
    {
      get
      {
        int num = 1;
        foreach (Dictionary<string, OptimizationParameter> dictionary in this.parameters.Values)
        {
          foreach (OptimizationParameter optimizationParameter in dictionary.Values)
          {
            if (optimizationParameter.Enabled)
              num *= optimizationParameter.Loops;
          }
        }
        return num;
      }
    }

    public event EventHandler ObjectiveCalled;

    public StrategyOptimizer(SolutionRunner solutionRunner)
    {
      this.solutionRunner = solutionRunner;
      this.parameters = new Dictionary<string, Dictionary<string, OptimizationParameter>>();
      this.parameterList = new List<OptimizationParameter>();
      this.OptimizerType = (EOptimizerType) 4;
      this.LoadParameters();
    }

    private void LoadParameters()
    {
      this.parameters.Clear();
      foreach (StrategyRunner strategyRunner in this.solutionRunner.Runners.Values)
      {
        if (strategyRunner.Enabled)
        {
          Strategy strategy = strategyRunner.Strategy;
          Dictionary<string, OptimizationParameter> dictionary = new Dictionary<string, OptimizationParameter>();
          this.parameters[strategyRunner.StrategyName] = dictionary;
          foreach (FieldInfo fieldInfo in strategy.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
          {
            object[] customAttributes = fieldInfo.GetCustomAttributes(typeof (OptimizationParameterAttribute), false);
            if (customAttributes.Length > 0)
            {
              OptimizationParameterAttribute parameterAttribute = customAttributes[0] as OptimizationParameterAttribute;
              if (!(fieldInfo.FieldType != typeof (int)) || !(fieldInfo.FieldType != typeof (float)) || (!(fieldInfo.FieldType != typeof (double)) || !(fieldInfo.FieldType != typeof (Decimal))))
              {
                EParamType type = (EParamType) 0;
                if (fieldInfo.FieldType == typeof (float) || fieldInfo.FieldType == typeof (double) || fieldInfo.FieldType == typeof (Decimal))
                  type = (EParamType) 1;
                OptimizationParameter optimizationParameter = new OptimizationParameter(strategyRunner.StrategyName, fieldInfo.Name, parameterAttribute.Start, parameterAttribute.Stop, parameterAttribute.Step, type);
                dictionary[fieldInfo.Name] = optimizationParameter;
                this.parameterList.Add(optimizationParameter);
              }
            }
          }
        }
      }
    }

    public void Init(ParamSet paramSet)
    {
      int num = 0;
      foreach (Dictionary<string, OptimizationParameter> dictionary in this.parameters.Values)
      {
        foreach (OptimizationParameter optimizationParameter in dictionary.Values)
        {
          if (optimizationParameter.Enabled)
          {
            paramSet.SetParamName(num, optimizationParameter.Name);
            paramSet.SetParam(num, optimizationParameter.Start + (optimizationParameter.Stop - optimizationParameter.Start) / 2.0);
            paramSet.SetLowerBound(num, optimizationParameter.Start);
            paramSet.SetUpperBound(num, optimizationParameter.Stop);
            paramSet.SetSteps(num, optimizationParameter.Step);
            paramSet.SetParamType(num, optimizationParameter.Type);
            optimizationParameter.Number = num;
            ++num;
          }
        }
      }
    }

    public double Objective()
    {
      if (this.ObjectiveCalled != null)
        this.ObjectiveCalled((object) this, EventArgs.Empty);
      switch (this.objectiveType)
      {
        case ObjectiveType.FinalWealth:
          return -this.solutionRunner.Portfolio.Performance.Equity;
        case ObjectiveType.MaxDrawdown:
          if (this.solutionRunner.Portfolio.Performance.DrawdownSeries.Count == 0)
            return double.NaN;
          else
            return -this.solutionRunner.Portfolio.Performance.DrawdownSeries.GetMin();
        case ObjectiveType.FinalWealthDivMaxDrawdown:
          if (this.solutionRunner.Portfolio.Performance.DrawdownSeries.Count == 0)
            return double.NaN;
          double num = -this.solutionRunner.Portfolio.Performance.DrawdownSeries.GetMin();
          if (num <= 4.94065645841247E-324)
            return double.NaN;
          else
            return -this.solutionRunner.Portfolio.Performance.Equity / num;
        default:
          throw new NotSupportedException(((object) this.objectiveType).ToString() + " Objective Type is not supported");
      }
    }

    public void OnCircle()
    {
    }

    public void OnStep()
    {
    }

    public void Update(ParamSet paramSet)
    {
      foreach (StrategyRunner strategyRunner in this.solutionRunner.Runners.Values)
      {
        if (strategyRunner.Enabled)
        {
          Strategy strategy = strategyRunner.Strategy;
          Dictionary<string, OptimizationParameter> dictionary = this.parameters[strategyRunner.StrategyName];
          foreach (FieldInfo fieldInfo in strategy.GetType().GetFields(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
          {
            if (dictionary.ContainsKey(fieldInfo.Name) && dictionary[fieldInfo.Name].Enabled)
            {
              int number = dictionary[fieldInfo.Name].Number;
              if (fieldInfo.FieldType == typeof (int))
                fieldInfo.SetValue((object) strategy, (object) (int) paramSet.GetParam(number));
              if (fieldInfo.FieldType == typeof (double))
                fieldInfo.SetValue((object) strategy, (object) paramSet.GetParam(number));
            }
          }
        }
      }
    }
  }
}
