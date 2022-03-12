using System;
using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;



namespace PathExperiments
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Load");
            Console.WriteLine(TcpPortHelper.GetTwoRandomPort());
            Console.WriteLine(TcpPortHelper.GetRandomPortNumber());
        }
    }

        public static class TcpPortHelper
        {
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

            private static int[] GetBusyPorts()
            {
                IPGlobalProperties properties = IPGlobalProperties.GetIPGlobalProperties();
                IPEndPoint[] listeners = properties.GetActiveTcpListeners();
                return listeners.Select(item => item.Port).ToArray();
            }
        }
    }
