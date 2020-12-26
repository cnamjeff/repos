using System;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium;

namespace ConsoleSelenium
{
    class Program
    {
        static void Main(string[] args)
        {
            InternetExplorerDriver service = new InternetExplorerDriver();
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.AddAdditionalInternetExplorerOption("silent", true);
            IWebDriver driver = new InternetExplorerDriver(options);
        }
    }
}
