using System;
using TechTalk.SpecFlow;
using TestAutomationAprilCohort.PageObject;

namespace TestAutomationAprilCohort.StepDefinitions
{
    [Binding]
    public class DataDrivenWithParameterStepDefinitions
    {
        DataDrivenWithParameter dataDrivenWithParameter;

            public DataDrivenWithParameterStepDefinitions()
            {
                dataDrivenWithParameter = new DataDrivenWithParameter();
            }

        [Given(@"a user launches the website ""([^""]*)""")]
        public void GivenAUserLaunchesTheWebsite(string url)
        {
            dataDrivenWithParameter.NavigateToWebsite(url);
        }

        [Given(@"enters username ""([^""]*)""")]
        public void GivenEntersUsername(string username)//use the same thing as what you used in your page object
        {
            dataDrivenWithParameter.EnterUsername(username);
        }

        [Given(@"enters email ""([^""]*)""")]
        public void GivenEntersEmail(string email)
        {
            dataDrivenWithParameter.EnterEmail(email);
        }

        [Given(@"enters password ""([^""]*)""")]
        public void GivenEntersPassword(string password)
        {
            dataDrivenWithParameter.EnterPassword(password);
        }
    }
}
