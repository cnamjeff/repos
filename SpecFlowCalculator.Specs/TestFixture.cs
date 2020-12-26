using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs
{
    [Binding]
    public sealed class TestFixture
    {
        // For additional details on SpecFlow hooks see http://go.specflow.org/doc-hooks
        [BeforeFeature]
        public static void BeforeFeature()
        {
            Console.WriteLine("Start before feature");
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            Console.WriteLine("Start before scenario");
        }

        [AfterScenario]
        public void AfterScenario()
        {
            Console.WriteLine("Start after scenario");
        }
    }
}
