using System;

namespace OpenQuant.API.Quant
{
	///<summary>
	///  A vector 
	///</summary>
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
			this.Allocate(nrows, 0);
		}

		public static double operator *(Vector v1, Vector v2)
		{
			if (!Vector.AreCompatible(v1, v2))
				throw new ApplicationException("Vectors are not compatible");
			double num = 0.0;
			for (int index = 0; index < v1.nrows; ++index)
				num += v1[index] * v2[index];
			return num;
		}

		public static Vector operator *(Vector vector, double val)
		{
			if (!vector.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector1 = new Vector(vector.nrows);
			for (int index = 0; index < vector.nrows; ++index)
				vector1[index] = vector[index] * val;
			return vector1;
		}

		public static Vector operator +(Vector vector, double val)
		{
			if (!vector.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector1 = new Vector(vector.nrows);
			for (int index = 0; index < vector.nrows; ++index)
				vector1[index] = vector[index] + val;
			return vector1;
		}

		public static Vector operator -(Vector vector, double val)
		{
			if (!vector.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector1 = new Vector(vector.nrows);
			for (int index = 0; index < vector.nrows; ++index)
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
			Vector vector = new Vector(target.nrows);
			for (int index = 0; index < target.nrows; ++index)
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
			Vector vector = new Vector(target.nrows);
			for (int index = 0; index < target.nrows; ++index)
				vector[index] = target[index] - source[index];
			return vector;
		}

		private void Allocate(int nrows, int row_lwb)
		{
			if (nrows <= 0)
				throw new ArgumentException("Number of rows has to be positive");
			this.nrows = nrows;
			this.elements = new double[this.nrows];
		}

		public bool IsValid()
		{
			return this.nrows != -1;
		}

		public static bool AreCompatible(Vector v1, Vector v2)
		{
			if (!v1.IsValid())
				throw new ArgumentException("Vector 1 is not initialized");
			if (!v2.IsValid())
				throw new ArgumentException("Vector 2 is not initialized");
			return v1.nrows == v2.nrows;
		}

		public void Zero()
		{
			for (int index = 0; index < this.nrows; ++index)
				this.elements[index] = 0.0;
		}

		public void ResizeTo(int newNRows)
		{
			if (newNRows <= 0)
				throw new ArgumentException("Number of rows has to be positive");
			double[] numArray = new double[newNRows];
			int num = Math.Min(this.nrows, newNRows);
			for (int index = 0; index < num; ++index)
				numArray[index] = this.elements[index];
			this.nrows = newNRows;
			this.elements = numArray;
		}

		public double Norm1()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			double num1 = 0.0;
			foreach (double num2 in this.elements)
				num1 += num2;
			return num1;
		}

		public double Norm2Sqr()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			double num1 = 0.0;
			foreach (double num2 in this.elements)
				num1 += num2 * num2;
			return num1;
		}

		public double NormInf()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			double val1 = 0.0;
			foreach (double num in this.elements)
				val1 = Math.Max(val1, Math.Abs(num));
			return val1;
		}

		public Vector Abs()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector = new Vector(this.nrows);
			for (int index = 0; index < this.nrows; ++index)
				vector[index] = Math.Abs(this.elements[index]);
			return vector;
		}

		public Vector Sqr()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector = new Vector(this.nrows);
			for (int index = 0; index < this.nrows; ++index)
				vector[index] = this.elements[index] * this.elements[index];
			return vector;
		}

		public Vector Sqrt()
		{
			if (!this.IsValid())
				throw new ApplicationException("Vector is not initialized");
			Vector vector = new Vector(this.nrows);
			for (int index = 0; index < this.nrows; ++index)
				vector[index] = Math.Sqrt(this.elements[index]);
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
			Vector vector = new Vector(target.nrows);
			for (int index = 0; index < this.nrows; ++index)
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
			Vector vector = new Vector(target.nrows);
			for (int index = 0; index < this.nrows; ++index)
				vector[index] = target[index] / source[index];
			return vector;
		}

		public override bool Equals(object vector)
		{
			Vector vector1 = (Vector)vector;
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
			this.Print("F2");
		}

		public void Print(string Format)
		{
			for (int index = 0; index < this.nrows; ++index)
				Console.WriteLine(this.elements[index].ToString(Format) + " ");
		}
	}
}
