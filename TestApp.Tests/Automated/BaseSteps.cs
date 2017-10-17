using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestFramework.Driver;

namespace TestApp.Tests.Automated
{
    [Binding]
    public class BaseSteps
    {
        public DriverManager DriverManager { get; set; }
        protected OpenQA.Selenium.Remote.RemoteWebDriver Driver { get { return DriverManager != null ? DriverManager.Driver : null; } }

        [BeforeScenario]
        public void StartDriver()
        {
            DriverManager = new DriverManager();
        }

        [AfterScenario]
        public void KillDriver()
        {
            DriverManager.CloseDriver();
            DriverManager = null;
        }
    }
}
