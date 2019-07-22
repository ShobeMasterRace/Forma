using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Forma.Data.Model
{
    public class PrijavaModel : IdModel
    {
              
        public string Username { get; set; }
 
        public string Password { get; set; }

    }
}
