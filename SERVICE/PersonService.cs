using DOMAIN;
using INFRAESTRUCTURE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace SERVICE
{
    public class PersonService
    {

        public List<Person> Get()
        {
            using (var context = new ProductContext())
            {
                return context.People.Where(x => x.IsEnable == true).ToList();
            }
        }
        public Person GetById(int id)
        {
            using (var context = new ProductContext())
            {
                return context.People.Find(id);
            }
        }


        public void Insert(Person person)
        {
            using (var context = new ProductContext())
            {

                person.IsEnable = true;
                person.CreatedON = DateTime.Today;
                context.People.Add(person);
                context.SaveChanges();
            }
        }
    }
}