using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed record CreateKiteSpotRequest(string Coordinates, string Name, string Difficulty) : IRequest<KiteSpotResponse>;
}
