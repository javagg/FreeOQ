using System;

namespace FreeQuant.FinChart
{
	public interface IChartDrawable
	{
		bool ToolTipEnabled { get; set; }
		string ToolTipFormat { get; set; }
		void Paint();
		void SetInterval(DateTime minDate, DateTime maxDate);
		Distance Distance(int x, double y);
		void Select();
		void UnSelect();
	}
}
