using NFL_Today.Gateway;
//using Eagles_Roster;
using NFL_Today.Models;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Manager
{
    public class DefStatsManager
    {
        DefStatsGateway _defStatsGateway = new DefStatsGateway();

        public bool Add(Def_Stats def_Stats)
        {
            return _defStatsGateway.Add(def_Stats);
        }

        public List<Def_Stats> GetAll()
        {
            return _defStatsGateway.GetAll();
        }

        public bool Update(Def_Stats def_Stats)
        {
            return _defStatsGateway.Update(def_Stats);
        }
        public bool Delete(int id)
        {
            return _defStatsGateway.Delete(id);
        }
    }
}
