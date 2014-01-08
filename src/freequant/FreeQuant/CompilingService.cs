using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FreeQuant
{
  public class CompilingService
  {

    public CompilingService()
    {
    }

    public static CompilerResults Compile(string[] files, string[] references, bool generateEXE, bool generateInMemory, string output)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults Compile(string[] files, string[] references, bool generateEXE)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults Compile(string filename, bool generateEXE)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults CompileSource(string source, string[] references)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults CompileSource(string source)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults Compile(string filename, string output)
    {
      return (CompilerResults) null;
    }

    public static CompilerResults Compile(string[] filenames, string output)
    {
      return (CompilerResults) null;
    }
  }
}
