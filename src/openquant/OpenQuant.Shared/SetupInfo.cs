namespace OpenQuant.Shared
{
	public class SetupInfo
	{
		public ProductInfo Product { get; private set; }

		public SetupFolders Folders { get; private set; }

		public SetupInfo(ProductInfo product, SetupFolders folders)
		{
			this.Product = product;
			this.Folders = folders;
		}
	}
}
