using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
namespace SeleniumPractice
{
    class SeleniumGetMethods
    {
        public static string GetText (IWebElement element)
        {
               return element.GetAttribute("value");
        }

        public static string GetTextFromDDL( IWebElement element, PropiertyType elementtype) {
            
                return new SelectElement(element).AllSelectedOptions.SingleOrDefault().Text;           
        }
    }
}
