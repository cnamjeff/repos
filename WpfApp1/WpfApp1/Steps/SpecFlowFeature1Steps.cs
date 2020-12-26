using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using NUnit.Framework;
using TechTalk.SpecFlow;
using TestStack.White;
using TestStack.White.UIItems;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.TabItems;
using TestStack.White.WindowsAPI;
using TestStack.White.AutomationElementSearch;
using TestStack.White.UIItems.Container;
using TestStack.White.UIItems.ListViewItems;
using TestStack.White.Sessions;
using TestStack.White.Configuration;
using TestStack.White.Mappings;
using TestStack.White.Factory;
using TestStack.White.UIItems.ListBoxItems;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems.TableItems;
using TestStack.White.UIItems.WindowStripControls;
using TestStack.White.UIItems.WPFUIItems;
using TestStack.White.Bricks;
using TestStack.White.Drawing;
using TestStack.White.Finder;
using TestStack.White.InputDevices;
using TestStack.White.Interceptors;
using TestStack.White.Recording;
using TestStack.White.ScreenMap;
using TestStack.White.SystemExtensions;
using TestStack.White.UIA;
using TestStack.White.UIItemEvents;
using TestStack.White.Utility;
using TestStack.White.WindowsAPI;




namespace WpfApp1
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        private  ViewModel.Main _vm = new ViewModel.Main();
        private string result;
        Application app;


        [Given(@"i start exe")]
        public void GivenIStartExe()
        {
            app = Application.Launch(@"C:\Users\mercu\source\repos\WpfApp1\WpfApp1\bin\Release\WpfApp1.exe");
        }

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(string text)
        {
            Window window = app.GetWindow("MainWindow");
            TextBox label1 =  window.Get<TextBox>("labelText");
            label1.Enter(text);
        }
       


        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            Window window = app.GetWindow("MainWindow");
            Button buttonValider = window.Get<Button>("valider");
            buttonValider.Click();
            result = _vm._champResult;
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeBravoOnTheScreen(string result)
        {
            if(string.IsNullOrWhiteSpace(result))
            {
               // Assert.AreNotEqual(result, MainWindow.affichage);

            }
            else
            {
                //Assert.AreEqual(result, _vm._text);
            }
           
        }
    }
}
