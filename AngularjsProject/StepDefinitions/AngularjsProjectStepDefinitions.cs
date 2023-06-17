using AngularjsProject.PageObject;
using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace AngularjsProject.StepDefinitions
{
    [Binding]
    public class AngularjsProjectStepDefinitions
    {
        AngularjsProjectPage angularjsProjectPage;

        public AngularjsProjectStepDefinitions()
        {
            angularjsProjectPage= new AngularjsProjectPage();   
        }


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            angularjsProjectPage.NavigateToWebsite();
        }

        [Given(@"I click on the SignUp")]
        public void GivenIClickOnTheSignUp()
        {
            angularjsProjectPage.ClickOnSignUp();
        }

        [Given(@"I enter Username")]
        public void GivenIEnterUsername()
        {
            angularjsProjectPage.EnterUsername();
        }

        [Given(@"I enter Email")]
        public void GivenIEnterEmail()
        {
            angularjsProjectPage.EnterEmail();
        }

        [Given(@"I enter Password")]
        public void GivenIEnterPassword()
        {
            angularjsProjectPage.EnterPassword();
        }

        [When(@"I click on SignUp button")]
        public void WhenIClickOnSignUpButton()
        {
            angularjsProjectPage.ClickOnSignUpButton();
        }

        [Then(@"I should be able to register successfully")]
        public void ThenIShouldBeAbleToRegisterSuccessfully()
        {
            Thread.Sleep(5000);
            Assert.That(angularjsProjectPage.IsSettingsDisplayed);
        }
    }
}
