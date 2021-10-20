using HorisIoinWebUI;
using HorisIoinWebUI.Page;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace HorizIoProject.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private Driver _init;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
           
        }

        [Given(@"a user not logged in")]
        public void GivenAUserNotLoggedIn()
        {
            // notihing here
        }

        [Given(@"on the homepage")]
        public void GivenOnTheHomepage()
        {
             _init = new Driver();
        }

        [When(@"I click on Call on the genie")]
        public void WhenIClickOnCallOnTheGenie()
        {
            HomePage homePage = new HomePage();
            homePage.ClickButtonCallGenie(DriverPage());
        }

        [Then(@"a modal appears and asks me to make a choice between Make a profitable investment or Manage the rental of your property\.")]
        public void ThenAModalAppearsAndAsksMeToMakeAChoiceBetweenMakeAProfitableInvestmentOrManageTheRentalOfYourProperty_()
        {
            HomePage homePage = new HomePage();
            homePage.ClickButtonDoInvest(DriverPage());
        }

        private IWebDriver DriverPage()
        {
            return _init.DriverPage();
        }

    }
}
