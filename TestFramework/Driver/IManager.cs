using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Driver
{
    public abstract class IManager
    {
        public RemoteWebDriver Driver { get; set; }

        public IManager(RemoteWebDriver _driver)
        {
            Driver = _driver;
        }
    }
}
