using AutoMapper;
using Valaki.Domain.Entities;


namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

public sealed class UpdateKiteSpotMapper : Profile
{
    public UpdateKiteSpotMapper() 
    {
        CreateMap<UpdateKiteSpotRequest, KiteSpot>();
        CreateMap<KiteSpot, KiteSpotResponse>();
    }
}

