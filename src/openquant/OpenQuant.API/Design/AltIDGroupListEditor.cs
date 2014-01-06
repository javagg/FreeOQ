using OpenQuant.API;
using FreeQuant.FIX;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;

namespace OpenQuant.API.Design
{
  internal class AltIDGroupListEditor : ArrayEditor
  {
    private Instrument instrument;

    public AltIDGroupListEditor()
      : base(typeof (ArrayList))
    {
    }

    public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
    {
      if (context != null && context.Instance is Instrument)
        this.instrument = (Instrument) context.Instance;
      return base.EditValue(context, provider, value);
    }

    protected override object CreateInstance(System.Type itemType)
    {
      if (!(itemType == typeof (AltIDGroup)))
        return base.CreateInstance(itemType);
      AltIDGroup[] altIdGroupArray = (AltIDGroup[]) null;
      AltSourceForm altSourceForm = new AltSourceForm();
      if (altSourceForm.ShowDialog() == DialogResult.OK)
        altIdGroupArray = new AltIDGroup[1]
        {
          this.instrument.AltIDGroups.Add(altSourceForm.AltSource)
        };
      return (object) altIdGroupArray;
    }

    protected override IList GetObjectsFromInstance(object instance)
    {
      if (instance is ICollection)
        return (IList) new ArrayList((ICollection) instance);
      else
        return (IList) null;
    }

    protected override object[] GetItems(object editValue)
    {
      List<object> list = new List<object>();
      foreach (FIXSecurityAltIDGroup group in (FIXGroupList) this.instrument.instrument.SecurityAltIDGroup)
        list.Add((object) new AltIDGroup(this.instrument, group));
      return list.ToArray();
    }

    protected override object SetItems(object editValue, object[] value)
    {
      AltIDGroupList altIdGroupList = editValue as AltIDGroupList;
      altIdGroupList.instrument.instrument.SecurityAltIDGroup.Clear();
      foreach (AltIDGroup altIdGroup in value)
        altIdGroupList.instrument.instrument.SecurityAltIDGroup.Add((FIXGroup) altIdGroup.group);
      return (object) altIdGroupList;
    }

    protected override System.Type CreateCollectionItemType()
    {
      return typeof (AltIDGroup);
    }
  }
}
