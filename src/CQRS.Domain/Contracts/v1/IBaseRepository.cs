﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CQRS.Domain.Contracts.v1
{
    public interface IBaseRepository<T> where T : IEntity
    {
        Task AddAsync(T entity, CancellationToken cancellation);

        Task UpdateAsync(T entity, CancellationToken cancellation);

        Task RemoveAsync(Guid id, CancellationToken cancellation);

        Task<T?> FindByIdAsync(Guid id, CancellationToken cancellation);

        Task<IEnumerable<T>?> FindAsync(Expression<Func<T, bool>> expression, CancellationToken cancellation);

    }
}
