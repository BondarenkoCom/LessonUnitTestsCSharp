using System;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace TCPtest
{
    class Program
    {
        static void Main(string[] args)
        {

            string Host = System.Net.Dns.GetHostName();
            string IP = System.Net.Dns.GetHostByName(Host).AddressList[0].ToString();
            Console.WriteLine($"Host:{Host} \nIP:{IP}");

            //int port = 53036;
            //IPAddress ipAddress = Dns.GetHostEntry("localhost").AddressList[0];
            //try
            //{
            //    //Load TCP 127.0.0.1 , 53036
            //    TcpListener tcpListener = new TcpListener(ipAddress, port);
            //    tcpListener.Start();
            //    Console.WriteLine($"Load TCP {ipAddress} , {port}");
            //    Console.ReadLine();
            //
            //}
            //catch (SocketException ex)
            //{
            //    Console.WriteLine(ex.Message, "kaboom");
            //    Console.ReadLine();
            //}


        }
    }
}
