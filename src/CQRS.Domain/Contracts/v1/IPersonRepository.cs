using CQRS.Domain.Entities.v1;
using System.Linq.Expressions;

namespace CQRS.Domain.Contracts.v1;
public interface IPersonRepository
{
    Task AddAsync(Person person, CancellationToken cancellation);

    Task UpdateAsync(Person person, CancellationToken cancellation);

    Task RemoveAsync(Guid personId, CancellationToken cancellation);

    Task<Person?> FindByIdAsync(Guid personId, CancellationToken cancellation);

    Task<IEnumerable<Person>?> FindAsync(Expression<Func<Person, bool>> expression, CancellationToken cancellation);
}