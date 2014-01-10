using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Charting.Draw3D
{
  public class TAxisCalc
  {
    private TVec3 FO4HKfjf8;
    private TVec3 BHevbMLA7;
    private double J7AUgXK5a;
    private double Usn4mA9ly;
    private int z6NrSRxNZ;
    private TAxisCalc.TTick[] BTvciJZkJ;
    private double SM2ynsEBp;

    public int nTicks
    {
       get
      {
        return this.z6NrSRxNZ;
      }
    }

    
    public TAxisCalc(TVec3 Origin, TVec3 End, double ValO, double ValEnd, int nTicks):base()
    {

      this.BTvciJZkJ = new TAxisCalc.TTick[0];

      this.FO4HKfjf8 = Origin;
      this.BHevbMLA7 = End;
      this.J7AUgXK5a = ValO;
      this.Usn4mA9ly = ValEnd;
      this.z6NrSRxNZ = nTicks;
      this.mXvbWEhZj();
      this.CKSEVIHa4();
    }

    
    public double TickVal(int i)
    {
      return this.BTvciJZkJ[i].Value;
    }

    
    public TVec3 TickPos(int i)
    {
      return new TVec3(this.BTvciJZkJ[i].Position);
    }

    
    public bool TickPassed(ref TAxisCalc.TTick Tick, double Val)
    {
      foreach (TAxisCalc.TTick ttick in this.BTvciJZkJ)
      {
        if (Val == ttick.Value || (Val - ttick.Value) * (this.SM2ynsEBp - ttick.Value) < 0.0)
        {
          Tick = ttick;
          this.SM2ynsEBp = Val;
          return true;
        }
      }
      this.SM2ynsEBp = Val;
      return false;
    }

    
    public bool TickPassed(double Val)
    {
      foreach (TAxisCalc.TTick ttick in this.BTvciJZkJ)
      {
        if (Val == ttick.Value || (Val - ttick.Value) * (this.SM2ynsEBp - ttick.Value) < 0.0)
        {
          this.SM2ynsEBp = Val;
          return true;
        }
      }
      this.SM2ynsEBp = Val;
      return false;
    }

    
    public static double Round(double x)
    {
      return Math.Pow(10.0, Math.Round(Math.Log10(x)));
    }

    
    public static double Ceiling(double x, double d)
    {
      if (x < 0.0)
        return d * Math.Floor(x / d);
      else
        return d * Math.Ceiling(x / d);
    }

    
    private void mXvbWEhZj()
    {
      double d = TAxisCalc.Round(Math.Abs(this.Usn4mA9ly - this.J7AUgXK5a) / (double) this.z6NrSRxNZ);
      double num1 = TAxisCalc.Ceiling(this.J7AUgXK5a, d);
      this.z6NrSRxNZ = (int) (Math.Abs(this.Usn4mA9ly - num1) / d) + 1;
      if (this.z6NrSRxNZ < 3)
        this.z6NrSRxNZ = 3;
      this.BTvciJZkJ = new TAxisCalc.TTick[this.z6NrSRxNZ];
      if (this.z6NrSRxNZ == 3)
      {
        this.BTvciJZkJ[0].Value = this.J7AUgXK5a;
        this.BTvciJZkJ[1].Value = 0.5 * (this.J7AUgXK5a + this.Usn4mA9ly);
        this.BTvciJZkJ[2].Value = this.Usn4mA9ly;
      }
      else
      {
        double num2 = num1;
        if (this.Usn4mA9ly < this.J7AUgXK5a)
          d = -d;
        int index = 0;
        while (index < this.z6NrSRxNZ)
        {
          this.BTvciJZkJ[index].Value = num2;
          ++index;
          num2 += d;
        }
      }
    }

    
    private void CKSEVIHa4()
    {
      for (int index = 0; index < this.BTvciJZkJ.Length; ++index)
        this.BTvciJZkJ[index].Position = this.FO4HKfjf8 + (this.BHevbMLA7 - this.FO4HKfjf8) * (this.BTvciJZkJ[index].Value - this.J7AUgXK5a) / (this.Usn4mA9ly - this.J7AUgXK5a);
    }

    public struct TTick
    {
      public double Value;
      public TVec3 Position;
    }
  }
}
