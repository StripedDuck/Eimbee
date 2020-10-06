using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Eimbee.DataAccessLayer.Repository
{
    public class AircraftTypeRepository : Repository<AircraftType>, IAircraftTypeRepository
    {
        public AircraftTypeRepository(DatabaseContext context) : base(context)
        {
        }
    }
}
