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
        public string Name;
        public double Chi ;
        public double Math ;
        public double Eng ;
        public double TotalScore;
        public double AverageScore;
        public string HigestSub;
        public string LowestSub;
        public double AddUpScore(List<int> ScoreList)//總分
        {
            TotalScore = 0;
            foreach(int item in ScoreList)
            {
                TotalScore += item;
            }
            return TotalScore;
        }

        public double AveScore(List<int> ScoreList)//平均
        {
            AverageScore = AddUpScore(ScoreList) / ScoreList.Count;
            return  AverageScore;
        }
        
        public void LowestAndHigestSub(List<int> ScoreList ,out int lowestScr,out int higestScr)
        {
            ScoreList.Sort();
            lowestScr = ScoreList[0] ;
            higestScr = ScoreList[ScoreList.Count-1];
        }
        public string higestSub(double chi, double math, double eng)
        {
            HigestSub = "國文";
            HigestSub = (math > chi && math > eng) ?
                $"數學{math}" : (eng > chi) ? $"英文{eng}" : HigestSub + chi;
            return HigestSub;
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
            LowestSub = "國文";
            LowestSub = (math < chi && math < eng) ?
                $"數學{math}" : (eng < chi) ? $"英文{eng}" : LowestSub + chi;
            return LowestSub;
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
