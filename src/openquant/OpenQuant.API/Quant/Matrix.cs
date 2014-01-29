using System;

namespace OpenQuant.API.Quant
{
	///<summary>
	///  A matrix
	///</summary>
	public class Matrix
	{
		internal double[,] elements;
		internal int rows;
		internal int cols;
		internal MatrixDiag diagonal;

		public MatrixDiag Diagonal
		{
			get
			{
				return this.diagonal;
			}
		}

		public int M
		{
			get
			{
				return this.rows;
			}
		}

		public int N
		{
			get
			{
				return this.cols;
			}
		}

		public int Rows
		{
			get
			{
				return this.rows;
			}
		}

		public int Cols
		{
			get
			{
				return this.cols;
			}
		}

		public double[,] Elements
		{
			get
			{
				return this.elements;
			}
		}

		public double this[int row, int col]
		{
			get
			{
				if (row >= 0 && row < this.M && (col >= 0 && col < this.N))
					return this.elements[row, col];
				else
					return 0.0;
			}
			set
			{
				if (row < 0 || row >= this.M || (col < 0 || col >= this.N))
					return;
				this.elements[row, col] = value;
			}
		}

		public Matrix Inverted
		{
			get
			{
				return new Matrix(this).Invert();
			}
		}

		public Matrix Transposed
		{
			get
			{
				return new Matrix(this).Transpose();
			}
		}

		public bool IsSymmetric
		{
			get
			{
				if (this.cols != this.rows)
					return false;
				for (int index1 = 0; index1 < this.rows; ++index1)
				{
					for (int index2 = 0; index2 < index1; ++index2)
					{
						if (this.elements[index1, index2] != this.elements[index2, index1])
							return false;
					}
				}
				return true;
			}
		}

		public Matrix()
		{
		}

		public Matrix(Matrix matrix)
		{
			this.elements = new double[matrix.M, matrix.N];
			this.diagonal = new MatrixDiag(this);
			this.rows = matrix.rows;
			this.cols = matrix.cols;
			for (int index1 = 0; index1 < this.M; ++index1)
			{
				for (int index2 = 0; index2 < this.N; ++index2)
					this.elements[index1, index2] = matrix.elements[index1, index2];
			}
		}

		public Matrix(int m, int n)
		{
			this.rows = m;
			this.cols = n;
			this.elements = new double[m, n];
			this.diagonal = new MatrixDiag(this);
		}

		public Matrix(int Size)
		{
			this.rows = Size;
			this.cols = Size;
			this.elements = new double[Size, Size];
			this.diagonal = new MatrixDiag(this);
		}

		public Matrix(int m, int n, double val)
		{
			this.rows = m;
			this.cols = n;
			this.elements = new double[m, n];
			this.diagonal = new MatrixDiag(this);
			for (int index1 = 0; index1 < m; ++index1)
			{
				for (int index2 = 0; index2 < n; ++index2)
					this.elements[index1, index2] = val;
			}
		}

		public Matrix(double[] values)
		{
			this.rows = 1;
			this.cols = values.Length;
			this.elements = new double[this.M, this.N];
			this.diagonal = new MatrixDiag(this);
			for (int index = 0; index < this.N; ++index)
				this.elements[0, index] = values[index];
		}

		public Matrix(double[,] values)
		{
			this.rows = values.GetLength(0);
			this.cols = values.GetLength(1);
			this.elements = new double[this.M, this.N];
			this.diagonal = new MatrixDiag(this);
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					this.elements[index1, index2] = values[index1, index2];
			}
		}

		public static Matrix operator +(Matrix Matrix1, Matrix Matrix2)
		{
			if (Matrix1.M != Matrix2.M || Matrix1.N != Matrix2.N)
				return new Matrix();
			Matrix matrix = new Matrix(Matrix1.M, Matrix1.N);
			for (int index1 = 0; index1 < Matrix1.M; ++index1)
			{
				for (int index2 = 0; index2 < Matrix1.N; ++index2)
					matrix[index1, index2] = Matrix1[index1, index2] + Matrix2[index1, index2];
			}
			return matrix;
		}

