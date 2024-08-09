using System.Data;

namespace BackEnd.Application.Core.Abstractions.Data;

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);


    Task<IDbTransaction> BeginTransaction(CancellationToken cancellationToken);
}
