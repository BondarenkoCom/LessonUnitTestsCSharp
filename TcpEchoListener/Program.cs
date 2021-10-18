using System;
using System.Net.Sockets;
using System.Net;
using System.Reflection;
using static TcpEchoListener.saveHostPort;

namespace TcpEchoListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Listen...");
            ServerResponse.ResponseBegin();

        }

        public class ServerResponse
        {
            public static void ResponseBegin()
            {

                TcpListener server = null;
                try
                {
                    //for develop
                    Int32 port = 9090;
                    IPAddress localAddr = IPAddress.Parse("127.0.0.1");

                    //for real work Orio-mk2 (For Islam(Standart Agent))
                    //Int32 port = 63270;
                    //IPAddress localAddr = IPAddress.Parse("10.2.11.108");

                    //for real work Orio-mk2 (Fot BondarenkoAS(Terminal mode))
                    //Int32 port = 61427;
                    //IPAddress localAddr = IPAddress.Parse("10.2.11.108");

                    //for real work Orio-mk4  User: .\test1 
                    //Int32 port = 139;
                    //IPAddress localAddr = IPAddress.Parse("10.2.12.11");


                    server = new TcpListener(localAddr, port);

                    server.Start();
                    Byte[] bytes = new Byte[4096];
                    String data = null;

                    while (true)
                    {
                        Console.Write("Жду подключения ...");

                        TcpClient client = server.AcceptTcpClient();

                        data = null;

                        NetworkStream stream = client.GetStream();
                        // Console.WriteLine(client.Available.ToString());
                        

                        //Console.WriteLine(IPAddress.Loopback);


                        //connectionSocket.RemoteEndPoint.toString();

                        int i;
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = System.Text.Encoding.ASCII.GetString(bytes, 0, i);
                            Console.WriteLine("Received: {0}", data);

                            data = data.ToUpper();
                            byte[] msg = System.Text.Encoding.ASCII.GetBytes(data);

                            stream.Write(msg, 0, msg.Length);
                            //Console.WriteLine(msg[0]);
                            //Console.WriteLine(msg[1]);
                            Console.WriteLine("принял от ПК Клиент: {0}", data);
                            //saveHostPortAndSend(data);

                            Console.WriteLine($"Я сохранил {data}");

                            string SaveData = data;
                            string SaveDataHost = (SaveData.Split(','))[0];
                            string SaveDataPort = (SaveData.Split(','))[1];

                            Console.ForegroundColor = ConsoleColor.DarkRed;

                            Console.WriteLine(SaveDataHost);

                            Console.ForegroundColor = ConsoleColor.Green;

                            Console.WriteLine(SaveDataPort);

                            Console.ForegroundColor = ConsoleColor.White;


                            Send(SaveDataHost, SaveDataPort);

                            Console.WriteLine("Данные отправлены");



                        }

                        client.Close();
                        break;

                    }
                }
                catch (SocketException e)
                {
                    Console.WriteLine("SocketException: {0}", e);
                }
                finally
                {
                    server.Stop();
                }

                //server.Start();
                Console.WriteLine("\nHit enter to continue...");
                //server.Start();
            }

        }
    }
}