using NFL_Today.Models;
//using Eagles_Roster;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Gateway
{
    public class DefStatsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Def_Stats def_Stats)
        {
            _dbContext.def_Stats.Add(def_Stats);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Def_Stats> GetAll()
        {
            return _dbContext.def_Stats.ToList();
        }

        public bool Update(Def_Stats def_Stats)
        {
            var data = _dbContext.def_Stats.FirstOrDefault(c => c.Id == def_Stats.Id);
            if (data == null)
            {
                return false;
            }
            data.Rank = def_Stats.Rank;
            data.Team = def_Stats.Team;
            data.Player = def_Stats.Player;
            data.Position = def_Stats.Position;
            data.GamesPlayed = def_Stats.GamesPlayed;
            data.SoloTackles = def_Stats.SoloTackles;
            data.AssistedTackles = def_Stats.AssistedTackles;
            data.TotalTackles = def_Stats.TotalTackles;
            data.Sacks = def_Stats.Sacks;
            data.SackYards = def_Stats.SackYards;
            data.TacklesforLoss = def_Stats.TacklesforLoss;
            data.PassesDefended = def_Stats.PassesDefended;
            data.Interceptions = def_Stats.Interceptions;
            data.InterceptionReturnYards = def_Stats.InterceptionReturnYards;
            data.LongInterception = def_Stats.LongInterception;
            data.ReturnTouchdowns = def_Stats.ReturnTouchdowns;
            data.ForcedFumbles = def_Stats.ForcedFumbles;
            data.FumblesRecovered = def_Stats.FumblesRecovered;
            data.FumbleTouchdown = def_Stats.FumbleTouchdown;
            

            return _dbContext.SaveChanges() > 0;

        }
        public bool Delete(int id)
        {
            var def_Stats = _dbContext.def_Stats.FirstOrDefault(s => s.Id == id);
            if (def_Stats == null)
            {
                return false;
            }
            _dbContext.def_Stats.Remove(def_Stats);
            return _dbContext.SaveChanges() > 0;

        
        }
    }
}
