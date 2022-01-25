using COMMON.DomainModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;
using System.Threading.Tasks;

namespace DATA.Contracts
{
    public interface IPracticeContextUnitOfWork
    {
        DbSet<Test> Test { get; set; }

        DbSet<Car> Car { get; set; }


        int SaveChanges();
        Task<int> SaveChangesAsync();
        public EntityEntry<TEntity> Entry<TEntity>([NotNull] TEntity entity) where TEntity : class;
        public void Dispose();
        public ValueTask DisposeAsync();
        public DatabaseFacade Database { get; }
        public DbSet<TEntity> Set<TEntity>() where TEntity : class;
    }
}
