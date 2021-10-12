using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace n11Test.Pages
{
    public class HomePage : BasePage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }
        /// <summary>
        /// Elements for Home Page
        /// </summary>
        public IWebElement txt_Search => FindElementByXPath("//input[@placeholder='Keşfetmeye Bak']");
        public IWebElement btn_Search => FindElementByXPath("//span[text()='BUL']");
        public IWebElement validate_Product => FindElementByXPath("//span[text()='Sponsorlu']");
        public IWebElement secondPage => FindElementByXPath("//a[@title='2. sayfa']");
        public IWebElement third_product => FindElementByXPath("(//DIV[@class='sc-533kbx-0 sc-1v2q8t1-0 iCRwxx ixSZpI sc-1n49x8z-12 bhlHZl'])[3]");
        public IWebElement btn_add_to_Cart => FindElementById("add-to-basket");
        public IWebElement btn_MyCard => FindElementByXPath("(//A[@href='https://www.gittigidiyor.com/sepetim'])[1]");



        public void NavigateToUrl() => goToUrl("http://www.gittigidiyor.com/");

        public void ValidatePageTittle() 
        {
            String expectedTitle = "GittiGidiyor - Türkiye'nin Öncü Alışveriş Sitesi";
            String actualTitle = Driver.Title;
            Assert.AreEqual(actualTitle, expectedTitle);
        }

        public void SearchforProduct(string productName) 
        {
            sendKeys(txt_Search, productName);
            btn_Search.Click();
            
        }
        public void ValidatePoduct() 
        {
            ScrollDown();
            ValidateProductExist(validate_Product, "Sponsorlu");
        }
        public void LocateSecondPage() 
        {
            ScrollDown();
            secondPage.Click();
            
        }
        public void VallidateSecondPage()
        {
            ScrollDown();
            secondPage.Click();
            ValidateCurrentURL("https://www.gittigidiyor.com/arama/?k=Samsung&sf=2");
        }

        public void AddtoCard() 
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,400);");
            third_product.Click();
            IJavaScriptExecutor js1 = Driver as IJavaScriptExecutor;
            js1.ExecuteScript("window.scrollBy(0,800);");
            btn_add_to_Cart.Click();
            Thread.Sleep(2000);
            Driver.Navigate().Refresh();
        }
        public CartPage LocateCartPage() 
        {
            Thread.Sleep(8000);
            btn_MyCard.Click();
            return new CartPage(Driver);
        }
    }
}
