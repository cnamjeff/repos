using OpenQA.Selenium;

namespace HorisIoinWebUI.Page
{
    public class PageEtape3 : MasterPage
    {
        public void ClickNo(IWebDriver driver)
        {            
            IWebElement element = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div/div/div[2]/div[2]/div[2]/div[2]/div"));
            _elements.ClickButton(element);
        }
    }
}
