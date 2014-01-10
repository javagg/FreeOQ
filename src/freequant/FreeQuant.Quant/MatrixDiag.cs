using System;

namespace FreeQuant.Quant
{
	public class MatrixDiag
	{
		internal Matrix matrix;

		public double this [int i]
		{
			get
			{
				return this.matrix.elements[i, i];
			}
			set
			{
				this.matrix.elements[i, i] = value;
			}
		}

		public int NDiag
		{
			get
			{
				return Math.Min(this.matrix.n, this.matrix.m);
			}
		}

		public MatrixDiag(Matrix matrix)
		{
			this.matrix = matrix;
		}

		public void Assign(MatrixDiag matrixDiag)
		{
			if (!Matrix.AreComparable(this.matrix, matrixDiag.matrix))
				return;
			for (int index = 0; index < this.NDiag; ++index)
				this[index] = matrixDiag[index];
		}

		public override bool Equals(object matrixDiag)
		{
			return this.matrix.Equals((object)((MatrixDiag)matrixDiag).matrix);
		}

		public override int GetHashCode()
		{
			return this.matrix.GetHashCode();
		}
	}
}
