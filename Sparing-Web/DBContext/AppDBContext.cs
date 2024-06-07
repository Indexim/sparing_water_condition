using Microsoft.EntityFrameworkCore;
using Sparing_Web.Models;
using System;

namespace Sparing_Web.DBContext
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<WaterCondition> WaterConditions { get; set; }
    }
}
