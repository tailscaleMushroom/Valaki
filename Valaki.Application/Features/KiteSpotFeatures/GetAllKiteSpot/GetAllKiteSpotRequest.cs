using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valaki.Application.Features.KiteSpotFeatures.GetAllKiteSpot;

public sealed record GetAllKiteSpotRequest : IRequest<List<KiteSpotResponse>>;

