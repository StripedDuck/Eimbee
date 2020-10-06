using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eimbee.DataAccessLayer.Repository
{
    public class AirlineRouteRepository : Repository<AirlineRoute>, IAirlineRouteRepository
    {
        public AirlineRouteRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
