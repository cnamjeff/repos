using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Hooks
{
    [Binding]
    public sealed class Hook
    {
        [AfterStep]
        public void AfterStep()
        {
            var featureTitle = FeatureContext.Current.FeatureInfo.Title;
            var scenarioTitle = ScenarioContext.Current.ScenarioInfo.Title;
            var scenarioTag = ScenarioContext.Current.ScenarioInfo.Tags;
            var stepInfo = ScenarioContext.Current.StepContext.StepInfo.Text;

            Console.WriteLine("the feature Title is : {featureTitle}");
            Console.WriteLine("the scenario Title is : {scenarioTitle}");
            Console.WriteLine("the scenario Taf is : {scenarioTag}");
            Console.WriteLine("the step info is : {stepInfo}");
        }
    }
}
