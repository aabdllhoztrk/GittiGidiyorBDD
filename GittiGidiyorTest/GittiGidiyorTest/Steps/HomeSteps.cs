using n11Test.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace n11Test.Steps
{
    [Binding]
    public sealed class HomeSteps
    {

        private readonly IWebDriver _driver;
       
        public HomeSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Given(@"I lounch the Application")]
        public void GivenILounchTheApplication()
        {

            HomePage homePage = new HomePage(_driver);
            homePage.NavigateToUrl();
            
        }

        [Then(@"I should see  page title")]
        public void ThenIShouldSeePageTitle()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.ValidatePageTittle();
        }


        [When(@"I have entered ""(.*)"" into SearchBox")]
        public void WhenIHaveEnteredİntoSearchBox(string p0)
        {
            HomePage homePage = new HomePage(_driver);
            homePage.SearchforProduct("Samsung");
        }

        [Then(@"Labels related to ""(.*)"" are shown on the results page")]
        public void ThenLabelsRelatedToAreShownOnTheResultsPage(string p0)
        {
            HomePage homePage = new HomePage(_driver);
            homePage.ValidatePoduct();
        }

        [When(@"I locate second page")]
        public void WhenILocateSecondPageAboutSamsung()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.LocateSecondPage();
        }

        [Then(@"I should know second page is shown")]
        public void ThenIShouldKnowSecondPageİsShown()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.VallidateSecondPage();
        }

        [When(@"I add third product to Cart")]
        public void WhenIAddThirdProductToCart()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.AddtoCard();
        }

        [When(@"I click Cart Button")]
        public void WhenIClickCartButton()
        {
            HomePage homePage = new HomePage(_driver);
            homePage.LocateCartPage();
        }


    }
}
