using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Wafer : Sweet
    {
        public string KindOfWafer { get; set; }
        public string Taste { get; set; }


        public Wafer(string name, int weight, int calories, int cost, string kindofwafer, string taste)
            : base(name, weight, calories, cost)
        {
            KindOfWafer = kindofwafer;
            Taste = taste;
        }
    }
}
