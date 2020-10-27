using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Eimbee.Server.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    public class AuthorizedController : MediatorController
    {
        //private readonly ICurrentUserAccessor _currentUserAccessor;
        //public AuthorizedController(IMediator mediator, ICurrentUserAccessor currentUserAccessor) : base(mediator)
        //{
        //    _currentUserAccessor = currentUserAccessor;
        //}

        public AuthorizedController(IMediator mediator) : base(mediator)
        {
        }
    }
}
