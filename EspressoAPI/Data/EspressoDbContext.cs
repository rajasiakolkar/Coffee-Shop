using System;
using EspressoAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace EspressoAPI.Data
{
    public class EspressoDbContext : DbContext
    {
        public EspressoDbContext()
        {
        }

        public DbSet<Menu> Menus { get; set; }

        public DbSet<Reservation> Reservations { get; set; }

    }
}
