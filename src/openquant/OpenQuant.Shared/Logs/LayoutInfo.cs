namespace OpenQuant.Shared.Logs
{
	public struct LayoutInfo
	{
		public TabLayoutInfo[] Tabs;

		public static LayoutInfo Default
		{
			get
			{
				LayoutInfo layoutInfo = new LayoutInfo();
				layoutInfo.Tabs = new TabLayoutInfo[] { TabLayoutInfo.Default };
				return layoutInfo;
			}
		}
	}
}
