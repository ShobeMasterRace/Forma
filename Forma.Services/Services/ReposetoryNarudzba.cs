using Forma.Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forma.Service.Services
{
    public class ReposetoryNarudzba : Repository<Narudzbe>
    {
        public override List<Narudzbe> GetAll()
        {
            
            List<Narudzbe> departments = Contx.Set<Narudzbe>().Include(a => a.Proizvodi).Include("Proizvodi.Proizvod").ToList();
            return departments;
        }

        public override Narudzbe Get(int id)
        {
            Narudzbe department = Contx.Set<Narudzbe>().Include(a => a.Proizvodi).Include("Proizvodi.Proizvod").FirstOrDefault(a => a.ID == id);
            return department;


        }
        

        

    }
}
