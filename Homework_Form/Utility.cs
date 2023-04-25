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
                double var1 = Convert.ToInt32(oText);
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
    //    public double NumOfProduct {get; set; }
    //    public string PriceOfProduct { get; set; }

    //    Menu(string ProductName, double NumOfProduct, string PriceOfProduct)
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
        public double Chi { get; set; }
        public double Math { get; set; }
        public double Eng { get; set; }
        //public double TotalScore;
        //public double AverageScore;
        //public double LowestScore { get; set; }
        //public double HigestScore { get; set; }
        //public string LowestSub;
        //public string HigestSub;
        public StudentScore(string name, double chi, double math, double eng/*,
        double total_score, double ave_score, string lowest_sub, string higestest_sub*/)
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
        public double AddUpScore(double chi, double math, double eng)//總分
        {
            double[] CountScore = { chi, math, eng };
            double TotalScore = 0;
            for (int i = 0; i < CountScore.Length; i++)
            {
                TotalScore += CountScore[i];
            }
            return TotalScore;
        }
        public double AveScore(double chi, double math, double eng)//平均
        {
            double AverageScore = AddUpScore(chi, math, eng)/3;
            return  AverageScore;
        }
        
        public string higestSub(double chi, double math, double eng)
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
        public string lowestSub(double chi, double math, double eng)
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
