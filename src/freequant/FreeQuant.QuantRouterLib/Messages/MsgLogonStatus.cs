using FreeQuant.QuantRouterLib.Data;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.QuantRouterLib.Messages
{
  public class MsgLogonStatus : Message
  {
    public LogonStatus Data { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

	public MsgLogonStatus() : base(2)
    {

      this.Data = new LogonStatus();
    }

    protected override void OnGetData(BinaryWriter writer)
    {
      writer.Write(this.Data.IsLoggedIn);
      writer.Write(this.Data.Text);
    }

    protected override void OnSetData(BinaryReader reader)
    {
      this.Data.IsLoggedIn = reader.ReadBoolean();
      this.Data.Text = reader.ReadString();
    }
  }
}
