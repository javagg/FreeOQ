using FreeQuant.FIX;

namespace FreeQuant.Execution
{
  public class InstrumentOrderListTable
  {
    private OrderList hVbJB1RIV;
    private OrderList Dw0G9Ja2B;
    private OrderList lKGjLl8vq;
    private OrderList w3MMlj4hL;
    private OrderList za8QSbwTi;
    private OrderList U6SZj2ncF;

    public OrderList All
    {
       get
      {
        return this.hVbJB1RIV;
      }
    }

    public OrderList New
    {
       get
      {
        if (this.Dw0G9Ja2B == null)
          this.Dw0G9Ja2B = this.GetOrderList(OrdStatus.New);
        return this.Dw0G9Ja2B;
      }
    }

    public OrderList Pending
    {
       get
      {
        if (this.lKGjLl8vq == null)
          this.lKGjLl8vq = this.GetOrderList(OrdStatus.PendingNew);
        return this.lKGjLl8vq;
      }
    }

    public OrderList Cancelled
    {
       get
      {
        if (this.w3MMlj4hL == null)
          this.w3MMlj4hL = this.GetOrderList(OrdStatus.Cancelled);
        return this.w3MMlj4hL;
      }
    }

    public OrderList Rejected
    {
       get
      {
        if (this.za8QSbwTi == null)
          this.za8QSbwTi = this.GetOrderList(OrdStatus.Rejected);
        return this.za8QSbwTi;
      }
    }

    public OrderList Filled
    {
       get
      {
        if (this.U6SZj2ncF == null)
          this.U6SZj2ncF = this.GetOrderList(OrdStatus.Filled);
        return this.U6SZj2ncF;
      }
    }

    public int Count
    {
       get
      {
        return this.hVbJB1RIV.Count;
      }
    }

    
    public InstrumentOrderListTable()
    {
      this.hVbJB1RIV = new OrderList();
      this.Dw0G9Ja2B = (OrderList) null;
      this.lKGjLl8vq = (OrderList) null;
      this.w3MMlj4hL = (OrderList) null;
      this.za8QSbwTi = (OrderList) null;
      this.U6SZj2ncF = (OrderList) null;
    }

    
    public virtual void Clear()
    {
      this.hVbJB1RIV.Clear();
      this.Dw0G9Ja2B = (OrderList) null;
      this.lKGjLl8vq = (OrderList) null;
      this.w3MMlj4hL = (OrderList) null;
      this.za8QSbwTi = (OrderList) null;
      this.U6SZj2ncF = (OrderList) null;
    }

    
    public virtual void Add(SingleOrder order)
    {
      this.hVbJB1RIV.Add((IOrder) order);
      this.Dw0G9Ja2B = (OrderList) null;
      this.lKGjLl8vq = (OrderList) null;
      this.w3MMlj4hL = (OrderList) null;
      this.za8QSbwTi = (OrderList) null;
      this.U6SZj2ncF = (OrderList) null;
    }

    
    public virtual void Remove(SingleOrder order)
    {
      this.hVbJB1RIV.Remove((IOrder) order);
      this.Dw0G9Ja2B = (OrderList) null;
      this.lKGjLl8vq = (OrderList) null;
      this.w3MMlj4hL = (OrderList) null;
      this.za8QSbwTi = (OrderList) null;
      this.U6SZj2ncF = (OrderList) null;
    }

    
    public virtual void Update(SingleOrder order)
    {
      this.Dw0G9Ja2B = (OrderList) null;
      this.lKGjLl8vq = (OrderList) null;
      this.w3MMlj4hL = (OrderList) null;
      this.za8QSbwTi = (OrderList) null;
      this.U6SZj2ncF = (OrderList) null;
    }

    
    public OrderList GetOrderList(OrdStatus ordStatus)
    {
      OrderList orderList = new OrderList();
      foreach (SingleOrder singleOrder in (FIXGroupList) this.hVbJB1RIV)
      {
        if (singleOrder.OrdStatus == ordStatus)
          orderList.Add((IOrder) singleOrder);
      }
      return orderList;
    }
  }
}
