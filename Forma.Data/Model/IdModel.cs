﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Forma.Data.Model
{
    public abstract class IdModel
    {
        [Key]
        public int ID { get; set; }
    }
}
