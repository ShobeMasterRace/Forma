using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Forma.Data.Model
{
    public class Narudzbe : IdModel
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public DateTime? TimeStamp { get; set; } = DateTime.UtcNow;

        public virtual IEnumerable<ProizvodiNadrudzbe> Proizvodi { get; set; } = new HashSet<ProizvodiNadrudzbe>();
    }
}
