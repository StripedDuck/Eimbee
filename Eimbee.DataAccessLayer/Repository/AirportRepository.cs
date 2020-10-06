using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eimbee.DataAccessLayer.Repository
{
    public class AirportRepository : Repository<Airport>, IAirportRepository
    {
        public AirportRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
