using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAutomationAprilCohort.Utilities;

namespace TestAutomationAprilCohort.PageObject
{
    class DataDrivenWithParameter
    {
        public DataDrivenWithParameter()
        {
            driver = Hooks1.driver;

        }
        IWebDriver driver;
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));
        IWebElement Email => driver.FindElement(By.CssSelector("body > div > div > div > div > div > div > form > fieldset > fieldset:nth-child(2) > input"));
        IWebElement Password => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[3]/input"));





        public void EnterUsername(string username) //The username written here is different from the one below and you can use anything to denote the item string just like an alias
        {
            Username.SendKeys(username);

        }
        public void EnterEmail(string email )
        {
            Email.SendKeys(email);

        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }


        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }












        }
}