		public static Matrix operator -(Matrix Matrix1, Matrix Matrix2)
		{
			if (Matrix1.M != Matrix2.M || Matrix1.N != Matrix2.N)
				return new Matrix();
			Matrix matrix = new Matrix(Matrix1.M, Matrix1.N);
			for (int index1 = 0; index1 < Matrix1.M; ++index1)
			{
				for (int index2 = 0; index2 < Matrix1.N; ++index2)
					matrix[index1, index2] = Matrix1[index1, index2] - Matrix2[index1, index2];
			}
			return matrix;
		}

		public static Matrix operator *(Matrix Matrix1, Matrix Matrix2)
		{
			if (Matrix1.N != Matrix2.M)
				return Matrix1;
			Matrix matrix = new Matrix(Matrix1.M, Matrix2.N);
			for (int index1 = 0; index1 < Matrix1.M; ++index1)
			{
				for (int index2 = 0; index2 < Matrix2.N; ++index2)
				{
					double num = 0.0;
					for (int index3 = 0; index3 < Matrix1.N; ++index3)
						num += Matrix1[index1, index3] * Matrix2[index3, index2];
					matrix[index1, index2] = num;
				}
			}
			return matrix;
		}

		public static Matrix operator /(Matrix Matrix1, Matrix Matrix2)
		{
			if (Matrix1.M != Matrix2.M || Matrix1.N != Matrix2.N)
				return Matrix1;
			Matrix matrix = new Matrix(Matrix1.M, Matrix1.N);
			for (int index1 = 0; index1 < Matrix1.M; ++index1)
			{
				for (int index2 = 0; index2 < Matrix1.N; ++index2)
					matrix[index1, index2] = Matrix1[index1, index2] / Matrix2[index1, index2];
			}
			return matrix;
		}

		public static Matrix operator +(Matrix matrix, double Scalar)
		{
			Matrix matrix1 = new Matrix(matrix.M, matrix.N);
			for (int index1 = 0; index1 < matrix.M; ++index1)
			{
				for (int index2 = 0; index2 < matrix.N; ++index2)
					matrix1[index1, index2] = matrix[index1, index2] + Scalar;
			}
			return matrix1;
		}

		public static Matrix operator -(Matrix matrix, double Scalar)
		{
			return matrix + -Scalar;
		}

		public static Matrix operator *(Matrix matrix, double Scalar)
		{
			Matrix matrix1 = new Matrix(matrix.M, matrix.N);
			for (int index1 = 0; index1 < matrix.M; ++index1)
			{
				for (int index2 = 0; index2 < matrix.N; ++index2)
					matrix1[index1, index2] = matrix[index1, index2] * Scalar;
			}
			return matrix1;
		}

		public static Matrix operator /(Matrix matrix, double Scalar)
		{
			return matrix * (1.0 / Scalar);
		}

		public static bool operator ==(Matrix Matrix1, Matrix Matrix2)
		{
			if (!Matrix.AreComparable(Matrix1, Matrix2))
				return false;
			for (int index1 = 0; index1 < Matrix1.rows; ++index1)
			{
				for (int index2 = 0; index2 < Matrix1.cols; ++index2)
				{
					if (Matrix1.elements[index1, index2] != Matrix2.elements[index1, index2])
						return false;
				}
			}
			return true;
		}

		public static bool operator !=(Matrix Matrix1, Matrix Matrix2)
		{
			if (!Matrix.AreComparable(Matrix1, Matrix2))
				return false;
			for (int index1 = 0; index1 < Matrix1.rows; ++index1)
			{
				for (int index2 = 0; index2 < Matrix1.cols; ++index2)
				{
					if (Matrix1.elements[index1, index2] == Matrix2.elements[index1, index2])
						return false;
				}
			}
			return true;
		}

