using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    sealed class ExtendedSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly EmployeesDetails _employeesDetails;

        public ExtendedSteps(EmployeesDetails employeesDetails)
        {
            this._employeesDetails = employeesDetails;
        }
        [Then(@"I should  get the same value from extended steps")]
        public void ThenIShouldGetTheSameValueFromExtendedSteps()
        {
            Console.WriteLine(_employeesDetails.Age);
            Console.WriteLine(_employeesDetails.Email);
            Console.WriteLine(_employeesDetails.Name);
            Console.WriteLine(_employeesDetails.Phone);            
        }


    }
}
