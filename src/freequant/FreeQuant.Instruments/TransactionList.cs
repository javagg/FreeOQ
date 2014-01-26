using FreeQuant.Charting;
using System;
using System.Collections;
using System.ComponentModel;
using System.Text;

namespace FreeQuant.Instruments
{
	public class TransactionList : IEnumerable, IDrawable, IZoomable
	{
		private ArrayList transactions;
		protected string drawingOption;
		protected bool toolTipEnabled;
		protected string toolTipFormat;

		public int Count
		{
			get
			{
				return this.transactions.Count;
			}
		}

		public Transaction First
		{
			get
			{
				if (this.transactions.Count != 0)
					return this.transactions[0] as Transaction;
				else
					return (Transaction)null;
			}
		}

		public Transaction Last
		{
			get
			{
				if (this.transactions.Count != 0)
					return this.transactions[this.transactions.Count - 1] as Transaction;
				else
					return (Transaction)null;
			}
		}

		public Transaction this [int index]
		{
			get
			{
				return this.transactions[index] as Transaction;
			}
		}

		[Category("ToolTip")]
		[Description("Enable or disable tooltip appearance for this marker.")]
		public bool ToolTipEnabled
		{
			get
			{
				return this.toolTipEnabled; 
			}
			set
			{
				this.toolTipEnabled = value;
			}
		}

		[Category("ToolTip")]
		[Description("Tooltip format string. {1} - X coordinate, {2} - Y coordinte.")]
		public string ToolTipFormat
		{
			get
			{
				return this.toolTipFormat; 
			}
			set
			{
				this.toolTipFormat = value;
			}
		}

		public TransactionList()
		{
			this.transactions = new ArrayList();
			this.drawingOption = "";
			this.toolTipEnabled = true;
			this.toolTipFormat = "invalid";
		}

		public void Add(Transaction transaction)
		{
			this.Add(transaction, true);
		}

		public void Add(Transaction transaction, bool sort)
		{
			this.transactions.Add((object)transaction);
			if (!sort || this.transactions.Count == 1 || !(transaction.DateTime < this[this.transactions.Count - 2].DateTime))
				return;
			this.transactions.Sort();
		}

		public void Remove(Transaction transaction)
		{
			this.transactions.Remove((object)transaction);
		}

		public void RemoveAt(int index)
		{
			this.transactions.RemoveAt(index);
		}

		public void Clear()
		{
			this.transactions.Clear();
		}

		public bool Contains(Transaction transaction)
		{
			return this.transactions.Contains((object)transaction);
		}

		public void Sort()
		{
			this.transactions.Sort();
		}

		public IEnumerator GetEnumerator()
		{
			return this.transactions.GetEnumerator();
		}

		public override string ToString()
		{
			string str = "";
			foreach (Transaction transaction in this.transactions)
				str = str + transaction.ToString() + Environment.NewLine;
			return str;
		}

		public void Paint(Pad Pad, double MinX, double MaxX, double MinY, double MaxY)
		{
			foreach (Transaction transaction in this)
				transaction.Paint(Pad, MinX, MaxX, MinY, MaxY);
		}

		public TDistance Distance(double X, double Y)
		{
			Transaction transaction1 = (Transaction)null;
			double num1 = double.MaxValue;
			TDistance tdistance = new TDistance();
			foreach (Transaction transaction2 in this)
			{
				double num2 = Math.Abs((double)transaction2.DateTime.Ticks - X);
				if (num2 < num1)
				{
					num1 = num2;
					transaction1 = transaction2;
				}
			}
			if (transaction1 != null)
			{
				tdistance.X = (double)transaction1.DateTime.Ticks;
				tdistance.Y = transaction1.Price;
				tdistance.dX = Math.Abs(X - tdistance.X);
				tdistance.dY = Math.Abs(Y - tdistance.Y);
				StringBuilder stringBuilder = new StringBuilder();
				if (transaction1.DateTime.Second != 0 || transaction1.DateTime.Minute != 0 || transaction1.DateTime.Hour != 0)
					stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)transaction1.Side).ToString(), (object)transaction1.Instrument.Symbol, (object)transaction1.Qty, (object)transaction1.Price, (object)transaction1.DateTime);
				else
					stringBuilder.AppendFormat(this.toolTipFormat, (object)((object)transaction1.Side).ToString(), (object)transaction1.Instrument.Symbol, (object)transaction1.Qty, (object)transaction1.Price, (object)transaction1.DateTime.ToShortDateString());
				tdistance.ToolTipText = ((object)stringBuilder).ToString();
			}
			else
			{
				tdistance.dX = double.MaxValue;
				tdistance.dY = double.MaxValue;
			}
			return tdistance;
		}

		public void Draw(string option)
		{
			this.drawingOption = option;
			Chart.Pad.Add((IDrawable)this);
		}

		public void Draw()
		{
			this.Draw("");
		}

		public bool IsPadRangeY()
		{
			return false;
		}

		public PadRange GetPadRangeY(Pad pad)
		{
			return (PadRange)null;
		}

		public bool IsPadRangeX()
		{
			return false;
		}

		public PadRange GetPadRangeX(Pad pad)
		{
			return (PadRange)null;
		}
	}
}
