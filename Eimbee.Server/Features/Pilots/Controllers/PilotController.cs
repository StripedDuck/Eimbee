using Eimbee.Server.Features.Models;
using Eimbee.Server.Features.Pilots;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eimbee.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PilotController : AuthorizedController
    {
        private readonly IMediator _mediator;
        public PilotController(IMediator mediator) : base(mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet()]
        public async Task<ClaimsEnvelope> Get(Claims.Query query)
        {
            return await _mediator.Send(query);
        }

        [HttpPost]
        public async Task<ClaimsEnvelope> Create([FromBody] Create.Command command)
        {
            return await _mediator.Send(command);
        }
    }
}
