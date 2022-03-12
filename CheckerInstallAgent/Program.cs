using System;
using System.IO;
using System.Linq;
using System.Management;

namespace CheckerInstallAgent
{


    //C:\Program Files (x86)\Taxcom\TaxcomTerminalAgent\
    //%USERPROFILE%\AppData\Roaming\TaxcomAgent\

    class Program
    {
        static void Main(string[] args)
        {
            //TODO MGA Сделать проверку на то что агент вообще установлен ибо он может просто не стоять на машине при старте тестов. Если агент стоит, то делаем тест желтым и идем дальше

            //ApplicationInPc.IsDirectoryEmpty();
            //ApplicationInPc.CheckInstallStandartAgent();
            ApplicationInPc.GetArch();

            Console.WriteLine();
        }
    }

    public class ApplicationInPc
    {
        public static void GetArch()
        {
            var archSystem = Environment.Is64BitOperatingSystem;
            Console.WriteLine(archSystem);


        }

        public static void GetAllApplication()
        {
            ManagementObjectSearcher mos = new ManagementObjectSearcher("SELECT * FROM Win32_Product");
            foreach (ManagementObject mo in mos.Get())
            {
                Console.WriteLine(mo["name"]);
            }
        }

        public static void CheckInstallStandartAgent()
        {
            //(@"C:\Program Files (x86)\Taxcom\TaxcomTerminalAgent\uninstaller.exe", "Terminal Agent Uninstaller Tool");

            //string MasterAgentPath = @"%USERPROFILE%\AppData\Roaming\TaxcomAgent\";
            try
            {
                string StandartAgentPath = @"C:\Users\BondarenkoAS\AppData\Roaming\TaxcomAgent";

                if (Directory.GetFiles(StandartAgentPath).Length == 0)
                {
                    Console.WriteLine("delete");
                }
                else
                {
                    Console.WriteLine("install");
                };

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                //throw;
            }

            
        } 

    }
}
