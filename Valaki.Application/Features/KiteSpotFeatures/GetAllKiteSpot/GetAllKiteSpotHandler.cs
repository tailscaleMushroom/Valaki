using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot;
using Valaki.Application.Repositories;

namespace Valaki.Application.Features.KiteSpotFeatures.GetAllKiteSpot;

public sealed class GetAllKiteSpotHandler : IRequestHandler<GetAllKiteSpotRequest, List<KiteSpotResponse>>
{
    private readonly IKiteSpotRepository _kiteSpotRepository;
    private readonly IMapper _mapper;

    public GetAllKiteSpotHandler(IKiteSpotRepository kiteSpotRepository, IMapper mapper)
    {
        _mapper = mapper;
        _kiteSpotRepository = kiteSpotRepository;
    }

    public async Task<List<KiteSpotResponse>> Handle(GetAllKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var kiteSpots = await _kiteSpotRepository.GetAll(cancellationToken);
        return _mapper.Map<List<KiteSpotResponse>>(kiteSpots);
    }
}

