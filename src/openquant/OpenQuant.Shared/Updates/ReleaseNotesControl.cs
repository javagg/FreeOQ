using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OpenQuant.Shared.Updates
{
	public partial class ReleaseNotesControl : UserControl
  {
    private Version userVersion;
    private ReleaseInfo[] releases;
    private List<Uri> uriList;

    public event EventHandler<UriEventArgs> DownloadRequested;

    public ReleaseNotesControl()
    {
      this.InitializeComponent();
      this.uriList = new List<Uri>();
    }

    public void Init(Version userVersion, ReleaseInfo[] releases)
    {
      this.userVersion = userVersion;
      this.releases = releases;
      this.DisplayReleases();
    }

    private void DisplayReleases()
    {
      StringBuilder stringBuilder = new StringBuilder();
      stringBuilder.Append("<body style='font-family:verdana;font-size:11px'>");
      this.uriList.Clear();
      foreach (ReleaseInfo releaseInfo in this.releases)
      {
        if (this.chbDisplayAll.Checked || !(this.userVersion >= releaseInfo.Version))
        {
          List<string> list = new List<string>();
          if (releaseInfo.Url86 != (Uri) null)
          {
            list.Add(string.Format("<a href={0}>32 bit</a>", (object) this.uriList.Count));
            this.uriList.Add(releaseInfo.Url86);
          }
          if (releaseInfo.Url64 != (Uri) null)
          {
            list.Add(string.Format("<a href={0}>64 bit</a>", (object) this.uriList.Count));
            this.uriList.Add(releaseInfo.Url64);
          }
          string str = list.Count == 0 ? string.Empty : string.Format("<p>Download: {0}</p>", (object) string.Join("&nbsp;&nbsp;", list.ToArray()));
          stringBuilder.AppendFormat("<p style='color:green;font-style:italic'>Version: {0} Date: {1:d}</p>{2}", (object) releaseInfo.Version, (object) releaseInfo.Date, (object) str);
          stringBuilder.Append("<ul>");
          foreach (NoteInfo noteInfo in releaseInfo.Notes)
            stringBuilder.AppendFormat("<li>{0}</li>", (object) noteInfo.Text);
          stringBuilder.Append("</ul>");
        }
      }
      stringBuilder.Append("</body>");
      this.browser.DocumentText = ((object) stringBuilder).ToString();
    }

    private void browser_Navigating(object sender, WebBrowserNavigatingEventArgs e)
    {
      int result;
      if (!int.TryParse(e.Url.AbsolutePath, out result) || result < 0 || result >= this.uriList.Count)
        return;
      if (this.DownloadRequested != null)
        this.DownloadRequested((object) this, new UriEventArgs(this.uriList[result]));
      e.Cancel = true;
    }

    private void chbDisplayAll_CheckedChanged(object sender, EventArgs e)
    {
      this.DisplayReleases();
    }
  }
}
