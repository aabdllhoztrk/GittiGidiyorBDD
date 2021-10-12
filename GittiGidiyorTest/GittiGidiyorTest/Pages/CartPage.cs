using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace n11Test.Pages
{
    public class CartPage : BasePage
    {
        public CartPage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        ///Elements For Cart Page
        /// </summary>
        public IWebElement validate_Product => FindElementByXPath("//h2[contains(text(),'Samsung')]");
        public IWebElement btn_Remove => FindElementByXPath("(//I[@class='gg-icon gg-icon-bin-medium'])[1]");


        public bool ValidateProductinCart() => validate_Product.Displayed;

        public void RemoveProduct() 
        {
            btn_Remove.Click();
            Thread.Sleep(8000);
        } 
        public void ValidateProductnotAppear() => ValidateProductNotExist("Samsung", "//h2[contains(text(),'Samsung')]");

    }
}
