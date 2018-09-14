using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace TaskAppTests.Util
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static string BaseUrl
        {
            get { return ConstantUtils.url; }
        }
        public static void initialize()
        {
            Instance = new ChromeDriver();
            wait();
            Instance.Manage().Window.Maximize();

        }

        public static void navigate()
        {
            Instance.Navigate().GoToUrl(BaseUrl);

        }
        public static void close()
        {
            Instance.Quit();

        }
        public static void wait()
        {
            new WebDriverWait(Instance, TimeSpan.FromSeconds(10000000));

        }
    }
}
