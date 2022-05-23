using Microsoft.EntityFrameworkCore;
using Practice_Pustok_Website.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practice_Pustok_Website.Data_access_layer
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Slider> sliders { get; set; }
    }
}
