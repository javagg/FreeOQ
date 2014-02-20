namespace FreeQuant.FIX
{
	public class FIXSecurityAltIDGroupList : FIXGroupList
	{
		public new FIXSecurityAltIDGroup this[int index]
		{
			get
			{
				return this.fList[index] as FIXSecurityAltIDGroup;
			}
		}
	}
}
