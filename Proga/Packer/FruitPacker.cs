﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class FruitPacker:Packer
    {
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int vitA, int vitC)
        {
            return new Fruit(name, weight, calories, cost, vitA, vitC);
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, string taste, int praceglaze)
        {
            throw new NotImplementedException();
        }
        public override Sweet FactoryMethod(string name, int weight, int calories, int cost, int prockak, string composition)
        {
            throw new NotImplementedException();
        }
    }
}
