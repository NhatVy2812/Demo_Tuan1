using Demo.Domain.Enitities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Infrastructure.Data
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> dbContextOptions) : base(dbContextOptions) { }
        public DbSet<Product> Products { get; set; }
<<<<<<< HEAD
=======
        public DbSet<User> Users { get; set; }
>>>>>>> 2cb1c2bd7c23700fd265a6d26281c585b2cf16e9
    }
}
