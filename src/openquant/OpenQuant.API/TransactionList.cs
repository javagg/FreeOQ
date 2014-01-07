using System.Collections;

namespace OpenQuant.API
{
  public class TransactionList : IEnumerable
  {
    private FreeQuant.Instruments.TransactionList transactionList;

    public int Count
    {
      get
      {
        return this.transactionList.Count;
      }
    }

    public Transaction this[int index]
    {
      get
      {
        return new Transaction(this.transactionList[index]);
      }
    }

    internal TransactionList(FreeQuant.Instruments.TransactionList transactionList)
    {
      this.transactionList = transactionList;
    }

    public IEnumerator GetEnumerator()
    {
      return (IEnumerator) new TransactionListEnumerator(this.transactionList);
    }
  }
}
