using BackEnd.Domain.Core.BaseType;
using System.Data;

namespace BackEnd.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}

public interface IUnitOfWork
{
    Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);


    Task<IDbTransaction> BeginTransaction(CancellationToken cancellationToken);
}
