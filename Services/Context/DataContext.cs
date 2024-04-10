using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrometoFoodTruckBackEnd.Services.Context
{
    public class DataContext : DbContext
    {
    public DbSet<UserModel> UserInfo { get; set; }
    public DbSet<AppItemModel> UserInfo { get; set; }

    public DataContext(DbContextOptions options): base(options){}

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
    }
}