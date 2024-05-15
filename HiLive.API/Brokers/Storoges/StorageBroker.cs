// ---------------------------------------------------------------
// Copyright (c) Coalition of the Good-Hearted Engineers
// FREE TO USE TO CONNECT THE WORLD
// ---------------------------------------------------------------



using Microsoft.EntityFrameworkCore;
using STX.EFxceptions.SqlServer;

namespace HiLive.API.Brokers.Storoges
{
    internal partial class StorageBroker : EFxceptionsContext
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
    }
}
