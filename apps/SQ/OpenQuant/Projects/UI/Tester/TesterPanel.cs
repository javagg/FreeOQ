// Type: OpenQuant.Projects.UI.Tester.TesterPanel
// Assembly: OpenQuant, Version=3.9.1.0, Culture=neutral, PublicKeyToken=null
// MVID: E55CD87F-F1ED-4D4E-8DEA-A2A903234F95
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\OpenQuant.exe

using SmartQuant.Charting;
using SmartQuant.ExcelLib;
using SmartQuant.Testing;
using SmartQuant.Testing.TesterItems;
using System.Collections;
using System.Collections.Specialized;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace OpenQuant.Projects.UI.Tester
{
  public class TesterPanel : Panel
  {
    protected LiveTester tester;
    protected ArrayList statisticViewers;
    protected TabControl tabControl;

    public ArrayList StatisticViewers
    {
      get
      {
        return this.statisticViewers;
      }
    }

    public LiveTester Tester
    {
      get
      {
        return this.tester;
      }
      set
      {
        if (this.tester != value)
        {
          this.tester = value;
          this.statisticViewers.Clear();
          this.Controls.Clear();
          this.tabControl = new TabControl();
          this.tabControl.Dock = DockStyle.Fill;
          TabPage tabPage1 = new TabPage("Single");
          StatisticsViewerContainer container1 = new StatisticsViewerContainer(this.tester, "Single");
          this.statisticViewers.Add((object) container1);
          this.AddSimpleViewers(container1);
          tabPage1.Controls.Add((Control) container1);
          TabPage tabPage2 = new TabPage("RoundTrips");
          StatisticsViewerContainer container2 = new StatisticsViewerContainer(this.tester, "RoundTrips");
          this.statisticViewers.Add((object) container2);
          this.AddRoundTripsViewers(container2);
          tabPage2.Controls.Add((Control) container2);
          this.tabControl.TabPages.Add(tabPage1);
          this.tabControl.TabPages.Add(tabPage2);
          this.Controls.Add((Control) this.tabControl);
          foreach (StatisticViewer statisticViewer in this.statisticViewers)
            statisticViewer.UpdateContent();
        }
        else
        {
          foreach (StatisticViewer statisticViewer in this.statisticViewers)
            statisticViewer.UpdateContent();
        }
      }
    }

    public TesterPanel()
    {
      this.statisticViewers = new ArrayList();
    }

    private void AddSimpleViewers(StatisticsViewerContainer container)
    {
      StatisticListView statisticListView1 = new StatisticListView(this.tester, "Performance Analysis");
      statisticListView1.AddComponentItem(this.tester.Components["InitialWealth"]);
      statisticListView1.AddComponentItem(this.tester.Components["FinalWealth"]);
      statisticListView1.AddComponentItem(this.tester.Components["Average Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Average Gain (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Average Loss (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Drawdown Average"]);
      statisticListView1.AddComponentItem(this.tester.Components["Drawdown Median"]);
      statisticListView1.AddComponentItem(this.tester.Components["Average Annual Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Median Annual Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Maximum Annual Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Minimum Annual Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Average Monthly Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Median Monthly Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Maximum Monthly Return (%)"]);
      statisticListView1.AddComponentItem(this.tester.Components["Minimum Monthly Return (%)"]);
      container.AddViewer((StatisticViewer) statisticListView1);
      StatisticListView statisticListView2 = new StatisticListView(this.tester, "Risk Analysis");
      statisticListView2.AddComponentItem(this.tester.Components["MAR Ratio"]);
      statisticListView2.AddComponentItem(this.tester.Components["Modified Sharpe Ratio"]);
      statisticListView2.AddComponentItem(this.tester.Components["Sotrino Ratio"]);
      statisticListView2.AddComponentItem(this.tester.Components["CompoundAverageReturn"]);
      statisticListView2.AddComponentItem(this.tester.Components["Minimum DrawDown"]);
      statisticListView2.AddComponentItem(this.tester.Components["StandardDeviation"]);
      statisticListView2.AddComponentItem(this.tester.Components["GainStandardDeviation"]);
      statisticListView2.AddComponentItem(this.tester.Components["LossStandardDeviation"]);
      statisticListView2.AddComponentItem(this.tester.Components["Skewness"]);
      statisticListView2.AddComponentItem(this.tester.Components["Kurtosis"]);
      statisticListView2.AddComponentItem(this.tester.Components["SharpeRatio"]);
      statisticListView2.AddComponentItem(this.tester.Components["VaR95"]);
      statisticListView2.AddComponentItem(this.tester.Components["VaR99"]);
      container.AddViewer((StatisticViewer) statisticListView2);
    }

    private void AddRoundTripsViewers(StatisticsViewerContainer container)
    {
      RoundTripsTableViewer tripsTableViewer1 = new RoundTripsTableViewer(this.tester, this.tester.RoundTripList, "RoundTrips Statistics");
      NameValueCollection nameValueCollection1 = new NameValueCollection();
      nameValueCollection1.Add("Number Of RoundTrips", "{0:F0}");
      nameValueCollection1.Add("Number Of Winning RoundTrips", "{0:F0}");
      nameValueCollection1.Add("Number Of Losing RoundTrips", "{0:F0}");
      nameValueCollection1.Add("Percent Of Profitable (%)", "");
      nameValueCollection1.Add("Value Open RoundTrips", "");
      nameValueCollection1.Add("Total PnL Of All RoundTrips", "");
      nameValueCollection1.Add("Total PnL Of Winning RoundTrips", "");
      nameValueCollection1.Add("Total PnL Of Losing RoundTrips", "");
      nameValueCollection1.Add("Profit Per Winning Trade", "");
      nameValueCollection1.Add("Average RoundTrip", "");
      nameValueCollection1.Add("Largest Winning RoundTrip", "");
      nameValueCollection1.Add("Largest Losing RoundTrip", "");
      nameValueCollection1.Add("Average Winning RoundTrip", "");
      nameValueCollection1.Add("Average Losing RoundTrip", "");
      nameValueCollection1.Add("Ratio avg. win / avg. loss", "");
      nameValueCollection1.Add("Profit Factor", "");
      nameValueCollection1.Add("Maximal Consecutive Winners", "");
      nameValueCollection1.Add("Maximal Consecutive Losers", "");
      nameValueCollection1.Add("Average Total Efficiency", "");
      nameValueCollection1.Add("Average Entry Efficiency", "");
      nameValueCollection1.Add("Average Exit Efficiency", "");
      foreach (string index in nameValueCollection1.Keys)
      {
        if (((object) nameValueCollection1[index]).ToString() != "")
          tripsTableViewer1.AddComponentItem(this.tester.Components[index] as SeriesTesterItem, this.tester.Components["(Long) " + index] as SeriesTesterItem, this.tester.Components["(Short) " + index] as SeriesTesterItem, ((object) nameValueCollection1[index]).ToString());
        else
          tripsTableViewer1.AddComponentItem(this.tester.Components[index] as SeriesTesterItem, this.tester.Components["(Long) " + index] as SeriesTesterItem, this.tester.Components["(Short) " + index] as SeriesTesterItem);
      }
      container.AddViewer((StatisticViewer) tripsTableViewer1);
      RoundTripsTableViewer tripsTableViewer2 = new RoundTripsTableViewer(this.tester, this.tester.RoundTripList, "RoundTrips Duration Statistics");
      NameValueCollection nameValueCollection2 = new NameValueCollection();
      nameValueCollection2.Add("Duration Of Last RoundTrip", "d");
      nameValueCollection2.Add("Average Duration Of RoundTrips", "d");
      nameValueCollection2.Add("Duration Of Last Winning RoundTrip", "d");
      nameValueCollection2.Add("Average Duration Of Winning RoundTrips", "d");
      nameValueCollection2.Add("Median Duration Of Winning RoundTrips", "d");
      nameValueCollection2.Add("Maximum Duration Of Winning RoundTrips", "d");
      nameValueCollection2.Add("Minimum Duration Of Winning RoundTrips", "d");
      nameValueCollection2.Add("Duration Of Last Losing RoundTrip", "d");
      nameValueCollection2.Add("Average Duration Of Losing RoundTrips", "d");
      nameValueCollection2.Add("Median Duration Of Losing RoundTrips", "d");
      nameValueCollection2.Add("Maximum Duration Of Losing RoundTrips", "d");
      nameValueCollection2.Add("Minimum Duration Of Losing RoundTrips", "d");
      foreach (string index in nameValueCollection2.Keys)
      {
        if (((object) nameValueCollection2[index]).ToString() != "")
          tripsTableViewer2.AddComponentItem(this.tester.Components[index] as SeriesTesterItem, this.tester.Components["(Long) " + index] as SeriesTesterItem, this.tester.Components["(Short) " + index] as SeriesTesterItem, ((object) nameValueCollection2[index]).ToString());
        else
          tripsTableViewer2.AddComponentItem(this.tester.Components[index] as SeriesTesterItem, this.tester.Components["(Long) " + index] as SeriesTesterItem, this.tester.Components["(Short) " + index] as SeriesTesterItem);
      }
      container.AddViewer((StatisticViewer) tripsTableViewer2);
      RoundTripsViewer roundTripsViewer1 = new RoundTripsViewer(this.tester, this.tester.RoundTripList, "Round Trips");
      container.AddViewer((StatisticViewer) roundTripsViewer1);
      RoundTripsViewer roundTripsViewer2 = new RoundTripsViewer(this.tester, this.tester.LongRoundTripList, "Long Round Trips");
      container.AddViewer((StatisticViewer) roundTripsViewer2);
      RoundTripsViewer roundTripsViewer3 = new RoundTripsViewer(this.tester, this.tester.ShortRoundTripList, "Short Round Trips");
      container.AddViewer((StatisticViewer) roundTripsViewer3);
    }

    public void Disconnect()
    {
      foreach (StatisticViewer statisticViewer in this.statisticViewers)
        statisticViewer.Disconnect();
    }

    public void CreateExcelReport(WorksheetList sheets)
    {
      bool flag = true;
      foreach (StatisticsViewerContainer statisticsViewerContainer in this.statisticViewers)
      {
        foreach (StatisticViewer statisticViewer in statisticsViewerContainer.StatisticsViewers)
        {
          if (statisticViewer.UpdateEnabled)
          {
            if (!flag)
              sheets.AddLast();
            else
              flag = false;
            Worksheet sheet = sheets.get_Item(sheets.get_Count());
            sheet.set_Name(statisticViewer.ViewerName.Replace(" ", "") ?? "");
            statisticViewer.WriteToExcel(sheet);
          }
        }
      }
    }

    private void CopyChartToWorksheet(Worksheet sheet, Chart chart)
    {
      string str = "c:\\qwe.bmp";
      chart.SaveImage(str, ImageFormat.Bmp);
      sheet.Activate();
      sheet.InsertPicture(str);
      File.Delete(str);
    }
  }
}
