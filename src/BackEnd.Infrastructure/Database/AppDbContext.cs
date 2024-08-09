using BackEnd.Application.Core.Abstractions.Data;
using BackEnd.Domain.Core.BaseType;
using Microsoft.EntityFrameworkCore;
using System.Data;
using System.Reflection;

namespace BackEnd.Infrastructure.Database;

public sealed class AppDbContext : DbContext, IDbContext, IUnitOfWork
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

    public new DbSet<TEntity> Set<TEntity>() where TEntity : Entity
    {
        throw new NotImplementedException();
    }

    public Task<IDbTransaction> BeginTransaction(CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    public new Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        throw new NotImplementedException();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
