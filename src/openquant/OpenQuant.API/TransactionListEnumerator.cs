using System.Collections;

namespace OpenQuant.API
{
  internal class TransactionListEnumerator : IEnumerator
  {
    private SmartQuant.Instruments.TransactionList transactionList;
    private IEnumerator enumerator;

    public object Current
    {
      get
      {
        return (object) new Transaction(this.enumerator.Current as SmartQuant.Instruments.Transaction);
      }
    }

    internal TransactionListEnumerator(SmartQuant.Instruments.TransactionList transactionList)
    {
      this.transactionList = transactionList;
      this.enumerator = transactionList.GetEnumerator();
    }

    public bool MoveNext()
    {
      return this.enumerator.MoveNext();
    }

    public void Reset()
    {
      this.enumerator.Reset();
    }
  }
}
