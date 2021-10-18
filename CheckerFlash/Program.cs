using System;
using System.Net.Http;
using System.Management;
using PCSC;

namespace CheckerFlash
{
    class Program
    {
        static void Main(string[] args)
        {
            //var contextFactory = ContextFactory.Instance;
            //using (var context = contextFactory.Establish(SCardScope.System))
            using (var context = ContextFactory.Instance.Establish(SCardScope.System))
            {
                Console.WriteLine("Currently connected readers: ");
                var readerNames = context.GetReaders();
                //Console.WriteLine(readerNames);
                foreach (var readerName in readerNames)
                {
                    //Console.WriteLine("\t" + readerName);
                    Console.WriteLine(readerName);
                }
            }
        }
    }
}
