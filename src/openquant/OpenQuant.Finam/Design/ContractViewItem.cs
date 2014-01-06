// Type: OpenQuant.Finam.Design.ContractViewItem
// Assembly: OpenQuant.Finam, Version=1.0.5037.20291, Culture=neutral, PublicKeyToken=null
// MVID: E1AD0E66-AEA6-4B28-B15B-542AE974A421
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Bin\OpenQuant.Finam.dll

using OpenQuant.Finam;
using System.Windows.Forms;

namespace OpenQuant.Finam.Design
{
  public class ContractViewItem : ListViewItem
  {
    private TransaqSecurity security;

    public ContractViewItem(TransaqSecurity security, string marketName)
      : base(new string[16])
    {
      this.security = security;
      this.SubItems[0].Text = this.security.SecId.ToString();
      this.SubItems[1].Text = this.security.Active.ToString();
      this.SubItems[2].Text = this.security.SecCode;
      this.SubItems[3].Text = this.security.Board;
      this.SubItems[4].Text = marketName;
      this.SubItems[5].Text = this.security.ShortName;
      this.SubItems[6].Text = this.security.Decimals.ToString();
      this.SubItems[7].Text = string.Format("{0:0.##########}", (object) this.security.MinStep);
      this.SubItems[8].Text = this.security.LotSize.ToString();
      this.SubItems[9].Text = this.security.PointCost.ToString();
      this.SubItems[10].Text = this.security.UseCredit.ToString();
      this.SubItems[11].Text = this.security.ByMarket.ToString();
      this.SubItems[12].Text = this.security.NoSplit.ToString();
      this.SubItems[13].Text = this.security.ImmOrCancel.ToString();
      this.SubItems[14].Text = this.security.CancelBalance.ToString();
      this.SubItems[15].Text = this.security.SecType;
    }
  }
}
