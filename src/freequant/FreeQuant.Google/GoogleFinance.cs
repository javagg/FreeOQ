// Type: SmartQuant.Google.GoogleFinance
// Assembly: SmartQuant.Google, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 5548D0DC-9B3D-44D8-B20A-ED7BD81AEA14
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Google.dll

using OMUxqEwt2GBC4rjjlJ;
using FreeQuant.Data;
using FreeQuant.Instruments;
using FreeQuant.Providers;
using FreeQuant.Providers.Design;
using sRyOKFOecYRjxLUCme;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Google
{
  public class GoogleFinance : IHistoricalDataProvider, IProvider
  {
    private const string fdOmo9xdI = "Information";
    private const string fpSBvApbD = "Status";
    private const string UdFHjjUR5 = "Historical Data";
    private const string dmW0TljKM = "http://finance.google.com/finance/historical?q={0}&histperiod=daily&startdate={1:MMM d, yyyy}&enddate={2:MMM d, yyyy}&output=csv";
    private bool pxqdEt2GB;
    private Dictionary<string, WebRequest> K4r2jjlJs;
    private ListDictionary YZKOeBcIM;

    [Category("Historical Data")]
    public HistoricalDataType DataType
    {
       get
      {
        return HistoricalDataType.Daily;
      }
    }

    [Category("Historical Data")]
    public HistoricalDataRange DataRange
    {
       get
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
      get
      {
        return -1;
      }
    }

    [Category("Information")]
    public byte Id
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return (byte) 25;
      }
    }

    [Category("Information")]
    public string Name
    {
      get
      {
        return SbDbdFkjjUR5MmWTlj.fvNFD9DS2(412);
      }
    }

    [Category("Information")]
    public string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return SbDbdFkjjUR5MmWTlj.fvNFD9DS2(428);
      }
    }

    [Category("Information")]
    public string URL
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return SbDbdFkjjUR5MmWTlj.fvNFD9DS2(474);
      }
    }

    [Category("Status")]
    public bool IsConnected
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.pxqdEt2GB;
      }
    }

    [Category("Status")]
    public ProviderStatus Status
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return !this.pxqdEt2GB ? ProviderStatus.Disconnected : ProviderStatus.LoggedIn;
      }
    }

    public event HistoricalTradeEventHandler NewHistoricalTrade;

    public event HistoricalQuoteEventHandler NewHistoricalQuote;

    public event HistoricalBarEventHandler NewHistoricalBar;

    public event HistoricalMarketDepthEventHandler NewHistoricalMarketDepth;

    public event HistoricalDataEventHandler HistoricalDataRequestCompleted;

    public event HistoricalDataEventHandler HistoricalDataRequestCancelled;

    public event HistoricalDataErrorEventHandler HistoricalDataRequestError;

    public event EventHandler StatusChanged;

    public event EventHandler Connected;

    public event EventHandler Disconnected;

    public event ProviderErrorEventHandler Error;

    public GoogleFinance()
    {
      this.pxqdEt2GB = false;
      this.K4r2jjlJs = new Dictionary<string, WebRequest>();
      this.YZKOeBcIM = new ListDictionary();
      ProviderManager.Add((IProvider) this);
    }

    public void SendHistoricalDataRequest(HistoricalDataRequest request)
    {
      if (!this.pxqdEt2GB)
        this.YchVmYD17(SbDbdFkjjUR5MmWTlj.fvNFD9DS2(0));
      else if (request.DataType != HistoricalDataType.Daily)
      {
        this.YchVmYD17(string.Format(SbDbdFkjjUR5MmWTlj.fvNFD9DS2(32), (object) request.DataType));
      }
      else
      {
        WebRequest webRequest = WebRequest.Create(string.Format((IFormatProvider) CultureInfo.InvariantCulture, SbDbdFkjjUR5MmWTlj.fvNFD9DS2(120), (object) (request.Instrument as Instrument).GetSymbol(this.Name), (object) request.BeginDate, (object) request.EndDate));
        this.K4r2jjlJs.Add(request.RequestId, webRequest);
        webRequest.BeginGetResponse(new AsyncCallback(this.tm9qNM8Cd), (object) request);
      }
    }

    public void CancelHistoricalDataRequest(string requestId)
    {
      if (!this.pxqdEt2GB)
      {
        this.YchVmYD17(SbDbdFkjjUR5MmWTlj.fvNFD9DS2(380));
      }
      else
      {
        WebRequest webRequest;
        if (!this.K4r2jjlJs.TryGetValue(requestId, out webRequest))
          return;
        this.YZKOeBcIM[(object) requestId] = (object) true;
        webRequest.Abort();
      }
    }

    private void tm9qNM8Cd([In] IAsyncResult obj0)
    {
      HistoricalDataRequest historicalDataRequest = (HistoricalDataRequest) obj0.AsyncState;
      WebRequest webRequest;
      if (!this.K4r2jjlJs.TryGetValue(historicalDataRequest.RequestId, out webRequest))
        return;
      this.K4r2jjlJs.Remove(historicalDataRequest.RequestId);
      try
      {
        StreamReader streamReader = new StreamReader(webRequest.EndGetResponse(obj0).GetResponseStream());
        List<string> list1 = new List<string>();
        string str;
        while ((str = streamReader.ReadLine()) != null)
          list1.Add(str);
        if (list1.Count > 0)
          list1.RemoveAt(0);
        list1.Reverse();
        List<Daily> list2 = new List<Daily>();
        for (int index = 0; index < list1.Count; ++index)
        {
          string[] strArray = list1[index].Split(new char[1]
          {
            ','
          });
          Daily daily = new Daily(DateTime.Parse(strArray[0], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[1], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[2], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[3], (IFormatProvider) CultureInfo.InvariantCulture), double.Parse(strArray[4], (IFormatProvider) CultureInfo.InvariantCulture), long.Parse(strArray[5], (IFormatProvider) CultureInfo.InvariantCulture));
          list2.Add(daily);
        }
        foreach (Daily daily in list2)
        {
          if (this.YZKOeBcIM.Contains((object) historicalDataRequest.RequestId))
          {
            this.YZKOeBcIM.Remove((object) historicalDataRequest.RequestId);
            this.FAwwpUwD2(historicalDataRequest, list2.Count);
            return;
          }
          else
            this.viIgpbj1M(historicalDataRequest, (Bar) daily, list2.Count);
        }
        this.iAYkpjLCs(historicalDataRequest, list2.Count);
      }
      catch (Exception ex)
      {
        if (this.YZKOeBcIM.Contains((object) historicalDataRequest.RequestId))
        {
          this.YZKOeBcIM.Remove((object) historicalDataRequest.RequestId);
          this.FAwwpUwD2(historicalDataRequest, 0);
        }
        else
          this.NxZTw30av(historicalDataRequest, ex.Message);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Connect()
    {
      if (this.pxqdEt2GB)
        return;
      this.pxqdEt2GB = true;
      this.TD6fZH9fy();
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
      if (!this.pxqdEt2GB)
        return;
      this.pxqdEt2GB = false;
      this.q7QMTcQe7();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Shutdown()
    {
      this.Disconnect();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void TD6fZH9fy()
    {
      if (this.aKVrxpyv2 == null)
        return;
      this.aKVrxpyv2((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void q7QMTcQe7()
    {
      if (this.VdpclrFO6 == null)
        return;
      this.VdpclrFO6((object) this, EventArgs.Empty);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void RBERAl36k([In] int obj0, [In] int obj1, [In] string obj2)
    {
      if (this.WqS1pwt1v == null)
        return;
      this.WqS1pwt1v(new ProviderErrorEventArgs((IProvider) this, obj0, obj1, obj2));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void YchVmYD17([In] string obj0)
    {
      this.RBERAl36k(-1, -1, obj0);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void iAYkpjLCs([In] HistoricalDataRequest obj0, [In] int obj1)
    {
      HistoricalDataEventArgs args = new HistoricalDataEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, obj1);
      if (this.utrQoQnL1 == null)
        return;
      this.utrQoQnL1((object) this, args);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void FAwwpUwD2([In] HistoricalDataRequest obj0, [In] int obj1)
    {
      HistoricalDataEventArgs args = new HistoricalDataEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, obj1);
      if (this.NI1e0JhDM == null)
        return;
      this.NI1e0JhDM((object) this, args);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void NxZTw30av([In] HistoricalDataRequest obj0, [In] string obj1)
    {
      HistoricalDataErrorEventArgs args = new HistoricalDataErrorEventArgs(obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, 0, obj1);
      if (this.FWtYcSNLi == null)
        return;
      this.FWtYcSNLi((object) this, args);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void viIgpbj1M([In] HistoricalDataRequest obj0, [In] Bar obj1, [In] int obj2)
    {
      HistoricalBarEventArgs args = new HistoricalBarEventArgs(obj1, obj0.RequestId, obj0.Instrument, (IHistoricalDataProvider) this, obj2);
      if (this.IoHu3RdKg == null)
        return;
      this.IoHu3RdKg((object) this, args);
    }
  }
}
