// Type: SmartQuant.Testing.Components.TesterComponentRecord
// Assembly: SmartQuant.Testing, Version=1.0.5036.28344, Culture=neutral, PublicKeyToken=null
// MVID: 176468FF-0FA0-4631-84AD-38EF6EDC463D
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Testing.dll

using Byqm85MNrFBe6JPJlI;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace SmartQuant.Testing.Components
{
  public class TesterComponentRecord
  {
    private const string gtgeOlIHtV = "Naming";
    private const string UaxeaZP1KM = "Misc";
    private string m2leiEkS0b;
    private string ihBe1O6DJg;
    private FileInfo jfGeuQbWrm;
    private Type PaNeHuD61b;

    [Category("Naming")]
    [Description("Component name")]
    public string Name
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.m2leiEkS0b;
      }
    }

    [Description("Component description")]
    [Category("Naming")]
    public string Description
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.ihBe1O6DJg;
      }
    }

    [Browsable(false)]
    public FileInfo File
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.jfGeuQbWrm;
      }
    }

    [Browsable(false)]
    public Type Type
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.PaNeHuD61b;
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    internal TesterComponentRecord(string name, string description, FileInfo file, Type type)
    {
      JALDIdDEhORsdnKRLQ.ot5XEbmzoL0lp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.m2leiEkS0b = name;
      this.ihBe1O6DJg = description;
      this.jfGeuQbWrm = file;
      this.PaNeHuD61b = type;
    }
  }
}
