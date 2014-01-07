// Type: SmartQuant.Shared.Data.Import.CSV.WizardPage
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using zOf5tchxCBEIPRknFZK;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class WizardPage : UserControl
  {
    protected ImportSettings settings;
    private Container fLVTk57be;

    public virtual bool CanBack
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
    }

    public virtual bool CanNext
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
    }

    public virtual bool CanClose
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return true;
      }
    }

    public virtual string Title
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return "";
      }
    }

    public event EventHandler ButtonEnabledChanged;

    [MethodImpl(MethodImplOptions.NoInlining)]
    public WizardPage()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aDQWLj4jD();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected override void Dispose(bool disposing)
    {
      if (disposing && this.fLVTk57be != null)
        this.fLVTk57be.Dispose();
      base.Dispose(disposing);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    private void aDQWLj4jD()
    {
      this.Name = RNaihRhYEl0wUmAftnB.aYu7exFQKN(554);
      this.Size = new Size(376, 288);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void SetSettings(ImportSettings settings)
    {
      this.settings = settings;
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BeforeNext()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BeforeBack()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BeforeLoad()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public virtual void BeforeClose()
    {
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    protected void EmitButtonEnabledChanged()
    {
      if (this.EtrfpfAeg == null)
        return;
      this.EtrfpfAeg((object) this, EventArgs.Empty);
    }
  }
}
