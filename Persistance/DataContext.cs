using System;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistance
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options): base(options)
        {
            
        }

        public DbSet<Weather> Weathers { get; set; }
        public DbSet<Activity> Activities { get; set; }
        protected override void OnModelCreating(ModelBuilder builder){
            builder.Entity<Weather>()
            .HasData(
                new Weather{Id=1, WeatherDate=DateTime.Now, TemperetureC=20, TemperetureF=50, Summary="windy"},
                new Weather{Id=2, WeatherDate=DateTime.Now, TemperetureC=15, TemperetureF=30, Summary="fogy"},
                new Weather{Id=3, WeatherDate=DateTime.Now, TemperetureC=5, TemperetureF=20, Summary="freezing"}
            );
        }
    }
}
