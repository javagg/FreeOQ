using System;
using System.Runtime.InteropServices;

namespace OpenQuant.Finam
{
  public class TXmlConnector : ITransaqConnector
  {
    private static object syncRoot = new object();
    private const string EX_SETTING_CALLBACK = "Could not establish a callback function";
    private static volatile TXmlConnector instance;
    public TXmlConnector.CallBack myDelegate;
    public TXmlConnector.CallBackEx myDelegateEx;

    public static TXmlConnector Instance
    {
      get
      {
        if (TXmlConnector.instance == null)
        {
          lock (TXmlConnector.syncRoot)
          {
            if (TXmlConnector.instance == null)
              TXmlConnector.instance = new TXmlConnector();
          }
        }
        return TXmlConnector.instance;
      }
    }

    public event EventHandler<NewDataEventArgs> NewData;

    static TXmlConnector()
    {
    }

    public TXmlConnector()
    {
      this.myDelegate = new TXmlConnector.CallBack(this.MyCallBack);
      this.myDelegateEx = new TXmlConnector.CallBackEx(this.MyCallBackEx);
      if (Environment.Is64BitProcess)
      {
        if (!TXmlConnector.SetCallback64(this.myDelegate))
          throw new Exception("Could not establish a callback function");
        if (!TXmlConnector.SetCallbackEx64(this.myDelegateEx, IntPtr.Zero))
          throw new Exception("Could not establish a callback function");
      }
      else
      {
        if (!TXmlConnector.SetCallback(this.myDelegate))
          throw new Exception("Could not establish a callback function");
        if (!TXmlConnector.SetCallbackEx(this.myDelegateEx, IntPtr.Zero))
          throw new Exception("Could not establish a callback function");
      }
      TXmlConnector.instance = this;
    }

    public void RaiseNewDataEvent(string data)
    {
      EventHandler<NewDataEventArgs> eventHandler = this.NewData;
      if (eventHandler == null)
        return;
      eventHandler(new object(), new NewDataEventArgs(data));
    }

    public string SendCommand(string command)
    {
      IntPtr num1 = MarshalUTF8.StringToHGlobalUTF8(command);
      IntPtr num2 = new IntPtr();
      IntPtr pData = !Environment.Is64BitProcess ? TXmlConnector.SendCommand(num1) : TXmlConnector.SendCommand64(num1);
      if (!(pData != IntPtr.Zero))
        return string.Empty;
      string str = MarshalUTF8.PtrToStringUTF8(pData);
      Marshal.FreeHGlobal(num1);
      if (Environment.Is64BitProcess)
        TXmlConnector.FreeMemory64(pData);
      else
        TXmlConnector.FreeMemory(pData);
      return str;
    }

    public string ConnectorInitialize(string Path, short LogLevel)
    {
      IntPtr num1 = MarshalUTF8.StringToHGlobalUTF8(Path);
      IntPtr num2 = new IntPtr();
      IntPtr pData = !Environment.Is64BitProcess ? TXmlConnector.Initialize(num1, (int) LogLevel) : TXmlConnector.Initialize64(num1, (int) LogLevel);
      if (pData != IntPtr.Zero)
      {
        string str = MarshalUTF8.PtrToStringUTF8(pData);
        Marshal.FreeHGlobal(num1);
        if (Environment.Is64BitProcess)
          TXmlConnector.FreeMemory64(pData);
        else
          TXmlConnector.FreeMemory(pData);
        return str;
      }
      else
      {
        Marshal.FreeHGlobal(num1);
        return string.Empty;
      }
    }

    public string ConnectorUnInitialize()
    {
      IntPtr num = new IntPtr();
      IntPtr pData = !Environment.Is64BitProcess ? TXmlConnector.UnInitialize() : TXmlConnector.UnInitialize64();
      if (!(pData != IntPtr.Zero))
        return string.Empty;
      string str = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXmlConnector.FreeMemory64(pData);
      else
        TXmlConnector.FreeMemory(pData);
      return str;
    }

    private void MyCallBack(IntPtr pData)
    {
      string data = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXmlConnector.FreeMemory64(pData);
      else
        TXmlConnector.FreeMemory(pData);
      this.RaiseNewDataEvent(data);
    }

    private void MyCallBackEx(IntPtr pData, IntPtr userData)
    {
      string data = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXmlConnector.FreeMemory64(pData);
      else
        TXmlConnector.FreeMemory(pData);
      this.RaiseNewDataEvent(data);
    }

    [DllImport("txmlconnector.dll")]
    private static bool SetCallback(TXmlConnector.CallBack pCallback);

    [DllImport("txmlconnector.dll", CallingConvention = CallingConvention.StdCall)]
    private static bool SetCallbackEx(TXmlConnector.CallBackEx pCallback, IntPtr userData);

    [DllImport("txmlconnector.dll")]
    private static IntPtr SendCommand(IntPtr pData);

    [DllImport("txmlconnector.dll")]
    private static bool FreeMemory(IntPtr pData);

    [DllImport("txmlconnector.dll")]
    private static IntPtr Initialize(IntPtr pPath, int logLevel);

    [DllImport("txmlconnector.dll")]
    private static IntPtr UnInitialize();

    [DllImport("txmlconnector64.dll", EntryPoint = "SetCallback")]
    private static bool SetCallback64(TXmlConnector.CallBack pCallback);

    [DllImport("txmlconnector64.dll", EntryPoint = "SetCallbackEx", CallingConvention = CallingConvention.StdCall)]
    private static bool SetCallbackEx64(TXmlConnector.CallBackEx pCallback, IntPtr userData);

    [DllImport("txmlconnector64.dll", EntryPoint = "SendCommand")]
    private static IntPtr SendCommand64(IntPtr pData);

    [DllImport("txmlconnector64.dll", EntryPoint = "FreeMemory")]
    private static bool FreeMemory64(IntPtr pData);

    [DllImport("txmlconnector64.dll", EntryPoint = "Initialize")]
    private static IntPtr Initialize64(IntPtr pPath, int logLevel);

    [DllImport("txmlconnector64.dll", EntryPoint = "UnInitialize")]
    private static IntPtr UnInitialize64();

    public delegate void CallBack(IntPtr pData);

    public delegate void CallBackEx(IntPtr pData, IntPtr userData);
  }
}
