﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valaki.Domain.Common;

namespace Valaki.Application.Repositories
{
    public interface IBaseRepository<T> where T : BaseEntity
    {
        void Create(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task<T> Get(Guid id, CancellationToken cancellationToken);
        Task<List<T>> GetAll(CancellationToken cancellationToken);
    }
}
