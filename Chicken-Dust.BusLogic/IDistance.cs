using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chicken_Dust.BusLogic
{
    internal interface IDistance
    {
        Task<string> Distance(string address, string origins);

        Task<string> DistanceAway(string address,string origins);
    }
}
