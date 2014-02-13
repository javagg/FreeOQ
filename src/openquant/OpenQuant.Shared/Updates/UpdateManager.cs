using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Xml;

namespace OpenQuant.Shared.Updates
{
	public class UpdateManager
	{
		public ReleaseInfo[] GetReleases(string uri)
		{
			byte[] buffer = new WebClient().DownloadData(uri);
			DataXmlDocument dataXmlDocument = new DataXmlDocument();
			((XmlDocument)dataXmlDocument).Load((Stream)new MemoryStream(buffer));
			List<ReleaseInfo> list1 = new List<ReleaseInfo>();
			IEnumerator enumerator1 = dataXmlDocument.Releases.GetEnumerator();
			try
			{
				while (enumerator1.MoveNext())
				{
					ReleaseXmlNode releaseXmlNode = (ReleaseXmlNode)enumerator1.Current;
					ReleaseInfo releaseInfo = new ReleaseInfo();
					releaseInfo.Version = releaseXmlNode.Version;
					releaseInfo.Date = releaseXmlNode.Date;
					releaseInfo.Url86 = releaseXmlNode.Url86;
					releaseInfo.Url64 = releaseXmlNode.Url64;
					List<NoteInfo> list2 = new List<NoteInfo>();
					IEnumerator enumerator2 = releaseXmlNode.Notes.GetEnumerator();
					try
					{
						while (enumerator2.MoveNext())
						{
							NoteXmlNode noteXmlNode = (NoteXmlNode)enumerator2.Current;
							list2.Add(new NoteInfo()
							{
								Text = noteXmlNode.Text
							});
						}
					}
					finally
					{
						IDisposable disposable = enumerator2 as IDisposable;
						if (disposable != null)
							disposable.Dispose();
					}
					releaseInfo.Notes = list2.ToArray();
					list1.Add(releaseInfo);
				}
			}
			finally
			{
				IDisposable disposable = enumerator1 as IDisposable;
				if (disposable != null)
					disposable.Dispose();
			}
			list1.Sort((Comparison<ReleaseInfo>)((releaseX, releaseY) => releaseY.Version.CompareTo(releaseX.Version)));
			return list1.ToArray();
		}
	}
}
