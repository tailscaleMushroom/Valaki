using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.CreateKiteSpot
{
    public sealed record CreateKiteSpotRequest(string Email, string Name) : IRequest<CreateKiteSpotResponse>;
}
