using FreeQuant.Testing;
using FreeQuant.Testing.TesterItems;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant.Trading
{
  [StrategyComponent("{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}", ComponentType.ReportManager, Description = "", Name = "Default_ReportManager")]
  public class ReportManager : ComponentBase
  {
    public const string GUID = "{5E7810DC-C9C1-427f-8CD9-1DFFE26E59B5}";
    protected LiveTester tester;

    [Browsable(false)]
    public LiveTester Tester
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.tester;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.tester = value;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public ReportManager()
    {
      oVoTkGp5q2gt8BRDXu5.g6GSKyfzPYiPV();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void RemoveAllStatistics()
    {
      foreach (TesterItem testerItem in this.tester.Components)
      {
        if (testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = false;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddAllStatistics()
    {
      foreach (TesterItem testerItem in this.tester.Components)
      {
        if (testerItem is SeriesTesterItem)
          (testerItem as SeriesTesterItem).Enabled = true;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddStatistics(string name)
    {
      TesterItem testerItem = this.tester.Components[name];
      if (!(testerItem is SeriesTesterItem))
        return;
      (testerItem as SeriesTesterItem).Enabled = true;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void AddComponentSet(string setName)
    {
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(5526))
      {
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5570));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5600));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5626));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5648));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5670));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5690));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5710));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5750));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5786));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5822));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5858));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5892));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5946));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(5998));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6052));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6106));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6162));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6216));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6272));
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(6328))
      {
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6358));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6380));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6426));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6456));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6502));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6538));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6576));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6622));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6668));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6688));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6708));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6734));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(6748));
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(6762))
      {
        string[] strArray1 = new string[5]
        {
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6802),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6818),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6834),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6850),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6864)
        };
        string[] strArray2 = new string[4]
        {
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6878),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6890),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6904),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6920)
        };
        string[] strArray3 = new string[3]
        {
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(6934),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(7046),
          USaG3GpjZagj1iVdv4u.Y4misFk9D9(7156)
        };
        foreach (string str in strArray3)
        {
          for (int index1 = 0; index1 < strArray1.Length; ++index1)
          {
            for (int index2 = 0; index2 < strArray2.Length; ++index2)
              this.tester.EnableComponent(str.Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7264), strArray1[index1]).Replace(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7276), strArray2[index2]));
          }
        }
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(7288))
      {
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7302));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7340));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7372));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7410));
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(7452))
      {
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7470));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7512));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7548));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7590));
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(7636))
      {
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7652));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7692));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7726));
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(7766));
      }
      if (setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(7810))
      {
        foreach (string name in new ArrayList()
        {
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(7856),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(7900),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(7960),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8018),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8072),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8118),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8176),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8242),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8306),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8358),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8396),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8450),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8502),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8556),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8608),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8664),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8694),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8752),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8808),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8860),
          (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(8912)
        })
        {
          this.tester.EnableComponent(name);
          this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(8962) + name);
          this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(8980) + name);
        }
      }
      if (!(setName == USaG3GpjZagj1iVdv4u.Y4misFk9D9(9000)))
        return;
      foreach (string name in new ArrayList()
      {
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9064),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9120),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9184),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9256),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9336),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9414),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9494),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9574),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9644),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9722),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9798),
        (object) USaG3GpjZagj1iVdv4u.Y4misFk9D9(9876)
      })
      {
        this.tester.EnableComponent(name);
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(9954) + name);
        this.tester.EnableComponent(USaG3GpjZagj1iVdv4u.Y4misFk9D9(9972) + name);
      }
    }
  }
}
