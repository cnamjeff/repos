using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaireTest.Models
{
    public class DefaultContext : DbContext
    {
        public DefaultContext(DbContextOptions<DefaultContext> options) : base(options)
        {
        }

        public DefaultContext()
        {
        }
        #region propriétés
        public DbSet<Contact> Etudiant { get; set; }  

        #endregion
    }
}
