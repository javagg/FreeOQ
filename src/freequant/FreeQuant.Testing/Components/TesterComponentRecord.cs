using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;

namespace FreeQuant.Testing.Components
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
       get
      {
        return this.m2leiEkS0b;
      }
    }

    [Description("Component description")]
    [Category("Naming")]
    public string Description
    {
       get
      {
        return this.ihBe1O6DJg;
      }
    }

    [Browsable(false)]
    public FileInfo File
    {
       get
      {
        return this.jfGeuQbWrm;
      }
    }

    [Browsable(false)]
    public Type Type
    {
       get
      {
        return this.PaNeHuD61b;
      }
    }

    
		internal TesterComponentRecord(string name, string description, FileInfo file, Type type):base()
    {
      this.m2leiEkS0b = name;
      this.ihBe1O6DJg = description;
      this.jfGeuQbWrm = file;
      this.PaNeHuD61b = type;
    }
  }
}
