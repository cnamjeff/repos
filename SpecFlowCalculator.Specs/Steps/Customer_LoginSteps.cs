using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class Customer_LoginSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

       
        [Given(@"I have opened the application")]
        [Scope(Feature = "Customer_LoginFeature")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine("I have opened the application" + "Customer_LoginFeature");
        }

        [Given(@"I login to application")]
        [Scope(Feature = "Customer_LoginFeature")]
        public void GivenILoginToApplication()
        {
            Console.WriteLine("I login to application" + "Customer_LoginFeature");
        }

        [Then(@"I see customer portal")]
        [Scope(Feature = "Customer_LoginFeature")]
        public void ThenISeeCustomerPortal()
        {
           
            Console.WriteLine("I see customer portal" + "Customer_LoginFeature");
        }
    }
}
