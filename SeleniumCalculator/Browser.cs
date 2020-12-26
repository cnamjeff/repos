using System;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;


namespace SeleniumCalculator
{
    public class Browser
    {
        public void InternetExplorer()
        {
            var options = new InternetExplorerOptions();
            options.FileUploadDialogTimeout = TimeSpan.FromMilliseconds(2000);
            var driver = new RemoteWebDriver(options);

        }



    }
}