		public static bool operator ==(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] != Scalar)
						return false;
				}
			}
			return true;
		}

		public static bool operator !=(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] == Scalar)
						return false;
				}
			}
			return true;
		}

		public static bool operator <(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] >= Scalar)
						return false;
				}
			}
			return true;
		}

		public static bool operator <=(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] > Scalar)
						return false;
				}
			}
			return true;
		}

		public static bool operator >(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] <= Scalar)
						return false;
				}
			}
			return true;
		}

		public static bool operator >=(Matrix matrix, double Scalar)
		{
			for (int index1 = 0; index1 < matrix.rows; ++index1)
			{
				for (int index2 = 0; index2 < matrix.cols; ++index2)
				{
					if (matrix.elements[index1, index2] < Scalar)
						return false;
				}
			}
			return true;
		}

		public void MakeEigenVectors(Vector d, Vector e, Matrix z)
		{
			int rows = z.Rows;
			double[] elements1 = d.Elements;
			double[] elements2 = e.Elements;
			double[] numArray = new double[rows * rows];
			for (int index = 0; index < rows * rows; ++index)
				numArray[index] = z.Elements[index / rows, index % rows];
			for (int index = 1; index < rows; ++index)
				elements2[index - 1] = elements2[index];
			elements2[rows - 1] = 0.0;
			for (int index1 = 0; index1 < rows; ++index1)
			{
				int num1 = 0;
				int index2;
				do
				{
					for (index2 = index1; index2 < rows - 1; ++index2)
					{
						double num2 = Math.Abs(elements1[index2]) + Math.Abs(elements1[index2 + 1]);
						if (Math.Abs(elements2[index2]) + num2 == num2)
							break;
					}
					if (index2 != index1)
					{
						if (num1++ == 30)
						{
							this.Error("MakeEigenVectors", "too many iterationsn");
							return;
						}
						else
						{
							double num2 = (elements1[index1 + 1] - elements1[index1]) / (2.0 * elements2[index1]);
							double num3 = Math.Sqrt(num2 * num2 + 1.0);
							double num4 = elements1[index2] - elements1[index1] + elements2[index1] / (num2 + (num2 >= 0.0 ? Math.Abs(num3) : -Math.Abs(num3)));
							double num5 = 1.0;
							double num6 = 1.0;
							double num7 = 0.0;
							int index3;
							for (index3 = index2 - 1; index3 >= index1; --index3)
							{
								double num8 = num5 * elements2[index3];
								double num9 = num6 * elements2[index3];
								num3 = Math.Sqrt(num8 * num8 + num4 * num4);
								elements2[index3 + 1] = num3;
								if (num3 == 0.0)
								{
									elements1[index3 + 1] -= num7;
									elements2[index2] = 0.0;
									break;
								}
								else
								{
									num5 = num8 / num3;
									num6 = num4 / num3;
									double num10 = elements1[index3 + 1] - num7;
									num3 = (elements1[index3] - num10) * num5 + 2.0 * num6 * num9;
									num7 = num5 * num3;
									elements1[index3 + 1] = num10 + num7;
									num4 = num6 * num3 - num9;
									for (int index4 = 0; index4 < rows; ++index4)
									{
										double num11 = numArray[index4 + (index3 + 1) * rows];
										numArray[index4 + (index3 + 1) * rows] = num5 * numArray[index4 + index3 * rows] + num6 * num11;
										numArray[index4 + index3 * rows] = num6 * numArray[index4 + index3 * rows] - num5 * num11;
									}
								}
							}
							if (num3 != 0.0 || index3 < index1)
							{
								elements1[index1] -= num7;
								elements2[index1] = num4;
								elements2[index2] = 0.0;
							}
						}
					}
				}
				while (index2 != index1);
			}
			for (int index = 0; index < rows * rows; ++index)
				z.Elements[index / rows, index % rows] = numArray[index];
		}

		public void EigenSort(Matrix eigenVectors, Vector eigenValues)
		{
			int rows = eigenVectors.Rows;
			double[] numArray = new double[rows * rows];
			for (int index = 0; index < rows * rows; ++index)
				numArray[index] = eigenVectors.Elements[index / rows, index % rows];
			double[] elements = eigenValues.Elements;
			for (int index1 = 0; index1 < rows; ++index1)
			{
				int index2 = index1;
				double num1 = elements[index1];
				for (int index3 = index1 + 1; index3 < rows; ++index3)
				{
					if (elements[index3] >= num1)
					{
						index2 = index3;
						num1 = elements[index3];
					}
				}
				if (index2 != index1)
				{
					elements[index2] = elements[index1];
					elements[index1] = num1;
					for (int index3 = 0; index3 < rows; ++index3)
					{
						double num2 = numArray[index3 + index1 * rows];
						numArray[index3 + index1 * rows] = numArray[index3 + index2 * rows];
						numArray[index3 + index2 * rows] = num2;
					}
				}
			}
			for (int index = 0; index < rows * rows; ++index)
				eigenVectors.Elements[index / rows, index % rows] = numArray[index];
		}

		public Matrix EigenVectors(Vector eigenValues)
		{
			if (!this.IsSymmetric)
				throw new ApplicationException("Not yet implemented for non-symmetric matrix");
			Matrix matrix = new Matrix(this.Rows, this.Cols);
			for (int index1 = 0; index1 < this.Rows; ++index1)
			{
				for (int index2 = 0; index2 < this.Cols; ++index2)
					matrix[index1, index2] = this[index1, index2];
			}
			eigenValues.ResizeTo(this.Rows);
			Vector e = new Vector(this.Rows);
			this.MakeTridiagonal(matrix, eigenValues, e);
			this.MakeEigenVectors(eigenValues, e, matrix);
			this.EigenSort(matrix, eigenValues);
			return matrix;
		}

		public void MakeTridiagonal(Matrix a, Vector d, Vector e)
		{
			int num1 = a.rows;
			if (a.rows != a.cols)
				throw new ApplicationException("Matrix to tridiagonalize must be square");
			if (!a.IsSymmetric)
				throw new ApplicationException("Can only tridiagonalise symmetric matrix");
			double[] numArray = new double[this.M * this.N];
			for (int index = 0; index < this.M * this.N; ++index)
				numArray[index] = a.Elements[index / this.M, index % this.N];
			double[] elements1 = d.Elements;
			double[] elements2 = e.Elements;
			for (int index1 = num1 - 1; index1 > 0; --index1)
			{
				int num2 = index1 - 1;
				double d1 = 0.0;
				double num3 = 0.0;
				if (num2 > 0)
				{
					for (int index2 = 0; index2 <= num2; ++index2)
						num3 += Math.Abs(numArray[index1 + index2 * num1]);
					if (num3 == 0.0)
					{
						elements2[index1] = numArray[index1 + num2 * num1];
					}
					else
					{
						for (int index2 = 0; index2 <= num2; ++index2)
						{
							numArray[index1 + index2 * num1] /= num3;
							d1 += numArray[index1 + index2 * num1] * numArray[index1 + index2 * num1];
						}
						double num4 = numArray[index1 + num2 * num1];
						double num5 = num4 < 0.0 ? Math.Sqrt(d1) : -Math.Sqrt(d1);
						elements2[index1] = num3 * num5;
						d1 -= num4 * num5;
						numArray[index1 + num2 * num1] = num4 - num5;
						double num6 = 0.0;
						for (int index2 = 0; index2 <= num2; ++index2)
						{
							numArray[index2 + index1 * num1] = numArray[index1 + index2 * num1] / d1;
							double num7 = 0.0;
							for (int index3 = 0; index3 <= index2; ++index3)
								num7 += numArray[index2 + index3 * num1] * numArray[index1 + index3 * num1];
							for (int index3 = index2 + 1; index3 <= num2; ++index3)
								num7 += numArray[index3 + index2 * num1] * numArray[index1 + index3 * num1];
							elements2[index2] = num7 / d1;
							num6 += elements2[index2] * numArray[index1 + index2 * num1];
						}
						double num8 = num6 / (d1 + d1);
						for (int index2 = 0; index2 <= num2; ++index2)
						{
							double num7 = numArray[index1 + index2 * num1];
							double num9;
							elements2[index2] = num9 = elements2[index2] - num8 * num7;
							for (int index3 = 0; index3 <= index2; ++index3)
								numArray[index2 + index3 * num1] -= num7 * elements2[index3] + num9 * numArray[index1 + index3 * num1];
						}
					}
				}
				else
					elements2[index1] = numArray[index1 + num2 * num1];
				elements1[index1] = d1;
			}
			elements1[0] = 0.0;
			elements2[0] = 0.0;
			for (int index1 = 0; index1 < num1; ++index1)
			{
				int num2 = index1 - 1;
				if (elements1[index1] != 0.0)
				{
					for (int index2 = 0; index2 <= num2; ++index2)
					{
						double num3 = 0.0;
						for (int index3 = 0; index3 <= num2; ++index3)
							num3 += numArray[index1 + index3 * num1] * numArray[index3 + index2 * num1];
						for (int index3 = 0; index3 <= num2; ++index3)
							numArray[index3 + index2 * num1] -= num3 * numArray[index3 + index1 * num1];
					}
				}
				elements1[index1] = numArray[index1 + index1 * num1];
				numArray[index1 + index1 * num1] = 1.0;
				for (int index2 = 0; index2 <= num2; ++index2)
					numArray[index2 + index1 * num1] = numArray[index1 + index2 * num1] = 0.0;
			}
			for (int index = 0; index < this.M * this.N; ++index)
				a.Elements[index / this.M, index % this.N] = numArray[index];
		}

		public static bool AreComparable(Matrix Matrix1, Matrix Matrix2)
		{
			return Matrix1.rows == Matrix2.rows && Matrix1.cols == Matrix2.cols;
		}

		public Matrix Abs()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					this.elements[index1, index2] = Math.Abs(this.elements[index1, index2]);
			}
			return this;
		}

		public Matrix Sqr()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					this.elements[index1, index2] = Math.Pow(this.elements[index1, index2], 2.0);
			}
			return this;
		}

		public Matrix Sqrt()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					this.elements[index1, index2] = Math.Sqrt(this.elements[index1, index2]);
			}
			return this;
		}

		public double RowNorm()
		{
			double val2 = 0.0;
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				double val1 = 0.0;
				for (int index2 = 0; index2 < this.cols; ++index2)
					val1 += Math.Abs(this.elements[index1, index2]);
				val2 = Math.Max(val1, val2);
			}
			return val2;
		}

		public double ColNorm()
		{
			double val2 = 0.0;
			for (int index1 = 0; index1 < this.cols; ++index1)
			{
				double val1 = 0.0;
				for (int index2 = 0; index2 < this.rows; ++index2)
					val1 += Math.Abs(this.elements[index2, index1]);
				val2 = Math.Max(val1, val2);
			}
			return val2;
		}

		public double E2Norm()
		{
			double num = 0.0;
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					num += Math.Pow(this.elements[index1, index2], 2.0);
			}
			return num;
		}

		public double E2Norm(Matrix Matrix1, Matrix Matrix2)
		{
			double num = 0.0;
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					num += Math.Pow(Matrix1.elements[index1, index2] - Matrix2.elements[index1, index2], 2.0);
			}
			return num;
		}

		public Matrix NormByDiag()
		{
			if (this.rows != this.cols)
			{
				this.Error("NormByDiag", "Not square");
				return this;
			}
			else
			{
				double[] numArray = new double[this.Diagonal.NDiag];
				for (int index = 0; index < this.Diagonal.NDiag; ++index)
				{
					numArray[index] = this.Diagonal[index];
					if (numArray[index] == 0.0)
					{
						this.Error("NormByDiag", "Zeros in diagonal");
						return this;
					}
				}
				for (int index1 = 0; index1 < this.rows; ++index1)
				{
					for (int index2 = 0; index2 < this.cols; ++index2)
						this[index1, index2] = this[index1, index2] / Math.Sqrt(numArray[index1] * numArray[index2]);
				}
				return this;
			}
		}

		public Matrix Transpose()
		{
			double[,] numArray = new double[this.cols, this.rows];
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					numArray[index2, index1] = this.elements[index1, index2];
			}
			this.elements = numArray;
			int num = this.cols;
			this.cols = this.rows;
			this.rows = num;
			return this;
		}

		public Matrix Invert()
		{
			double det;
			return this.Invert(out det);
		}

		public Matrix Invert(out double det)
		{
			det = 1.0;
			if (this.Rows != this.Cols)
				this.Error("Invert", "#columns != #rows");
			int rows = this.Rows;
			Matrix matrix = new Matrix(rows, 2 * rows);
			for (int index1 = 0; index1 < rows; ++index1)
			{
				for (int index2 = 0; index2 < rows; ++index2)
					matrix[index1, index2] = this[index1, index2];
			}
			for (int index1 = 0; index1 < rows; ++index1)
			{
				for (int index2 = rows; index2 < 2 * rows; ++index2)
					matrix[index1, index2] = index1 == index2 - rows ? 1.0 : 0.0;
			}
			for (int index1 = 0; index1 < rows; ++index1)
			{
				double num1 = 0.0;
				int index2 = -1;
				for (int index3 = index1; index3 < rows; ++index3)
				{
					if (Math.Abs(matrix[index3, index1]) > num1)
					{
						num1 = Math.Abs(matrix[index3, index1]);
						index2 = index3;
					}
				}
				if (num1 < 1E-35)
					throw new ApplicationException("Element max value less than required minimum.");
				if (index2 != index1)
				{
					for (int index3 = index1; index3 < 2 * rows; ++index3)
					{
						double num2 = matrix[index1, index3];
						matrix[index1, index3] = matrix[index2, index3];
						matrix[index2, index3] = num2;
					}
					det = -det;
				}
				for (int index3 = 0; index3 < rows; ++index3)
				{
					if (index3 != index1)
					{
						double num2 = matrix[index3, index1] / matrix[index1, index1];
						for (int index4 = index1; index4 < 2 * rows; ++index4)
							matrix[index3, index4] = matrix[index3, index4] - matrix[index1, index4] * num2;
					}
				}
				double num3 = matrix[index1, index1];
				for (int index3 = index1; index3 < 2 * rows; ++index3)
					matrix[index1, index3] = matrix[index1, index3] / num3;
				det = det * num3;
			}
			for (int index1 = 0; index1 < rows; ++index1)
			{
				for (int index2 = 0; index2 < rows; ++index2)
					this[index1, index2] = matrix[index1, rows + index2];
			}
			return this;
		}

		public Matrix MakeSymetric()
		{
			if (this.cols != this.rows)
			{
				this.Error("MakeSymetric", "Matrix to symmetrize must be square");
				return this;
			}
			else
			{
				for (int index1 = 0; index1 < this.rows; ++index1)
				{
					for (int index2 = 0; index2 < this.cols; ++index2)
					{
						this.elements[index1, index2] = (this.elements[index1, index2] + this.elements[index2, index1]) / 2.0;
						this.elements[index2, index1] = this.elements[index1, index2];
					}
				}
				return this;
			}
		}

		public Matrix UnitMatrix()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
					this.elements[index1, index2] = index1 != index2 ? 0.0 : 1.0;
			}
			return this;
		}

		public Matrix HilbertMatrix()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
				{
					if (index1 == index2)
						this.elements[index1, index2] = 1.0 / ((double)(index1 + index2) + 1.0);
				}
			}
			return this;
		}

		public Matrix HilbertMatrix2()
		{
			for (int index1 = 0; index1 < this.rows; ++index1)
			{
				for (int index2 = 0; index2 < this.cols; ++index2)
				{
					if (index1 == index2)
						this.elements[index1, index2] = 1.0 / ((double)(index1 + index2) + 1.0);
				}
			}
			return this;
		}

		public void Print()
		{
			this.Print("F2");
		}

		public void Print(string Format)
		{
			for (int index1 = 0; index1 < this.M; ++index1)
			{
				for (int index2 = 0; index2 < this.N; ++index2)
					Console.Write(" " + this[index1, index2].ToString(Format));
				Console.WriteLine("");
			}
		}

		public override bool Equals(object matrix)
		{
			return this == (Matrix)matrix;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}

		protected void Error(string Where, string What)
		{
			Console.WriteLine("Matrix: " + Where + " : " + What);
		}
	}
}
