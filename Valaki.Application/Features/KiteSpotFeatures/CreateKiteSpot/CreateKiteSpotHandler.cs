using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valaki.Application.Repositories;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed class CreateKiteSpotHandler : IRequestHandler<CreateKiteSpotRequest, KiteSpotResponse>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IKiteSpotRepository _kiteSpotRepository;
        private readonly IMapper _mapper;

        public CreateKiteSpotHandler(IUnitOfWork unitOfWork, IKiteSpotRepository kiteSpotRepository, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _kiteSpotRepository = kiteSpotRepository;
            _mapper = mapper;
        }

        public async Task<KiteSpotResponse> Handle(CreateKiteSpotRequest request, CancellationToken cancellationToken)
        {
            var kiteSpot = _mapper.Map<KiteSpot>(request);
            _kiteSpotRepository.Create(kiteSpot);
            await _unitOfWork.Save(cancellationToken);

            return _mapper.Map<KiteSpotResponse>(kiteSpot);
        }
    }
}
