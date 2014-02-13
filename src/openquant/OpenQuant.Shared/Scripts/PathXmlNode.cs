using FreeQuant.Xml;
using System;
using System.IO;

namespace OpenQuant.Shared.Scripts
{
	class PathXmlNode : XmlNodeBase
	{
		private const string ATTR_TYPE = "type";

		public override string NodeName
		{
			get
			{
				return "path";
			}
		}

		private PathXmlNode.PathType Type
		{
			get
			{
				return (PathXmlNode.PathType)Enum.Parse(typeof(PathXmlNode.PathType), this.GetStringAttribute("type"));
			}
			set
			{
				this.SetAttribute("type", (Enum)value);
			}
		}

		private string Path
		{
			get
			{
				return this.GetStringValue();
			}
			set
			{
				base.SetValue(value);
			}
		}

		public PathXmlNode() : base()
		{
		}

		public FileInfo GetValue(DirectoryInfo directory)
		{
			PathXmlNode.PathType type = this.Type;
			switch (type)
			{
				case PathXmlNode.PathType.Absolute:
					return new FileInfo(this.Path);
				case PathXmlNode.PathType.Relative:
					return new FileInfo(string.Format("{0}\\{1}", directory.FullName, this.Path));
				default:
					throw new NotSupportedException(string.Format("Unknown path type - {0}", type));
			}
		}

		public void SetValue(FileInfo value, DirectoryInfo directory)
		{
			string fullName = directory.FullName;
			if (value.FullName.ToUpper().StartsWith(fullName.ToUpper()))
			{
				this.Type = PathXmlNode.PathType.Relative;
				this.Path = value.FullName.Substring(fullName.Length + 1);
			}
			else
			{
				this.Type = PathXmlNode.PathType.Absolute;
				this.Path = value.FullName;
			}
		}

		public enum PathType
		{
			Absolute,
			Relative,
		}
	}
}
