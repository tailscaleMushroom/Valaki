using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed record GetKiteSpotRequest(Guid Id) : IRequest<GetKiteSpotResponse>;


