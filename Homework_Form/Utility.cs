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
        //public int TotalGrade { get; set; }
        //public int AverageGrade { get;set; }
        //public int LowestGrade { get; set; }
        //public int HigestGrade { get; set; }
        StudentScore(string name,int chi ,int math,int eng)
        {
            Name = name;
            Chi = chi;
            Math = math;
            Eng = eng;
        }
        public int AddGrade(int chi, int math, int eng)//相加
        {
            int[] CountGrade = { chi, math, eng };
            int TotalGrade = 0;
            for (int i = 0; i < CountGrade.Length; i++)
            {
                TotalGrade += CountGrade[i];
            }
            return TotalGrade;
        }
        public int AveGrade(int chi, int math, int eng)//平均
        {

            int aveGrade = AddGrade(chi, math, eng)/3;
            return aveGrade;
        }
        public string Max(int chi, int math, int eng)
        {
            string Max = "國文";
            
            int HighestScore = chi;
            
            if (Math > HighestScore)
            {
                HighestScore = Math;
                Max = "數學";

            }
            if (Eng > HighestScore)
            {
                HighestScore = Eng;
                Max = "英文";
            }
            
            return Max + HighestScore;
        }
        public string Min(int chi, int math, int eng)
        {
            string Min = "國文";
            int LowestScore = chi;
            if (Math < LowestScore)
            {
                LowestScore = Math;
                Min = "數學";
            }
            if (Eng < LowestScore)
            {
                LowestScore = Eng;
                Min = "英文";
            }
            return Min + LowestScore ;
        }
    }
}
