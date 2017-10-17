using System;
using TechTalk.SpecFlow;
using TestFramework.Driver;
using TestFramework.Navigation;
using TestFramework.Element;
using TestFramework.Cinematics;

namespace TestApp.Tests.Automated
{
    [Binding]
    public class AcessarPaginaSteps : BaseSteps
    {
        [Given(@"que eu estou na home do site")]
        public void DadoQueEuEstouNaHomeDoSite()
        {
            new NavigationManager(Driver).NavegarParaLink("http://localhost:43244/");
        }

        [Then(@"eu irei visualizar o texto ""(.*)""")]
        public void EntaoEuIreiVisualizarOTexto(string p0)
        {
            new Overrides.ElementsManager(Driver).EsperarElementoPorConteudo(p0, 120);
        }

        [Then(@"Salvar evidência ""(.*)"" em ""(.*)""")]
        public void EntaoSalvarEvidenciaEm(string p0, string p1)
        {
            new CinematicManager(Driver).SalvarImagem(p0, p1);
        }
        
        [Then(@"eu irei clicar no link ""(.*)""")]
        public void EntaoEuIreiClicarNoLink(string p0)
        {
            new ElementsManager(Driver).ClicarLinkPorTexto(p0);
        }
    }
}
