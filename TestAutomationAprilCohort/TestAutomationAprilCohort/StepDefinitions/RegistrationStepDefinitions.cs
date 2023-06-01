using NUnit.Framework;
using TestAutomationAprilCohort.PageObject;

namespace TestAutomationAprilCohort.StepDefinitions
{
    [Binding]
    public class RegistrationStepDefinitions
    {

        RegistrationPage registrationPage;

        public RegistrationStepDefinitions()
        {
            registrationPage = new RegistrationPage();
        }


        [Given(@"a user launches the website")]
        public void GivenAUserLaunchesTheWebsite()
        {
            registrationPage.NavigateToWebsite();
        }

        [Given(@"clicks on Signup")]
        public void GivenClicksOnSignup()
        {
            registrationPage.ClickOnSignup();
        }

        [Given(@"enters username")]
        public void GivenEntersUsername()
        {
            registrationPage.EnterUsername();
        }

        [Given(@"enters email")]
        public void GivenEntersEmail()
        {
            registrationPage.EnterEmail();
        }

        [Given(@"enters password")]
        public void GivenEntersPassword()
        {
            registrationPage.EnterPassword();
        }

        [When(@"user clicks Sign up button")]
        public void WhenUserClicksSignUpButton()
        {
            registrationPage.ClickOnSignUpButton();
        }

        [Then(@"user should be registered successfully")]
        public void ThenUserShouldBeRegisteredSuccessfully()
        {
            Thread.Sleep(5000);     //wait time
            Assert.That(registrationPage.IsNewArticleDisplayed);

        }
        

    }
}
