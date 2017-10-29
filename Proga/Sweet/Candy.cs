using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proga
{
    class Candy:Sweet
    {
        public int ProcKakao { get; set; }
        public string Сomposition{ get; set; }

        public Candy(string name, int weight, int calories, int cost, int prockak, string composition)
            : base(name, weight, calories, cost)
        {
            ProcKakao = prockak;
            Сomposition  = composition;
        }
        //public override string ToString()
        //{
        //    string myPod = string.Format("Procent of Kakao: {0} \tСomposition: {1}", ProcKakao, Сomposition);
        //    myPod += base.ToString();
        //    return myPod;
        //}
        public override bool contain(string str)
        {
            if (str == "candy") return true;
            return false;
        }
    }
}
