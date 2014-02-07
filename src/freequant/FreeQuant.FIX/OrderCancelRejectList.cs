namespace FreeQuant.FIX
{
	public class OrderCancelRejectList : FIXGroupList
	{
		public new OrderCancelReject this [int index]
		{
			get
			{
				return base[index] as OrderCancelReject;
			}
		}

		public OrderCancelReject GetById(int id)
		{
			return base.GetById(id) as OrderCancelReject;
		}
	}
}
