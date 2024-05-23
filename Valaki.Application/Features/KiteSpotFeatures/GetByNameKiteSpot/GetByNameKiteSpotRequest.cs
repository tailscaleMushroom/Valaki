using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.GetByNameKiteSpot;

public sealed record GetByNameKiteSpotRequest(string Name) : IRequest<KiteSpotResponse>;


