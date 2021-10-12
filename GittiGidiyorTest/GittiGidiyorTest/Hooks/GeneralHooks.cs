using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace n11Test.Hooks
{
    [Binding]
    public sealed class GeneralHooks
    {

        public IWebDriver _driver;

        [BeforeScenario]        
        public void BeforeScenario()
        {
            var options = new ChromeOptions();
            options.AddArguments("test-type");
            options.AddArgument("disable-web-security");
            options.AddArgument("allow-running-insecure-content");           
            options.AddExcludedArgument("enable-automation");
            options.AddArgument("disable-popup-blocking");
            options.AddArgument("disable-notifications");          
            options.AddArgument("--start-maximized");
            _driver = new ChromeDriver(options);                   
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(10);
            ScenarioContext.Current.Add("currentDriver", _driver);
        }

        [AfterScenario]
        public void AfterScenario()
        {
            _driver.Quit();
        }
    }
}
