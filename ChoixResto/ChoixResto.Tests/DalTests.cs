﻿using ChoixResto.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChoixResto.Tests
{
    
        [TestClass]
        public class DalTests
        {
            [TestMethod]
            public void CreerRestaurant_AvecUnNouveauRestaurant_ObtientTousLesRestaurantsRenvoitBienLeRestaurant()
            {
                using (IDal dal = new Dal())
                {
                    dal.CreerRestaurant("La bonne fourchette", "01 02 03 04 05");
                    List<Resto> restos = dal.ObtientTousLesRestaurants();

                    Assert.IsNotNull(restos);
                    Assert.AreEqual(1, restos.Count);
                    Assert.AreEqual("La bonne fourchette", restos[0].Nom);
                    Assert.AreEqual("01 02 03 04 05", restos[0].Telephone);
                }
            }
        }
    }
