using OpenQA.Selenium;

namespace HorisIoinWebUI.SeleniumElements
{
    public class Elements
    {
        public void ClickButton(IWebElement element)
        {
            element.Click();
        }

        public void InsertText(IWebElement element, string text)
        {
            element.SendKeys(text);
        }

        public void KeysArrowDown(IWebElement element)
        {
            element.SendKeys(Keys.ArrowDown);
        }
    }
}
