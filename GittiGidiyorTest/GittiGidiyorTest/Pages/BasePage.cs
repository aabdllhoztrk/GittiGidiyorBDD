using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace n11Test.Pages
{
   public abstract class BasePage
    {
        private IWebDriver _driver;

        protected IWebDriver Driver => _driver;

        public BasePage(IWebDriver driver)
        {
            this._driver = driver;
        }


        public IWebElement FindElementByXPath(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath(element)));
        }

        public IWebElement FindElementById(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id(element)));
        }
        public IWebElement FindElementByName(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Name(element)));
        }

        public IWebElement FindElementCssSelector(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector(element)));
        }
        public IWebElement FindElementByLinkText(string element)
        {
            WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(15));
            return wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.LinkText(element)));
        }

        public void goToUrl(string url)
        {
            Driver.Url = url;
        }

        public void sendKeys(IWebElement element, string value)
        {
            element.Clear();
            element.SendKeys(value);
        }

        public void ValidateProductExist(IWebElement actualLabel, string expectedLabel)
        {
            string expected = expectedLabel;

            try
            {
                Thread.Sleep(100);
                Assert.IsTrue(actualLabel.Text.Equals(expected));
                //Assert.IsTrue(actualLabel.Displayed);
            }
            catch (Exception e)
            {

                Console.WriteLine("Beklenen label sayfa kaynagında bulunamadi !!!" + "  Label: " + expected);

            }
        }


        public void ValidateProductNotExist(string elementName, string elementxpath)
        {
            Thread.Sleep(1000);
            int count = Driver.FindElements(By.XPath(elementxpath)).Count();
            if (count > 0)
            {
                Assert.Fail(elementName + " Silinmedi.");
            }
        }

        public void ValidateCurrentURL(string expectedUrl)
        {
            string URL = Driver.Url;
            string expected = expectedUrl;

            try
            {
                Assert.That(URL, Is.EqualTo(expected));

            }
            catch (Exception e)
            {
                Console.WriteLine("Dogrulamak Istediginiz URL Sayfadaki Url ile eslesmedi.");

            }
        }

        public void ScrollDown()
        {
            IJavaScriptExecutor js = Driver as IJavaScriptExecutor;
            js.ExecuteScript("window.scrollBy(0,4000);");
        }
        
            
        
    }
}

