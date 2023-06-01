using OpenQA.Selenium;
using TestAutomationAprilCohort.Utilities;

namespace TestAutomationAprilCohort.PageObject
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;

        }
        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(2) > li:nth-child(3) > a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));

        IWebElement SignUpButton => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/button"));

        IWebElement NewArticle => driver.FindElement(By.CssSelector("body > div > app-header > nav > div > ul:nth-child(3) > li:nth-child(2) > a"));
    public void ClickOnSignup()
    {
        SignUp.Click();
    }
          

    public void EnterUsername()
    {
        Username.SendKeys("sinzu");

    }
    public void EnterEmail()
    {
        Email.SendKeys("mayur@hotmail.com");

    }

    public void EnterPassword()
    {
        Password.SendKeys("teing");
    }

    public void ClickOnSignUpButton()
    {
            SignUpButton.Click();
    }

    public bool IsNewArticleDisplayed()
        {
            return NewArticle.Displayed;
        }
   



        public void NavigateToWebsite()
    {
        driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
    }


}
    }
