using Microsoft.EntityFrameworkCore;
using SuperHeroAPI.Models;
using System;

namespace SuperHeroAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
        : base(options) {}

        public DbSet<SuperHero> SuperHeroes { get; set; }  //DbSet exposes properties which represent the collection of specified entity.
    }
}
