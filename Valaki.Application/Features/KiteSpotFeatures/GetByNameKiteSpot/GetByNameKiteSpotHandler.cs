using AutoMapper;
using MediatR;
using Valaki.Application.Repositories;

namespace Valaki.Application.Features.KiteSpotFeatures.GetByNameKiteSpot;

public sealed class GetByNameKiteSpotHandler : IRequestHandler<GetByNameKiteSpotRequest, KiteSpotResponse>
{
    private readonly IKiteSpotRepository _kiteSpotRepository;
    private readonly IMapper _mapper;

    public GetByNameKiteSpotHandler(IKiteSpotRepository kiteSpotRepository, IMapper mapper)
    {
        _kiteSpotRepository = kiteSpotRepository;
        _mapper = mapper;
    }

    public async Task<KiteSpotResponse> Handle(GetByNameKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var kiteSpot = await _kiteSpotRepository.GetByName(request.Name, cancellationToken);
        return _mapper.Map<KiteSpotResponse>(kiteSpot);
    }
}

