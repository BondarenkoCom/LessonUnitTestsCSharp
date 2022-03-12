using System;
using System.Diagnostics;
using System.IO.Enumeration;
using System.Net.NetworkInformation;
using System;

namespace TestOnlineSlow
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load");

            //Отключение от Интернета:
            ControlInternet.InternetConnection("ipconfig", "/release");

            System.Threading.Thread.Sleep(5000);


            //Подключение к Интернету:
             ControlInternet.InternetConnection("ipconfig", "/renew");
        }
            
    }

    class ControlInternet
    {
        public static bool CheckInternetConnection()
        {
            try
            {
                //класс Ping позволяет определять доступен ли компьютер удаленный
                Ping myPing = new Ping();
                //String host = "google.com";
                String host = "jupiter-r.taxcom.ru";
                byte[] buffer = new byte[32];
                int timeout = 1000;

                //Используется для управления передачей пакетов данных Ping.
                PingOptions pingOptions = new PingOptions();

                //Предоставляет сведения о состоянии и о данных, полученных в результате операции Send или SendAsync
                PingReply reply = myPing.Send(host, timeout, buffer, pingOptions);
                Console.WriteLine($"{reply.Status == IPStatus.Success} ,{reply.Status} ");
                return (reply.Status == IPStatus.Success);
            }
            catch (Exception)
            {
                Console.WriteLine("false");
                return false;
            }
        }
        //Process.Start("ipconfig", "/release"); //For disabling internet
        //System.Diagnostics.Process.Start("ipconfig", "/renew"); //For enabling internet

        public static void InternetConnection(string commandIp , string commandSwitchOnline)
        { 
            //ProcessStartInfo internet = new ProcessStartInfo()
            Process.Start(commandIp , commandSwitchOnline);
            //  {
            //  FileName = "cmd.exe",
            //      Arguments = "/C ipconfig /" + str,
            //  WindowStyle = ProcessWindowStyle.Hidden
            //};
            //Process.Start(internet);
        }
    }
}

