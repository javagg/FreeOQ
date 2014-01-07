using CkC6gLogtoswXETFiV;
using ee15rOC9NalRXxVUl2;
using FreeQuant;
using FreeQuant.Data;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Providers.Design;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Yahoo
{
  public class YahooHistoryDownloader : IHistoricalDataProvider, IProvider
  {
    private const string jLnPdcvZs = "Information";
    private const string FAANscVYy = "Data";
    private const string kVBJfh6bF = "Status";
    private const string DKlLxInQU = "Historical Data";
    private const string gAZWCSjKk = "Yahoo";
    private const string o6guLgtos = "Yahoo Finance";
    private const byte BXEbTFiVL = (byte) 17;
    private const string yF8CcxbvC = "http://finance.yahoo.com";
    private const string kOF0uPIUo = "http://chart.yahoo.com/table.csv?q=q&g={0}&s={1}&a={2}&b={3}&c={4}&d={5}&e={6}&f={7}";
    private const bool nF3DvNPNo = true;
    private bool K1McepZXI;
    private Dictionary<string, WebRequest> EjDBtJJBo;
    private ListDictionary FexSQYEw9;
    private bool YGOxAtD62;

    [Category("Historical Data")]
    [Description("Adjust historical data for splits and dividends")]
    [DefaultValue(true)]
    public bool Adjusted
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.YGOxAtD62;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.YGOxAtD62 = value;
      }
    }

    [Category("Information")]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RbFKKlTxInQUoAZCSj.q6GyF96n8(0);
      }
    }

    [Category("Information")]
    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RbFKKlTxInQUoAZCSj.q6GyF96n8(14);
      }
    }

    [Category("Information")]
    public byte Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (byte) 17;
      }
    }

    [Category("Information")]
    public string URL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return RbFKKlTxInQUoAZCSj.q6GyF96n8(44);
      }
    }

    [Category("Status")]
    public bool IsConnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.K1McepZXI;
      }
    }

    [Category("Status")]
    public ProviderStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return !this.K1McepZXI ? ProviderStatus.Disconnected : ProviderStatus.Connected;
      }
    }

    [Category("Historical Data")]
    public HistoricalDataType DataType
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return HistoricalDataType.Daily;
      }
    }

    [Category("Historical Data")]
    public HistoricalDataRange DataRange
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return HistoricalDataRange.DateTimeInterval;
      }
    }

    [Category("Historical Data")]
    [TypeConverter(typeof (BarSizesTypeConverter))]
    public int[] BarSizes
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new int[0];
      }
    }

    [Category("Historical Data")]
    public int MaxConcurrentRequests
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return -1;
      }
    }

    public event EventHandler Disconnected;

    public event EventHandler Connected;

    public event ProviderErrorEventHandler Error;

    public event EventHandler StatusChanged;

    public event HistoricalTradeEventHandler NewHistoricalTrade;

    public event HistoricalQuoteEventHandler NewHistoricalQuote;

    public event HistoricalBarEventHandler NewHistoricalBar;

    public event HistoricalMarketDepthEventHandler NewHistoricalMarketDepth;

    public event HistoricalDataEventHandler HistoricalDataRequestCompleted;

    public event HistoricalDataEventHandler HistoricalDataRequestCancelled;

    public event HistoricalDataErrorEventHandler HistoricalDataRequestError;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public YahooHistoryDownloader()
    {
      hrYGpFbpvD3gYMJXML.N36Q1VPziPqoI();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.K1McepZXI = false;
      this.EjDBtJJBo = new Dictionary<string, WebRequest>();
      this.FexSQYEw9 = new ListDictionary();
      this.YGOxAtD62 = true;
      ProviderManager.Add((IProvider) this);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect()
    {
      if (this.K1McepZXI)
        return;
      this.K1McepZXI = true;
      this.a0nmGNGy6();
      this.iuaEZ5ord();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect(int timeout)
    {
      this.Connect();
      ProviderManager.WaitConnected((IProvider) this, timeout);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Disconnect()
    {
      if (!this.K1McepZXI)
        return;
      this.K1McepZXI = false;
      this.aZtaIFtUM();
      this.iuaEZ5ord();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown()
    {
      this.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      return this.Name;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void a0nmGNGy6()
    {
      if (this.oyCYNpfcW == null)
        return;
      this.oyCYNpfcW((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aZtaIFtUM()
    {
      if (this.anEk2i7cn == null)
        return;
      this.anEk2i7cn((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iuaEZ5ord()
    {
      if (this.de82Etvag == null)
        return;
      this.de82Etvag((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FbLqFuXmj([In] int obj0, [In] int obj1, [In] string obj2)
    {
      if (this.ARxs7eCmm == null)
        return;
      this.ARxs7eCmm(new ProviderErrorEventArgs(new ProviderError(Clock.Now, (IProvider) this, obj0, obj1, obj2)));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SendHistoricalDataRequest(HistoricalDataRequest request)
    {
      WebRequest webRequest = WebRequest.Create(string.Format(RbFKKlTxInQUoAZCSj.q6GyF96n8(96), (object) RbFKKlTxInQUoAZCSj.q6GyF96n8(268), (object) (request.Instrument as Instrument).GetSymbol(this.Name), (object) (request.BeginDate.Month - 1), (object) request.BeginDate.Day, (object) request.BeginDate.Year, (object) (request.EndDate.Month - 1), (object) request.EndDate.Day, (object) request.EndDate.Year));
      this.EjDBtJJBo.Add(request.RequestId, webRequest);
      webRequest.BeginGetResponse(new AsyncCallback(this.LEn1aOXgs), (object) request);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CancelHistoricalDataRequest(string requestId)
    {
      WebRequest webRequest = (WebRequest) null;
      if (!this.EjDBtJJBo.TryGetValue(requestId, out webRequest))
        return;
      this.FexSQYEw9[(object) requestId] = (object) true;
      webRequest.Abort();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void LEn1aOXgs([In] IAsyncResult obj0)
    {
      HistoricalDataRequest historicalDataRequest = (HistoricalDataRequest) obj0.AsyncState;
      WebRequest webRequest = (WebRequest) null;
      if (!this.EjDBtJJBo.TryGetValue(historicalDataRequest.RequestId, out webRequest))
        return;
      this.EjDBtJJBo.Remove(historicalDataRequest.RequestId);
      try
      {
        StreamReader streamReader = new StreamReader(webRequest.EndGetResponse(obj0).GetResponseStream());
        List<string> list1 = new List<string>();
        string str;
        while ((str = streamReader.ReadLine()) != null)
          list1.Add(str);
        list1.RemoveAt(0);
        list1.Reverse();
        List<Daily> list2 = new List<Daily>();
        for (int index1 = 0; index1 < list1.Count; ++index1)
        {
          string[] strArray = list1[index1].Split(new char[1]
          {
            ','
          });
          if (strArray.Length >= 7)
          {
            for (int index2 = 0; index2 < strArray.Length; ++index2)
            {
              strArray[index2] = strArray[index2].Trim(new char[1]
              {
                '"'
              });
              if (strArray[index2] == RbFKKlTxInQUoAZCSj.q6GyF96n8(274))
                strArray[index2] = RbFKKlTxInQUoAZCSj.q6GyF96n8(284);
            }
            Daily daily1 = new Daily(DateTime.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[3], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[4], (IFormatProvider) CultureInfo.InvariantCulture), long.Parse(strArray[5], (IFormatProvider) CultureInfo.InvariantCulture));
            if (this.YGOxAtD62)
            {
              double num1 = double.Parse(strArray[6], (IFormatProvider) CultureInfo.InvariantCulture);
              double num2 = num1 / daily1.Close;
              Daily daily2 = daily1;
              double num3 = daily2.Open * num2;
              daily2.Open = num3;
              Daily daily3 = daily1;
              double num4 = daily3.High * num2;
              daily3.High = num4;
              Daily daily4 = daily1;
              double num5 = daily4.Low * num2;
              daily4.Low = num5;
              daily1.Close = num1;
            }
            list2.Add(daily1);
          }
        }
        foreach (Daily daily in list2)
        {
          if (this.FexSQYEw9.Contains((object) historicalDataRequest.RequestId))
          {
            this.FexSQYEw9.Remove((object) historicalDataRequest.RequestId);
            this.J9LThvcYS(historicalDataRequest, list2.Count);
            return;
          }
          else if (this.c6Jl2nfcs != null)
            this.c6Jl2nfcs((object) this, new HistoricalBarEventArgs((Bar) daily, historicalDataRequest.RequestId, historicalDataRequest.Instrument, (IHistoricalDataProvider) this, list2.Count));
        }
        this.xmlocsjtF(historicalDataRequest, list2.Count);
      }
      catch (Exception ex)
      {
        if (this.FexSQYEw9.Contains((object) historicalDataRequest.RequestId))
        {
          this.FexSQYEw9.Remove((object) historicalDataRequest.RequestId);
          this.J9LThvcYS(historicalDataRequest, 0);
        }
        else
          this.iC2ZqQH0T(historicalDataRequest, ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void J9LThvcYS([In] HistoricalDataRequest obj0, [In] int obj1)
    {
      HistoricalDataEventArgs args = new HistoricalDataEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, obj1);
      if (this.MYMwJXMLq == null)
        return;
      this.MYMwJXMLq((object) this, args);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void xmlocsjtF([In] HistoricalDataRequest obj0, [In] int obj1)
    {
      HistoricalDataEventArgs args = new HistoricalDataEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, obj1);
      if (this.uGp8FpvD3 == null)
        return;
      this.uGp8FpvD3((object) this, args);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iC2ZqQH0T([In] HistoricalDataRequest obj0, [In] string obj1)
    {
      HistoricalDataErrorEventArgs args = new HistoricalDataErrorEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, 0, obj1);
      if (this.z159rO9Na == null)
        return;
      this.z159rO9Na((object) this, args);
    }
  }
}
