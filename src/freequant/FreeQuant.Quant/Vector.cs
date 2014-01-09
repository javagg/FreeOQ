using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Quant
{
  public class Vector
  {
		private int nrows; 
		private double[] elements; 

    public int NRows
    {
       get
      {
        return this.nrows;
      }
    }

    public double[] Elements
    {
       get
      {
        return this.elements;
      }
    }

    public double this[int index]
    {
       get
      {
        return this.elements[index];
      }
       set
      {
        this.elements[index] = value;
      }
    }

    public Vector()
    {
      this.nrows = -1;
    }

    public Vector(int nrows)
    {
      this.gbFbjaEcH(nrows, 0);
    }

    public static double operator *(Vector v1, Vector v2)
    {
      double num = 0.0;
      for (int index = 0; index < v1.nrows; ++index)
        num += v1[index] * v2[index];
      return num;
    }

    public static Vector operator *(Vector vector, double val)
    {
      Vector vector1 = new Vector(vector.nrows);
      for (int index = 0; index < vector.nrows; ++index)
        vector1[index] = vector[index] * val;
      return vector1;
    }

    
    public static Vector operator +(Vector vector, double val)
    {
      Vector vector1 = new Vector(vector.nrows);
      for (int index = 0; index < vector.nrows; ++index)
        vector1[index] = vector[index] + val;
      return vector1;
    }

    public static Vector operator -(Vector vector, double val)
    {
      Vector vector1 = new Vector(vector.nrows);
      for (int index = 0; index < vector.nrows; ++index)
        vector1[index] = vector[index] - val;
      return vector1;
    }

    public static Vector operator +(Vector target, Vector source)
    {
      Vector vector = new Vector(target.nrows);
      for (int index = 0; index < target.nrows; ++index)
        vector[index] = target[index] + source[index];
      return vector;
    }

    
    public static Vector operator -(Vector target, Vector source)
    {
      Vector vector = new Vector(target.nrows);
      for (int index = 0; index < target.nrows; ++index)
        vector[index] = target[index] - source[index];
      return vector;
    }

    private void gbFbjaEcH([In] int obj0, [In] int obj1)
    {
      this.nrows = obj0;
      this.elements = new double[this.nrows];
    }

    
    public bool IsValid()
    {
      return this.nrows != -1;
    }

    
    public static bool AreCompatible(Vector v1, Vector v2)
    {
      return v1.nrows == v2.nrows;
    }

    public void Zero()
    {
      for (int index = 0; index < this.nrows; ++index)
        this.elements[index] = 0.0;
    }

    
    public void ResizeTo(int newNRows)
    {
      double[] numArray = new double[newNRows];
      int num = Math.Min(this.nrows, newNRows);
      for (int index = 0; index < num; ++index)
        numArray[index] = this.elements[index];
      this.nrows = newNRows;
      this.elements = numArray;
    }

    public double Norm1()
    {
      double num1 = 0.0;
      foreach (double num2 in this.elements)
        num1 += num2;
      return num1;
    }

    
    public double Norm2Sqr()
    {
      double num1 = 0.0;
      foreach (double num2 in this.elements)
        num1 += num2 * num2;
      return num1;
    }

    public double NormInf()
    {
      double val1 = 0.0;
      foreach (double num in this.elements)
        val1 = Math.Max(val1, Math.Abs(num));
      return val1;
    }

    
    public Vector Abs()
    {
      Vector vector = new Vector(this.nrows);
      for (int index = 0; index < this.nrows; ++index)
        vector[index] = Math.Abs(this.elements[index]);
      return vector;
    }

    public Vector Sqr()
    {
      Vector vector = new Vector(this.nrows);
      for (int index = 0; index < this.nrows; ++index)
        vector[index] = this.elements[index] * this.elements[index];
      return vector;
    }

    public Vector Sqrt()
    {
      Vector vector = new Vector(this.nrows);
      for (int index = 0; index < this.nrows; ++index)
        vector[index] = Math.Sqrt(this.elements[index]);
      return vector;
    }

    public Vector ElementMult(Vector target, Vector source)
    {
      Vector vector = new Vector(target.nrows);
      for (int index = 0; index < this.nrows; ++index)
        vector[index] = target[index] * source[index];
      return vector;
    }

    public Vector ElementDiv(Vector target, Vector source)
    {
      Vector vector = new Vector(target.nrows);
      for (int index = 0; index < this.nrows; ++index)
        vector[index] = target[index] / source[index];
      return vector;
    }

    public override bool Equals(object vector)
    {
      Vector vector1 = (Vector) vector;
      if (this.nrows != vector1.nrows)
        return false;
      for (int index = 0; index < vector1.nrows; ++index)
      {
        if (this[index] != vector1[index])
          return false;
      }
      return true;
    }

    public override int GetHashCode()
    {
      return base.GetHashCode();
    }

    public override string ToString()
    {
      return base.ToString();
    }

    public void Print()
    {
			this.Print(String.Empty);
    }

    public void Print(string Format)
    {
      for (int index = 0; index < this.nrows; ++index)
				Console.WriteLine(this.elements[index].ToString(Format) + String.Empty);
    }
  }
}
