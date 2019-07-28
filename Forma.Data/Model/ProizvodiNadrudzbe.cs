using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Forma.Data.Model
{
    public class ProizvodiNadrudzbe 
    {
        [Key, Column(Order = 0)]
        public int NarudzbaId { get; set; }

        [ForeignKey(nameof(NarudzbaId))]
        public virtual Narudzbe Narudzba { get; set; }


        [Key, Column(Order = 1)]
        public int? ProizvodId { get; set; }

        [ForeignKey(nameof(ProizvodId))]
        public virtual ProizvodModel Proizvod { get; set; }

        public virtual string ImeProizvoda { get
            {
                return Proizvod?.Naziv;
            } }

        public decimal Kolicina { get; set; }

    }
}
