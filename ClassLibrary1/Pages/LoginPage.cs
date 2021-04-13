using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace ClassLibrary1
{
    public class LoginPage
    {
        //locate username element
        [FindsBy(How = How.Name, Using = "email")]
        private IWebElement userName;

        //locate password element
        [FindsBy(How = How.Name, Using = "password")]
        private IWebElement passWord;

        //locate login button
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/div[1]/div/div[4]/button")]
        private IWebElement loginButton;

        //pass parameters and sendkeys
        public void EnterInformation(string username, string password)
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("email")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")));
            userName.Click();
            userName.SendKeys(username);
            passWord.Click();
            passWord.SendKeys(password);
            loginButton.Click();

        }

  
    }
}
