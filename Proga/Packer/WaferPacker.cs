using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class WaferPacker:Packer
    {
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, string taste, int praceglaze)
        {
            return new Wafer(name,weight,calories,cost, taste, praceglaze);
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int vitA, int vitC)
        {
            throw new NotImplementedException();
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int prockak, string composition)
        {
            throw new NotImplementedException();
        }
    }
}
