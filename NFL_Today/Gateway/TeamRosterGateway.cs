using NFL_Today.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Gateway
{
    public class TeamRosterGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Team_Roster SF_Roster)
        {
            _dbContext.SF_Roster.Add(SF_Roster);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Team_Roster> GetAll()
        {
            return _dbContext.SF_Roster.ToList();
        }

        public bool Update(Team_Roster SF_Roster)
        {
            var data = _dbContext.SF_Roster.FirstOrDefault(c => c.Id == SF_Roster.Id);
            if (data == null)
            {
                return false;
            }
            //data.Team = SF_Roster.Pos;
            data.Pos = SF_Roster.Pos;
            data.Name = SF_Roster.Name;
            data.No = SF_Roster.No;
            data.Rating = SF_Roster.Rating;
            data.Ranking = SF_Roster.Ranking;
            data.Height = SF_Roster.Height;
            data.Weight = SF_Roster.Weight;
            data.Age = SF_Roster.Age;
            data.Birthday = SF_Roster.Birthday;
            data.Exp = SF_Roster.Exp;
            data.Drafted = SF_Roster.Drafted;
            data.DraftRound = SF_Roster.DraftRound;
            data.DraftPick = SF_Roster.DraftPick;
            data.College = SF_Roster.College;



            return _dbContext.SaveChanges() > 0;

        }
        public bool Delete(int id)
        {
            var team_Rosters = _dbContext.SF_Roster.FirstOrDefault(s => s.Id == id);
            if (team_Rosters == null)
            {
                return false;
            }
            _dbContext.SF_Roster.Remove(team_Rosters);
            return _dbContext.SaveChanges() > 0;


        }




    }
    public class NFLRostersGateway
    {
        ApplicationDbContext _dbContext = new ApplicationDbContext();

        public bool Add(Team_Roster Team_Roster)
        {
            _dbContext.Team_Roster.Add(Team_Roster);
            return _dbContext.SaveChanges() > 0;
        }

        public List<Team_Roster> GetAll()
        {
            return _dbContext.Team_Roster.ToList();
        }

        public bool Update(Team_Roster Team_Roster)
        {
            var data = _dbContext.Team_Roster.FirstOrDefault(c => c.Id == Team_Roster.Id);
            if (data == null)
            {
                return false;
            }
            data.Team = Team_Roster.Team;
            data.Pos = Team_Roster.Pos;
            data.Name = Team_Roster.Name;
            data.No = Team_Roster.No;
            data.Rating = Team_Roster.Rating;
            data.Ranking = Team_Roster.Ranking;
            data.Height = Team_Roster.Height;
            data.Weight = Team_Roster.Weight;
            data.Age = Team_Roster.Age;
            data.Birthday = Team_Roster.Birthday;
            data.Exp = Team_Roster.Exp;
            data.Drafted = Team_Roster.Drafted;
            data.DraftRound = Team_Roster.DraftRound;
            data.DraftPick = Team_Roster.DraftPick;
            data.College = Team_Roster.College;



            return _dbContext.SaveChanges() > 0;

        }
        public bool Delete(int id)
        {
            var team_Rosters = _dbContext.Team_Roster.FirstOrDefault(s => s.Id == id);
            if (team_Rosters == null)
            {
                return false;
            }
            _dbContext.Team_Roster.Remove(team_Rosters);
            return _dbContext.SaveChanges() > 0;


        }
    }
}