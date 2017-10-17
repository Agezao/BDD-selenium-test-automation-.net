using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework.Driver
{
    public class DriverManager
    {
        public RemoteWebDriver Driver { get { return _driver; } }
        private RemoteWebDriver _driver { get; set; }
        public string Browser{ get; set; }
        public string BrowserPath { get; set; }

        public DriverManager() {
            Browser = "";
            GetDriver();
        }
        public DriverManager(string _browser, string _browserPath) {
            Browser = _browser;
            BrowserPath = _browserPath;
            GetDriver();
        }

        public RemoteWebDriver GetDriver() {
            if (_driver == null)
            {
                switch (Browser.ToLower()) {
                    case "firefox":
                        GetFirefoxDriver();
                        break;
                    case "chrome":
                        GetChromeDriver();
                        break;
                    default:
                        GetChromeDriver();
                        break;
                }
            }

            _driver.Manage().Window.Maximize();

            return _driver;
        }

        private void GetFirefoxDriver() {
            if (BrowserPath != null)
            {
                FirefoxOptions options = new FirefoxOptions { BrowserExecutableLocation = BrowserPath };
                _driver = new FirefoxDriver(options);
            }
            else
                _driver = new FirefoxDriver();
        }

        private void GetChromeDriver() {
            if (BrowserPath != null)
            {
                ChromeOptions options = new ChromeOptions { BinaryLocation = BrowserPath };
                _driver = new ChromeDriver(options);
            }
            else
                _driver = new ChromeDriver();
        }

        public void CloseDriver()
        {
            Driver.Close();
            _driver = null;
        }
    }
}
