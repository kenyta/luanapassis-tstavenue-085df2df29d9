using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Chrome;
using TaskAppTests.Util;

namespace TaskAppTests.Pages
{
    public class LoginPage : Driver
    {
        public LoginPage()
        {
            PageFactory.InitElements(Instance, this);
        }
        

        [FindsBy(How = How.Id, Using = "user_email")]
        private IWebElement UserEmail { get; set; }

        [FindsBy(How = How.Id, Using = "user_password")]
        private IWebElement UserPassword { get; set; }

        [FindsBy(How = How.Name, Using = "commit")]
        private IWebElement SignIn { get; set; }


        public void Submit(string username, string password)
        {
            UserEmail.SendKeys(username);
            UserPassword.SendKeys(password);
            SignIn.Click();
        }


    }
}
