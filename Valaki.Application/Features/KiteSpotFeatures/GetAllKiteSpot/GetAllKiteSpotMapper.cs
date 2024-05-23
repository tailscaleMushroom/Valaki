using AutoMapper;
using Valaki.Domain.Entities;

namespace Valaki.Application.Features.KiteSpotFeatures.GetAllKiteSpot;

public sealed class GetAllKiteSpotMapper : Profile
{
    public GetAllKiteSpotMapper()
    {
        CreateMap<KiteSpot, GetAllKiteSpotResponse>();
    }
}

