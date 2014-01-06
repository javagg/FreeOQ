using System;

namespace OpenQuant.API.Quant
{
  public class Vector
  {
    private int fNRows;
    private double[] fElements;

    public int NRows
    {
      get
      {
        return this.fNRows;
      }
    }

    public double[] Elements
    {
      get
      {
        return this.fElements;
      }
    }

    public double this[int index]
    {
      get
      {
        return this.fElements[index];
      }
      set
      {
        this.fElements[index] = value;
      }
    }

    public Vector()
    {
      this.fNRows = -1;
    }

    public Vector(int nrows)
    {
      this.Allocate(nrows, 0);
    }

    public static double operator *(Vector v1, Vector v2)
    {
      if (!Vector.AreCompatible(v1, v2))
        throw new ApplicationException("Vectors are not compatible");
      double num = 0.0;
      for (int index = 0; index < v1.fNRows; ++index)
        num += v1[index] * v2[index];
      return num;
    }

    public static Vector operator *(Vector vector, double val)
    {
      if (!vector.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector1 = new Vector(vector.fNRows);
      for (int index = 0; index < vector.fNRows; ++index)
        vector1[index] = vector[index] * val;
      return vector1;
    }

    public static Vector operator +(Vector vector, double val)
    {
      if (!vector.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector1 = new Vector(vector.fNRows);
      for (int index = 0; index < vector.fNRows; ++index)
        vector1[index] = vector[index] + val;
      return vector1;
    }

    public static Vector operator -(Vector vector, double val)
    {
      if (!vector.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector1 = new Vector(vector.fNRows);
      for (int index = 0; index < vector.fNRows; ++index)
        vector1[index] = vector[index] - val;
      return vector1;
    }

    public static Vector operator +(Vector target, Vector source)
    {
      if (!source.IsValid())
        throw new ApplicationException("Source vector is not initialized");
      if (!target.IsValid())
        throw new ApplicationException("Target vector is not initialized");
      if (!Vector.AreCompatible(target, source))
        throw new ApplicationException("Vectors are not compatible");
      Vector vector = new Vector(target.fNRows);
      for (int index = 0; index < target.fNRows; ++index)
        vector[index] = target[index] + source[index];
      return vector;
    }

    public static Vector operator -(Vector target, Vector source)
    {
      if (!source.IsValid())
        throw new ApplicationException("Source vector is not initialized");
      if (!target.IsValid())
        throw new ApplicationException("Target vector is not initialized");
      if (!Vector.AreCompatible(target, source))
        throw new ApplicationException("Vectors are not compatible");
      Vector vector = new Vector(target.fNRows);
      for (int index = 0; index < target.fNRows; ++index)
        vector[index] = target[index] - source[index];
      return vector;
    }

    private void Allocate(int nrows, int row_lwb)
    {
      if (nrows <= 0)
        throw new ArgumentException("Number of rows has to be positive");
      this.fNRows = nrows;
      this.fElements = new double[this.fNRows];
    }

    public bool IsValid()
    {
      return this.fNRows != -1;
    }

    public static bool AreCompatible(Vector v1, Vector v2)
    {
      if (!v1.IsValid())
        throw new ArgumentException("Vector 1 is not initialized");
      if (!v2.IsValid())
        throw new ArgumentException("Vector 2 is not initialized");
      return v1.fNRows == v2.fNRows;
    }

    public void Zero()
    {
      for (int index = 0; index < this.fNRows; ++index)
        this.fElements[index] = 0.0;
    }

    public void ResizeTo(int newNRows)
    {
      if (newNRows <= 0)
        throw new ArgumentException("Number of rows has to be positive");
      double[] numArray = new double[newNRows];
      int num = Math.Min(this.fNRows, newNRows);
      for (int index = 0; index < num; ++index)
        numArray[index] = this.fElements[index];
      this.fNRows = newNRows;
      this.fElements = numArray;
    }

    public double Norm1()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      double num1 = 0.0;
      foreach (double num2 in this.fElements)
        num1 += num2;
      return num1;
    }

    public double Norm2Sqr()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      double num1 = 0.0;
      foreach (double num2 in this.fElements)
        num1 += num2 * num2;
      return num1;
    }

    public double NormInf()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      double val1 = 0.0;
      foreach (double num in this.fElements)
        val1 = Math.Max(val1, Math.Abs(num));
      return val1;
    }

    public Vector Abs()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector = new Vector(this.fNRows);
      for (int index = 0; index < this.fNRows; ++index)
        vector[index] = Math.Abs(this.fElements[index]);
      return vector;
    }

    public Vector Sqr()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector = new Vector(this.fNRows);
      for (int index = 0; index < this.fNRows; ++index)
        vector[index] = this.fElements[index] * this.fElements[index];
      return vector;
    }

    public Vector Sqrt()
    {
      if (!this.IsValid())
        throw new ApplicationException("Vector is not initialized");
      Vector vector = new Vector(this.fNRows);
      for (int index = 0; index < this.fNRows; ++index)
        vector[index] = Math.Sqrt(this.fElements[index]);
      return vector;
    }

    public Vector ElementMult(Vector target, Vector source)
    {
      if (!source.IsValid())
        throw new ApplicationException("Source vector is not initialized");
      if (!target.IsValid())
        throw new ApplicationException("Target vector is not initialized");
      if (!Vector.AreCompatible(target, source))
        throw new ApplicationException("Vectors are not compatible");
      Vector vector = new Vector(target.fNRows);
      for (int index = 0; index < this.fNRows; ++index)
        vector[index] = target[index] * source[index];
      return vector;
    }

    public Vector ElementDiv(Vector target, Vector source)
    {
      if (!source.IsValid())
        throw new ApplicationException("Source vector is not initialized");
      if (!target.IsValid())
        throw new ApplicationException("Target vector is not initialized");
      if (!Vector.AreCompatible(target, source))
        throw new ApplicationException("Vectors are not compatible");
      Vector vector = new Vector(target.fNRows);
      for (int index = 0; index < this.fNRows; ++index)
        vector[index] = target[index] / source[index];
      return vector;
    }

    public override bool Equals(object vector)
    {
      Vector vector1 = (Vector) vector;
      if (this.fNRows != vector1.fNRows)
        return false;
      for (int index = 0; index < vector1.fNRows; ++index)
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
      this.Print("F2");
    }

    public void Print(string Format)
    {
      for (int index = 0; index < this.fNRows; ++index)
        Console.WriteLine(this.fElements[index].ToString(Format) + " ");
    }
  }
}
