using System;
using EspressoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EspressoAPI.Data
{
    public class EspressoDbContext : DbContext
    {
        public EspressoDbContext(DbContextOptions<EspressoDbContext>options):base(options)
        {
        }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
