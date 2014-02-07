using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Xml;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Diagnostics;

namespace FreeQuant.Services
{
	public class ServiceManager
	{
		private const string MUyoVT3Dg = "service.properties.xml";
		private static ServiceList services;
		private static ExecutionServiceList executionServices;
		private static IExecutionService executionSimulator;
		private static ServiceErrorList serviceErrors;

		public static ServiceList Services
		{
			get
			{
				return ServiceManager.services; 
			}
		}

		public static ExecutionServiceList ExecutionServices
		{
			get
			{
				return ServiceManager.executionServices; 
			}
		}

		public static ServiceErrorList ServiceErrors
		{
			get
			{
				return ServiceManager.serviceErrors; 
			}
		}

		public static IExecutionService ExecutionSimulator
		{
			get
			{
				return ServiceManager.executionSimulator; 
			}
			set
			{
				ServiceManager.executionSimulator = value;
			}
		}

		public static event ServiceEventHandler ServiceAdded;
		public static event ServiceEventHandler ServiceStatusChanged;
		public static event ServiceErrorEventHandler ServiceError;
		public static event LogonEventHandler Logon;
		public static event LogoutEventHandler Logout;
		public static event NewOrderSingleEventHandler NewOrderSingle;

		static ServiceManager()
		{
			ServiceManager.services = new ServiceList();
			ServiceManager.executionServices = new ExecutionServiceList();
			ServiceManager.serviceErrors = new ServiceErrorList();
		}

		public static void Add(IService service)
		{
//			if (Framework.Installation.Edition == Edition.Research && (int)service.Id != 1)
//				return;
			ServiceManager.services.Add(service);
			ServiceManager.Load(service);
			service.StatusChanged += new EventHandler(ServiceManager.EmitServiceStatusChanged);
			service.Error += new ServiceErrorEventHandler(ServiceManager.EmitServiceError);
			if (service is IMarketService)
			{
				IMarketService marketService = service as IMarketService;
				marketService.Logon += new FIXLogonEventHandler(ServiceManager.EmitLogon);
				marketService.Logout += new FIXLogoutEventHandler(ServiceManager.EmitLogout);
			}
			if (service is IExecutionService)
			{
				IExecutionService executionService = service as IExecutionService;
				ServiceManager.executionServices.Add(executionService);
				executionService.NewOrderSingle += new FIXNewOrderSingleEventHandler(ServiceManager.nKWRNT2TM);
				executionService.OrderCancelRequest += new FIXOrderCancelRequestEventHandler(ServiceManager.NdSXrHt2W);
				executionService.OrderCancelReplaceRequest += new FIXOrderCancelReplaceRequestEventHandler(ServiceManager.iHPj7xf9A);
			}
			if (ServiceManager.ServiceAdded != null)
			ServiceManager.ServiceAdded(typeof(ServiceManager), new ServiceEventArgs(service));
		}

		private static void EmitServiceStatusChanged(object sender, EventArgs e)
		{
			if (ServiceManager.ServiceStatusChanged != null)
				ServiceManager.ServiceStatusChanged(typeof(ServiceManager), new ServiceEventArgs(sender as IService));
		}

		private static void EmitServiceError(object obj0, ServiceErrorEventArgs obj1)
		{
			ServiceManager.HandleServiceError(obj1.Error);
		}

		private static void HandleServiceError(ServiceError error)
		{
			ServiceManager.serviceErrors.Add(error);
			bool flag;
			switch (error.ErrorType)
			{
				case ServiceErrorType.Message:
					flag = Trace.IsLevelEnabled(TraceLevel.Info);
					break;
				case ServiceErrorType.Warning:
					flag = Trace.IsLevelEnabled(TraceLevel.Warning);
					break;
				case ServiceErrorType.Error:
					flag = Trace.IsLevelEnabled(TraceLevel.Error);
					break;
				default:
					flag = false;
					break;
			}
			if (flag)
				Trace.WriteLine(error.ToString());
			if (ServiceManager.ServiceError != null)
			ServiceManager.ServiceError(typeof(ServiceManager), new ServiceErrorEventArgs(error));
		}

		private static void P4q3Qf7DF(IService service, string text)
		{
			ServiceManager.HandleServiceError(new ServiceError(service, ServiceErrorType.Warning, DateTime.Now, text));
		}

		private static void EmitLogon(object sender, FIXLogonEventArgs e)
		{
			if (ServiceManager.Logon != null)
			{
				ServiceManager.Logon(typeof(ServiceManager), new LogonEventArgs(sender as IMarketService, e.Logon));
		}
		}

