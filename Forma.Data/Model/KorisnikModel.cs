using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Forma.Data.Model
{
    public class KorisnikModel
    {
        
        [Required]
        public string Ime { get; set; }

        [Required]
        public string Prezime { get; set; }

        public string Ulica { get; set; }
        public string Grad { get; set; }
        public string PostanskiBroj { get; set; }
        public string BrojUkucana { get; set; }

        [Required]
        public string Upit { get; set; }

    }
}
