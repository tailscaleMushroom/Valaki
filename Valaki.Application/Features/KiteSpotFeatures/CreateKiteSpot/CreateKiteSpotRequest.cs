using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed record CreateKiteSpotRequest(string Name, string Coordinates, string Difficulty) : IRequest<KiteSpotResponse>
    {
        
    }
}
