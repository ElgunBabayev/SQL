using HomeWorkApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWorkApp.DAL
{
    public class FirstDbContext : DbContext

    {
        public FirstDbContext(DbContextOptions<FirstDbContext> options):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
