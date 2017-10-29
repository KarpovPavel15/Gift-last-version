using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class CandyPacker:Packer
    {
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int prockak, string compositionstring )
        {
            return new Candy(name, weight, calories, cost, prockak, compositionstring);
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int vitA, int vitC)
        {
            throw new NotImplementedException();
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, string taste, int praceglaze)
        {
            throw new NotImplementedException();
        }
    }
}
