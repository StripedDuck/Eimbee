using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eimbee.DataAccessLayer.Repository
{
    public class CityRepository : Repository<City>,ICityRepository
    {
        public CityRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
