using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
   abstract class Packer
    {
        public abstract Sweet FactoryMethod(string name, int weight, int calories, int cost, int prockak, string composition);
        public abstract Sweet FactoryMethod(string name, int weight, int calories, int cost, int vitA, int vitC);
        public abstract Sweet FactoryMethod(string name, int weight, int calories, int cost, string taste, int praceglaze);
    }
}
