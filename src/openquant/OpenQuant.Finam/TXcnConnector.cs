using System;
using System.Runtime.InteropServices;

namespace OpenQuant.Finam
{
  public class TXcnConnector : ITransaqConnector
  {
    private static object syncRoot = new object();
    private const string EX_SETTING_CALLBACK = "Could not establish a callback function";
    private static volatile TXcnConnector instance;
    public TXcnConnector.CallBack myDelegate;
    public TXcnConnector.CallBackEx myDelegateEx;

    public static TXcnConnector Instance
    {
      get
      {
        if (TXcnConnector.instance == null)
        {
          lock (TXcnConnector.syncRoot)
          {
            if (TXcnConnector.instance == null)
              TXcnConnector.instance = new TXcnConnector();
          }
        }
        return TXcnConnector.instance;
      }
    }

    public event EventHandler<NewDataEventArgs> NewData;

    static TXcnConnector()
    {
    }

    public TXcnConnector()
    {
      this.myDelegate = new TXcnConnector.CallBack(this.MyCallBack);
      this.myDelegateEx = new TXcnConnector.CallBackEx(this.MyCallBackEx);
      if (Environment.Is64BitProcess)
      {
        if (!TXcnConnector.SetCallback64(this.myDelegate))
          throw new Exception("Could not establish a callback function");
        if (!TXcnConnector.SetCallbackEx64(this.myDelegateEx, IntPtr.Zero))
          throw new Exception("Could not establish a callback function");
      }
      else
      {
        if (!TXcnConnector.SetCallback(this.myDelegate))
          throw new Exception("Could not establish a callback function");
        if (!TXcnConnector.SetCallbackEx(this.myDelegateEx, IntPtr.Zero))
          throw new Exception("Could not establish a callback function");
      }
      TXcnConnector.instance = this;
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
      IntPtr pData = !Environment.Is64BitProcess ? TXcnConnector.SendCommand(num1) : TXcnConnector.SendCommand64(num1);
      if (!(pData != IntPtr.Zero))
        return string.Empty;
      string str = MarshalUTF8.PtrToStringUTF8(pData);
      Marshal.FreeHGlobal(num1);
      if (Environment.Is64BitProcess)
        TXcnConnector.FreeMemory64(pData);
      else
        TXcnConnector.FreeMemory(pData);
      return str;
    }

    public string ConnectorInitialize(string Path, short LogLevel)
    {
      IntPtr num1 = MarshalUTF8.StringToHGlobalUTF8(Path);
      IntPtr num2 = new IntPtr();
      IntPtr pData = !Environment.Is64BitProcess ? TXcnConnector.Initialize(num1, (int) LogLevel) : TXcnConnector.Initialize64(num1, (int) LogLevel);
      if (pData != IntPtr.Zero)
      {
        string str = MarshalUTF8.PtrToStringUTF8(pData);
        Marshal.FreeHGlobal(num1);
        if (Environment.Is64BitProcess)
          TXcnConnector.FreeMemory64(pData);
        else
          TXcnConnector.FreeMemory(pData);
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
      IntPtr pData = !Environment.Is64BitProcess ? TXcnConnector.UnInitialize() : TXcnConnector.UnInitialize64();
      if (!(pData != IntPtr.Zero))
        return string.Empty;
      string str = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXcnConnector.FreeMemory64(pData);
      else
        TXcnConnector.FreeMemory(pData);
      return str;
    }

    public void MyCallBack(IntPtr pData)
    {
      string data = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXcnConnector.FreeMemory64(pData);
      else
        TXcnConnector.FreeMemory(pData);
      this.RaiseNewDataEvent(data);
    }

    public void MyCallBackEx(IntPtr pData, IntPtr userData)
    {
      string data = MarshalUTF8.PtrToStringUTF8(pData);
      if (Environment.Is64BitProcess)
        TXcnConnector.FreeMemory64(pData);
      else
        TXcnConnector.FreeMemory(pData);
      this.RaiseNewDataEvent(data);
    }

    [DllImport("txcn.dll")]
    private static bool SetCallback(TXcnConnector.CallBack pCallback);

    [DllImport("txcn.dll", CallingConvention = CallingConvention.StdCall)]
    private static bool SetCallbackEx(TXcnConnector.CallBackEx pCallback, IntPtr userData);

    [DllImport("txcn.dll")]
    private static IntPtr SendCommand(IntPtr pData);

    [DllImport("txcn.dll")]
    private static bool FreeMemory(IntPtr pData);

    [DllImport("txcn.dll")]
    private static IntPtr Initialize(IntPtr pPath, int logLevel);

    [DllImport("txcn.dll")]
    private static IntPtr UnInitialize();

    [DllImport("txcn64.dll", EntryPoint = "SetCallback")]
    private static bool SetCallback64(TXcnConnector.CallBack pCallback);

    [DllImport("txcn64.dll", EntryPoint = "SetCallbackEx", CallingConvention = CallingConvention.StdCall)]
    private static bool SetCallbackEx64(TXcnConnector.CallBackEx pCallback, IntPtr userData);

    [DllImport("txcn64.dll", EntryPoint = "SendCommand")]
    private static IntPtr SendCommand64(IntPtr pData);

    [DllImport("txcn64.dll", EntryPoint = "FreeMemory")]
    private static bool FreeMemory64(IntPtr pData);

    [DllImport("txcn64.dll", EntryPoint = "Initialize")]
    private static IntPtr Initialize64(IntPtr pPath, int logLevel);

    [DllImport("txcn64.dll", EntryPoint = "UnInitialize")]
    private static IntPtr UnInitialize64();

    public delegate void CallBack(IntPtr pData);

    public delegate void CallBackEx(IntPtr pData, IntPtr userData);
  }
}
