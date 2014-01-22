using Microsoft.Win32;
using System;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant
{
  public class Installation
  {
    private const string OsEB10mv7f = "QUANTSYS";
    private const string eVRBoveg7a = "QUANTDAT";
    private const string hgMBLxQl6m = "QUANTAPP";
    private const string TqrBFoqdfv = "Version";
    private const string RwEB7FGGnP = "{CDD416EC-BA43-47f9-BEE8-89125652118F}";
    private const string WI2BekVjWs = "{A7834A40-B64B-4efe-B697-DE670034DE0B}";
    private const string LIHBKqc3F3 = "solutions";
    private const string mUCBuH2sAx = "bin";
    private const string knDBOHiue0 = "objects";
    private const string vieBA7nEIb = "ini";
    private const string lS2BJNYjZr = "components";
    private const string i77BQIL7Kg = "templates";
    private const string ws5Ba4t27i = "help";
    private const string qFdBjQYUWm = "logs";
    private const string MZuBqYY2PX = "fix";
    private const string a4BBXpGGSs = "temp";
    private const string Q3eB3KSxo8 = "Main";
    private const string as1BzPVKYp = "Other";
    private const int ObTrn8HleO = 14;
    private DirectoryInfo oPMrmf3G9r;
    private DirectoryInfo T4Wr4Fk6P5;
    private DirectoryInfo rrmrBhZYP6;
    private DirectoryInfo EdPrrVSRQ8;
    private DirectoryInfo gEgrYJNnEK;
    private Version BABrSjmqdm;
    private bool mHQrkRnDmx;
    private bool krqrifGoPr;
    private bool TqSrDicxx6;
    private bool X4vrP8Ly4E;

    [Category("Main")]
    public Version Version
    {
       get
      {
        return (Version) null;
      }
    }

    [Browsable(false)]
    public Edition Edition
    {
       get
      {
				return Edition.Enterprise;
      }
    }

    [Browsable(false)]
    public string MainProduct
    {
       get
      {
        return (string) null;
      }
    }

    [Category("Main")]
    public DirectoryInfo QUANTSYS
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Main")]
    [ReadOnly(true)]
    public DirectoryInfo QUANTDAT
    {
       get
      {
        return (DirectoryInfo) null;
      }
       set
      {
      }
    }

    [Category("Main")]
    public DirectoryInfo QUANTAPP
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo DataDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    [ReadOnly(true)]
    public DirectoryInfo BinDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
       set
      {
      }
    }

    [Category("Other")]
    public DirectoryInfo IniDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo SolutionDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo ComponentDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo TemplateDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo HelpDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo LogDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo FIXDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

    [Category("Other")]
    public DirectoryInfo TempDir
    {
       get
      {
        return (DirectoryInfo) null;
      }
    }

   
    internal Installation()
    {
    }

    
    internal void k9JB9fI5oq()
    {
    }

    
    public LicenseInfo GetLicense()
    {
      // ISSUE: reference to a compiler-generated field
			return new LicenseInfo();
    }

    [SpecialName]
    
    internal bool tnABvXFOOP()
    {
      return true;
    }

    [SpecialName]
    internal bool c7kBpxixDa()
    {
      return true;
    }

    [SpecialName]
    internal bool i94BcvgC0K()
    {
      return true;
    }

    private string MR4BVNrLnA([In] RegistryKey obj0, [In] string obj1)
    {
      return (string) null;
    }

    private bool H3jBgrTW1C([In] RegistryKey obj0, [In] string obj1)
    {
      return true;
    }

    private void XoMBb3l1md([In] RegistryKey obj0, [In] string obj1, [In] string obj2)
    {
    }
  }
}
