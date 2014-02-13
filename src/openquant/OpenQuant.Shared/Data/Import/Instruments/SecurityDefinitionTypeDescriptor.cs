// Type: OpenQuant.Shared.Data.Import.Instruments.SecurityDefinitionTypeDescriptor
// Assembly: OpenQuant.Shared, Version=1.0.5037.20293, Culture=neutral, PublicKeyToken=null
// MVID: A690BAEF-D039-46EF-A391-4A4F5A74669E
// Assembly location: E:\OpenQuant\Bin\OpenQuant.Shared.dll

using FreeQuant.FIX;
using System;
using System.ComponentModel;

namespace OpenQuant.Shared.Data.Import.Instruments
{
  internal class SecurityDefinitionTypeDescriptor : CustomTypeDescriptor
  {
    private FIXSecurityDefinition definition;

    public SecurityDefinitionTypeDescriptor(FIXSecurityDefinition definition)
    {
      this.definition = definition;
    }

    public override PropertyDescriptorCollection GetProperties(Attribute[] attributes)
    {
      PropertyDescriptorCollection collection = new PropertyDescriptorCollection((PropertyDescriptor[]) null);
      foreach (FIXField field in ((FIXGroup) this.definition).Fields)
      {
        switch ((int) field.Tag)
        {
          case 454:
          case 555:
          case 711:
          case 320:
          case 322:
          case 323:
          case 393:
            goto case 454;
          default:
            if (field.GetValue() != null)
            {
              collection.Add((PropertyDescriptor) new FIXFieldPropertyDescriptor(field, "_"));
              goto case 454;
            }
            else
              goto case 454;
        }
      }
      FIXGroup[] groups1 = new FIXGroup[this.definition.NoUnderlyings];
      for (int index = 0; index < groups1.Length; ++index)
        groups1[index] = (FIXGroup) this.definition.GetUnderlyingsGroup(index);
      this.AddGroups(collection, groups1, "Underlying");
      FIXGroup[] groups2 = new FIXGroup[this.definition.NoLegs];
      for (int index = 0; index < groups2.Length; ++index)
        groups2[index] = (FIXGroup) this.definition.GetLegsGroup(index);
      this.AddGroups(collection, groups2, "Leg");
      FIXGroup[] groups3 = new FIXGroup[this.definition.NoSecurityAltID];
      for (int index = 0; index < groups3.Length; ++index)
        groups3[index] = (FIXGroup) this.definition.GetSecurityAltIDGroup(index);
      this.AddGroups(collection, groups3, "SecurityAltID");
      return collection;
    }

    private void AddGroups(PropertyDescriptorCollection collection, FIXGroup[] groups, string category)
    {
      int num = 1;
      foreach (FIXGroup fixGroup in groups)
      {
        foreach (FIXField field in fixGroup.Fields)
        {
          if (field.GetValue() != null)
            collection.Add((PropertyDescriptor) new FIXFieldPropertyDescriptor(field, string.Format("{0} {1}", (object) category, (object) num)));
        }
        ++num;
      }
    }
  }
}
