using Eimbee.DataAccessLayer.Entity;
using System.Threading.Tasks;

namespace Eimbee.DataAccessLayer.Repository
{
    public interface IPilotRepository : IRepository<Pilot>
    {
        Task<Pilot> GetByEmail(string email);
    }
}
