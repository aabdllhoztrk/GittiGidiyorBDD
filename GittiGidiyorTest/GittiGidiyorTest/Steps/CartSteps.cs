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
        public CartSteps()
        {
            _driver = ScenarioContext.Current.Get<IWebDriver>("currentDriver");
        }

        [Then(@"I should see third product is shown")]
        public void ThenIShouldSeeThirdProductİsShown()
        {
            CartPage cartPage = new CartPage(_driver);
            Assert.That(cartPage.ValidateProductinCart(), Is.True);
        }
        
        [Then(@"I remove product")]
        public void ThenIRemoveProduct()
        {
            CartPage cartPage = new CartPage(_driver);
            cartPage.RemoveProduct();
            
        }

        [Then(@"I validate product not exist in cart")]
        public void ThenIValidateProductNotExistİnCart()
        {
            CartPage cartPage = new CartPage(_driver);
            cartPage.ValidateProductnotAppear();
        }


    }
}
