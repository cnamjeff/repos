using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HorisIoinWebUI
{
    public class Driver
    {
        private readonly ChromeDriver _driver;
        public Driver()
        {
            _driver = new ChromeDriver(@"C:\Users\mercu\source\repos\HorizIoProject\HorisIoinWebUI\Driver");           
            _driver.Navigate().GoToUrl("https://horiz.io/");
        }

        public IWebDriver DriverPage()
        {
            return _driver;
        }

    }
}
