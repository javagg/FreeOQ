
using FreeQuant;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FreeQuant.Trading
{
  public class StrategyComponentManager
  {
    private const string DLiRXh7mPw = "data";
    private const string XUgRPvxH5s = "templates";
    private const string BWERDXKR0T = "data.data";
    private static StrategyComponentList wcrRFbhwry;
    private static List<string> yNoRLNTZ2P;
    private static Hashtable tuxR3OBtRK;
    private static Hashtable gLhRsqD2VZ;

    public static StrategyComponentList Components
    {
       get
      {
        return StrategyComponentManager.wcrRFbhwry;
      }
    }

    public static ICollection ComponentTypes
    {
       get
      {
        return StrategyComponentManager.tuxR3OBtRK.Keys;
      }
    }

    public static ICollection ComponentRuntimeTypes
    {
       get
      {
        return (ICollection) new ArrayList()
        {
          (object) typeof (CrossEntry),
          (object) typeof (CrossExit),
          (object) typeof (Entry),
          (object) typeof (Exit),
          (object) typeof (MoneyManager),
          (object) typeof (RiskManager),
          (object) typeof (ExposureManager),
          (object) typeof (MarketManager),
          (object) typeof (OptimizationManager),
          (object) typeof (ReportManager),
          (object) typeof (MetaExposureManager),
          (object) typeof (MetaMoneyManager),
          (object) typeof (MetaRiskManager),
          (object) typeof (SimulationManager),
          (object) typeof (ExecutionManager),
          (object) typeof (ATSComponent),
          (object) typeof (ATSCrossComponent)
        };
      }
    }

    public static event ComponentEventHandler ComponentAdded;

    public static event ComponentEventHandler ComponentRemoved;

    public static event ComponentEventHandler ComponentReconstructed;

    
    static StrategyComponentManager()
    {
      StrategyComponentManager.tuxR3OBtRK = new Hashtable();
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.CrossEntry, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.CrossExit, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.Entry, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.Exit, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.ExecutionManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.ExposureManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.MoneyManager,  "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.RiskManager,"");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.MarketManager,"");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.OptimizationManager,"");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.ReportManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.MetaExposureManager,"");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.MetaMoneyManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.MetaRiskManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.SimulationManager, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.ATSComponent, "");
			StrategyComponentManager.tuxR3OBtRK.Add((object) ComponentType.ATSCrossComponent, "");
      StrategyComponentManager.gLhRsqD2VZ = new Hashtable();
      StrategyComponentManager.wcrRFbhwry = new StrategyComponentList();
      StrategyComponentManager.yNoRLNTZ2P = new List<string>();
      StrategyComponentManager.qGjRTr4ZHe();
    }

    
		public StrategyComponentManager():base()
    {
    }

    
    private static void duERGEeA5M()
    {
      string path = Framework.Installation.ComponentDir.FullName;
      if (!File.Exists(path))
        return;
      StreamReader streamReader = new StreamReader(path);
      string str;
      while ((str = streamReader.ReadLine()) != null)
        StrategyComponentManager.yNoRLNTZ2P.Add(str);
      streamReader.Close();
    }

    
    public static void SaveBuiltComponents()
    {
      StreamWriter streamWriter = new StreamWriter(Framework.Installation.ComponentDir.FullName);
      foreach (ComponentRecord componentRecord in StrategyComponentManager.wcrRFbhwry)
      {
        if (componentRecord.File != null && (componentRecord.Errors == null || !componentRecord.Errors.HasErrors))
          streamWriter.WriteLine(componentRecord.File.Name);
      }
      streamWriter.Close();
    }

    
    public static void LoadComponents()
    {
      StrategyComponentManager.idbRrwVHpr();
      FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
      fileSystemWatcher.Path = Framework.Installation.ComponentDir.FullName;
			fileSystemWatcher.Filter = "filer";
      fileSystemWatcher.NotifyFilter = NotifyFilters.LastWrite;
      fileSystemWatcher.Changed += new FileSystemEventHandler(StrategyComponentManager.uWxRhBPP9U);
      fileSystemWatcher.EnableRaisingEvents = true;
    }

    
    public static void Init()
    {
      StrategyComponentManager.duERGEeA5M();
      StrategyComponentManager.LoadComponents();
    }

    
    public static void AddNewComponent(ComponentType componentType, string name, string description)
    {
      StreamReader streamReader = new StreamReader(Framework.Installation.ComponentDir.FullName + (string) StrategyComponentManager.tuxR3OBtRK[(object) componentType]);
      string str1 = streamReader.ReadToEnd();
      streamReader.Close();
			string newValue = Guid.NewGuid().ToString() + ((object) componentType).ToString() + name +  description;
			string str2 = str1.Replace("fdddfs", newValue).Replace("dfdfs", name);
      FileInfo fileInfo = new FileInfo(Framework.Installation.ComponentDir.FullName + name);
      if (fileInfo.Exists)
				throw new IOException(string.Format("fdsfd", (object) fileInfo.Name));
      StreamWriter text = fileInfo.CreateText();
      text.Write(str2);
      text.Close();
      StrategyComponentManager.sLsRSGwrU3(fileInfo);
    }

    
    private static void sLsRSGwrU3([In] FileInfo obj0)
    {
      CompilerResults compilerResults = CompilingService.Compile(obj0.FullName, false);
      if (compilerResults.Errors.HasErrors)
      {
        ComponentRecord componentRecord = new ComponentRecord(Guid.Empty, ComponentType.Unknown, obj0.Name, "", obj0, (Type) null, compilerResults.Errors);
        StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord);
        StrategyComponentManager.H13R1k6g2K(componentRecord);
      }
      else
      {
        bool flag = false;
        foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
        {
          ComponentRecord componentRecord = StrategyComponentManager.cN2R9Xa8LN(type, obj0);
          if (componentRecord != null)
          {
            StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord);
            StrategyComponentManager.H13R1k6g2K(componentRecord);
            flag = true;
          }
        }
        if (flag)
          return;
        ComponentRecord componentRecord1 = new ComponentRecord(Guid.Empty, ComponentType.Unknown, obj0.Name, "", obj0, (Type) null, new CompilerErrorCollection(new CompilerError[1]
        {
						new CompilerError(obj0.FullName, -1, -1, "dfdfs", "fdsdfs")
        }));
        StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord1);
        StrategyComponentManager.H13R1k6g2K(componentRecord1);
      }
    }

    
    public static void AddExistingComponent(FileInfo existingFile)
    {
      StrategyComponentManager.sLsRSGwrU3(existingFile.CopyTo(Framework.Installation.ComponentDir.FullName +  existingFile.Name));
    }

    
    public static bool RebuildComponent(FileInfo file)
    {
      ComponentRecord[] records = StrategyComponentManager.wcrRFbhwry.FindRecords(file);
      foreach (ComponentRecord componentRecord in records)
      {
        componentRecord.HrjA5j3PaA(new CompilerErrorCollection());
        StrategyComponentManager.gLhRsqD2VZ.Remove((object) componentRecord);
      }
      CompilerResults compilerResults = CompilingService.Compile(file.FullName, false);
      if (compilerResults.Errors.HasErrors)
      {
        foreach (ComponentRecord componentRecord in records)
        {
          componentRecord.HrjA5j3PaA(compilerResults.Errors);
          StrategyComponentManager.TXQRKdObj1(componentRecord);
        }
        return false;
      }
      else
      {
        ArrayList arrayList1 = new ArrayList();
        foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
        {
          ComponentRecord componentRecord = StrategyComponentManager.cN2R9Xa8LN(type, file);
          if (componentRecord != null)
            arrayList1.Add((object) componentRecord);
        }
        ArrayList arrayList2 = new ArrayList((ICollection) records);
        foreach (ComponentRecord componentRecord1 in arrayList1)
        {
          bool flag = false;
          foreach (ComponentRecord componentRecord2 in arrayList2)
          {
            if (componentRecord2.GUID == componentRecord1.GUID)
            {
              componentRecord2.lfVAUUDxYN(componentRecord1.Name);
              componentRecord2.x63AOXlRIK(componentRecord1.Description);
              componentRecord2.CvyAHpcreG(componentRecord1.ComponentType);
              componentRecord2.X8yAQiuh7R(componentRecord1.RuntimeType);
              componentRecord2.VnhAiVxt7S(false);
              flag = true;
              arrayList2.Remove((object) componentRecord2);
              StrategyComponentManager.TXQRKdObj1(componentRecord2);
              break;
            }
          }
          if (!flag)
          {
            StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord1);
            StrategyComponentManager.H13R1k6g2K(componentRecord1);
          }
        }
        foreach (ComponentRecord componentRecord in arrayList2)
        {
          if (componentRecord.GUID == Guid.Empty)
          {
            StrategyComponentManager.wcrRFbhwry.fc56KRbFEA(componentRecord);
            StrategyComponentManager.IP7RCltgOJ(componentRecord);
          }
        }
        return true;
      }
    }

    
    public static void RemoveComponent(ComponentRecord record)
    {
      record.File.Delete();
      StrategyComponentManager.wcrRFbhwry.fc56KRbFEA(record);
      StrategyComponentManager.gLhRsqD2VZ.Remove((object) record);
      StrategyComponentManager.IP7RCltgOJ(record);
    }

    
    public static StrategyComponentList GetComponentList(ComponentType componentType)
    {
      StrategyComponentList strategyComponentList = new StrategyComponentList();
      foreach (ComponentRecord componentRecord in StrategyComponentManager.wcrRFbhwry)
      {
        if ((componentRecord.ComponentType & componentType) != (ComponentType) 0)
          strategyComponentList.ROm6C46rfm(componentRecord);
      }
      return strategyComponentList;
    }

    
    public static IComponentBase GetDefaultComponent(ComponentType type, object issuer)
    {
      switch (type)
      {
        case ComponentType.CrossEntry:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.ATSCrossComponent:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.ReportManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.ATSComponent:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.MetaMoneyManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.MetaRiskManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.SimulationManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.ExecutionManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.OptimizationManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.MetaExposureManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.RiskManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.MarketManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.Entry:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.Exit:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.ExposureManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        case ComponentType.MoneyManager:
					return StrategyComponentManager.GetComponent("getCom", issuer);
        default:
          return (IComponentBase) null;
      }
    }

    
    public static IComponentBase GetComponent(Guid guid, object issuer)
    {
      ComponentRecord record1 = StrategyComponentManager.wcrRFbhwry.FindRecord(guid);
      if (record1 == null)
        return (IComponentBase) null;
      if (record1.IsChanged)
      {
        StrategyComponentManager.gLhRsqD2VZ.Remove((object) record1);
        CompilerResults compilerResults = CompilingService.Compile(record1.File.FullName, false);
        if (compilerResults.Errors.HasErrors)
        {
          record1.HrjA5j3PaA(compilerResults.Errors);
          return (IComponentBase) null;
        }
        else
        {
          record1.VnhAiVxt7S(false);
          foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
          {
            ComponentRecord componentRecord = StrategyComponentManager.cN2R9Xa8LN(type, record1.File);
            if (componentRecord != null)
            {
              record1.X8yAQiuh7R(componentRecord.RuntimeType);
              break;
            }
          }
        }
      }
      Hashtable hashtable = StrategyComponentManager.gLhRsqD2VZ[(object) record1] as Hashtable;
      if (hashtable == null)
      {
        hashtable = new Hashtable();
        StrategyComponentManager.gLhRsqD2VZ.Add((object) record1, (object) hashtable);
      }
      IComponentBase componentBase = hashtable[issuer] as IComponentBase;
      if (componentBase == null)
      {
        ComponentRecord record2 = StrategyComponentManager.wcrRFbhwry.FindRecord(guid);
        componentBase = Activator.CreateInstance(record2.RuntimeType) as IComponentBase;
        componentBase.Name = record2.Name;
        componentBase.Description = record2.Description;
        hashtable.Add(issuer, (object) componentBase);
      }
      return componentBase;
    }

    
    public static IComponentBase GetComponent(string guid, object issuer)
    {
      return StrategyComponentManager.GetComponent(new Guid(guid), issuer);
    }

    
    public static void ClearComponentCache(object issuer)
    {
      foreach (DictionaryEntry dictionaryEntry in new Hashtable((IDictionary) StrategyComponentManager.gLhRsqD2VZ))
      {
        Hashtable hashtable = (Hashtable) dictionaryEntry.Value;
        hashtable.Remove(issuer);
        if (hashtable.Count == 0)
          StrategyComponentManager.gLhRsqD2VZ.Remove(dictionaryEntry.Key);
      }
    }

    
    private static void qGjRTr4ZHe()
    {
      foreach (Type runtimeType in (IEnumerable) StrategyComponentManager.ComponentRuntimeTypes)
        StrategyComponentManager.RegisterDefaultComponent(runtimeType);
    }

    
    public static void RegisterDefaultComponent(Type runtimeType)
    {
      ComponentRecord componentRecord = StrategyComponentManager.cN2R9Xa8LN(runtimeType, (FileInfo) null);
      StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord);
    }

    
    private static void idbRrwVHpr()
    {
      StrategyComponentManager.faQRIM6nIU(new DirectoryInfo(Framework.Installation.ComponentDir.FullName).GetFiles());
    }

    
    private static void faQRIM6nIU([In] FileInfo[] obj0)
    {
      string source = "";
      Dictionary<string, FileInfo> dictionary = new Dictionary<string, FileInfo>();
      List<FileInfo> list1 = new List<FileInfo>();
      List<FileInfo> list2 = new List<FileInfo>();
      int num = 1;
      foreach (FileInfo fileInfo in obj0)
      {
        if (StrategyComponentManager.yNoRLNTZ2P.Contains(fileInfo.Name))
        {
          StreamReader streamReader = new StreamReader(fileInfo.FullName);
					string index = num.ToString();
          dictionary[index] = fileInfo;
          list1.Add(fileInfo);
          source = source +  index + Environment.NewLine + Environment.NewLine + streamReader.ReadToEnd() + Environment.NewLine + Environment.NewLine;
          ++num;
          streamReader.Close();
        }
        else
          list2.Add(fileInfo);
      }
      CompilerResults compilerResults = CompilingService.CompileSource(source);
      if (compilerResults.Errors.HasErrors)
      {
        foreach (FileInfo fileInfo in obj0)
          StrategyComponentManager.sLsRSGwrU3(fileInfo);
      }
      else
      {
        foreach (Type type in compilerResults.CompiledAssembly.GetTypes())
        {
          if (type.IsPublic)
          {
						string index = type.FullName.Substring(0, type.FullName.IndexOf(""));
            FileInfo fileInfo = dictionary[index];
            list1.Remove(fileInfo);
            ComponentRecord componentRecord = StrategyComponentManager.cN2R9Xa8LN(type, fileInfo);
            if (componentRecord != null)
            {
              StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord);
              StrategyComponentManager.H13R1k6g2K(componentRecord);
            }
          }
        }
        foreach (FileInfo file in list1)
        {
          ComponentRecord componentRecord = new ComponentRecord(Guid.Empty, ComponentType.Unknown, file.Name, "", file, (Type) null, new CompilerErrorCollection(new CompilerError[1]
          {
							new CompilerError(file.FullName, -1, -1,"fddfs","trtr")
          }));
          StrategyComponentManager.wcrRFbhwry.ROm6C46rfm(componentRecord);
          StrategyComponentManager.H13R1k6g2K(componentRecord);
        }
        foreach (FileInfo fileInfo in list2)
          StrategyComponentManager.sLsRSGwrU3(fileInfo);
      }
    }

    
    private static ComponentRecord cN2R9Xa8LN([In] Type obj0, [In] FileInfo obj1)
    {
      StrategyComponentAttribute[] componentAttributeArray = obj0.GetCustomAttributes(typeof (StrategyComponentAttribute), false) as StrategyComponentAttribute[];
      if (componentAttributeArray == null || componentAttributeArray.Length != 1)
        return (ComponentRecord) null;
      StrategyComponentAttribute componentAttribute = componentAttributeArray[0];
      string name = componentAttribute.Name == null ? obj0.Name : componentAttribute.Name;
      return new ComponentRecord(componentAttribute.GUID, componentAttribute.Type, name, componentAttribute.Description, obj1, obj0, (CompilerErrorCollection) null);
    }

    
    private static void uWxRhBPP9U([In] object obj0, [In] FileSystemEventArgs obj1)
    {
      if (obj1.ChangeType != WatcherChangeTypes.Changed)
        return;
      string str = obj1.FullPath;
			if (str.EndsWith("/"))
      {
				int length = str.LastIndexOf("/");
        if (length != -1)
          str = str.Substring(0, length);
      }
      foreach (ComponentRecord componentRecord in StrategyComponentManager.wcrRFbhwry)
      {
        if (!componentRecord.BuiltIn && componentRecord.File.FullName.ToLower() == str.ToLower())
          componentRecord.VnhAiVxt7S(true);
      }
    }

    
    private static void H13R1k6g2K([In] ComponentRecord obj0)
    {
//      if (StrategyComponentManager.L7oR4xlqNi == null)
//        return;
//      StrategyComponentManager.L7oR4xlqNi(new ComponentEventArgs(obj0));
    }

    
    private static void IP7RCltgOJ([In] ComponentRecord obj0)
    {
//      if (StrategyComponentManager.RBMRJwDgsx == null)
//        return;
//      StrategyComponentManager.RBMRJwDgsx(new ComponentEventArgs(obj0));
    }

    
    private static void TXQRKdObj1([In] ComponentRecord obj0)
    {
//      if (StrategyComponentManager.GvhR0aa8Qx == null)
//        return;
//      StrategyComponentManager.GvhR0aa8Qx(new ComponentEventArgs(obj0));
    }
  }
}
