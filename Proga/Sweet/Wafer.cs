using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Wafer:Sweet
    {
        public string Taste { get; set; }
        public int PraceofGlaze { get; set; }


        public Wafer(string name, int weight, int calories, int cost, string taste, int praceglaze)
            : base(name, weight, calories, cost)
        {
            Taste = taste;
            PraceofGlaze = praceglaze;
        }
        //public override string ToString()
        //{
        //    string myPod = string.Format("Taste : {0} \tPrace of Glaze : {1}",Taste,PraceofGlaze);
        //    myPod += base.ToString();
        //    return myPod;
            
        //}
        public override bool contain(string str)
        {
            if (str == "wafer") return true;
            return false;
        }
    }
}
