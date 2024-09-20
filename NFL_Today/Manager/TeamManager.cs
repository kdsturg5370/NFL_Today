//using Eagles_Roster;
using NFL_Today.Gateway;
using NFL_Today.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Manager
{
    public class TeamManager
    {
        TeamsGateway _TeamsGateway=new TeamsGateway();

        public bool Add(Teams Team)
        {
            return _TeamsGateway.Add(Team);
        }

        public List<Teams> GetAll()
        {
            return _TeamsGateway.GetAll();    
        }

        public bool Update(Teams Team)
        {
            return _TeamsGateway.Update(Team);
        }
        public bool Delete(int id)
        {
            return _TeamsGateway.Delete(id);
        }
    }

    
}
