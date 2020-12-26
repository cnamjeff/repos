using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs
{
    [Binding]
    public class CustomerStepTransformer
    {
        [StepArgumentTransformation(@"(\d+) days from current date")]
        //or 
        //[StepArgumentTransformation("(\d+|[5])")]
        public DateTime DayAdderTransformation(int days)
        {
            return DateTime.Today.AddDays(days);
        }

    }
}
