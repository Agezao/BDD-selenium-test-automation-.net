using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Driver;

namespace TestFramework.Navigation
{
    public class NavigationManager : IManager
    {
        public NavigationManager(RemoteWebDriver _driver) : base(_driver) {}

        public virtual void NavegarParaLink(string link) {
            Driver.Navigate().GoToUrl(link);
        }
    }
}
