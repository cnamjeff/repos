﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ChoixResto.Models
{
   
    [Table("Restos")]
    public class Resto
    {
     
        public int Id { get; set; }
        [Required(ErrorMessage = "Le nom du restaurant doit être saisi"), StringLength(80)]
        public string Nom { get; set; }
        [Display(Name = "Téléphone"), RegularExpression(@"^0[0-9]{9}$", ErrorMessage = "Le numéro de téléphone est incorrect")]
        public string Telephone { get; set; }
        public string Email { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (string.IsNullOrWhiteSpace(Telephone) && string.IsNullOrWhiteSpace(Email))
                yield return new ValidationResult("Vous devez saisir au moins un moyen de contacter le restaurant", new[] { "Telephone", "Email" });
            // etc.
        }
    }
}