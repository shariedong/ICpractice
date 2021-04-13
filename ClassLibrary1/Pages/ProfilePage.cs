using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class ProfilePage
    {
        //locate products Description edit button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")]
        private IWebElement descriptionEditBtn;

        [FindsBy(How = How.Name, Using = "value")]
        private IWebElement descriptionInputBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/form/div/div/div[2]/button")]
        private IWebElement descriptionSaveButton;

        //locate the pop up notification
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]")]
        private IWebElement popUpNotification;


        //locate add new languages button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")]
        private IWebElement addNewLanguageBtn;
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")]
        private IWebElement languageInputBox;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select")]
        private IWebElement languageLevelBtn;

        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]")]
        private IWebElement languageAddSideByBtn;


        //locate add new availibility button
        [FindsBy(How = How.XPath, Using = "/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")]
        private IWebElement editAvailibilityBtn;

        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement availibiltyMenu;



        public void EditDescriptionMethod()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/div/div/div/h3/span/i")));
            descriptionEditBtn.Click();

            wait.Until(ExpectedConditions.ElementIsVisible(By.Name("value")));
            descriptionInputBox.SendKeys("This is my test description");
            descriptionSaveButton.Click();

        }

        public void EditLanguageMethod()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div")));
            addNewLanguageBtn.Click();
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[1]/input")));
            languageInputBox.SendKeys("Testlanguage");

            languageLevelBtn.Click();
            SelectElement select = new SelectElement(languageLevelBtn);
            select.SelectByIndex(1);
            languageAddSideByBtn.Click();


        }

        public void EditAvalibility()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]/div/section[2]/div/div/div/div[2]/div/div/div/div/div/div[3]/div/div[2]/div/span/i")));
            editAvailibilityBtn.Click();
            SelectElement select = new SelectElement(availibiltyMenu);
            select.SelectByIndex(1);
        }

        public string ReadPopUpMessage()
        {
            WebDriverWait wait = new WebDriverWait(Browser.Driver2, new TimeSpan(0, 0, 5));
            wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("/html/body/div[1]")));
            
            return popUpNotification.Text;
        }
    }
}
