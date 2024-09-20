using Microsoft.EntityFrameworkCore;
//using Eagles_Roster;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Models
{
    public class ApplicationDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source=C:\Users\kdsturg5370\source\repos\NFL_Today\DB\NFLDB.db");
        }
        public DbSet<Teams> Teams { get; set; }

        public DbSet<Def_Stats> def_Stats { get; set; }

        public DbSet<Team_Roster> SF_Roster { get; set; }

        public DbSet<Team_Roster> Team_Roster { get; set; }

        public DbSet<Player_Fantasy_Stats> Player_Fantasy_Stats { get; set; }
    }
}

