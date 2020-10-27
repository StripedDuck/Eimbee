using MediatR;
using Microsoft.AspNetCore.Mvc;


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
        

    }
}
