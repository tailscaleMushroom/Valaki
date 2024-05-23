using AutoMapper;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed class GetByNameKiteSpotMapper : Profile
{
    public GetByNameKiteSpotMapper()
    {
        CreateMap<KiteSpot, GetByNameKiteSpotResponse>();
    }
}

