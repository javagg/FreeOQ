using System.Windows.Forms;

namespace OpenQuant.Shared.Options
{
	class OptionsNode : TreeNode
	{
		public OptionsBase Options { get; private set; }

		public OptionsNode(OptionsBase options) : base(options.Text)
		{
			this.Options = options;
		}
	}
}
