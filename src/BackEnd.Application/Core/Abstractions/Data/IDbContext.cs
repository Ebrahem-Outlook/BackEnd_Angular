using BackEnd.Domain.Core.BaseType;
using Microsoft.EntityFrameworkCore;

namespace BackEnd.Application.Core.Abstractions.Data;

public interface IDbContext
{
    DbSet<TEntity> Set<TEntity>() where TEntity : Entity;
}
