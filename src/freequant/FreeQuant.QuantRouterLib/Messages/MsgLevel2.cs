using FreeQuant.QuantRouterLib.Data;
using System;
using System.IO;

namespace FreeQuant.QuantRouterLib.Messages
{
    public class MsgLevel2 : Message
    {
        public Level2 Data { get; private set; }

        public MsgLevel2(Level2 level2) : base(1001)
        {
            this.Data = level2;
        }

        public MsgLevel2() : base(1001)
        {
            this.Data = new Level2();
        }

        protected override void OnGetData(BinaryWriter writer)
        {
            writer.Write(this.Data.RequestId);
            writer.Write(this.Data.SourceId);
            writer.Write((byte)this.Data.TickType);
            writer.Write(this.Data.DateTime.Ticks);
            writer.Write(this.Data.Price);
            writer.Write(this.Data.Size);
            writer.Write(this.Data.Action);
            writer.Write(this.Data.Side);
            writer.Write(this.Data.Position);
        }

        protected override void OnSetData(BinaryReader reader)
        {
            this.Data.RequestId = reader.ReadInt32();
            this.Data.SourceId = reader.ReadInt32();
            this.Data.TickType = (TickType)reader.ReadByte();
            this.Data.DateTime = new DateTime(reader.ReadInt64());
            this.Data.Price = reader.ReadDouble();
            this.Data.Size = reader.ReadInt32();
            this.Data.Action = reader.ReadByte();
            this.Data.Side = reader.ReadByte();
            this.Data.Position = reader.ReadInt32();
        }
    }
}