		private static void EmitLogout(object obj0, FIXLogoutEventArgs obj1)
		{
			if (ServiceManager.Logout != null)
			{
				ServiceManager.Logout(typeof(ServiceManager), new LogoutEventArgs(obj0 as IMarketService, obj1.Logout));
			}
		}

		private static void nKWRNT2TM(object sender, FIXNewOrderSingleEventArgs e)
		{
			NewOrderSingle order = e.NewOrderSingle as NewOrderSingle;
			if (ServiceManager.NewOrderSingle != null)
			{	
				ServiceManager.NewOrderSingle(typeof(ServiceManager), new NewOrderSingleEventArgs(sender as IExecutionService, order));
			}
		}

		private static void NdSXrHt2W(object obj0, FIXOrderCancelRequestEventArgs obj1)
		{
		}

		private static void iHPj7xf9A(object obj0, FIXOrderCancelReplaceRequestEventArgs obj1)
		{
		}

		public static void SaveServiceProperties()
		{
//			MLPBqQ6agR41WImwkC mlpBqQ6agR41WimwkC = new MLPBqQ6agR41WImwkC();
			foreach (IService service in ServiceManager.services)
			{
//				CPe7qfAuNWXs9rJfqU cpe7qfAuNwXs9rJfqU = mlpBqQ6agR41WimwkC.qwk8C84fU().ye7LqgErt(service);
//				cpe7qfAuNwXs9rJfqU.uTuNmYiVX(service.Name);
				foreach (PropertyInfo propertyInfo in service.GetType().GetProperties())
				{
					if (propertyInfo.CanRead && propertyInfo.CanWrite && (propertyInfo.PropertyType.IsValueType || propertyInfo.PropertyType.IsEnum || (propertyInfo.PropertyType == typeof(string) || propertyInfo.PropertyType == typeof(TimeSpan))))
					{
						object obj = propertyInfo.GetValue(service, (object[])null);
//						if (obj != null)
//							cpe7qfAuNwXs9rJfqU.TX4qfjqoJ().Add(propertyInfo.Name, propertyInfo.PropertyType, Convert.ToString(obj, (IFormatProvider)CultureInfo.InvariantCulture));
					}
				}
			}
//			mlpBqQ6agR41WimwkC.Save(ServiceManager.GetFilename());
		}

		private static void Load(IService service)
		{
			string filename = ServiceManager.GetFilename();
			if (!File.Exists(filename))
				return;
//			MLPBqQ6agR41WImwkC mlpBqQ6agR41WimwkC = new MLPBqQ6agR41WImwkC();
//			mlpBqQ6agR41WimwkC.Load(filename);
//			CPe7qfAuNWXs9rJfqU cpe7qfAuNwXs9rJfqU = mlpBqQ6agR41WimwkC.qwk8C84fU().MGyCX7o6p(service.Name);
//			if (cpe7qfAuNwXs9rJfqU == null)
//				return;
//			foreach (PropertyXmlNode propertyXmlNode in (ListXmlNode<PropertyXmlNode>) cpe7qfAuNwXs9rJfqU.TX4qfjqoJ())
//			{
//				if (propertyXmlNode.Type == (Type)null)
//				{
//					ServiceManager.P4q3Qf7DF(service, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(60), (object)propertyXmlNode.Name, (object)propertyXmlNode.Value));
//				}
//				else
//				{
//					PropertyInfo property = service.GetType().GetProperty(propertyXmlNode.Name, propertyXmlNode.Type);
//					if (property == (PropertyInfo)null)
//					{
//						ServiceManager.P4q3Qf7DF(service, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(182), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value));
//					}
//					else
//					{
//						try
//						{
//							object obj = !propertyXmlNode.Type.IsEnum ? (!(propertyXmlNode.Type == typeof(string)) ? (!(propertyXmlNode.Type == typeof(TimeSpan)) ? Convert.ChangeType((object)propertyXmlNode.Value, propertyXmlNode.Type, (IFormatProvider)CultureInfo.InvariantCulture) : (object)TimeSpan.Parse(propertyXmlNode.Value)) : (object)propertyXmlNode.Value) : Enum.Parse(propertyXmlNode.Type, propertyXmlNode.Value);
//							if (obj == null)
//								ServiceManager.P4q3Qf7DF(service, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(338), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value));
//							else
//								property.SetValue((object)service, obj, (object[])null);
//						}
//						catch (Exception ex)
//						{
//							ServiceManager.P4q3Qf7DF(service, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(530), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value, (object)ex.Message));
//						}
//					}
//				}
//			}
		}

		private static string GetFilename()
		{
			return string.Format("{0}", Framework.Installation.IniDir.FullName, "");
		}
	}
}
