using OpenQA.Selenium;

namespace HorisIoinWebUI.Page
{
    public class HomePage : MasterPage
    {     
 
        public void ClickButtonCallGenie(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='entry']/div/div[3]/div[4]/picture/img"));
            _elements.ClickButton(element);
        }

        public void ClickButtonDoInvest(IWebDriver driver)
        {
            IWebElement element = driver.FindElement(By.XPath("//*[@id='homepage']/div[1]/div/div/div[2]/a[1]"));
            _elements.ClickButton(element);
        }

    }
}
