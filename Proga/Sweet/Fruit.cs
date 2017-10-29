using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Fruit:Sweet
    {
        public int ProcVitA { get; set; }
        public int ProcVitC { get; set; }

        public Fruit(string name, int weight, int calories, int cost, int vitA, int vitC)
            : base(name, weight, calories, cost)
        {
            ProcVitA = vitA;
            ProcVitC = vitC;
        }
        //public override string ToString()
        //{
        //    string myPod = base.ToString();
        //    myPod += string.Format("Procent Of Vitamin A : {0} \tProcent of Vitamin C : {1} ", ProcVitA, ProcVitC);
        //    return myPod;
        //}
        public override bool contain(string str)
        {
            if (str == "fruit") return true;
            return false;
        }
    }
}
