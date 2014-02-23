using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
    public class MsgSubscribe : MsgSubscriptionBase
    {
        public MsgSubscribe() : base(10)
        {
        }

        protected override void OnGetData(BinaryWriter writer)
        {
            base.OnGetData(writer);
            writer.Write(this.Data.Symbol);
            writer.Write(this.Data.Formula);
        }

        protected override void OnSetData(BinaryReader reader)
        {
            base.OnSetData(reader);
            this.Data.Symbol = reader.ReadString();
            this.Data.Formula = reader.ReadString();
        }
    }
}
