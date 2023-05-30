using BoDi;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestProject1.src.code.session;

namespace TestProject1.src.Hooks
{
    [Binding]
    public class Hooks
    {
        
        private readonly IObjectContainer _container;

        public Hooks(IObjectContainer container)
        {
            _container = container;
        }

        [BeforeScenario("@createProject")]
        public void BeforeScenarioWithTag()
        {
            Console.WriteLine("Running inside tagged hooks in Specflow");
        }

        [BeforeScenario(Order = 1)]
        public void FirstBeforeScenario()
        {
            Session.Instance().GetBrowser().Navigate().GoToUrl("http://todo.ly/");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Session.Instance().CloseBrowser();

        }
    }
}
