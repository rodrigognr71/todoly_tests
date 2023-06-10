using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject1.src.code.factoryBrowser
{
    public class Chrome : IBrowser
    {
        public IWebDriver Create()
        {           
            Console.WriteLine("setup");
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            IWebDriver driver = new ChromeDriver(path + "resources/driver");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            return driver;

        }
    }
}
