using CleanArchitecture.HR.Domain.Common.Interfaces;
using CleanArchitecture.HR.Domain.Common;
using CleanArchitectureHR.Application.Interfaces;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CleanArchitecture.HR.Domain.Entities;

namespace ClearnArchitectureHR.Persistence.Context
{
    public class HrDbContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;

        #region Constructeur
        public HrDbContext(DbContextOptions<HrDbContext> options,
          IDomainEventDispatcher dispatcher)
            : base(options)
        {
            _dispatcher = dispatcher;
        }
        #endregion

        #region Propriétes Navigations
        //public DbSet<Employee> Students => Set<Employee>();
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Location> Locations  { get; set; }
    #endregion

    #region Ovveride Methods

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            foreach (var entry in ChangeTracker.Entries<BaseAuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.Entity.CreatedDate = DateTime.Now;
                        break;
                    case EntityState.Modified:
                        entry.Entity.ModifiedDate = DateTime.Now;
                        break;

                    case EntityState.Deleted:
                        entry.Entity.DeletededDate = DateTime.Now;
                        break;
                }
            }
            //distribuer les événements uniquement si la sauvegarde a réussi
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);
            
            return result;
        }
        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
        #endregion
    }
}
