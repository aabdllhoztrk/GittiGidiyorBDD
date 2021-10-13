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
        private HomePage _homePage;
       
        public HomeSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _homePage = new HomePage(_driver);
        }

        [Given(@"I lounch the Application")]
        public void GivenILounchTheApplication()
        {

            _homePage.NavigateToUrl();
            
        }

        [Then(@"I should see  page title")]
        public void ThenIShouldSeePageTitle()
        {
            
            _homePage.ValidatePageTittle();
        }


        [When(@"I have entered ""(.*)"" into SearchBox")]
        public void WhenIHaveEnteredİntoSearchBox(string p0)
        {
            _homePage.SearchforProduct("Samsung");
        }

        [Then(@"Labels related to ""(.*)"" are shown on the results page")]
        public void ThenLabelsRelatedToAreShownOnTheResultsPage(string p0)
        {
            _homePage.ValidatePoduct();
        }

        [When(@"I locate second page")]
        public void WhenILocateSecondPageAboutSamsung()
        {
            _homePage.LocateSecondPage();
        }

        [Then(@"I should know second page is shown")]
        public void ThenIShouldKnowSecondPageİsShown()
        {
            _homePage.VallidateSecondPage();
        }

        [When(@"I add third product to Cart")]
        public void WhenIAddThirdProductToCart()
        {
            _homePage.AddtoCard();
        }

        [When(@"I click Cart Button")]
        public void WhenIClickCartButton()
        {
            _homePage.LocateCartPage();
        }


    }
}
