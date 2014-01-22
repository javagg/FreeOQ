using FreeQuant;
using FreeQuant.FIX;
using FreeQuant.Xml;
using System;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
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
			ServiceManager.services.jLl6RmfZp(service);
			ServiceManager.HlUrceJWW(service);
			service.StatusChanged += new EventHandler(ServiceManager.CjQS2cYWM);
			service.Error += new ServiceErrorEventHandler(ServiceManager.DXXHdAxP1);
			if (service is IMarketService)
			{
				IMarketService marketService = service as IMarketService;
				marketService.Logon += new FIXLogonEventHandler(ServiceManager.UcjG1rH0l);
				marketService.Logout += new FIXLogoutEventHandler(ServiceManager.ab4IIxqEN);
			}
			if (service is IExecutionService)
			{
				IExecutionService executionService = service as IExecutionService;
				ServiceManager.executionServices.jLl6RmfZp((IService)executionService);
				executionService.NewOrderSingle += new FIXNewOrderSingleEventHandler(ServiceManager.nKWRNT2TM);
				executionService.OrderCancelRequest += new FIXOrderCancelRequestEventHandler(ServiceManager.NdSXrHt2W);
				executionService.OrderCancelReplaceRequest += new FIXOrderCancelReplaceRequestEventHandler(ServiceManager.iHPj7xf9A);
			}
//			if (ServiceManager.agr17t8EE == null)
//				return;
//			ServiceManager.agr17t8EE((object)typeof(ServiceManager), new ServiceEventArgs(service));
		}

		private static void CjQS2cYWM([In] object obj0, [In] EventArgs obj1)
		{
//			if (ServiceManager.UUmpoSA4u == null)
//				return;
//			ServiceManager.UUmpoSA4u((object)typeof(ServiceManager), new ServiceEventArgs(obj0 as IService));
		}

		private static void DXXHdAxP1([In] object obj0, [In] ServiceErrorEventArgs obj1)
		{
			ServiceManager.YUgmSxdnP(obj1.Error);
		}

		private static void YUgmSxdnP([In] ServiceError obj0)
		{
			ServiceManager.serviceErrors.EJUWWWMFm(obj0);
			bool flag;
			switch (obj0.ErrorType)
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
				Trace.WriteLine(obj0.ToString());
//			if (ServiceManager.nw4tlMEor == null)
//				return;
//			ServiceManager.nw4tlMEor((object)typeof(ServiceManager), new ServiceErrorEventArgs(obj0));
		}

		private static void P4q3Qf7DF([In] IService obj0, [In] string obj1)
		{
			ServiceManager.YUgmSxdnP(new ServiceError(obj0, ServiceErrorType.Warning, Clock.Now, obj1));
		}

		private static void UcjG1rH0l([In] object obj0, [In] FIXLogonEventArgs obj1)
		{
//			if (ServiceManager.L4s21PXag == null)
//				return;
			LogonEventArgs args = new LogonEventArgs(obj0 as IMarketService, obj1.Logon);
//			ServiceManager.L4s21PXag((object)typeof(ServiceManager), args);
		}

		private static void ab4IIxqEN([In] object obj0, [In] FIXLogoutEventArgs obj1)
		{
//			if (ServiceManager.cuV9ccqCE == null)
//				return;
			LogoutEventArgs args = new LogoutEventArgs(obj0 as IMarketService, obj1.Logout);
//			ServiceManager.cuV9ccqCE((object)typeof(ServiceManager), args);
		}

		private static void nKWRNT2TM([In] object obj0, [In] FIXNewOrderSingleEventArgs obj1)
		{
			NewOrderSingle newOrderSingle = obj1.NewOrderSingle as NewOrderSingle;
//			if (ServiceManager.rS1MEo9kS == null)
//				return;
			NewOrderSingleEventArgs args = new NewOrderSingleEventArgs(obj0 as IExecutionService, (FIXNewOrderSingle)newOrderSingle);
//			ServiceManager.rS1MEo9kS((object)typeof(ServiceManager), args);
		}

		private static void NdSXrHt2W([In] object obj0, [In] FIXOrderCancelRequestEventArgs obj1)
		{
		}

		private static void iHPj7xf9A([In] object obj0, [In] FIXOrderCancelReplaceRequestEventArgs obj1)
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
						object obj = propertyInfo.GetValue((object)service, (object[])null);
//						if (obj != null)
//							cpe7qfAuNwXs9rJfqU.TX4qfjqoJ().Add(propertyInfo.Name, propertyInfo.PropertyType, Convert.ToString(obj, (IFormatProvider)CultureInfo.InvariantCulture));
					}
				}
			}
//			mlpBqQ6agR41WimwkC.Save(ServiceManager.Ie9TX0DmM());
		}

		private static void HlUrceJWW([In] IService obj0)
		{
			string str = ServiceManager.Ie9TX0DmM();
			if (!File.Exists(str))
				return;
//			MLPBqQ6agR41WImwkC mlpBqQ6agR41WimwkC = new MLPBqQ6agR41WImwkC();
//			mlpBqQ6agR41WimwkC.Load(str);
//			CPe7qfAuNWXs9rJfqU cpe7qfAuNwXs9rJfqU = mlpBqQ6agR41WimwkC.qwk8C84fU().MGyCX7o6p(obj0.Name);
//			if (cpe7qfAuNwXs9rJfqU == null)
//				return;
//			foreach (PropertyXmlNode propertyXmlNode in (ListXmlNode<PropertyXmlNode>) cpe7qfAuNwXs9rJfqU.TX4qfjqoJ())
//			{
//				if (propertyXmlNode.Type == (Type)null)
//				{
//					ServiceManager.P4q3Qf7DF(obj0, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(60), (object)propertyXmlNode.Name, (object)propertyXmlNode.Value));
//				}
//				else
//				{
//					PropertyInfo property = obj0.GetType().GetProperty(propertyXmlNode.Name, propertyXmlNode.Type);
//					if (property == (PropertyInfo)null)
//					{
//						ServiceManager.P4q3Qf7DF(obj0, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(182), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value));
//					}
//					else
//					{
//						try
//						{
//							object obj = !propertyXmlNode.Type.IsEnum ? (!(propertyXmlNode.Type == typeof(string)) ? (!(propertyXmlNode.Type == typeof(TimeSpan)) ? Convert.ChangeType((object)propertyXmlNode.Value, propertyXmlNode.Type, (IFormatProvider)CultureInfo.InvariantCulture) : (object)TimeSpan.Parse(propertyXmlNode.Value)) : (object)propertyXmlNode.Value) : Enum.Parse(propertyXmlNode.Type, propertyXmlNode.Value);
//							if (obj == null)
//								ServiceManager.P4q3Qf7DF(obj0, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(338), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value));
//							else
//								property.SetValue((object)obj0, obj, (object[])null);
//						}
//						catch (Exception ex)
//						{
//							ServiceManager.P4q3Qf7DF(obj0, string.Format(vHt2WFcHP7xf9AvlUc.NIyE6a865(530), (object)propertyXmlNode.Name, (object)propertyXmlNode.Type, (object)propertyXmlNode.Value, (object)ex.Message));
//						}
//					}
//				}
//			}
		}

		private static string Ie9TX0DmM()
		{
			return string.Format("", (object)Framework.Installation.IniDir.FullName, "");
		}
	}
}
