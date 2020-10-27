using System.Threading;
using System.Threading.Tasks;
using Eimbee.Core.Enums;
using Eimbee.DataAccessLayer.Entity;
using Eimbee.DataAccessLayer.Repository;
using Eimbee.Server.Features.Models;
using MediatR;

namespace Eimbee.Server.Features.Pilots
{
    public class Create
    {
        public class Command : IRequest<ClaimsEnvelope>
        {
            public string Email { get; set; }
        }


        public class Handler : IRequestHandler<Command, ClaimsEnvelope>
        {
            private readonly IPilotRepository _pilotRepository;
            private readonly IAirlineRepository _airlineRepository;
            //private readonly IPilotRepository _pilotRepository;

            public Handler(IPilotRepository pilotRepository)
            {
                _pilotRepository = pilotRepository;
            }

            public async Task<ClaimsEnvelope> Handle(Command message, CancellationToken cancellationToken)
            {                
                var pilot = new Pilot() { Email = message.Email, Rank = Rank.StudentPilot, Role = Role.Pilot };
                await _pilotRepository.InsertAsync(pilot);
                return new ClaimsEnvelope() { Role = Role.Pilot.ToString(), VirtualAirline = "GEN" };
            }
        }
    }
}
