using NFL_Today.Gateway;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace NFL_Today.Manager
{
    public class FanPlayStatsManager

    {
        FanPlayStatsGateway _FanPlayStatsGateway = new FanPlayStatsGateway();
        
        public bool Delete(int id)
        {
            return _FanPlayStatsGateway.Delete(id);
        }
    }
}

