using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Fruit : Sweet
    {
        public int ProcVitA { get; set; }
        public int ProcVitC { get; set; }

        public Fruit(string name, int weight, int calories, int cost, int vitA, int vitC)
            : base(name, weight, calories, cost)
        {
            ProcVitA = vitA;
            ProcVitC = vitC;
        }
    }
}
