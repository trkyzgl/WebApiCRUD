using ApiCrud.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ApiCrud.DataAccess
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options):base(options)
        {
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Car> Cars { get; set; }
    }
}
