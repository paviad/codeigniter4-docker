using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiranApp.Models;
using Microsoft.EntityFrameworkCore;

namespace LiranApp {
    public class LiranDb : DbContext {
        public LiranDb(DbContextOptions<LiranDb> options) : base(options) {

        }

        public DbSet<Product> Products { get; set; }
    }
}
