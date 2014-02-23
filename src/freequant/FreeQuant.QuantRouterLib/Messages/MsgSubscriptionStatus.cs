using FreeQuant.QuantRouterLib.Data;
using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
    public class MsgSubscriptionStatus : Message
    {
        public SubscriptionStatus Data { get; set; }

        public MsgSubscriptionStatus() : base(13)
        {
            this.Data = new SubscriptionStatus();
        }

        protected override void OnGetData(BinaryWriter writer)
        {
            writer.Write(this.Data.Status);
            writer.Write(this.Data.Text);
        }

        protected override void OnSetData(BinaryReader reader)
        {
            this.Data.Status = reader.ReadByte();
            this.Data.Text = reader.ReadString();
        }
    }
}
