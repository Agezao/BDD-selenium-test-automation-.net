using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFramework.Driver;

namespace TestFramework.Cinematics
{
    public class CinematicManager : IManager
    {
        public CinematicManager(RemoteWebDriver _driver) : base(_driver) {}

        public virtual void SalvarImagem(string nomeImagem, string caminho) {
            Screenshot ss = ((ITakesScreenshot)Driver).GetScreenshot();
            var dir = System.IO.Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName;
            dir = dir + "\\" + caminho;
            System.IO.Directory.CreateDirectory(dir);
            dir += nomeImagem;
            ss.SaveAsFile(dir, ScreenshotImageFormat.Jpeg);
        }
    }
}
