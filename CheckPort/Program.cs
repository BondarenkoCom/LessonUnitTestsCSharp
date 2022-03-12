using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace CheckPort
{
    class Program
    {
        static void Main(string[] args)
        {
            //var b = TcpPortHelper.CheckPortIsAvailable(64266);
            //Console.WriteLine(b);
            //51285
            // localMachineDatas = ("10.2.11.108", 63270);

            PingHost("10.2.11.108", 63270);
            //PingHost("10.2.9.128", 50201);
        }


        public static bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber)) 
                    return true;

            }
            catch (SocketException ex)
            {
                Console.WriteLine("Error pinging host:'" + hostUri + ":" + portNumber.ToString() + "'");
                return false;
            }
        }

    }




    public static class TcpPortHelper
        {

            public static void CheckIpPortName()
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());

                //10.2.9.108
                //64251
                foreach (var ip in host.AddressList)
                {
                    Console.WriteLine($"{ip} {ip.AddressFamily} {ip}");

                }
            }

            public static bool CheckPortIsAvailable(int portToCheck)
            {
                return GetBusyPorts().All(openPort => openPort != portToCheck);
            }

            public static bool CheckPortIsAvailable(int portToCheck, int secondPort)
            {
                return GetBusyPorts().All(openPort => openPort != portToCheck && openPort != secondPort);
            }

            public static int GetRandomPortNumber()
            {
                var port = new Random().Next(1, 65535);
                while (!CheckPortIsAvailable(port))
                {
                    port += 1;
                }
                return port;
            }

            public static (int port, int port2) GetTwoRandomPort()
            {
                var port = new Random().Next(1, 40000);
                var port2 = new Random().Next(1, 40000);
                while (!CheckPortIsAvailable(port, port2))
                {
                    port += 1;
                    port2 += 1;
                }
                return (port, port2);
            }

            public static int[] GetBusyPorts()
            {
                IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
                IPEndPoint[] listeners = properties.GetActiveTcpListeners();
                return listeners.Select(item => item.Port).ToArray();
            }
        }
    }
