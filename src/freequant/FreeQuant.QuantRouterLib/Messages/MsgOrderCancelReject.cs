using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
    public class MsgOrderCancelReject : Message
    {
        public OrderCancelReject Data { get; private set; }

        public MsgOrderCancelReject() : base(1102)
        {
        }

        public MsgOrderCancelReject(OrderCancelReject orderCancelReject) : base(1102)
        {
            this.Data = orderCancelReject;
        }

        protected override void OnGetData(BinaryWriter writer)
        {
            writer.Write(this.Data.CommandId);
            writer.Write(this.Data.Text);
            writer.Write(this.Data.TransactTime.Ticks);
            writer.Write(this.Data.CxlRejReason);
            writer.Write(this.Data.CxlRejResponseTo);
            writer.Write(this.Data.OrderID);
            writer.Write(this.Data.OrdStatus);
            writer.Write(this.Data.OrigClOrdID);
            writer.Write(this.Data.ClOrdID);
        }

        protected override void OnSetData(BinaryReader reader)
        {
            this.Data.CommandId = reader.ReadInt32();
            this.Data.Text = reader.ReadString();
            this.Data.TransactTime = new DateTime(reader.ReadInt64());
            this.Data.CxlRejReason = reader.ReadInt32();
            this.Data.CxlRejResponseTo = reader.ReadChar();
            this.Data.OrderID = reader.ReadString();
            this.Data.OrdStatus = reader.ReadChar();
            this.Data.OrigClOrdID = reader.ReadString();
            this.Data.ClOrdID = reader.ReadString();
        }
    }
}
