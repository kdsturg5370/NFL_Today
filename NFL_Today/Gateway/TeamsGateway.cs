using NFL_Today.Models;
//using Eagles_Roster;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Gateway
{
    public class TeamsGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Teams Team)
        {
            _dbContext.Teams.Add(Team);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Teams> GetAll()
        {
            return _dbContext.Teams.ToList();
        }

        public bool Update(Teams Team)
        {
            var data = _dbContext.Teams.FirstOrDefault(c => c.Id == Team.Id);
            if (data == null)
            {
                return false;
            }
            data.Name = Team.Name;
            data.Season = Team.Season;
            data.PTS = Team.PTS;
            data.FPTS = Team.FPTS;
            data.Plays = Team.Plays;
            data.Yds = Team.Yds;
            data.Int = Team.Int;
            data.Pass_Yds = Team.Pass_Yds;
            data.Pass_Att = Team.Pass_Att;
            data.Pass_Comp = Team.Pass_Comp;
            data.Pass_TD = Team.Pass_TD;
            data.Rush_Yds = Team.Rush_Yds;
            data.Rush_Att = Team.Rush_Att;
            data.Rush_TD = Team.Rush_TD;
            data.TD = Team.TD;
            data.RZ_Att = Team.RZ_Att;
            data.RZ_TD = Team.RZ_TD;
            data.RZ_TD1 = Team.RZ_TD1;
            data.RZ_2D = Team.RZ_2D;
            data.RZ_3D = Team.RZ_4D;
            data.RZ_4D = Team.RZ_4D;
            data.TO = Team.TO;
            data.SCKS_Allow = Team.SCKS_Allow;

            return _dbContext.SaveChanges() > 0;

        }
        public bool Delete(int id)
        {
            var Team = _dbContext.Teams.FirstOrDefault(s => s.Id == id);
            if (Team == null)
            {
                return false;
            }
            _dbContext.Teams.Remove(Team);
            return _dbContext.SaveChanges() > 0;
        }
    }
    

}
