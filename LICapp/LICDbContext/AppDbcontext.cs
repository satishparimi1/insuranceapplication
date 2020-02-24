using LICapp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LICapp.LICDbContext
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {

        }

        public DbSet<Carrier> Carriers { get; set; }
        public DbSet<MGA> MGAs { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Contract> contracts { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
