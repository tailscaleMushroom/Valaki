using AutoMapper;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed class GetKiteSpotMapper : Profile
{
    public GetKiteSpotMapper()
    {
        CreateMap<KiteSpot, KiteSpotResponse>();
    }
}

