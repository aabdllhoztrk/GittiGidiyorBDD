using n11Test.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace n11Test.Steps
{
    [Binding]
    public sealed class LoginSteps
    {

        private readonly IWebDriver _driver;
        public LoginSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }


        [Then(@"I enter the fallowing detail")]
        public void ThenIEnterTheFallowingDetail(Table table)
        {
            LoginPage loginPage = new LoginPage(_driver);
            dynamic data = table.CreateDynamicInstance();
            loginPage.Login((string)data.Mail, (string)data.Password);
            
        }

    }
}
