using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Form
{
    public static class Utility
    {
        public static bool IsNumber(string oText)
        {
            try
            {
                int var1 = Convert.ToInt32(oText);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    //public struct Menu
    //{
    //    public string ProductName { get; set; }
    //    public string ProductEngName { get; set; }
    //    public int NumOfProduct {get; set; }
    //    public string PriceOfProduct { get; set; }

    //    Menu(string ProductName, int NumOfProduct, string PriceOfProduct)
    //    {
    //        this.ProductName = ProductName;
    //        this.ProductEngName = ProductName;
    //        this.NumOfProduct = NumOfProduct;
    //        this.PriceOfProduct = PriceOfProduct;
    //    }

    //}
    public struct StudentScore
    {
        
        public string Name { get; set; }
        public int Chi { get; set; }
        public int Math { get; set; }
        public int Eng { get; set; }
        //public int TotalScore;
        //public int AverageScore;
        //public int LowestScore { get; set; }
        //public int HigestScore { get; set; }
        //public string LowestSub;
        //public string HigestSub;
        public StudentScore(string name, int chi, int math, int eng/*,
        int total_score, int ave_score, string lowest_sub, string higestest_sub*/)
        {
            Name = name;
            Chi = chi;
            Math = math;
            Eng = eng;
            //TotalScore = total_score;
            //AverageScore = ave_score;
            //LowestSub = lowest_sub;
            //HigestSub = higestest_sub;
        }
        public int AddUpGrade(int chi, int math, int eng)//總分
        {
            int[] CountGrade = { chi, math, eng };
            int TotalScore = 0;
            for (int i = 0; i < CountGrade.Length; i++)
            {
                TotalScore += CountGrade[i];
            }
            return TotalScore;
        }
        public int AveGrade(int chi, int math, int eng)//平均
        {
            int AverageScore = AddUpGrade(chi, math, eng)/3;
            return AverageScore;
        }
        
        public string higestSub(int chi, int math, int eng)
        {
            string HigestSub = "國文"; 
            HigestSub = (math > chi && math > eng) ? 
                $"數學{math}" : (eng > chi) ? $"英文{eng}" : HigestSub+ chi;
            return HigestSub ;
            //if (math > HigestGrade)
            //{
            //    HigestGrade = math;
            //    HigestSub = "數學";

            //}
            //if (eng > HigestGrade)
            //{
            //    HigestGrade = eng;
            //    HigestSub = "英文";
            //}
        }
        public string lowestSub(int chi, int math, int eng)
        {
            string LowestSub = "國文";
            LowestSub = (math < chi && math < eng) ?
                $"數學{math}" : (eng < chi) ? $"英文{eng}" : LowestSub + chi;
            return LowestSub ;
            //if (math < LowestGrade)
            //{
            //    LowestGrade = math;
            //    LowestSub = "數學";
            //}
            //if (eng < LowestGrade)
            //{
            //    LowestGrade = eng;
            //    LowestSub = "英文";
            //}
        }
    }
}
