using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valaki.Application.Repositories;
using Valaki.Domain.Entities;
using Valaki.Persistence.Context;

namespace Valaki.Persistence.Repositories
{
    public class KiteSpotRepository : BaseRepository<KiteSpot>, IKiteSpotRepository
    {
        public KiteSpotRepository(DataContext context) : base(context)
        { 
        }

        public Task<KiteSpot> GetByEmail(string email, CancellationToken cancellationToken)
        {
            return Context.KiteSpots.FirstOrDefaultAsync(x => x.Email == email, cancellationToken);
        }

        public Task<KiteSpot> GetByName(string name, CancellationToken cancellationToken)
        {
            return Context.KiteSpots.FirstOrDefaultAsync(x => x.Email == name, cancellationToken);
        }
    }
}
