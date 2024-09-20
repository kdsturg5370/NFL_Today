using NFL_Today.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Gateway
{
    public class FanPlayStatsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        //public bool Add(Player_Fantasy_Stats Player_Fantasy_Stats)
        //{
        //    _dbContext.Player_Fantasy_Stats.Add(Player_Fantasy_Stats);
        //    return _dbContext.SaveChanges() > 0;
        //}
        //public List<Player_Fantasy_Stats> GetAll()
        //{
        //    return _dbContext.Player_Fantasy_Stats.ToList();
        //}

        //public bool Update(Player_Fantasy_Stats Player_Fantasy_Stats)
        //{
        //    var data = _dbContext.Player_Fantasy_Stats.FirstOrDefault(c => c.Id == Player_Fantasy_Stats.Id);
        //    if (data == null)
        //    {
        //        return false;
        //    }
        //    data.Full_Name = Player_Fantasy_Stats.Full_Name;
        //    data.Team = Player_Fantasy_Stats.Team;
        //    data.Position = Player_Fantasy_Stats.Position;
        //    data.Position = Player_Fantasy_Stats.Position;
        //    data.Games = Player_Fantasy_Stats.Games;
        //    data.Snaps_PG = Player_Fantasy_Stats.Snaps_PG;
        //    data.Pct_Team_Snaps = Player_Fantasy_Stats.Pct_Team_Snaps;
        //    data.Pct_Team_First_Snaps = Player_Fantasy_Stats.Pct_Team_First_Snaps;
        //    data.Pct_Team_Second_Snaps = Player_Fantasy_Stats.Pct_Team_Second_Snaps;
        //    data.Pct_Team_Third_Snaps = Player_Fantasy_Stats.Pct_Team_Third_Snaps;
        //    data.RZ_Snaps_PG = Player_Fantasy_Stats.RZ_Snaps_PG;
        //    data.Pct_Team_RZ_Snaps = Player_Fantasy_Stats.Pct_Team_RZ_Snaps;
        //    data.Ppr_Points = Player_Fantasy_Stats.Ppr_Points;
        //    data.Ppr_Points_PG = Player_Fantasy_Stats.Ppr_Points_PG;
        //    data.Exp_Fpts = Player_Fantasy_Stats.Exp_Fpts;
        //    data.Exp_Fpts_PG = Player_Fantasy_Stats.Exp_Fpts_PG;
        //    data.Fpoe = Player_Fantasy_Stats.Fpoe;
        //    data.Fpoe_PG = Player_Fantasy_Stats.Fpoe_PG;
        //    data.Exp_Pass_Fpts = Player_Fantasy_Stats.Exp_Pass_Fpts;

        //    data.Exp_Pass_Fpts_PG = Player_Fantasy_Stats.Exp_Pass_Fpts_PG;
        //    data.Exp_Rush_Fpts = Player_Fantasy_Stats.Exp_Rush_Fpts;
        //    data.Exp_Rush_Fpts_PG = Player_Fantasy_Stats.Exp_Rush_Fpts_PG;
        //    data.Exp_Rec_Fpts = Player_Fantasy_Stats.Exp_Rec_Fpts;
        //    data.Exp_Rec_Fpts_PG = Player_Fantasy_Stats.Exp_Rec_Fpts_PG;


        //    return _dbContext.SaveChanges() > 0;

        //}
        public bool Delete(int id)
        {
            var Player_Fantasy_Stats = _dbContext.Player_Fantasy_Stats.FirstOrDefault(s => s.Id == id);
            if (Player_Fantasy_Stats == null)
            {
                return false;
            }
            _dbContext.Player_Fantasy_Stats.Remove(Player_Fantasy_Stats);
            return _dbContext.SaveChanges() > 0;
        }

    }
}
