using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SeleniumPractice.PageObjects
{
    public  class POLogin
    {
        public IWebElement InputUser(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Name("Username"));
            return element;
        }

        public IWebElement InputPassword(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Name("Password"));
            return element;
        }

        public IWebElement ButtonEntrar(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("/html/body/div[1]/form/div/div[4]/div[2]/input"));
            return element;
        }

        public IWebElement ButtonCrear(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("registerAction"));
            return element;
        }

        public IWebElement LinkOlvidastePassword(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//a[contains(.,'¿Olvidaste tu contraseña?')]"));
            return element;
        }

        public IWebElement DivMenuAdmim(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.Id("topbar-menu-admin"));
            return element;
        }

        public IWebElement FailLogin(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//li[contains(text(),'El usuario o contraseña es incorrecto')]"));
            return element;
        }
    }
}
