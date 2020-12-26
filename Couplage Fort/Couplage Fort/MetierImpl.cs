﻿using CouplageFort;
using CouplageFort.Interface;


namespace CouplageFort
{
    public class MetierImpl : IMetierImpl
    {
        public IDAOImpl Dao { get; set; }

        public MetierImpl(IDAOImpl Dao) { this.Dao = Dao; }

        public MetierImpl() { }

        public int Calcul()
        {
            //IDAOImpl dao = new DAOImpl();
            var data = Dao.GetValue();  
            return data +2;
        }
    }
}
