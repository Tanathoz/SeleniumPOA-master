using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
namespace SeleniumPractice
{
    enum PropiertyType{
        Id,
        Name,
        Xpath,
        LinkText,
        ClassName,

    }
    class PropiertiesCollection
    {
        public static  IWebDriver driver { get; set; }
    }
}
