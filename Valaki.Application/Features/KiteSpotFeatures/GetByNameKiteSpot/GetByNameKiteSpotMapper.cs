using AutoMapper;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.GetByNameKiteSpot;

public sealed class GetByNameKiteSpotMapper : Profile
{
    public GetByNameKiteSpotMapper()
    {
        CreateMap<KiteSpot, KiteSpotResponse>();
    }
}

