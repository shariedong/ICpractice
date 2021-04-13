using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace ClassLibrary1
{
    public class Browser
    {
        static IWebDriver webdriver = new FirefoxDriver();
        public static string Title
        {
            get
            {
                return webdriver.Title;
            }
        }

        public static ISearchContext Driver
        {
            get
            {
                return webdriver;
            }
        }

        public static IWebDriver Driver2
        {
            get
            {
                return webdriver;
            }
        }

        public static void Goto(String url)
        {
            webdriver.Url = url;
        }

        public static void close()
        {
            webdriver.Quit();
        }

    

    




    }
}
