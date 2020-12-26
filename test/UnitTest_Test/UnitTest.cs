
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTest_Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Factorielle_AvecValeur10_Retourne1()
        {
            int valeur = 10;
            
            int resultat = Math.Factorielle(valeur);
            Assert.AreEqual(1, resultat, "La valeur doit être égale à 1");
        }
    }
}
