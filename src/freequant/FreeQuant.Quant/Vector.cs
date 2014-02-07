using System;

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

		public Vector(int nrows)
		{
			this.nrows = nrows;
			this.elements = new double[this.nrows];
		}

		public static double operator *(Vector v1, Vector v2)
		{
			double sum = 0.0;
			for (int i = 0; i < v1.nrows; ++i)
				sum += v1[i] * v2[i];
			return sum;
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
			for (int i = 0; i < vector.nrows; ++i)
				vector1[i] = vector[i] + val;
			return vector1;
		}

		public static Vector operator -(Vector vector, double val)
		{
			Vector vector1 = new Vector(vector.nrows);
			for (int i = 0; i < vector.nrows; ++i)
				vector1[i] = vector[i] - val;
			return vector1;
		}

		public static Vector operator +(Vector target, Vector source)
		{
			Vector vector = new Vector(target.nrows);
			for (int i = 0; i < target.nrows; ++i)
				vector[i] = target[i] + source[i];
			return vector;
		}

		public static Vector operator -(Vector target, Vector source)
		{
			Vector vector = new Vector(target.nrows);
			for (int i = 0; i < target.nrows; ++i)
				vector[i] = target[i] - source[i];
			return vector;
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
			for (int i = 0; i < this.nrows; ++i)
				this.elements[i] = 0.0;
		}

		public void ResizeTo(int newNRows)
		{
			double[] numArray = new double[newNRows];
			int num = Math.Min(this.nrows, newNRows);
			for (int i = 0; i < num; ++i)
				numArray[i] = this.elements[i];
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
			Vector v = new Vector(this.nrows);
			for (int i = 0; i < this.nrows; ++i)
				v[i] = Math.Abs(this.elements[i]);
			return v;
		}

		public Vector Sqr()
		{
			Vector v = new Vector(this.nrows);
			for (int i = 0; i < this.nrows; ++i)
				v[i] = this.elements[i] * this.elements[i];
			return v;
		}

		public Vector Sqrt()
		{
			Vector v = new Vector(this.nrows);
			for (int i = 0; i < this.nrows; ++i)
				v[i] = Math.Sqrt(this.elements[i]);
			return v;
		}

		public Vector ElementMult(Vector target, Vector source)
		{
			Vector v = new Vector(target.nrows);
			for (int i = 0; i < this.nrows; ++i)
				v[i] = target[i] * source[i];
			return v;
		}

		public Vector ElementDiv(Vector target, Vector source)
		{
			Vector vector = new Vector(target.nrows);
			for (int i = 0; i < this.nrows; ++i)
				vector[i] = target[i] / source[i];
			return vector;
		}

		public override bool Equals(object vector)
		{
			Vector vector1 = (Vector)vector;
			if (this.nrows != vector1.nrows)
				return false;
			for (int i = 0; i < vector1.nrows; ++i)
			{
				if (this[i] != vector1[i])
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
			for (int i = 0; i < this.nrows; ++i)
				Console.WriteLine(this.elements[i].ToString(Format));
		}
	}
}
