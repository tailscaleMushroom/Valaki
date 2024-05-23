using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

public sealed record UpdateKiteSpotRequest(Guid Id, string Coordinates, string Name, string Difficulty) : IRequest<KiteSpotResponse>;

