using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace TaskAppTests.Util
{
    public class ImplicityWait
    {
        public static void waitForElementPresent(IWebElement element, int seconds)
        {
            new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(seconds)).Until(ExpectedConditions.ElementToBeClickable(element));

        }
    }
}
