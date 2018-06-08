using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GameStore2.Models;

namespace GameStore2.Models
{
    public class GameStore2Context : DbContext
    {
        public GameStore2Context (DbContextOptions<GameStore2Context> options)
            : base(options)
        {
        }

        public DbSet<GameStore2.Models.Game> Game { get; set; }

        public DbSet<GameStore2.Models.Cart> Cart { get; set; }
    }
}
