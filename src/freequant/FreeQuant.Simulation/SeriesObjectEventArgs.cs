using FreeQuant.Data;
using System;
using System.Runtime.CompilerServices;

namespace FreeQuant.Simulation
{
  public class SeriesObjectEventArgs : EventArgs
  {
    private IDataSeries hFCPq0vSfe;
    private IDataObject TF3PMehmVT;

    public IDataObject Object
    {
       get
      {
        return this.TF3PMehmVT;
      }
    }

    public IDataSeries Series
    {
       get
      {
        return this.hFCPq0vSfe;
      }
    }

    
		public SeriesObjectEventArgs(IDataSeries series, IDataObject obj):base()
    {

      this.hFCPq0vSfe = series;
      this.TF3PMehmVT = obj;
    }
  }
}
