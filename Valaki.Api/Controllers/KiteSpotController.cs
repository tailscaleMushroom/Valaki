using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;

namespace Valaki.Api.Controllers;

[ApiController]
[Route("kitespot")]
public class KiteSpotController : ControllerBase
{
    private readonly IMediator _mediator;

    public KiteSpotController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    public async Task<ActionResult<CreateKiteSpotResponse>> Create(CreateKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }
}

