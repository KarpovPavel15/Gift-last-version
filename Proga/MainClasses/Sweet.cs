using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Sweet : IComparable
    {

        public string Name { get; set; }

        public int Weight { get; set; }

        public int Calories { get; set; }

        public int Cost { get; set; }

        public Sweet() { }


        public Sweet(string name, int weight, int calories, int cost)
        {
            Name = name;
            Weight = weight;
            Calories = calories;
            Cost = cost;
        }

        public override string ToString()
        {
            string ThisPod = string.Format("  Name: {0} \tWeight: {1} \tCalories: {2} \tCost: {3}", Name, Weight, Calories, Cost);
            return ThisPod;
        }
        public virtual bool contain(string str)
        {
            if (str == "sweet") return true;
            return false;
        }

        public int CompareTo(object obj)
        {
            if (obj is Sweet)
                return this.Calories.CompareTo((obj as Sweet).Calories);
            return 0;


        }
    }
}
