using OpenQA.Selenium;

namespace HorisIoinWebUI.Page
{
    class PageEtape2 : MasterPage
    {

        public void SendCountry(IWebDriver driver)
        {
            //tape dans le champ adresse
            IWebElement element = driver.FindElement(By.Name("address"));
            _elements.InsertText(element,"Chaillac-sur");

            //click sur la flèche du bas
            _elements.KeysArrowDown(element);
            _elements.ClickButton(element);

        }

        public void SendPurchaseCost(IWebDriver driver)
        {
            //tape dans le champ prix
            IWebElement element = driver.FindElement(By.Name("price"));
            _elements.InsertText(element, "123645");
        }

        public void ClickNext(IWebDriver driver)
        {
            //tape dans le champ prix
            IWebElement element = driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/div/div/div[2]/div[2]/div[2]/span/form/div[3]/button"));
            _elements.ClickButton(element);
        }
    }
}
