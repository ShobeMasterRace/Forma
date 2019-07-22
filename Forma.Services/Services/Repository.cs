using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Forma.Service.Services
{
 
    public class Repository<T> where T : Data.Model.IdModel 
    {
            private Data.Context Contx;

            public Repository()
            {

                Contx = new Data.Context();



            }



            public List<T> GetAll()
            {
                List<T> departments = Contx.Set<T>().ToList();
                return departments;


            }

            public T Get(int id)
            {
                T department = Contx.Set<T>().FirstOrDefault(a => a.ID == id);
                return department;


            }

            public T Add(T item)
            {
            Contx.Set<T>().Add(item);
            Contx.SaveChanges();
                return item;


            }

            public List<T> AddMultiple(List<T> departments)
            {
                for (int i = 0; i < departments.Count; i++)
                {
                Contx.Set<T>().Add(departments[i]);
                Contx.SaveChanges();


                }

                return departments;

            }

            public T Edit(T item)
            {
                Contx.Attach(item).State = EntityState.Modified;
                Contx.SaveChanges();
                return item;
            }

            public void Delete(int id)
            {

                T item = Contx.Set<T>().FirstOrDefault(a => a.ID == id);
                Contx.Set<T>().Remove(item);
                Contx.SaveChanges();

            }
        }
}
