using SampleArch.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleArch.Service
{
    public class CountryService : EntityService<Country>, ICountryService
    {
        public CountryService(IContext context) : base(context) { }

        public Country GetById(int Id)
        {
            return _dbset.FirstOrDefault(x => x.Id == Id);
        }
    }
}
