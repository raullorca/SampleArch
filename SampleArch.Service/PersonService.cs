using SampleArch.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Service
{
    public class PersonService : EntityService<Person>, IPersonService
    {
        public PersonService(IContext context) : base(context) { }

        public override IEnumerable<Person> GetAll()
        {
            return _context.People.Include(x => x.Country).ToList();
        }

        public Person GetById(long Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }

    }
}
