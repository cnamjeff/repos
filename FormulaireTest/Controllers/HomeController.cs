using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using FormulaireTest.Models;
using MySql.Data.MySqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;

namespace FormulaireTest.Controllers
{   
    public class HomeController : Controller
    {
        #region champ

        private readonly ILogger<HomeController> _logger;
        private SqlConnection _connection;
        private string server;
        private string database;
        private string user;
        private string password;
        private string port;
        private string connectionString;
        private string sslM;

        #endregion champ

        public HomeController(ILogger<HomeController> logger)
        {
            Initialize();
                     
            _logger = logger;
        }
        private void Initialize()
        {
            string path = System.IO.Directory.GetCurrentDirectory();
            var builder = new ConfigurationBuilder()
                               .SetBasePath(path)
                               .AddJsonFile("appsettings.json");


            var config = builder.Build();

            var connectionString = config.GetConnectionString("DefaultContext");

            //DbContextOptionsBuilder<DefaultContext> optionBuilder = new DbContextOptionsBuilder<DefaultContext>();
            //optionBuilder.UseSqlServer(connectionString);


            //server = @"JEFFHIMMER""SQLEXPRESS";
            //database = "FormulaireEcole";
            //user = @"JEFFHIMMER\""mercu";
            //password = "";
            //string connectionString;
            //connectionString = String.Format("server={0};database={1};user={2}; password={3}", server, database,user, password);
            _connection = new SqlConnection(connectionString);
            try
            {
                _connection.Open();
                Console.WriteLine("connecté");
               
            }
            catch (MySqlException ex)
            {
                ex.ErrorCode.ToString();                
            }
          
            string myInsertQuery = "INSERT INTO Etudiants (Nom, Prenom, age) Values('zoe', 'fredy', 67)";
            SqlCommand myCommand = new SqlCommand(myInsertQuery);
            myCommand.Connection = _connection;
          
            myCommand.ExecuteNonQuery();
            myCommand.Connection.Close();
        }

        public IActionResult Index()
        {
           
            return View("Views/Home/AddMovies.cshtml");
        }

        public IActionResult AddContact(Contact contact)
        {
                    
            try
            {
               
                // Ouverture de la connexion SQL

                //this._connection.Open();


                //// Création d'une commande SQL en fonction de l'objet connection
                //DefaultContext context = new DefaultContext();
              
         
                
                //context.Etudiant.Add(contact);            
                         

                //// Fermeture de la connexion
                this._connection.Close();
            }
            catch (Exception ex)
            {
                ex.GetBaseException();
            }
            return View("Views/Home/AddMovies.cshtml");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
