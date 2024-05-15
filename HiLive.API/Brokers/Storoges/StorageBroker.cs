﻿// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using HiLive.API.Models.VideoMetadatas;
using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;

namespace HiLive.API.Brokers.Storoges
{
    public partial class StorageBroker : EFxceptionsContext, IStorageBroker
    {
        private readonly IConfiguration _configuration;

        public StorageBroker(IConfiguration configuration)
        {
            _configuration = configuration;
            this.Database.Migrate();
        }

        protected override void  OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionString = this._configuration.GetConnectionString("DefaultConnection")!;
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            optionsBuilder.UseSqlServer(connectionString);
        }

        private async ValueTask<T> InsertAsync<T>(T @object)
        {
            var broker = new StorageBroker(this._configuration);
            broker.Entry(@object).State = EntityState.Added;
            await broker.SaveChangesAsync();

            return @object;
        }

        private IQueryable<T> SelectAll<T>() where T : class
        {
            var broker = new StorageBroker(this._configuration);
            return broker.Set<T>();
        }

        private async ValueTask<T?> SelectAsync<T>(params object[] objectIds) where T : class =>
            await FindAsync<T>(objectIds);
    }
}
