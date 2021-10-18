using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Automation;
using Winium.Cruciatus.Core;
using Winium.Cruciatus.Extensions;

namespace ConsoleApplication
{
    public class Program
    {
        private static void Main(string[] args)
        {
            var calc = new Winium.Cruciatus.Application("C:/windows/system32/calc.exe");
            calc.Start();

            var winFinder = By.Name("Калькулятор").AndType(ControlType.Window);
            var win = Winium.Cruciatus.CruciatusFactory.Root.FindElement(winFinder);
            var menu = win.FindElementByUid("MenuBar").ToMenu();

            menu.SelectItem("Вид$Инженерный");
            menu.SelectItem("Вид$Журнал");

            win.FindElementByUid("132").Click(); // 2
            win.FindElementByUid("93").Click(); // +
            win.FindElementByUid("134").Click(); // 4
            win.FindElementByUid("97").Click(); // ^
            win.FindElementByUid("138").Click(); // 8
            win.FindElementByUid("121").Click(); // =

            calc.Close();
        }
    }
}