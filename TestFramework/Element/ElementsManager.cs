using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Driver;

namespace TestFramework.Element
{
    public class ElementsManager : IManager
    {
        public ElementsManager(RemoteWebDriver _driver) : base(_driver) { }

        /// <summary>
        /// Espera o elemento aparecer na tela de acordo com o selector passado
        /// </summary>
        /// <param name="selector">O css selector do elemento em escopo</param>
        /// <param name="tempo">Tempo que irá ser esperado pelo elemento aparecer</param>
        public virtual void EsperarElementoPorSelector(string selector, int tempo)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(tempo)).Until(ExpectedConditions.ElementToBeClickable(By.CssSelector(selector)));
        }

        /// <summary>
        /// Espera o elemento aparecer na tela pelo conteúdo da tag HTML
        /// </summary>
        /// <param name="conteudo">Conteúdo para procurar dentro da tag</param>
        /// <param name="tempo">Tempo que irá ser esperado pelo elemento aparecer</param>
        public virtual void EsperarElementoPorConteudo(string conteudo, int tempo)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(tempo)).Until(x => x.FindElements(By.XPath("//*[contains(text(), \"" + conteudo + "\")]")).Count(field => field.Displayed) > 0);
        }

        /// <summary>
        /// Espera o elemento aparecer na tela pelo seu Id
        /// </summary>
        /// <param name="id">Id do elemento a ser procurado</param>
        /// <param name="tempo">Tempo que irá ser esperado pelo elemento aparecer</param>
        public virtual void EsperarElementoPorId(string id, int tempo)
        {
            new WebDriverWait(Driver, TimeSpan.FromSeconds(tempo)).Until(x => x.FindElements(By.Id(id)).Count(field => field.Displayed) > 0);
        }

        /// <summary>
        /// Clica no elemento especificado pelo Selector
        /// </summary>
        /// <param name="selector">O css selector do elemento em escopo</param>
        public virtual void ClicarElementoPorSelector(string selector)
        {
            Driver.FindElementByCssSelector(selector).Click();
        }

        /// <summary>
        /// Clica no link especificado pelo Texto dele
        /// </summary>
        /// <param name="texto">Texto do link para ser clicado</param>
        public virtual void ClicarLinkPorTexto(string texto)
        {
            Driver.FindElementByLinkText(texto).Click();
        }
    }
}
