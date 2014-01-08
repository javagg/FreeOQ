using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class Message
  {
    public int Type { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    protected Message(int type)
    {
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
