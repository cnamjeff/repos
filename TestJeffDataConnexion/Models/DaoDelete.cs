using System;
using System.Collections.Generic;
using LibSH;

namespace TestJeffDataConnexion.Models
{
    public class DAODelete
    {
        //efface la ligne en entière
        public static void Delete(string LockType, string LockedValue)
        {

            using (DataBase db = AssemblySettings.getConnection(AssemblySettings.ShCatalog.SecurehWS))
            {

                var sql = @"delete  FROM WebServiceLoginLock 
                           where LockType=@LockType and LockedValue=@LockedValue";

                db.Requete = sql;
                db.addParameter("@LockType", LockType);
                db.addParameter("@LockedValue", LockedValue);

                db.execute_non_query();

            }

        }
        // récupère la l'ensemble des champs de la table WebServiceLoginLock
        public static List<LoginLock> GetLockList()
        {
            List<LoginLock> outList1 = new List<LoginLock>();

            using (DataBase db = AssemblySettings.getConnection(AssemblySettings.ShCatalog.SecurehWS))
            {

                var sql = @"select LockType, LockedValue, LockExpiration FROM WebServiceLoginLock ";

                db.Requete = sql;

                db.execute_reader();
                while (db.NextLine())
                {
                    var Type = db.GetDataOrDefault<string>("LockType");
                    var Value = db.GetDataOrDefault<string>("LockedValue");
                    var Expiration = db.GetDataOrDefault<DateTime>("LockExpiration");

                    LoginLock tr1 = new LoginLock(Type, Value, Expiration);

                    outList1.Add(tr1);
                }


            }
            return outList1;
        }
    }
}