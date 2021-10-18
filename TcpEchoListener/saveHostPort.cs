using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace TcpEchoListener
{
    class saveHostPort
    {
        //public static void saveHostPortAndSend(string dataMsg)
        //{
        //    Console.WriteLine($"Я сохранил {dataMsg}");
        //
        //    string SaveData = dataMsg;
        //    string SaveDataHost = (SaveData.Split(','))[0];
        //    string SaveDataPort = (SaveData.Split(','))[1];
        //
        //    Console.ForegroundColor = ConsoleColor.DarkRed;
        //
        //    Console.WriteLine(SaveDataHost);
        //
        //    Console.ForegroundColor = ConsoleColor.Green;
        //
        //    Console.WriteLine(SaveDataPort);
        //
        //    Console.ForegroundColor = ConsoleColor.White;
        //
        //
        //    Send(SaveDataHost  , SaveDataPort);
        //
        //    Console.WriteLine("Данные отправлены");
        //
        //
        //}

        public static void Send(string sendHost, string sendPort)
        {
            
            IPAddress[] IPs = Dns.GetHostAddresses(sendHost);
            int newPort = Convert.ToInt32(sendPort);

            Socket s = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            Console.WriteLine($"Установление соединения с {sendHost} \nпорт {newPort}");
            
            
            s.Connect(IPs[0], newPort);
            //s.Connect(IPs[0], sendPort);

            Console.ForegroundColor = ConsoleColor.Green;
            
            //string comandTerminalMode = Console.ReadLine();
            byte[] Bytes = Encoding.ASCII.GetBytes($"Hello IP:{sendHost} Port:{newPort}");
            s.Send(Bytes);
            
            byte[] Ipbuffer = new byte[256];
            
            //s.Receive(buffer , offset:0  , size:9000 , System.Net.Sockets.SocketFlags SocketFlags);
            s.Receive(Ipbuffer);
            Console.Write(Encoding.ASCII.GetString(Ipbuffer));
            Console.WriteLine("\n Connection established");
            s.Close();
        }


    }
}
