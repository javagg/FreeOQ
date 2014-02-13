using FreeQuant.Providers;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OpenQuant.Shared.Providers
{
	class ProviderTypeNode : TreeNode
	{
		private System.Type providerType;
		private Dictionary<IProvider, ProviderNode> providerNodes;

		public ProviderTypeNode(System.Type providerType, string text) : base(text, 0, 0)
		{
			this.providerType = providerType;
			this.providerNodes = new Dictionary<IProvider, ProviderNode>();
		}

		public bool IsProviderValid(IProvider provider)
		{
			return this.providerType.IsInstanceOfType(provider);
		}

		public void AddProvider(IProvider provider)
		{
			ProviderNode providerNode = new ProviderNode(provider);
			this.providerNodes.Add(provider, providerNode);
			this.Nodes.Add(providerNode);
		}

		public void UpdateProviderStatus(IProvider provider)
		{
			if (!this.providerNodes.ContainsKey(provider))
				return;
			this.providerNodes[provider].UpdateStatus();
		}

		public void UpdateIcon()
		{
			this.ImageIndex = this.SelectedImageIndex = !this.IsExpanded ? 0 : 1;
		}
	}
}
