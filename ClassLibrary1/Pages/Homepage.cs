using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    public class Homepage
    {
        static string Url = "http://localhost:5000";
        //locate login web element
        [FindsBy(How = How.LinkText, Using = "Sign In")]
        private IWebElement Login;

        //locate loadmore web element
        //[FindsBy(How = How.XPath, Using = "/html/body/div[1]/section[2]/div/div[4]/a")]
        //private IWebElement LoadMore;

        //define login function
        public void SelcetLogin()
        {

            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText("Sign In")));
            Login.Click();
        }
        //define  loadmore function
        

        public void GoTo()
        {
            Browser.Goto(Url);
        } 


    }
}
