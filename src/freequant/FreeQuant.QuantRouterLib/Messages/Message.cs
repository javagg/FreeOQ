// Type: SmartQuant.QuantRouterLib.Messages.Message
// Assembly: SmartQuant.QuantRouterLib, Version=1.0.5036.28341, Culture=neutral, PublicKeyToken=null
// MVID: FDF277D6-C8FB-45C3-A0BD-1C1035F3B027
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.QuantRouterLib.dll

using NI8YCE6tH4BIeIEcEy;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.QuantRouterLib.Messages
{
  public class Message
  {
    public int Type { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected Message(int type)
    {
      FsUk4MLSBO9D20pvmc.ecCbiMQzAUsLm();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.Type = type;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void GetData(BinaryWriter writer)
    {
      this.OnGetData(writer);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetData(BinaryReader reader)
    {
      this.OnSetData(reader);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnGetData(BinaryWriter writer)
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected virtual void OnSetData(BinaryReader reader)
    {
    }
  }
}
