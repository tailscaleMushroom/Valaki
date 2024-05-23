using MediatR;

namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

public sealed record UpdateKiteSpotRequest(Guid Id, string Email, string Name) : IRequest<UpdateKiteSpotResponse>;

