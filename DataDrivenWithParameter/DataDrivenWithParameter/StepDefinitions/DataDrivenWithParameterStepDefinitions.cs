using System;
using TechTalk.SpecFlow;

namespace DataDrivenWithParameter.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        [Given(@"a user launches the website ""([^""]*)""")]
        public void GivenAUserLaunchesTheWebsite(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"clicks on Signup")]
        public void GivenClicksOnSignup()
        {
            throw new PendingStepException();
        }

        [Given(@"enters username ""([^""]*)""")]
        public void GivenEntersUsername(string bambo)
        {
            throw new PendingStepException();
        }

        [Given(@"enters email ""([^""]*)""")]
        public void GivenEntersEmail(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"enters password ""([^""]*)""")]
        public void GivenEntersPassword(string yinus)
        {
            throw new PendingStepException();
        }

        [When(@"user clicks Sign up button")]
        public void WhenUserClicksSignUpButton()
        {
            throw new PendingStepException();
        }

        [Then(@"user should be registered successfully")]
        public void ThenUserShouldBeRegisteredSuccessfully()
        {
            throw new PendingStepException();
        }
    }
}
