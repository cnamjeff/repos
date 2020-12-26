using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Demo
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private const string V = "";

        protected void Page_Load(object sender, EventArgs e)
        {
            SampleDataContext dbContext = new SampleDataContext();
            var linqQuery = from employee in dbContext.Employees                            
                            join departement in dbContext.Departments
                            on employee.DepartmentId equals departement.ID                            
                            where departement.Location == "London"                            
                            select new {employee.FirstName , employee.LastName, departement.Location };

            var linqQuery4 = from employee in dbContext.Employees                              
                            join departement in dbContext.Departments
                            on employee.DepartmentId equals departement.ID                            
                            where departement.Location == "London"
                            select new { employee.FirstName, employee.LastName, departement.Location };

            var linqQuery2 = dbContext.Employees.
                Join(dbContext.Departments,
                empl => empl.DepartmentId, 
                depart => depart.ID,
                (empl,depart) => new { Empl =empl, Depart= depart}).
                Where(x=> x.Depart.Location == "London").
                Where(x => x.Empl.Gender == "Male").
                Select(x=> new { x.Empl.FirstName,x.Empl.LastName,x.Depart.Location, x.Empl.Gender });

            var linqQuery3 = dbContext.Employees.
                Join(dbContext.Departments,
                empl => empl.DepartmentId,
                depart => depart.ID,
                (empl, depart) => new { Empl = empl, Depart = depart }).                
                Where(x => x.Depart.Location == "London").
                Select(x => new { x.Empl.FirstName, x.Empl.LastName, x.Depart.Location});

            var linqQuery5 = dbContext.Employees.GroupBy(x=>x.Salary).OrderBy(x=>x.Min()).                
                        Select(x => x.Key).ToList();

            GridView1.DataSource = linqQuery5;
            GridView1.DataBind();
        }

        private void GetData()
        {
            SampleDataContext dbContext = new SampleDataContext();

            //dbContext.Log = Response.Output;
            // première solution pour récupérer tous les employés de la table
            var linqQuery = from employee in dbContext.Employees
                            select employee;

            //troisième façon de le faire avec une lambda expression
            var lindQuery3 = dbContext.Employees.Select(x => x);
            //Response.Write(dbContext.GetCommand(linqQuery).CommandText);

            // deuxième solution pour récupérer tous les employés de la table avec une procédure stokée
            var linqQuery2 = dbContext.GetEmployees();
            GridView1.DataSource = lindQuery3;
            GridView1.DataBind();
        }

      

        protected void btmDetData(object sender, EventArgs e)
        {
            GetData();

        }

      

        protected void BtmInsert(object sender, EventArgs e)
        {
            try
            {
                using (SampleDataContext dbContext = new SampleDataContext())
                {
                    Employees newEmployee = new Employees
                    {
                        FirstName = "jean",
                        LastName = "Fred",
                        Gender = "Male",
                        Salary = 50000,
                        DepartmentId = 1,

                    };
                    dbContext.Employees.InsertOnSubmit(newEmployee);
                    dbContext.SubmitChanges();
                }
                GetData();
            }
            catch (Exception ex)
            {
                ExceptionMethod(ex);
            }
        }

 


        protected void BtmUpdate(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                Employees employee = dbContext.Employees.SingleOrDefault(x => x.ID == 8);
                employee.Salary = 65000;
                dbContext.SubmitChanges();
            }
            GetData();
        }
             
        protected void BtmDelete(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                try
                {
                    Employees employee = dbContext.Employees.SingleOrDefault(x => x.ID == 10);
                    dbContext.Employees.DeleteOnSubmit(employee);
                    dbContext.SubmitChanges();
                }
                catch (Exception ex)
                {
                    ExceptionMethod(ex);
                }           
            }
            GetData();
        }
            
        
        protected void GetEmpoyeesByDepartment(object sender, EventArgs e)
        {
            using (SampleDataContext dbContext = new SampleDataContext())
            {
                string deptName = string.Empty;
                GridView1.DataSource = dbContext.GetEmployeesByDepartment(1, ref deptName);
                GridView1.DataBind();
                lblDept.Text = "Le nom du département est :" + deptName;
            }
            GetData();

        }
        #region privateMethod
        private static void ExceptionMethod(Exception ex)
        {
            Console.WriteLine("\nMessage ---\n{0}", ex.Message);
            Console.WriteLine(
                "\nHelpLink ---\n{0}", ex.HelpLink);
            Console.WriteLine("\nSource ---\n{0}", ex.Source);
            Console.WriteLine(
                "\nStackTrace ---\n{0}", ex.StackTrace);
            Console.WriteLine(
                "\nTargetSite ---\n{0}", ex.TargetSite);
        }
        #endregion
    }
}