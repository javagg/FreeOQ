using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Quant
{
  public class MatrixDiag
  {
	internal Matrix matrix; 

    public double this[int i]
    {
      get
      {
        if (i >= 0 && i < this.NDiag)
          return this.matrix.elements[i, i];
        this.Error(Cu7kFnKYoLS7VpKgGV.TFnpYoLS7(1580), Cu7kFnKYoLS7VpKgGV.TFnpYoLS7(1596));
        return 0.0;
      }
      set
      {
        if (i >= 0 && i < this.NDiag)
          this.matrix.elements[i, i] = value;
        else
          this.Error(Cu7kFnKYoLS7VpKgGV.TFnpYoLS7(1628), Cu7kFnKYoLS7VpKgGV.TFnpYoLS7(1644));
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
      xD5tUhTqkMWaoU2QXj.oXSRIlMzpvkq6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.matrix = matrix;
    }

    public void Assign(MatrixDiag matrixDiag)
    {
      if (!Matrix.AreComparable(this.matrix, matrixDiag.matrix))
        return;
      for (int index = 0; index < this.NDiag; ++index)
        this[index] = matrixDiag[index];
    }

    protected void Error(string Where, string What)
    {
    }

    public override bool Equals(object matrixDiag)
    {
      return this.matrix.Equals((object) ((MatrixDiag) matrixDiag).matrix);
    }

  }
}
