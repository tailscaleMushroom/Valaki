using AutoMapper;
using MediatR;
using Valaki.Application.Repositories;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed class GetKiteSpotHandler : IRequestHandler<GetKiteSpotRequest, KiteSpotResponse>
{
    private readonly IKiteSpotRepository _kiteSpotRepository;
    private readonly IMapper _mapper;

    public GetKiteSpotHandler(IKiteSpotRepository kiteSpotRepository, IMapper mapper)
    {
        _kiteSpotRepository = kiteSpotRepository;
        _mapper = mapper;
    }

    public async Task<KiteSpotResponse> Handle(GetKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var kiteSpot = await _kiteSpotRepository.Get(request.Id, cancellationToken);
        return _mapper.Map<KiteSpotResponse>(kiteSpot);
    }
}

