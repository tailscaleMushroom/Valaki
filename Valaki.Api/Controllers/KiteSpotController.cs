using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Application.Features.KiteSpotFeatures.GetAllKiteSpot;
using Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;
using Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

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

    [HttpPut]
    public async Task<ActionResult<UpdateKiteSpotResponse>> Update(UpdateKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetByName")]
    public async Task<ActionResult<GetByNameKiteSpotResponse>> GetByName([FromQuery]GetByNameKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<GetAllKiteSpotResponse>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllKiteSpotRequest(), cancellationToken);
        return Ok(response);
    }
}

