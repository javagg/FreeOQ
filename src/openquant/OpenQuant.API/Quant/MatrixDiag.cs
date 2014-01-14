using System;

namespace OpenQuant.API.Quant
{
	///<summary>
	///  A matrix diagonal
	///</summary>
	public class MatrixDiag
	{
		internal Matrix fMatrix;

		public double this [int i]
		{
			get
			{
				if (i >= 0 && i < this.NDiag)
					return this.fMatrix.elements[i, i];
				this.Error("this[]", "Out of boundry");
				return 0.0;
			}
			set
			{
				if (i >= 0 && i < this.NDiag)
					this.fMatrix.elements[i, i] = value;
				else
					this.Error("this[]", "Out of boundry");
			}
		}

		public int NDiag
		{
			get
			{
				return Math.Min(this.fMatrix.cols, this.fMatrix.rows);
			}
		}

		public MatrixDiag(Matrix matrix)
		{
			this.fMatrix = matrix;
		}

		public void Assign(MatrixDiag matrixDiag)
		{
			if (!Matrix.AreComparable(this.fMatrix, matrixDiag.fMatrix))
				return;
			for (int index = 0; index < this.NDiag; ++index)
				this[index] = matrixDiag[index];
		}

		protected void Error(string Where, string What)
		{
		}

		public override bool Equals(object matrixDiag)
		{
			return this.fMatrix.Equals((object)((MatrixDiag)matrixDiag).fMatrix);
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override string ToString()
		{
			return base.ToString();
		}
	}
}
