using OpenQuant.Shared.Compiler;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Xml;

namespace OpenQuant.Shared.Options
{
	[OptionsNode("Build", typeof(BuildOptionsPanel))]
	public class BuildOptions : OptionsBase
	{
		private FileInfo configFile;

		internal DirectoryInfo BinDirectory { get; private set; }

		internal BuildReferenceList References { get; private set; }

		public BuildOptions(FileInfo configFile, DirectoryInfo binDirectory)
		{
			this.configFile = configFile;
			this.BinDirectory = binDirectory;
			this.References = new BuildReferenceList();
		}

		public BuildReference[] GetReferences()
		{
			return this.References.ToArray();
		}

		protected override void OnLoad()
		{
			if (this.configFile.Exists)
			{
				BuildXmlDocument buildXmlDocument = new BuildXmlDocument();
				((XmlDocument)buildXmlDocument).Load(this.configFile.FullName);
				IEnumerator enumerator = buildXmlDocument.References.GetEnumerator();
				try
				{
					while (enumerator.MoveNext())
					{
						BuildReferenceXmlNode referenceXmlNode = (BuildReferenceXmlNode)enumerator.Current;
						BuildReference buildReference;
						switch (referenceXmlNode.ReferenceType)
						{
							case BuildReferenceType.API:
								buildReference = (BuildReference)new APIBuildReference(referenceXmlNode.ReferenceName, this.BinDirectory);
								break;
							case BuildReferenceType.NET:
								buildReference = (BuildReference)new GACBuildReference(referenceXmlNode.ReferenceName, referenceXmlNode.ReferenceVersion);
								break;
							case BuildReferenceType.User:
								buildReference = (BuildReference)new UserBuildReference(referenceXmlNode.HintPath);
								break;
							default:
								throw new ArgumentException(string.Format("Unknown reference type - {0}", (object)referenceXmlNode.ReferenceType));
						}
						if (!buildReference.Name.StartsWith("SmartQuant.", StringComparison.InvariantCultureIgnoreCase))
							this.References.Add(buildReference);
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					if (disposable != null)
						disposable.Dispose();
				}
			}
			else
			{
				this.References.Add((BuildReference)new GACBuildReference("System", new Version(4, 0, 0, 0)));
				this.References.Add((BuildReference)new GACBuildReference("System.Drawing", new Version(4, 0, 0, 0)));
				this.References.Add((BuildReference)new GACBuildReference("System.Windows.Forms", new Version(4, 0, 0, 0)));
				this.References.Add((BuildReference)new GACBuildReference("System.Xml", new Version(4, 0, 0, 0)));
				this.References.Add((BuildReference)new GACBuildReference("System.Xml.Linq", new Version(4, 0, 0, 0)));
				this.References.Add((BuildReference)new APIBuildReference("OpenQuant.API", this.BinDirectory));
			}
		}

		protected override void OnSave()
		{
			BuildXmlDocument buildXmlDocument = new BuildXmlDocument();
			foreach (BuildReference reference in (List<BuildReference>) this.References)
				buildXmlDocument.References.Add(reference);
			((XmlDocument)buildXmlDocument).Save(this.configFile.FullName);
		}
	}
}
