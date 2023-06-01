using LearnWithPride.PageObject;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Xml.Linq;
using TechTalk.SpecFlow;

namespace LearnWithPride.StepDefinitions
{
    [Binding]
    public class RegistrationFormStepDefinitions
    {
        RegistrationForm registrationForm;
        
        public RegistrationFormStepDefinitions()
        {
            registrationForm = new RegistrationForm();
        }

        public IWebElement element;
      

        [Given(@"a user navigates to the website")]
        public void GivenAUserNavigatesToTheWebsite()
        {
            registrationForm.NavigateToWebsite();
        }

        [Given(@"user enters First name")]
        public void GivenUserEntersFirstName()
        {
            registrationForm.EnterFirstName();
        }

        [Given(@"user enters Last name")]
        public void GivenUserEntersLastName()
        {
            registrationForm.EnterLastName();
        }

        [Given(@"user enters Address")]
        public void GivenUserEntersAddress()
        {
            registrationForm.EnterAddress();
        }

        [Given(@"user enters Email address")]
        public void GivenUserEntersEmailAddress()
        {
            registrationForm.EnterEmailAddress();
        }

        [Given(@"user enters Phone number")]
        public void GivenUserEntersPhoneNumber()
        {
            registrationForm.EnterPhoneNumber();
        }

        [Given(@"user ticks Gender")]
        public void GivenUserTicksGender()
        {
            registrationForm.TicksGender();
        }

        [Given(@"user ticks Hobbies")]
        public void GivenUserTicksHobbies()
        {
            registrationForm.TicksHobbies();
        }

        [Given(@"user selects Language")]
        public void GivenUserSelectsLanguage()
        {
            registrationForm.SelectLanguages();
        }

        [Given(@"user selects Skills")]
        public void GivenUserSelectsSkills()
        {
            registrationForm.SelectSkills();
        }

        [Given(@"user selects Country")]
        public void GivenUserSelectsCountry()
        {
            registrationForm.SelectCountry();
        }

        [Given(@"user selects Year of birth")]
        public void GivenUserSelectsYearOfBirth()
        {
            registrationForm.SelectYearOfBirth();
        }

        [Given(@"user selects Month of birth")]
        public void GivenUserSelectsMonthOfBirth()
        {
            registrationForm.SelectMonthOfBirth();
        }

        [Given(@"user selects Day of birth")]
        public void GivenUserSelectsDayOfBirth()
        {
            registrationForm.SelectDayOfBirth();
        }

        [Given(@"user enters Password")]
        public void GivenUserEntersPassword()
        {
            registrationForm.EnterPassword();
        }

        [Given(@"user enters Confirm Password")]
        public void GivenUserEntersConfirmPassword()
        {
            registrationForm.EnterConfirmPassword();
        }

        [When(@"user clicks the Submit button")]
        public void WhenUserClicksTheSubmitButton()
        {
            registrationForm.ClickOnSubmit();
        }

        [Then(@"user is registered successfully")]
        public void ThenUserIsRegisteredSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
