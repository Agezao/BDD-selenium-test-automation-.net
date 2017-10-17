using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Tests.Automated.Overrides
{
    public class ElementsManager : TestFramework.Element.ElementsManager
    {
        public ElementsManager(RemoteWebDriver _driver) : base(_driver) {}

        public override void EsperarElementoPorConteudo(string conteudo, int tempo)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(tempo)).Until(x => x.FindElements(By.XPath("//*[contains(text(), \"" + conteudo + "\")]")).Count(field => field.Displayed) > 0);
        }
    }
}
