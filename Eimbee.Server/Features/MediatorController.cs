using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Eimbee.Server.Controllers
{
    public class MediatorController : Controller
    {
        private readonly IMediator _mediator;

        public MediatorController(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}
