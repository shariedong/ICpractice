using ClassLibrary1.Models;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace ClassLibrary1.Steps
{
    [Binding]
    public class AddProfileFeatureSteps
    {
        [Given(@"I have logged in")]
        public void GivenIHaveLoggedIn(Table table)
        {
            Pages.Homepage.GoTo();
            Pages.Homepage.SelcetLogin();
            //create a instance 
            var user = table.CreateInstance<Products>();
            Pages.LoginPage.EnterInformation(user.name, user.password);
        }
        
        [When(@"I edit my description")]
        public void WhenIEditMyDescription()
        {
            Pages.ProfilePage.EditDescriptionMethod();
        }
        
        [When(@"I add new language")]
        public void WhenIAddNewLanguage()
        {
            Pages.ProfilePage.EditLanguageMethod();
        }
        
        [When(@"I add new availinility")]
        public void WhenIAddNewAvailinility()
        {
            Pages.ProfilePage.EditAvalibility();
        }
        
        [Then(@"I can see the pop up notification with Description has been saved successfully")]
        public void ThenICanSeeThePopUpNotificationWithDescriptionHasBeenSavedSuccessfully()
        {
            Assert.AreEqual(Pages.ProfilePage.ReadPopUpMessage(), "Description has been saved successfully");

        }
        
        [Then(@"I can see the pop up notification with (.*) has been added to your languages")]
        public void ThenICanSeeThePopUpNotificationWithHasBeenAddedToYourLanguages(string p0)
        {
            Assert.AreEqual(Pages.ProfilePage.ReadPopUpMessage(), "Testlanguage has been added to your languages");
        }
        
        [Then(@"I can see the pop up notification with Availability updated")]
        public void ThenICanSeeThePopUpNotificationWithAvailabilityUpdated()
        {
            Assert.AreEqual(Pages.ProfilePage.ReadPopUpMessage(), "Availability updated");
        }
    }
}
