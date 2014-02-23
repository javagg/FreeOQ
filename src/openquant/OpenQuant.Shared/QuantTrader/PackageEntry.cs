namespace OpenQuant.Shared.QuantTrader
{
    public class PackageEntry
    {
        internal string Name { get; set; }

        internal PackageEntry()
        {
            this.Name = null;
        }

        internal virtual void InitFrom(PackageEntry entry)
        {
            this.Name = entry.Name;
        }
    }
}
