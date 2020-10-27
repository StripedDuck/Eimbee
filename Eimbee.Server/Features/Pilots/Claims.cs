using System.Threading;
using System.Threading.Tasks;
using Eimbee.Core.Enums;
using Eimbee.DataAccessLayer.Entity;
using Eimbee.DataAccessLayer.Repository;
using Eimbee.Server.Features.Models;
using MediatR;

namespace Eimbee.Server.Features.Pilots
{
    public class Claims
    {
        public class Query : IRequest<ClaimsEnvelope>
        {
            public string Email { get; set; }
        }


        public class Handler : IRequestHandler<Query, ClaimsEnvelope>
        {
            private readonly IPilotRepository _pilotRepository;

            public Handler(IPilotRepository pilotRepository)
            {
                _pilotRepository = pilotRepository;
            }

            public async Task<ClaimsEnvelope> Handle(Query query, CancellationToken cancellationToken)
            {                
                var pilot = await _pilotRepository.GetByEmail(query.Email);
                return new ClaimsEnvelope() { Role = pilot.Role.ToString(), VirtualAirline = pilot.VirtualAirline};
            }
        }
    }
}
