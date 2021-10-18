using System;
using System.Drawing.Text;
using System.Windows.Forms;
using FlaUI.Core;
using FlaUI.Core.AutomationElements;
using FlaUI.Core.Conditions;
using FlaUI.Core.Definitions;
using FlaUI.Core.Input;
using FlaUI.Core.Tools;
using FlaUI.UIA3;

const int BigWaitTimeout = 3000;
string passWord = "Motoko19-93";
// Note: Works only pre-Windows 8 with the legacy calculator
//var msApplication = Application.Launch(@"C:\Users\BondarenkoAS\AppData\Local\Postman\Postman.exe");
//var msApplication = Application.Launch(@"‪C:\WINDOWS\system32\mstsc.exe");
var automation = new UIA3Automation();
//var mainWindow = msApplication.GetMainWindow(automation);
var Desktop = automation.GetDesktop();

ConditionFactory cf = new ConditionFactory(new UIA3PropertyLibrary());
Desktop.FindFirstDescendant(cf.ByName("Подключение к удаленному рабочему столу")).AsButton().Click();
System.Threading.Thread.Sleep(1500);

Desktop.FindFirstDescendant(cf.ByName("Подключить")).AsButton().Click();
System.Threading.Thread.Sleep(1500);

Desktop.FindFirstDescendant(cf.ByName("Пароль").And(cf.ByControlType(ControlType.Edit)));
Keyboard.Type(passWord);
System.Threading.Thread.Sleep(1500);

//Desktop.FindFirstDescendant(cf.ByName("ОK")).AsButton().Click();
var buttonOK = Desktop.FindFirstDescendant(cf.ByName("ОК")).AsButton();
buttonOK.Click();

System.Threading.Thread.Sleep(2500);

var buttonInRDP = Desktop.FindFirstDescendant((cf.ByName("Проводник")));
buttonInRDP.Click();
//buttonInRDP.Click();
//var buttonInRDP = Desktop.FindFirstDescendant(cf.ByName("Проводник"));
//buttonInRDP.Click();
//var buttonInRDP = Desktop.ControlType == ControlType.Window;
//var RDPwindow = automation.GetDesktop();
//RDPwindow.FindFirstDescendant(cf.ByName(name: "ОК")).AsButton().Click();

//mainWindow.FindFirstDescendant(cf.ByName("Отмена")).AsButton().Click();

//var app = FlaUI.Core.Application.Launch("calc.exe");
//using (var automation = new UIA3Automation())
//{
//    var window = app.GetMainWindow(automation);
//    var button1 = window.FindFirstDescendant(cf => cf.ByText("1"))?.AsButton();
//    button1?.Invoke();
//}