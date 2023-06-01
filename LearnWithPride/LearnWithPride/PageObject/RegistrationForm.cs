using LearnWithPride.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Xml.Linq;
using AngleSharp.Dom;
using TechTalk.SpecFlow.Configuration.JsonConfig;

namespace LearnWithPride.PageObject
{
    internal class RegistrationForm
    {
        public RegistrationForm() 

        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

       

        IWebElement FirstName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(2) > input"));
        IWebElement LastName => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(1) > div:nth-child(3) > input"));
        IWebElement Address => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(2) > div > textarea"));
        IWebElement EmailAddress => driver.FindElement(By.CssSelector("#eid > input"));
        IWebElement PhoneNumber => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(4) > div > input"));
        IWebElement Gender => driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[5]/div/label[2]/input"));
        IWebElement Hobbies => driver.FindElement(By.XPath("//*[@id=\"checkbox2\"]"));

        IWebElement Language => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(7) > div > multi-select > div:nth-child(2) > ul > li:nth-child(8) > a"));



        //IWebElement Languages => driver.FindElement(By.CssSelector("#msdd"));

        //IWebElement Skills => driver.FindElement(By.XPath("//*[@id=\"Skills\"]"));


        // Locate the dropdown element
        //IWebElement dropdown = driver.FindElement(By.Id("dropdownId"));

        // Create a SelectElement object to work with the dropdown


        // Select an item from the dropdown by its value, text, or index
        //select.SelectByValue("optionValue");
        // or select.SelectByText("Option Text");
        // or select.SelectByIndex(2);
        //SelectElement Language => (SelectElement)driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(7) > div > multi-select > div:nth-child(2) > ul > li:nth-child(8) > a"));

        SelectElement Skills => (SelectElement)driver.FindElement(By.XPath("//*[@id=\"Skills\"]"));
        SelectElement Country => (SelectElement)driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[10]/div/span/span[1]/span"));
        SelectElement YearOfBirth => (SelectElement)driver.FindElement(By.XPath("//*[@id=\"yearbox\"]"));
        SelectElement MonthOfBirth => (SelectElement)driver.FindElement(By.XPath("//*[@id=\"basicBootstrapForm\"]/div[11]/div[2]/select"));
        SelectElement DayOfBirth => (SelectElement)driver.FindElement(By.XPath("//*[@id=\"daybox\"]"));

        //IWebElement Country => driver.FindElement(By.XPath("//*[@id=\"countries\"]"));
        //IWebElement SelectCountry => driver.FindElement(By.CssSelector("#countries"));
        //IWebElement Year => driver.FindElement(By.CssSelector("#yearbox"));
        //IWebElement Month => driver.FindElement(By.CssSelector("#basicBootstrapForm > div:nth-child(11) > div:nth-child(3) > select"));
        //IWebElement Day => driver.FindElement(By.CssSelector("#daybox"));
        IWebElement Password => driver.FindElement(By.CssSelector("#firstpassword"));
        IWebElement ConfirmPassword => driver.FindElement(By.CssSelector("#secondpassword"));
        IWebElement Submit => driver.FindElement(By.CssSelector("#submitbtn"));


        //Methods

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://demo.automationtesting.in/Register.html");
        }
        public void EnterFirstName()
        {
            FirstName.SendKeys("mayowa");
        }
        public void EnterLastName()
        {
            LastName.SendKeys("tade");
        }
        public void EnterEmailAddress()
        {
            EmailAddress.SendKeys("bisi@gmail.com");
        }
        public void EnterAddress()
        {
            Address.SendKeys("lagos");
        }
        public void EnterPhoneNumber()
        {
            PhoneNumber.SendKeys("08023423466");
        }

        public void TicksGender()
        {
            Gender.Click();
        }

        public void TicksHobbies()
        {
            Hobbies.Click();
        }
        public void SelectLanguages()
        {
            selectElement.SelectByText("Option 1");

        }

        public void SelectSkills()
        {
            Skills.SelectByText("Configuration");

        }
        public void SelectCountry()
        {
            Country.SelectByText("Denmark");

        }
        public void SelectYearOfBirth()
        {
            YearOfBirth.SelectByText("1924");

        }
        public void SelectMonthOfBirth()
        {
            MonthOfBirth.SelectByText("March");

        }
        public void SelectDayOfBirth()
        {
            DayOfBirth.SelectByText("19");

        }
        public void EnterPassword()
        {
            Password.SendKeys("testing");
        }

        public void EnterConfirmPassword()
        {
            ConfirmPassword.SendKeys("testing");
        }
        public void ClickOnSubmit()
        {
            Submit.Click();
        }

            









    }
}
