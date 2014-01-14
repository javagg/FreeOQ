using System.IO;

namespace OpenQuant.Startup
{
  internal class SamplesInstaller : DataInstaller
  {
    public override void CheckInstallation()
    {
      this.IsInstalled = this.setup.Folders.Projects.Exists && this.setup.Folders.Solutions.Exists && (this.setup.Folders.Scripts.Exists && this.setup.Folders.SampleIndicators.Exists) && this.setup.Folders.SampleProviders.Exists;
    }

    public override void Install()
    {
      if (!this.setup.Folders.Projects.Exists)
        this.UnpackFile(new FileInfo(string.Format("{0}\\projects.zip", (object) this.setup.Folders.SamplesSource.FullName)), this.setup.Folders.Projects);
      if (!this.setup.Folders.Solutions.Exists)
        this.UnpackFile(new FileInfo(string.Format("{0}\\solutions.zip", (object) this.setup.Folders.SamplesSource.FullName)), this.setup.Folders.Solutions);
      if (!this.setup.Folders.Scripts.Exists)
        this.UnpackFile(new FileInfo(string.Format("{0}\\scripts.zip", (object) this.setup.Folders.SamplesSource.FullName)), this.setup.Folders.Scripts);
      if (!this.setup.Folders.SampleIndicators.Exists)
        this.UnpackFile(new FileInfo(string.Format("{0}\\sampleindicators.zip", (object) this.setup.Folders.SamplesSource.FullName)), this.setup.Folders.SampleIndicators);
      if (this.setup.Folders.SampleProviders.Exists)
        return;
      this.UnpackFile(new FileInfo(string.Format("{0}\\sampleproviders.zip", (object) this.setup.Folders.SamplesSource.FullName)), this.setup.Folders.SampleProviders);
    }
  }
}
