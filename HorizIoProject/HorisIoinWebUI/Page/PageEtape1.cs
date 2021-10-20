using OpenQA.Selenium;


namespace HorisIoinWebUI.Page
{
    class PageEtape1 : MasterPage
    {
        public void ClickButtonDoInvest(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='homepage']/div[1]/div/div/div[2]/a[1]"));
            _elements.ClickButton(element);
        }

    }
}
