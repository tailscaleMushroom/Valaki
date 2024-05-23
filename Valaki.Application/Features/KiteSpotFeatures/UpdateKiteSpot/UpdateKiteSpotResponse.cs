using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valaki.Application.Features.KiteSpotFeatures.UpdateKiteSpot;

public sealed record UpdateKiteSpotResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
}

