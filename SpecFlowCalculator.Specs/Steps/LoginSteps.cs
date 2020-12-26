using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class LoginSteps
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        // [Scope(Feature = "UserLoginFeature")] permet de lié à une feature en particulier en l'occurence 
        //celle de UserLogiinFeature pour ce step. CE scope peut se mettre au niveau de la classe également.
        // Il est aussi possible de lié par rapport à un nom de Tag ou un nom de Scénario

        [Given(@"I have opened the application")]
        [Scope(Feature = "UserLoginFeature")]
        public void GivenIHaveOpenedTheApplication()
        {
            Console.WriteLine("I have opened the application" + "UserLoginFeature");
        }

        [Given(@"I login to application")]
        [Scope(Feature = "UserLoginFeature")]
        public void GivenILoginToApplication()
        {
            Console.WriteLine("I login to application" + "UserLoginFeature");
        }

        [Given(@"I login to application as admin")]
        [Scope(Feature = "UserLoginFeature")]
        public void GivenILoginToApplicationAsAdmin()
        {
            Console.WriteLine("I login to application as admin" + "UserLoginFeature");
        }

        [Then(@"I see user portal")]
        [Scope(Feature = "UserLoginFeature")]
        public void ThenISeeUserPortal()
        {
            Console.WriteLine("I see user portal" + "UserLoginFeature");
        }

       

        [Then(@"I see last date logged in data  is (.* days from current date)")]
        [Scope(Feature = "UserLoginFeature")]
        public void ThenISeeLastDateLoggedInDataIsDaysFromCurrentDate(DateTime correctDateTime)
        {
            //Cette méthode est lié a la méthode de "DayAdderTransformation" de la classe "CustomerStepTransformer" grace au regex!
            //se trouvant dans le then de cette méthode!
            // Il est important de changer le type de la variable dans cette méthode
            Console.WriteLine(correctDateTime);
        }

        [Then(@"I see the menus like")]
        [Scope(Feature = "UserLoginFeature")]
        public void ThenISeeTheMenusLike(/*IEnumerable<dynamic>*/ Table menus)
        {
            //first version
            //dynamic menu = menus.CreateDynamicInstance();

            //second version only for this example because there only one value in this table.
            // if you use more values you can t use this version.
            //If you use this version you can use the type inside de parameter and you delete behind the type just after this sentence
            IEnumerable<dynamic> menuList = menus.CreateDynamicSet();
            var menu = menuList.First();
            string menu1=menu.Menu_1;
            string menu2=menu.Menu_2;
            string menu3 = menu.Menu_3;
            Console.WriteLine("the menu 1 contient : {0} et le menu 2 contient: {1} et le menu 3 contient : {2}", menu1, menu2, menu3);
        }


    }
}
