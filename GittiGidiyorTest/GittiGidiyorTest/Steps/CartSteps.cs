using n11Test.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace n11Test.Steps
{
    [Binding]
    public sealed class CartSteps
    {

        private readonly IWebDriver _driver;
        private CartPage _cartPage;
        public CartSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
            _cartPage = new CartPage(_driver);
        }

        [Then(@"I should see third product is shown")]
        public void ThenIShouldSeeThirdProductİsShown()
        {
            Assert.That(_cartPage.ValidateProductinCart(), Is.True);
        }
        
        [Then(@"I remove product")]
        public void ThenIRemoveProduct()
        {
            _cartPage.RemoveProduct();
            
        }

        [Then(@"I validate product not exist in cart")]
        public void ThenIValidateProductNotExistİnCart()
        {
            _cartPage.ValidateProductnotAppear();
        }


    }
}
