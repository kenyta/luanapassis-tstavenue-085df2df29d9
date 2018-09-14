using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using TechTalk.SpecFlow;

namespace TaskAppTests.Util
{
    public class Start : Driver
    {

       
        [Before]
        public void setup()
        {
            Driver.initialize();
            Driver.Instance.Navigate().GoToUrl(Driver.BaseUrl);

           
        }
        [After]
        public void tearDown()
        {
            Driver.close();
        }
    }
}
