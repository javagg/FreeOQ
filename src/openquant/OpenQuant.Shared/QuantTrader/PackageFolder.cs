using System;
using System.Collections.Generic;

namespace OpenQuant.Shared.QuantTrader
{
  public class PackageFolder : PackageEntry
  {
    private Dictionary<string, PackageEntry> entries;

    public PackageFolder()
    {
      this.entries = new Dictionary<string, PackageEntry>();
    }

    internal ICollection<PackageEntry> GetEntries()
    {
			return this.entries.Values;
    }

    internal T GetEntry<T>(string name) where T : PackageEntry, new()
    {
      PackageEntry entry;
      if (!this.entries.TryGetValue(name, out entry))
      {
        entry = (PackageEntry) Activator.CreateInstance<T>();
        entry.Name = name;
        this.entries.Add(name, entry);
      }
      if (entry is T)
        return (T) entry;
      T instance = Activator.CreateInstance<T>();
      instance.InitFrom(entry);
      this.entries[name] = (PackageEntry) instance;
      return instance;
    }

    internal IEnumerator<T> GetFoldersAs<T>() where T : PackageFolder, new()
    {
      List<T> list = new List<T>();
      foreach (PackageEntry packageEntry in new List<PackageEntry>((IEnumerable<PackageEntry>) this.entries.Values))
      {
        if (packageEntry is PackageFolder)
          list.Add(this.GetEntry<T>(packageEntry.Name));
      }
      return (IEnumerator<T>) list.GetEnumerator();
    }

    internal IEnumerator<T> GetFilesAs<T>() where T : PackageFile, new()
    {
      List<T> list = new List<T>();
      foreach (PackageEntry packageEntry in new List<PackageEntry>((IEnumerable<PackageEntry>) this.entries.Values))
      {
        if (packageEntry is PackageFile)
          list.Add(this.GetEntry<T>(packageEntry.Name));
      }
      return (IEnumerator<T>) list.GetEnumerator();
    }

    internal override void InitFrom(PackageEntry entry)
    {
      base.InitFrom(entry);
      this.entries = ((PackageFolder) entry).entries;
    }
  }
}
