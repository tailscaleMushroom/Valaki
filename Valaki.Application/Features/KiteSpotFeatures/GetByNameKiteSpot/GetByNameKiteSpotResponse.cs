using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valaki.Application.Features.KiteSpotFeatures.GetKiteSpot
{
    public sealed record GetByNameKiteSpotResponse
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
    }
}
