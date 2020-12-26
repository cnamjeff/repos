using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
    [Table("Utilisateurs")]
    public class Utilisateur
    {
        public int Id { get; set; }
        [StringLength(80)]
        public string Prenom { get; set; }        
        [Range(18, 120)]
        public int Age { get; set; }
        
    }
}