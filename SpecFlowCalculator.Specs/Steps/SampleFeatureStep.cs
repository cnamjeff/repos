using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
     sealed class SampleFeatureStep
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef
        private readonly EmployeesDetails _employeesDetails;

        public SampleFeatureStep (EmployeesDetails employeesDetails)
        {
            this._employeesDetails = employeesDetails;
        }

        [When(@"I fill all the  mandatory details form")]
        public void WhenIFillAllTheMandatoryDetailsForm(Table table)
        {
            EmployeesDetails details = table.CreateInstance<EmployeesDetails>();
            var dataList = table.CreateDynamicSet();
            foreach (var data in dataList)
            {
                _employeesDetails.Age = data.Age;
                _employeesDetails.Email = data.Email;
                _employeesDetails.Name = data.Name;
                _employeesDetails.Phone = data.Phone;
            }

            //    EmployeesDetails details = table.CreateInstance<EmployeesDetails>();
            //    Console.WriteLine(details.Name);
            //    Console.WriteLine(details.Email);
            //    Console.WriteLine(details.Age);
            //    Console.WriteLine(details.Phone);

            //var detailsList = table.CreateDynamicSet(); 
            //foreach (var emp in detailsList)
            //{
            //    Console.WriteLine("The employee name is :" + emp.Name);
            //    Console.WriteLine("The employee Phone is :" + emp.Phone);
            //    Console.WriteLine("The employee Age is :" + emp.Age);
            //    Console.WriteLine("The employee Email is :" + emp.Email);
            //}


        }

        [When(@"I fill all the  mandatory  details form (.*), (.*) and (.*)")]
        [Obsolete]
        public void WhenIFillAllTheMandatoryDetailsFormHimmerAnd(string name, int age, Int64 number)
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Number: " + number);

            ScenarioContext.Current["InfoForNextStep"] = "Step1 passed";
            Console.WriteLine(ScenarioContext.Current["InfoForNextStep"].ToString());
            List<EmployeesDetails> empDetails = new List<EmployeesDetails>()
            {
                new EmployeesDetails
                {
                    Age = 30,
                    Email = "rodrigue@gmail.com",
                    Name = "Rodrigue",
                    Phone = 0321568978
                },
                new EmployeesDetails
                {
                     Age = 50,
                    Email = "Matin@gmail.com",
                    Name = "Martin",
                    Phone = 0689457823
                },
                new EmployeesDetails
                {
                     Age = 40,
                    Email = "Zoe@gmail.com",
                    Name = "Zoe",
                    Phone = 0789562315
                }
            };

            //SettingValueElement the value is ScenarioContext
            ScenarioContext.Current.Add("EmpDetails", empDetails);

            //Get the value  out from Scenario Context
            var empList = ScenarioContext.Current.Get<IEnumerable<EmployeesDetails>>("EmpDetails");

            foreach (EmployeesDetails emp in empList)
            {
                Console.WriteLine("The employee name is :" + emp.Name);
                Console.WriteLine("The employee Phone is :" + emp.Phone);
                Console.WriteLine("The employee Age is :" + emp.Age);
                Console.WriteLine("The employee Email is :" + emp.Email);
            }
            Console.WriteLine(ScenarioContext.Current.Count);
            Console.WriteLine(ScenarioContext.Current.CurrentScenarioBlock);
        }

       
    }
}
