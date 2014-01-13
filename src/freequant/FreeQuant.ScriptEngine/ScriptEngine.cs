using System;
using Microsoft.CSharp;
using System.Text;
using System.CodeDom.Compiler;

namespace FreeQuant
{
	public class ScriptEngine
    {
		private static readonly string[] DEFAULT_ASSEMBLIES = new string[] { "System.dll", "System.Core.dll", "System.Data.dll", "System.Xml.dll", "System.Xml.Linq.dll" };
		private static readonly string[] DEFAULT_NAMESPACES = new string[] { "System", "System.Collections.Generic", "System.Linq", "System.Text" };
		public ScriptEngine()
        {
        }

		public static void Main()
		{
			var engine = new ScriptEngine();
			CompilerErrorCollection err = new CompilerErrorCollection();
			engine.Run("Console.WriteLine(\"Hello, Script!\");", out err);

		}
		public bool Run(string sourceCode, out CompilerErrorCollection compilationErrors)
		{
			bool compilationSucceeded = true;
			compilationErrors = new CompilerErrorCollection();
			CSharpCodeProvider provider = new CSharpCodeProvider();

			// Build the parameters for source compilation.
			CompilerParameters cp = new CompilerParameters();
			cp.TreatWarningsAsErrors = false;

			// Add assembly references.
			cp.ReferencedAssemblies.AddRange(DEFAULT_ASSEMBLIES);
			//cp.ReferencedAssemblies.AddRange(ReferencedAssemblies.ToArray());

			cp.GenerateInMemory = true;

			// Add using statements.
			StringBuilder script = new StringBuilder();
			foreach (var usingNamespace in DEFAULT_NAMESPACES)
				script.AppendFormat("using {0};\n", usingNamespace);

//			foreach (var additionalUsingNamespace in UsingNamespaces)
//				script.AppendFormat("using {0};\n", additionalUsingNamespace);

			// Create the script.
			script.AppendLine();
			script.AppendLine("namespace ScriptEngine");
			script.AppendLine("{");
			script.AppendLine("    public class Program");
			script.AppendLine("    {");
			script.AppendLine("        public void Run()");
			script.AppendLine("        {");
			script.AppendLine("            try");
			script.AppendLine("            {");
			script.AppendFormat("              {0}\n", sourceCode);
			script.AppendLine("            }");
			script.AppendLine("            catch (Exception e)");
			script.AppendLine("            {");
//			script.AppendLine("                Context.Error = _compilationException;");
			script.AppendLine("            }");
			script.AppendLine("        }");
			script.AppendLine("    }");
			script.AppendLine("}");

			// Invoke compilation.
			CompilerResults cr = provider.CompileAssemblyFromSource(cp, script.ToString());

			if (cr.Errors.Count > 0)
			{
				foreach (CompilerError ce in cr.Errors)
				{
					#if DEBUG
					Console.WriteLine("  {0}", ce.ToString());
					Console.WriteLine();
					#endif
					ce.Line = ce.Line - 13;
					compilationErrors.Add(ce);

					if (!ce.IsWarning)
						compilationSucceeded = false;
				}
			}

			if (compilationSucceeded)
			{
				var ass = cr.CompiledAssembly;
				var execInstance = ass.CreateInstance("ScriptEngine.Program");

				var type = execInstance.GetType();
				var methodInfo = type.GetMethod("Run");

				// Execute the code.
//				methodInfo.Invoke(execInstance, new object[] { context });
				methodInfo.Invoke(execInstance, new object[] {});
			}

			return compilationSucceeded;
		}
    }
}

