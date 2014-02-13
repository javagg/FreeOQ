using FreeQuant.Data;
using FreeQuant.Instruments;
using System;
using System.Collections.Generic;
using System.Threading;

namespace OpenQuant.Shared.Data.Import.NxCore
{
  internal class AsyncDataWriter : DataWriter
  {
    private Thread thread;
    private volatile bool doWork;
    private Queue<AsyncDataWriter.QueueAction> queue;
    private int maxBufferSize;
    private Exception error;

    public AsyncDataWriter(int maxBufferSize)
    {
      this.maxBufferSize = maxBufferSize;
      this.error = (Exception) null;
    }

    public override void BeginWrite()
    {
      this.queue = new Queue<AsyncDataWriter.QueueAction>();
      this.thread = new Thread(new ParameterizedThreadStart(this.ThreadMain));
      this.thread.Name = "NxCore Data Writer";
      this.thread.IsBackground = true;
      ManualResetEvent manualResetEvent = new ManualResetEvent(false);
      this.doWork = true;
      this.thread.Start((object) manualResetEvent);
      manualResetEvent.WaitOne();
      base.BeginWrite();
    }

    public override void EndWrite()
    {
      if (this.error == null)
      {
label_1:
        lock (this.queue)
        {
          if (this.queue.Count != 0)
            goto label_1;
        }
        this.doWork = false;
        while (this.thread.IsAlive)
          Thread.Sleep(1);
      }
      base.EndWrite();
    }

    public override void Write(Instrument instrument, Trade trade)
    {
      if (this.error != null)
        throw this.error;
      this.Enqueue(instrument, (IDataObject) trade);
    }

    public override void Write(Instrument instrument, Quote quote)
    {
      if (this.error != null)
        throw this.error;
      this.Enqueue(instrument, (IDataObject) quote);
    }

    private void Enqueue(Instrument instrument, IDataObject dataObject)
    {
      while (true)
      {
        lock (this.queue)
        {
          if (this.queue.Count < this.maxBufferSize)
          {
            if (dataObject is Trade)
              this.queue.Enqueue((AsyncDataWriter.QueueAction) new AsyncDataWriter.TradeAction(instrument, (Trade) dataObject));
            if (!(dataObject is Quote))
              break;
            this.queue.Enqueue((AsyncDataWriter.QueueAction) new AsyncDataWriter.QuoteAction(instrument, (Quote) dataObject));
            break;
          }
        }
        Thread.Sleep(1);
      }
    }

    private void ThreadMain(object state)
    {
      ((EventWaitHandle) state).Set();
      try
      {
        while (this.doWork)
        {
          AsyncDataWriter.QueueAction[] queueActionArray;
          lock (this.queue)
          {
            queueActionArray = this.queue.ToArray();
            this.queue.Clear();
          }
          if (queueActionArray.Length > 0)
          {
            foreach (AsyncDataWriter.QueueAction queueAction in queueActionArray)
              queueAction.Invoke();
          }
          else
            Thread.Sleep(1);
        }
      }
      catch (Exception ex)
      {
        this.error = ex;
      }
    }

    private abstract class QueueAction
    {
      protected Instrument instrument;

      protected QueueAction(Instrument instrument)
      {
        this.instrument = instrument;
      }

      public abstract void Invoke();
    }

    private class TradeAction : AsyncDataWriter.QueueAction
    {
      private Trade trade;

      public TradeAction(Instrument instrument, Trade trade)
        : base(instrument)
      {
        this.trade = trade;
      }

      public override void Invoke()
      {
        this.instrument.Add(this.trade);
      }
    }

    private class QuoteAction : AsyncDataWriter.QueueAction
    {
      private Quote quote;

      public QuoteAction(Instrument instrument, Quote quote)
        : base(instrument)
      {
        this.quote = quote;
      }

      public override void Invoke()
      {
        this.instrument.Add(this.quote);
      }
    }
  }
}
