using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot;

public sealed record GetByNameKiteSpotRequest(string Name) : IRequest<GetByNameKiteSpotResponse>;


