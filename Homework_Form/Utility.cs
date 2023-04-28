using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
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
        public double Eng;
        public double TotalScore;
        public double AverageScore;
        public string HigestSub;
        public string LowestSub;
        //public double ChiTotalScore;
        //public double MathTotalScore;
        //public double EngTotalScore;
        public double AddUpScore()//總分
        {
            TotalScore =Chi +Math +Eng;
            return TotalScore;
        }
        


        public double AveScore()//平均
        {
            AverageScore = TotalScore / 3;
            return AverageScore;
        }

        public void LS(List<int> ScoreList ,out int lowestScr)
        {
            ScoreList.Sort();
            lowestScr = ScoreList[0] ;
            
        }
        public void HS(List<int> ScoreList, out int higestScr)
        {
            ScoreList.Sort();
            higestScr = ScoreList[ScoreList.Count - 1];
        }
        public string higestSub(double chi, double math, double eng)
        {
            HigestSub = "國文";
            HigestSub = (math > chi && math > eng) ?
                $"數學{math}" : (eng > chi) ? $"英文{eng}" : HigestSub + chi;
            return HigestSub;
            
        }
        public string lowestSub(double chi, double math, double eng)
        {
            LowestSub = "國文";
            LowestSub = (math < chi && math < eng) ?
                $"數學{math}" : (eng < chi) ? $"英文{eng}" : LowestSub + chi;
            return LowestSub;
           
        }
    }
}
