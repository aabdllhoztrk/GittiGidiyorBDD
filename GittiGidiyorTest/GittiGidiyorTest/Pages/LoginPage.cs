using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace n11Test.Pages
{
    public class LoginPage : BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver)
        {
        }

        public IWebElement txt_Mail => FindElementByName("kullanici");
        public IWebElement txt_Password => FindElementByName("sifre");
        public IWebElement btn_GirisYap => FindElementByXPath("//INPUT[@id='gg-login-enter']");


        public void Login(string mail, string password)
        {
            sendKeys(txt_Mail, mail);
            sendKeys(txt_Password, password);
            Thread.Sleep(5000);
            btn_GirisYap.Click();
            Thread.Sleep(5000);
        }
    }
}
