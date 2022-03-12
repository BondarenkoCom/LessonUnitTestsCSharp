using System;
using System.Management;
using System.Collections.Generic;
using System.ComponentModel.Design;
using PCSC;

namespace CheckerFlash
{
    class Program
    {
        static void Main(string[] args)
        {
            GetDeivces.GetUsbDevices();
            //var res = GetDeivces.GetLogicalDevices().ToString();
            //Console.WriteLine(res);
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                Console.WriteLine("Currently connected readers: ");
                var readerNames = context.GetReaders();
                //Console.WriteLine(readerNames);
                foreach (var readerName in readerNames)
                {
                    //Console.WriteLine("\t" + readerName);
                    Console.WriteLine(readerName);
                    //System.Threading.Thread.Sleep(15000);
                   // Console.ReadKey();
                    //System.Threading.Thread.Sleep(15000);
                }
            }
        }

        public class GetDeivces
        {
            public static List<ManagementBaseObject> GetLogicalDevices()
            {
                List<ManagementBaseObject> devices = new List<ManagementBaseObject>();
                ManagementObjectCollection collection;
                using (var searcher = new ManagementObjectSearcher("root\\CIMV2", @"SELECT * From CIM_LogicalDevice"))
                    collection = searcher.Get();
                foreach (var device in collection)
                {
                    devices.Add(device);
                }
                collection.Dispose();
                return devices;
                //Console.WriteLine(devices);
            }

            public static void GetUsbDevices()
            {
                //TODO Доделать https://thedarkprojects.github.io/devjammer/enable-disable-driver-csharp 
                var usbDevices = GetLogicalDevices();
                foreach (var usbDevice in usbDevices)
                {
                    Console.WriteLine("Name = {0} , Status = {1} , Instance path = {2} , GUID = {3}",
                            usbDevice.GetPropertyValue("Caption"),
                            usbDevice.GetPropertyValue("Status"),
                            usbDevice.GetPropertyValue("DeviceID"), 
                            usbDevice.GetPropertyValue("ClassGuid"));
                }
            }

        }
    }
}
