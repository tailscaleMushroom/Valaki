using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valaki.Domain.Entities;

namespace Valaki.Application.Repositories
{
    public interface IKiteSpotRepository : IBaseRepository<KiteSpot>
    {
        Task<KiteSpot> GetByName(string name, CancellationToken cancellationToken);
    }
}
