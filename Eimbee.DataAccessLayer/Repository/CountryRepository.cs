using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eimbee.DataAccessLayer.Repository
{
    public class CountryRepository : Repository<Country>,ICountryRepository
    {
        public CountryRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
