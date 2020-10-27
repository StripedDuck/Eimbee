using Eimbee.DataAccessLayer.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Eimbee.DataAccessLayer.Repository
{
    public class PilotRepository : Repository<Pilot>, IPilotRepository
    {
        public PilotRepository(DatabaseContext context) : base(context)
        {
        }

        public async Task<Pilot> GetByEmail(string email)
        {
            return await Context.Pilots.FindAsync(email);
        }
    }
}
