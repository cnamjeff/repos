using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{

    public class User
    {
        internal static IEnumerable<User> MockData;

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime BirthDate { get; set; }

        public ICollection<CryptoWallet> Wallets { get; set; }

    }

    public class CryptoWallet
    {

        public string Currency { get; set; }

        public decimal Amount { get; set; }

    }

    public decimal Ex2()
    {
        IEnumerable<User> users = User.MockData;
        int total = 0;

        foreach (var user in users)
        {
            foreach (var item in user.Wallets)
            {
                if (item.Currency == "BTC")
                {
                    total = total + 1;
                }

            }      


         }
    }

    public static Dictionary<string, decimal> Ex3()
    {
        IEnumerable<User> users = User.MockData;

        IDictionary<string,int> dico = users.

        // Un dictionnaire contenant la somme possédée par tous les utilisateurs pour chaque monnaie
        // Ex :
        // { { "BTC" : 1452 }, { "DOGE" : 467 } }


        return null;
    }

    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
