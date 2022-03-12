using System;

namespace GetValuesMachines
{
    class Program
    {
        static void Main(string[] args)
        {

            //var getOs = Environment.OSVersion;
            var getOs = Environment.OSVersion;
            string getMachineName = Environment.MachineName.ToString();

            Console.WriteLine($"{getOs} , {getMachineName}");
        }
    }
}
