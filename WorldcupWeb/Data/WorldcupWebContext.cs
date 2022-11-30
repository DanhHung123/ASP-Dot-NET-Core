using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WorldcupWeb.Models;

namespace WorldcupWeb.Data
{
    public class WorldcupWebContext : DbContext
    {
        public WorldcupWebContext (DbContextOptions<WorldcupWebContext> options)
            : base(options)
        {
        }

        public DbSet<WorldcupWeb.Models.WorldCup> WorldCup { get; set; } = default!;
    }
}
