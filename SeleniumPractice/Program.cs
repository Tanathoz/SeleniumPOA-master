using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

using NUnit.Framework;

namespace SeleniumPractice
{
    class Program
    {


        //Create the reference to browser
        public static void Main(string[] args) {
        }   

        [SetUp]
        public void Initialize()
        {
            PropiertiesCollection.driver = new ChromeDriver();
            PropiertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Go to URL");
        }

        [Test]
        public void ExecuteTest() {

            ExcelLib.PopulateInCollection(@"C:\Users\Tanathoz\Music\Book1.xlsx");

            LoginPageObject objLogin = new LoginPageObject();
            EAPageObject objEApage = objLogin.Login(ExcelLib.ReadData(1,"UserName"), ExcelLib.ReadData(1,"Password"));
            objEApage.FillUserForm(ExcelLib.ReadData(1,"Initial"), ExcelLib.ReadData(1,"MiddleName"),ExcelLib.ReadData(1,"FirstName"));
            
           /* SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropiertyType.Id);

            SeleniumSetMethods.EnterText("Initial", "execute Automation", PropiertyType.Name);
            //perform ops
            SeleniumSetMethods.Click( "Save", PropiertyType.Name);
            Console.WriteLine("The value from my title is :"+ SeleniumGetMethods.GetTextFromDDL("TitleId",PropiertyType.Id));
            Console.WriteLine("The value from my text box  is :" + SeleniumGetMethods.GetText("Initial", PropiertyType.Name));
            Console.WriteLine("execute Test");*/
        }

        [Test]
        public void NextTest() {
            Console.WriteLine("next method test");
        }
        [TearDown]
        public void CleanUp() {
            PropiertiesCollection.driver.Close();
            Console.WriteLine("close browser");
        }
    
    }
}
