using AutoMapper;
using Valaki.Domain.Entities;


namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed class CreateKiteSpotMapper : Profile
    {
        public CreateKiteSpotMapper() 
        {
            CreateMap<CreateKiteSpotRequest, KiteSpot>();
            CreateMap<KiteSpot, KiteSpotResponse>();
        }
    }
}
