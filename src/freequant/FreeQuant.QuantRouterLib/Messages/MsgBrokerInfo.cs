using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
    public class MsgBrokerInfo : Message
    {
        public BrokerInfo Data { get; set; }

        public MsgBrokerInfo(BrokerInfo brokerInfo) : base(2001)
        {
            this.Data = brokerInfo;
        }

        public MsgBrokerInfo() : base(2001)
        {
            this.Data = new BrokerInfo();
        }

        protected override void OnGetData(BinaryWriter writer)
        {
            writer.Write(this.Data.ProviderId);
            writer.Write(this.Data.Accounts.Count);
            foreach (BrokerAccount brokerAccount in this.Data.Accounts)
                this.H4vuEjxO1C(writer, brokerAccount);
        }

        private void H4vuEjxO1C(BinaryWriter obj0, BrokerAccount obj1)
        {
            obj0.Write(obj1.Name);
            obj0.Write(obj1.BuyingPower);
            BrokerOrder[] orders = obj1.GetOrders();
            obj0.Write(orders.Length);
            foreach (BrokerOrder brokerOrder in orders)
                this.RoYu8jI0tu(obj0, brokerOrder);
            BrokerPosition[] positions = obj1.GetPositions();
            obj0.Write(positions.Length);
            foreach (BrokerPosition brokerPosition in positions)
                this.oR3uofPPWO(obj0, brokerPosition);
            BrokerAccountField[] fields = obj1.GetFields();
            obj0.Write(fields.Length);
            foreach (BrokerAccountField brokerAccountField in fields)
            {
                obj0.Write(brokerAccountField.Name);
                obj0.Write(brokerAccountField.Value);
                obj0.Write(brokerAccountField.Currency);
            }
        }

        private void oR3uofPPWO(BinaryWriter obj0, BrokerPosition obj1)
        {
            obj0.Write(obj1.Currency);
            obj0.Write(obj1.LongQty);
            obj0.Write(obj1.MaturityDate.Ticks);
            obj0.Write(obj1.PutOrCall);
            obj0.Write(obj1.Qty);
            obj0.Write(obj1.SecurityExchange);
            obj0.Write(obj1.SecurityType);
            obj0.Write(obj1.ShortQty);
            obj0.Write(obj1.Strike);
            obj0.Write(obj1.Symbol);
            BrokerPositionField[] customFields = obj1.GetCustomFields();
            obj0.Write(customFields.Length);
            foreach (BrokerPositionField brokerPositionField in customFields)
            {
                obj0.Write(brokerPositionField.Name);
                obj0.Write(brokerPositionField.Value);
            }
        }

        private void RoYu8jI0tu(BinaryWriter obj0, BrokerOrder obj1)
        {
            obj0.Write(obj1.Currency);
            obj0.Write(obj1.OrderID);
            obj0.Write(obj1.OrderQty);
            obj0.Write(obj1.OrdStatus);
            obj0.Write(obj1.OrdType);
            obj0.Write(obj1.Price);
            obj0.Write(obj1.SecurityExchange);
            obj0.Write(obj1.SecurityType);
            obj0.Write(obj1.Side);
            obj0.Write(obj1.StopPx);
            obj0.Write(obj1.Symbol);
            BrokerOrderField[] customFields = obj1.GetCustomFields();
            obj0.Write(customFields.Length);
            foreach (BrokerOrderField brokerOrderField in customFields)
            {
                obj0.Write(brokerOrderField.Name);
                obj0.Write(brokerOrderField.Value);
            }
        }

        protected override void OnSetData(BinaryReader reader)
        {
            this.Data.ProviderId = reader.ReadByte();
            int num = reader.ReadInt32();
            for (int index = 0; index < num; ++index)
                this.Data.Accounts.Add(this.cKpu5qjmIn(reader));
        }

        private BrokerAccount cKpu5qjmIn(BinaryReader obj0)
        {
            string name1 = obj0.ReadString();
            double num1 = obj0.ReadDouble();
            BrokerAccount brokerAccount = new BrokerAccount(name1);
            brokerAccount.BuyingPower = num1;
            int num2 = obj0.ReadInt32();
            for (int index = 0; index < num2; ++index)
                brokerAccount.AddOrder(this.vHxhvWlydv(obj0));
            int num3 = obj0.ReadInt32();
            for (int index = 0; index < num3; ++index)
                brokerAccount.AddPosition(this.lrvuzgJsBI(obj0));
            int num4 = obj0.ReadInt32();
            for (int index = 0; index < num4; ++index)
            {
                string name2 = obj0.ReadString();
                string str = obj0.ReadString();
                string currency = obj0.ReadString();
                brokerAccount.AddField(name2, currency, str);
            }
            return brokerAccount;
        }

        private BrokerPosition lrvuzgJsBI(BinaryReader obj0)
        {
            BrokerPosition brokerPosition = new BrokerPosition();
            brokerPosition.Currency = obj0.ReadString();
            brokerPosition.LongQty = obj0.ReadDouble();
            brokerPosition.MaturityDate = new DateTime(obj0.ReadInt64());
            brokerPosition.PutOrCall = obj0.ReadInt32();
            brokerPosition.Qty = obj0.ReadDouble();
            brokerPosition.SecurityExchange = obj0.ReadString();
            brokerPosition.SecurityType = obj0.ReadString();
            brokerPosition.ShortQty = obj0.ReadDouble();
            brokerPosition.Strike = obj0.ReadDouble();
            brokerPosition.Symbol = obj0.ReadString();
            int num = obj0.ReadInt32();
            for (int index = 0; index < num; ++index)
            {
                string name = obj0.ReadString();
                string str = obj0.ReadString();
                brokerPosition.AddCustomField(name, str);
            }
            return brokerPosition;
        }

        private BrokerOrder vHxhvWlydv(BinaryReader obj0)
        {
            BrokerOrder brokerOrder = new BrokerOrder();
            brokerOrder.Currency = obj0.ReadString();
            brokerOrder.OrderID = obj0.ReadString();
            brokerOrder.OrderQty = obj0.ReadDouble();
            brokerOrder.OrdStatus = obj0.ReadChar();
            brokerOrder.OrdType = obj0.ReadChar();
            brokerOrder.Price = obj0.ReadDouble();
            brokerOrder.SecurityExchange = obj0.ReadString();
            brokerOrder.SecurityType = obj0.ReadString();
            brokerOrder.Side = obj0.ReadChar();
            brokerOrder.StopPx = obj0.ReadDouble();
            brokerOrder.Symbol = obj0.ReadString();
            int num = obj0.ReadInt32();
            for (int index = 0; index < num; ++index)
            {
                string name = obj0.ReadString();
                string str = obj0.ReadString();
                brokerOrder.AddCustomField(name, str);
            }
            return brokerOrder;
        }
    }
}
