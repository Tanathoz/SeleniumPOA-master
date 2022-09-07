using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using OpenQA.Selenium;
using SeleniumPractice.PageObjects;

namespace SeleniumPractice.Flujos
{
    public class FLLogin
    {
        POLogin objLogin = new POLogin();
        private bool resultado = false;

        public void Login(IWebDriver driver, string user, string password)
        {
            try
            {
                if (user.Trim().CompareTo(string.Empty) > 0)
                {
                    objLogin.InputUser(driver).SendKeys(user);
                }

                if (password.Trim().CompareTo(string.Empty) > 0)
                {
                    objLogin.InputPassword(driver).SendKeys(password);
                    objLogin.ButtonEntrar(driver).Click();
                    Thread.Sleep(2000);
                }

                if (objLogin.DivMenuAdmim(driver).Displayed)
                {
                    resultado = true;
                }
                else if (objLogin.FailLogin(driver).Displayed)
                {
                    resultado = false;
                    throw new Exception("No se inicio sesión correctamente");
                }
            }
            catch (Exception)
            {
                resultado = false;
                throw new Exception("No se encontraron los elementos necesarios para iniciar sesión");
            }

        }

        public void LoginFail(IWebDriver driver, string user, string password)
        {
            try
            {
                if (user.Trim().CompareTo(string.Empty) > 0)
                {
                    objLogin.InputUser(driver).SendKeys(user);
                }

                if (password.Trim().CompareTo(string.Empty) > 0)
                {
                    objLogin.InputPassword(driver).SendKeys(password);
                    objLogin.ButtonEntrar(driver).Click();
                    Thread.Sleep(2000);
                }

                if (objLogin.FailLogin(driver).Displayed)
                {
                    resultado = true;
                }
                else
                {
                    resultado = false;
                }
            }
            catch (Exception)
            {
                resultado = false;
                throw new Exception("No se encontraron los elementos necesarios para iniciar sesión");
            }

        }


        public bool DevolverResultado()
        {
            return resultado;
        }
    }
}
