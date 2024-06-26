﻿using MediatR;
using Microsoft.AspNetCore.Mvc;
using Valaki.Application.Features.KiteSpotFeatures;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Application.Features.KiteSpotFeatures.GetAllKiteSpot;
using Valaki.Application.Features.KiteSpotFeatures.GetByNameKiteSpot;
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
    public async Task<ActionResult<KiteSpotResponse>> Create(CreateKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpPut]
    public async Task<ActionResult<KiteSpotResponse>> Update(UpdateKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetByName")]
    public async Task<ActionResult<KiteSpotResponse>> GetByName([FromQuery]GetByNameKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    [Route("GetById")]
    public async Task<ActionResult<KiteSpotResponse>> Get([FromQuery] GetKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(request, cancellationToken);
        return Ok(response);
    }

    [HttpGet]
    public async Task<ActionResult<KiteSpotResponse>> GetAll(CancellationToken cancellationToken)
    {
        var response = await _mediator.Send(new GetAllKiteSpotRequest(), cancellationToken);
        return Ok(response);
    }
}

