using System;
using System.Diagnostics;
using System.Linq;
using System.Management.Automation;

namespace LessonsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Load");

            //PowerShell ps = PowerShell.Create().AddCommand("(ps TaxcomMasterAgent).Kill()");
            //PowerShell psSt = PowerShell.Create().AddCommand("(ps TaxcomAgent).Kill()");
            //

            var chromeDriverProcesses = Process.GetProcesses().
                Where(pr => pr.ProcessName == "TaxcomAgent"); // without '.exe'

            foreach (var process in chromeDriverProcesses)
            {
                process.Kill();
            }

            //PowerShell ps = PowerShell.Create().AddCommand("Get-Process");
            //
            //IAsyncResult asyncpl = ps.BeginInvoke();
            //
            //foreach (PSObject result in ps.EndInvoke(asyncpl))
            //{
            //    Console.WriteLine("{0,-20}{1}",
            //        result.Members["ProcessName"].Value,
            //        result.Members["Id"].Value);
            //} // End foreach.
            //System.Console.WriteLine("Hit any key to exit.");
            //System.Console.ReadKey();

       
            //IAsyncResult asyncpl = ps.BeginInvoke();
            //IAsyncResult async = psSt.BeginInvoke();

        }
    }
}
