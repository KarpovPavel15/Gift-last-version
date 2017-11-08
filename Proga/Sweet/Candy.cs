using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Candy : Sweet
    {
        public int PercentOfSugar { get; set; }
        public string Сomposition { get; set; }

        public Candy(string name, int weight, int calories, int cost, int percentofsugar, string composition)
            : base(name, weight, calories, cost)
        {
            PercentOfSugar = percentofsugar;
            Сomposition = composition;
        }
    }
}
