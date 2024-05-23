using AutoMapper;
using MediatR;
using Valaki.Application.Repositories;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

public sealed class UpdateKiteSpotHandler : IRequestHandler<UpdateKiteSpotRequest, UpdateKiteSpotResponse>
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IKiteSpotRepository _kiteSpotRepository;
    private readonly IMapper _mapper;

    public UpdateKiteSpotHandler(IUnitOfWork unitOfWork, IKiteSpotRepository kiteSpotRepository, IMapper mapper)
    {
        _unitOfWork = unitOfWork;
        _kiteSpotRepository = kiteSpotRepository;
        _mapper = mapper;
    }

    public async Task<UpdateKiteSpotResponse> Handle(UpdateKiteSpotRequest request, CancellationToken cancellationToken)
    {
        var kiteSpot = _mapper.Map<KiteSpot>(request);
        _kiteSpotRepository.Update(kiteSpot);
        await _unitOfWork.Save(cancellationToken);

        return _mapper.Map<UpdateKiteSpotResponse>(kiteSpot);
    }
}
