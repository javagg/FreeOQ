using OpenQuant.API.Design;
using FreeQuant.FIX;
using System.ComponentModel;
using System.Drawing.Design;

namespace OpenQuant.API
{
	public class AltIDGroup
	{
		internal FIXSecurityAltIDGroup group;
		private Instrument instrument;

		[Description("Instrument alternative symbol")]
		[Category("Appearance (alternative)")]
		public string AltSymbol
		{
			get
			{
				return this.group.SecurityAltID;
			}
			set
			{
				this.group.SecurityAltID = value;
				this.instrument.instrument.Save();
			}
		}

		[Editor(typeof(AltSourceTypeEditor), typeof(UITypeEditor))]
		[Category("Appearance (alternative)")]
		[Description("Alternative source of instrument definition (provider name)")]
		public string AltSource
		{
			get
			{
				return this.group.SecurityAltIDSource;
			}
			set
			{
				this.group.SecurityAltIDSource = value;
				this.instrument.instrument.Save();
			}
		}

		[Category("Appearance (alternative)")]
		[Description("Instrument alternative exchange")]
		public string AltExchange
		{
			get
			{
				return this.group.SecurityAltExchange;
			}
			set
			{
				this.group.SecurityAltExchange = value;
				this.instrument.instrument.Save();
			}
		}

		internal AltIDGroup(Instrument instrument, FIXSecurityAltIDGroup group)
		{
			this.group = group;
			this.instrument = instrument;
		}

		public override bool Equals(object obj)
		{
			AltIDGroup altIdGroup = obj as AltIDGroup;
			if (altIdGroup != null)
				return altIdGroup.group == this.group;
			else
				return false;
		}

		public override int GetHashCode()
		{
			return this.group.GetHashCode();
		}

		public override string ToString()
		{
			return this.AltSource;
		}
	}
}
