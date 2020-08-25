using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WishList.Models;

namespace WishList.Data
{
    public class ApplicationDbContext : DbContext
    {
        private static DbContextOptions options;

        public ApplicationDbContext(DbContextOptions dbContextOptions) : base(options)
        {

        }
        public DbSet<Item> Items { get; set; }
    }
}
