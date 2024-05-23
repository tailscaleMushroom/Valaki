using System.Drawing;
using Valaki.Domain.Common;

namespace Valaki.Domain.Entities
{
    public sealed class KiteSpot : BaseEntity
    {
        public string Name { get; set; }
        public string Coordinates { get; set; }
        public string Difficulty { get; set; }
    }
}
