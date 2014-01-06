// Type: SmartQuant.FIX.FIXGroup
// Assembly: SmartQuant.FIX, Version=1.0.5036.28336, Culture=neutral, PublicKeyToken=null
// MVID: 126ED788-A8C6-4224-A17F-6E9A67745D7C
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.FIX.dll

using iL6jh33hEcPk05eVIF;
using QjaKfQ9Jr3AV8F2T87;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SmartQuant.FIX
{
  public class FIXGroup
  {
    private Dictionary<int, FIXField> d1F8MdRGd;
    private object oncZo3Ix5;

    [Browsable(false)]
    public int Id { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] set; }

    [Browsable(false)]
    public virtual int Tag
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return -1;
      }
    }

    [Browsable(false)]
    public FIXField[] Fields
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        lock (this.oncZo3Ix5)
        {
          FIXField[] local_0 = new FIXField[this.d1F8MdRGd.Count];
          this.d1F8MdRGd.Values.CopyTo(local_0, 0);
          return local_0;
        }
      }
    }

    [Browsable(false)]
    public FIXGroupTable Groups { [MethodImpl(MethodImplOptions.NoInlining)] get; [MethodImpl(MethodImplOptions.NoInlining)] private set; }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXGroup()
    {
      v09p8g7rbqSJwrIsGb.qk7PgoFzKVMdL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.d1F8MdRGd = new Dictionary<int, FIXField>();
      this.oncZo3Ix5 = new object();
      this.Id = -1;
      this.Groups = new FIXGroupTable();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool ContainsField(int tag)
    {
      lock (this.oncZo3Ix5)
        return this.d1F8MdRGd.ContainsKey(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void RemoveField(int tag)
    {
      lock (this.oncZo3Ix5)
        this.d1F8MdRGd.Remove(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Clear()
    {
      lock (this.oncZo3Ix5)
        this.d1F8MdRGd.Clear();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddField(FIXField field)
    {
      lock (this.oncZo3Ix5)
        this.d1F8MdRGd[field.Tag] = field;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddField(int tag, object value)
    {
      if (value is char)
        this.AddCharField(tag, (char) value);
      else if (value is int)
        this.AddIntField(tag, (int) value);
      else if (value is double)
        this.AddDoubleField(tag, (double) value);
      else if (value is bool)
        this.AddBoolField(tag, (bool) value);
      else if (value is string)
      {
        this.AddStringField(tag, (string) value);
      }
      else
      {
        if (!(value is DateTime))
          return;
        this.AddDateTimeField(tag, (DateTime) value);
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddStringField(int tag, string value)
    {
      this.AddField((FIXField) new FIXStringField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddCharField(int tag, char value)
    {
      this.AddField((FIXField) new FIXCharField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddBoolField(int tag, bool value)
    {
      this.AddField((FIXField) new FIXBoolField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddIntField(int tag, int value)
    {
      this.AddField((FIXField) new FIXIntField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDoubleField(int tag, double value)
    {
      this.AddField((FIXField) new FIXDoubleField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddDateTimeField(int tag, DateTime value)
    {
      this.AddField((FIXField) new FIXDateTimeField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddNumInGroupField(int tag, int value)
    {
      this.AddField((FIXField) new FIXNumInGroupField(tag, value));
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void AddFields(FIXGroup from)
    {
      foreach (FIXField field in from.Fields)
        this.AddField(field);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXField GetField(int tag)
    {
      lock (this.oncZo3Ix5)
      {
        FIXField local_0;
        return this.d1F8MdRGd.TryGetValue(tag, out local_0) ? local_0 : (FIXField) null;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXStringField GetStringField(int tag)
    {
      return (FIXStringField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXCharField GetCharField(int tag)
    {
      return (FIXCharField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXBoolField GetBoolField(int tag)
    {
      return (FIXBoolField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXIntField GetIntField(int tag)
    {
      return (FIXIntField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDoubleField GetDoubleField(int tag)
    {
      return (FIXDoubleField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXDateTimeField GetDateTimeField(int tag)
    {
      return (FIXDateTimeField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public FIXNumInGroupField GetNumInGroupField(int tag)
    {
      return (FIXNumInGroupField) this.GetField(tag);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public object GetValue(int tag)
    {
      FIXField field = this.GetField(tag);
      if (field != null)
        return field.GetValue();
      else
        return (object) null;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public bool GetBoolValue(int tag)
    {
      FIXBoolField boolField = this.GetBoolField(tag);
      if (boolField != null)
        return boolField.Value;
      else
        return false;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetIntValue(int tag)
    {
      FIXIntField intField = this.GetIntField(tag);
      if (intField != null)
        return intField.Value;
      else
        return 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public double GetDoubleValue(int tag)
    {
      FIXDoubleField doubleField = this.GetDoubleField(tag);
      if (doubleField != null)
        return doubleField.Value;
      else
        return 0.0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public char GetCharValue(int tag)
    {
      FIXCharField charField = this.GetCharField(tag);
      if (charField != null)
        return charField.Value;
      else
        return char.MinValue;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public string GetStringValue(int tag)
    {
      FIXStringField stringField = this.GetStringField(tag);
      if (stringField != null)
        return stringField.Value;
      else
        return string.Empty;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public DateTime GetDateTimeValue(int tag)
    {
      FIXDateTimeField dateTimeField = this.GetDateTimeField(tag);
      if (dateTimeField != null)
        return dateTimeField.Value;
      else
        return new DateTime(0L);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public int GetNumInGroupValue(int tag)
    {
      FIXNumInGroupField numInGroupField = this.GetNumInGroupField(tag);
      if (numInGroupField != null)
        return numInGroupField.Value;
      else
        return 0;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetBoolValue(int tag, bool value)
    {
      this.AddBoolField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetIntValue(int tag, int value)
    {
      this.AddIntField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDoubleValue(int tag, double value)
    {
      this.AddDoubleField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetCharValue(int tag, char value)
    {
      this.AddCharField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetStringValue(int tag, string value)
    {
      this.AddStringField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetDateTimeValue(int tag, DateTime value)
    {
      this.AddDateTimeField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetNumInGroupValue(int tag, int value)
    {
      this.AddNumInGroupField(tag, value);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public override string ToString()
    {
      List<string> list = new List<string>();
      foreach (FIXField fixField in this.Fields)
        list.Add(string.Format(Ugjylcah9mCMM4kO7N.tLah92SpBQ(0), (object) EFIXField.ToString(fixField.Tag), (object) fixField));
      return string.Join(Ugjylcah9mCMM4kO7N.tLah92SpBQ(18), (IEnumerable<string>) list);
    }
  }
}
