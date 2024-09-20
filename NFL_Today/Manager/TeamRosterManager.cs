//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Manager
{
   
    //using Eagles_Roster;
    
    //using System;
    using System.Collections.Generic;
    //using System.Linq;
    //using System.Text;
    //using System.Threading.Tasks;
    using global::NFL_Today.Gateway;
    using global::NFL_Today.Models;

    namespace NFL_Today.Manager
    {
        public class TeamRosterManager
        {
            TeamRosterGateway _teamRosterGateway = new TeamRosterGateway();

            public bool Add(Team_Roster NFLRoster)
            {
                return _teamRosterGateway.Add(NFLRoster);
            }

            public List<Team_Roster> GetAll()
            {
                return _teamRosterGateway.GetAll();
            }

            public bool Update(Team_Roster NFLRoster)
            {
                return _teamRosterGateway.Update(NFLRoster);
            }
            public bool Delete(int id)
            {
                return _teamRosterGateway.Delete(id);
            }
        }

        public class BillsTeamRosterManager
        {
            TeamRosterGateway _teamRosterGateway = new TeamRosterGateway();

            public bool Add(Team_Roster Bills_Roster)
            {
                return _teamRosterGateway.Add(Bills_Roster);
            }

            public List<Team_Roster> GetAll()
            {
                return _teamRosterGateway.GetAll();
            }

            public bool Update(Team_Roster Bills_Roster)
            {
                return _teamRosterGateway.Update(Bills_Roster);
            }
            public bool Delete(int id)
            {
                return _teamRosterGateway.Delete(id);
            }
        }
        //public class TeamRosterManager
        //{
        //    NFLRosterGateway _TeamRosterGateway = new TeamRosterGateway();

        //    public bool Add(NFLRoster NFLRoster)
        //    {
        //        return _NFLRosterGateway.Add(NFLRoster);
        //    }

        //    public List<NFLRoster> GetAll()
        //    {
        //        return _NFLRosterGateway.GetAll();
        //    }

        //    public bool Update(NFLRoster NFLRoster)
        //    {
        //        return _NFLRosterGateway.Update(NFLRoster);
        //    }
        //    public bool Delete(int id)
        //    {
        //        return _NFLRosterGateway.Delete(id);
        //    }
        //}
    }
}
