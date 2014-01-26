using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class ComponentRecord
  {
    private const string RZLA2JgLpl = "Naming";
    private const string geMABJq1qp = "Misc";
    private Guid Nw6AMYVhpY;
    private ComponentType ADRAb0ogRe;
    private string PCJAyM2mJo;
    private string VE2AGjfq7K;
    private FileInfo cJeASj73hr;
    private Type h8rATLvYmT;
    private CompilerErrorCollection aDSArHx8Z9;
    private bool rHqAIJtKMy;

    [Category("Misc")]
    [Description("Component GUID")]
    public Guid GUID
    {
       get
      {
        return this.Nw6AMYVhpY;
      }
    }

    [Description("Component type")]
    [ReadOnly(true)]
    [Category("Misc")]
    public ComponentType ComponentType
    {
       get
      {
        return this.ADRAb0ogRe;
      }
    }

    [Description("Component name")]
    [Category("Naming")]
    public string Name
    {
       get
      {
        return this.PCJAyM2mJo;
      }
    }

    [Description("Component description")]
    [Category("Naming")]
    public string Description
    {
       get
      {
        return this.VE2AGjfq7K;
      }
    }

    [Browsable(false)]
    public FileInfo File
    {
       get
      {
        return this.cJeASj73hr;
      }
    }

    public bool BuiltIn
    {
       get
      {
        return this.cJeASj73hr == null;
      }
    }

    public Type RuntimeType
    {
       get
      {
        return this.h8rATLvYmT;
      }
    }

    public bool IsChanged
    {
       get
      {
        return this.rHqAIJtKMy;
      }
    }

    [Browsable(false)]
    public CompilerErrorCollection Errors
    {
       get
      {
        return this.aDSArHx8Z9;
      }
    }

    
    internal ComponentRecord(Guid guid, ComponentType componentType, string name, string description, FileInfo file, Type runtimeType, CompilerErrorCollection errors)
    {
      this.Nw6AMYVhpY = guid;
      this.ADRAb0ogRe = componentType;
      this.PCJAyM2mJo = name;
      this.VE2AGjfq7K = description;
      this.cJeASj73hr = file;
      this.h8rATLvYmT = runtimeType;
      this.aDSArHx8Z9 = errors;
      this.rHqAIJtKMy = false;
    }

    
    internal void VnhAiVxt7S([In] bool obj0)
    {
      this.rHqAIJtKMy = obj0;
    }

    
    internal void TkgA7UI4gW([In] Guid obj0)
    {
      this.Nw6AMYVhpY = obj0;
    }

    
    internal void CvyAHpcreG([In] ComponentType obj0)
    {
      this.ADRAb0ogRe = obj0;
    }

    
    internal void lfVAUUDxYN([In] string obj0)
    {
      this.PCJAyM2mJo = obj0;
    }

    
    internal void x63AOXlRIK([In] string obj0)
    {
      this.VE2AGjfq7K = obj0;
    }

    
    internal void X8yAQiuh7R([In] Type obj0)
    {
      this.h8rATLvYmT = obj0;
    }

    
    internal void HrjA5j3PaA([In] CompilerErrorCollection obj0)
    {
      this.aDSArHx8Z9 = obj0;
    }
  }
}
