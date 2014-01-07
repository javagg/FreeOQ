// Type: SmartQuant.Shared.Data.Import.CSV.TemplateCollection
// Assembly: SmartQuant.Shared, Version=1.0.5036.28348, Culture=neutral, PublicKeyToken=null
// MVID: BB2FC74B-486B-4DBF-B165-607056B8E43A
// Assembly location: C:\Program Files\SmartQuant Ltd\OpenQuant\Framework\bin\SmartQuant.Shared.dll

using AMiPSuhk8DSY5eSibKw;
using System;
using System.Collections;
using System.Runtime.CompilerServices;

namespace SmartQuant.Shared.Data.Import.CSV
{
  public class TemplateCollection : ICollection, IEnumerable
  {
    private SortedList aJ8duHpkdC;

    public bool IsSynchronized
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aJ8duHpkdC.IsSynchronized;
      }
    }

    public int Count
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aJ8duHpkdC.Count;
      }
    }

    public object SyncRoot
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aJ8duHpkdC.SyncRoot;
      }
    }

    public Template this[string name]
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return this.aJ8duHpkdC[(object) name] as Template;
      }
      [MethodImpl(MethodImplOptions.NoInlining)] set
      {
        this.aJ8duHpkdC[(object) value.Name] = (object) value;
      }
    }

    public string[] Names
    {
      [MethodImpl(MethodImplOptions.NoInlining)] get
      {
        return new ArrayList(this.aJ8duHpkdC.Keys).ToArray(typeof (string)) as string[];
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public TemplateCollection()
    {
      eX4XcIhHpDXt70u2x3N.k8isAcYzkUOGF();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this.aJ8duHpkdC = new SortedList();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void CopyTo(Array array, int index)
    {
      this.aJ8duHpkdC.CopyTo(array, index);
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public IEnumerator GetEnumerator()
    {
      return this.aJ8duHpkdC.Values.GetEnumerator();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    public void Add(Template template)
    {
      this.aJ8duHpkdC.Add((object) template.Name, (object) template);
    }
  }
}
