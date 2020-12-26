using System;
using System.Collections.Generic;
using LibSH;


namespace TestJeffDataConnexion.Models
{
    public class DaoGetLogin
    {
        // gère les champs de recherche
        public static List<Login> GetLogin(string search, DateTime? searchDateMin,
            DateTime? searchDateMax, string state)
        {


            List<Login> outList1 = new List<Login>();

            using (DataBase db = AssemblySettings.getConnection(AssemblySettings.ShCatalog.SecurehWS))
            {
                //retourne les données à l'ouverture de la page web
               
                var byDesc = "ORDER BY Now DESC";
                var sql = @"SELECT Login, IpAddress, Now, WebServiceMethod, Status FROM [SecurehWS].[dbo].[WebServiceLogin] where 1=1 " ;             

               
                //retourne la donnée des champs date
                if (searchDateMin != null && searchDateMax != null)
                {
                    sql = sql + " and Now between @searchDateMin and @searchDateMax ";

                }

                //retourne la donnée du champ search uniquement
                if (search != null)
                {

                    sql = sql + " and ( Login like @search or  IpAddress like @search or Now like @search or WebServiceMethod like @search or Status like @search ) ";

                }

                //retourne la donnée du champ etat uniquement
                if (state != null)
                {

                    sql = sql + " and Status = @state ";

                }
                
                db.Requete = sql + byDesc;
                db.addParameter("@state", state);
                db.addParameter("@searchDateMin", searchDateMin);
                db.addParameter("@searchDateMax", searchDateMax);
                db.addParameter("@search", $"%{search}%");
                db.execute_reader();


                while (db.NextLine())
                {

                    var login = db.GetDataOrDefault<string>("Login");
                    var addresse = db.GetDataOrDefault<string>("IpAddress");
                    var dateNow = db.GetDataOrDefault<DateTime>("Now");
                    var webservice = db.GetDataOrDefault<string>("WebServiceMethod");
                    var Status = db.GetDataOrDefault<string>("Status");
                    Login tr1 = new Login { addresse = addresse, date = dateNow, login = login, state = Status, webservice = webservice};
                    outList1.Add(tr1);
                }
            }
            return outList1;

        }


    }
}
