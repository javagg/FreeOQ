// Type: SmartQuant.FIXData.FIXGroupStreamer
// Assembly: SmartQuant.FIXData, Version=1.0.5036.28338, Culture=neutral, PublicKeyToken=null
// MVID: EFFB17F5-E3EE-4C04-A796-299A152DA0CE
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIXData.dll

using E8idH0Km5kZBKt6QG5;
using SmartQuant.FIX;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using wX0V5eTmynNWOQ6XiD;

namespace SmartQuant.FIXData
{
  public class FIXGroupStreamer
  {
    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroupStreamer()
    {
      aHVXF4EQTqOeMK8FH8.jYIb1Y6zBfgK8();
      // ISSUE: explicit constructor call
      base.\u002Ector();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void WriteTo(BinaryWriter writer, FIXGroup group)
    {
      writer.Write(group.Fields.Length);
      foreach (FIXField fixField in group.Fields)
      {
        writer.Write(fixField.Tag);
        switch (fixField.FIXType)
        {
          case FIXType.Bool:
            writer.Write(((FIXBoolField) fixField).Value);
            break;
          case FIXType.Int:
            writer.Write(((FIXIntField) fixField).Value);
            break;
          case FIXType.Double:
            writer.Write(((FIXDoubleField) fixField).Value);
            break;
          case FIXType.Char:
            writer.Write(((FIXCharField) fixField).Value);
            break;
          case FIXType.String:
            writer.Write(((FIXStringField) fixField).Value);
            break;
          case FIXType.DateTime:
            writer.Write(((FIXDateTimeField) fixField).Value.Ticks);
            break;
          default:
            throw new ArgumentException(lM8JZ634QZnRu7hfEw.vt70XMgdJ(0) + ((object) fixField.FIXType).ToString());
        }
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public static void ReadFrom(BinaryReader reader, FIXGroup group)
    {
      int num = reader.ReadInt32();
      for (int index = 0; index < num; ++index)
      {
        int tag = reader.ReadInt32();
        FIXType fixType = EFIXFieldTypes.GetFIXType(tag);
        switch (fixType)
        {
          case FIXType.Bool:
            group.AddBoolField(tag, reader.ReadBoolean());
            break;
          case FIXType.Int:
            group.AddIntField(tag, reader.ReadInt32());
            break;
          case FIXType.Double:
            group.AddDoubleField(tag, reader.ReadDouble());
            break;
          case FIXType.Char:
            group.AddCharField(tag, reader.ReadChar());
            break;
          case FIXType.String:
            group.AddStringField(tag, reader.ReadString());
            break;
          case FIXType.DateTime:
            group.AddDateTimeField(tag, new DateTime(reader.ReadInt64()));
            break;
          default:
            throw new ArgumentException(lM8JZ634QZnRu7hfEw.vt70XMgdJ(42) + ((object) fixType).ToString());
        }
      }
    }
  }
}
