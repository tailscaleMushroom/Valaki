using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed record GetKiteSpotRequest(string Name) : IRequest<GetKiteSpotResponse>;


