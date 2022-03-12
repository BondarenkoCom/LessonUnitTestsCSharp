using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace CheckPublicIPHost
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load");


           // static int FreeTcpPort()
           // {
                //TcpListener l = new TcpListener(IPAddress.Loopback, 0);
                //l.Start();
                //var Ip = ((IPEndPoint)l.LocalEndpoint).Address;
                //l.Stop();
                //Console.WriteLine(Ip);
                //Console.ReadKey();
                // return port;
                // }


                IPGlobalProperties igp = IPGlobalProperties.GetIPGlobalProperties();
                TcpConnectionInformation[] tinfo = igp.GetActiveTcpConnections();
                
                
                //tcpi.LocalEndPoint = {10.2.9.108:7680}
                foreach (TcpConnectionInformation tcpi in tinfo)
                {

                    var state = tcpi.State;
                    var ipnum = tcpi.RemoteEndPoint.Address;
                    Console.WriteLine($"{state} , {ipnum} Where Established {state == TcpState.Established}");



                    //if (tcpi.LocalEndPoint.Port == 342)
                    //{
                    //    //порт занят
                    //    Console.WriteLine(tcpi.LocalEndPoint.Port);
                    //
                    //}
                }

        }
    }
}
