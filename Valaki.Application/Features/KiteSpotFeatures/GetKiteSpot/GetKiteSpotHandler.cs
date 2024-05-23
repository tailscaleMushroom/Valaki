using AutoMapper;
using MediatR;
using Valaki.Application.Repositories;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed class GetKiteSpotHandler : IRequestHandler<GetKiteSpotRequest, GetKiteSpotResponse>
{
    private readonly IKiteSpotRepository _kiteSpotRepository;
    private readonly IMapper _mapper;

    public GetKiteSpotHandler(IKiteSpotRepository kiteSpotRepository, IMapper mapper)
    {
        _kiteSpotRepository = kiteSpotRepository;
        _mapper = mapper;
    }

    public async Task<GetKiteSpotResponse> Handle(GetKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var kiteSpot = await _kiteSpotRepository.GetByName(request.Name, cancellationToken);
        return _mapper.Map<GetKiteSpotResponse>(kiteSpot);
    }
}

