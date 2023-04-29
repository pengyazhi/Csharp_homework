using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public static class Utility
    {
        public static bool IsNumber(string oText)
        {
            int num;
            if (int.TryParse(oText, out num))
            {
                return true;
            }
            else
            {
                return false;
            }
            //try
            //{
            //    double var1 = Convert.ToInt32(oText);
            //    return true;
            //}
            //catch
            //{
            //    return false;
            //}
        }
    }
    

    public struct StudentScore
    {
        public string Name;
        public double Chi ;
        public double Math ;
        public double Eng;
        public double TotalScore;//每筆三科目相加
        public double AverageScore;//每筆三科目平均
        public string HigestSub;//最高科目+名稱
        public string LowestSub;//最低科目+名稱
        //單科總分,最高/低分
        public double ChiTotalScore;
        public double MathTotalScore;
        public double EngTotalScore;
        public double ChiMaxScore ;
        public double ChiMinScore;
        public double MathMaxScore;
        public double MathMinScore;
        public double EngMaxScore;
        public double EngMinScore;
        public bool AddValueToList(string name,string txtChi,string txtMath,string txtEng)
        {
            if (!string.IsNullOrEmpty(name) && Utility.IsNumber(txtChi) && Utility.IsNumber(txtMath) && Utility.IsNumber(txtEng))
            {
                Name = name;
                Chi = Convert.ToDouble(txtChi);
                Math = Convert.ToDouble(txtMath);
                Eng = Convert.ToDouble(txtEng);
                TotalScore = AddUpScore();
                AverageScore = AveScore();
                LowestSub = lowestSub(Chi, Math, Eng);
                HigestSub = higestSub(Chi, Math, Eng);
                return true;
            }
            else
            {
                if (string.IsNullOrEmpty(name))
                {
                    MessageBox.Show("請輸入姓名");
                }
                else
                {
                    MessageBox.Show("請輸入正整數");
                }
                
                return false;
            }
            
                
        }
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

        //public void LS(List<int> ScoreList ,out int lowestScr)
        //{
        //    ScoreList.Sort();
        //    lowestScr = ScoreList[0] ;
            
        //}
        //public void HS(List<int> ScoreList, out int higestScr)
        //{
        //    ScoreList.Sort();
        //    higestScr = ScoreList[ScoreList.Count - 1];
        //}
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
        #region 每科最低分
        public double LS(List<StudentScore> ssl, string subName)
        {
            double min = 0;
            if (subName == "Chi")
            {
                min = Convert.ToDouble(ssl[0].Chi);
                foreach (StudentScore item in ssl)
                {
                    if (item.Chi < min)
                    {
                        min = item.Chi;
                    }
                }
                return min;
            }
            else if (subName == "Math")
            {
                min = Convert.ToDouble(ssl[0].Math);
                foreach (StudentScore item in ssl)
                {
                    if (item.Math < min)
                    {
                        min = item.Math;
                    }
                }
                return min;
            }
            else
            {
                min = Convert.ToDouble(ssl[0].Eng);
                foreach (StudentScore item in ssl)
                {
                    if (item.Eng < min)
                    {
                        min = item.Eng;
                    }
                }
                return min;
            }

        }
        #endregion 每科最低分
        #region 每科最高分
        public double HS(List<StudentScore> ssl, string subName)
        {
            double max = 0;
            if (subName == "Chi")
            {
                max = Convert.ToDouble(ssl[0].Chi);
                foreach (StudentScore item in ssl)
                {
                    if (item.Chi > max)
                    {
                        max = item.Chi;
                    }
                }
            }
            else if (subName == "Math")
            {
                max = Convert.ToDouble(ssl[0].Math);
                foreach (StudentScore item in ssl)
                {
                    if (item.Math > max)
                    {
                        max = item.Math;
                    }
                }
            }
            else
            {
                max = Convert.ToDouble(ssl[0].Eng);
                foreach (StudentScore item in ssl)
                {
                    if (item.Eng > max)
                    {
                        max = item.Eng;
                    }
                }
            }
            return max;
        }
        #endregion 每科最高分
        public void ShowSubCompare(List<StudentScore> ssl)
        {
            foreach (StudentScore item in ssl)
            {
                ChiTotalScore += item.Chi;
                MathTotalScore += item.Math;
                EngTotalScore += item.Eng;
            }

             ChiMaxScore = HS(ssl, "Chi");
             ChiMinScore = LS(ssl, "Chi");
             MathMaxScore = HS(ssl, "Math");
             MathMinScore = LS(ssl, "Math");
             EngMaxScore = HS(ssl, "Eng");
             EngMinScore = LS(ssl, "Eng");
            // 使用中文成績進行升序排序，選擇最低分和最高分
            //ssl.Sort((x, y) => x.Chi.CompareTo(y.Chi));
            //double ChiMinScore = ssl[0].Chi;
            //double ChiMaxScore = ssl[ssl.Count - 1].Chi;

            // 使用數學成績進行升序排序，選擇最低分和最高分
            //ssl.Sort((x, y) => x.Math.CompareTo(y.Math));
            //double MathMinScore = ssl[0].Math;
            //double MathMaxScore = ssl[ssl.Count - 1].Math;

            // 使用英文成績進行升序排序，選擇最低分和最高分
            //ssl.Sort((x, y) => x.Eng.CompareTo(y.Eng));
            //double EngMinScore = ssl[0].Eng;
            //double EngMaxScore = ssl[ssl.Count - 1].Eng;

            //ssl.Sort();
            //double CL = ssl[0].Chi;
            //double ML = ssl[0].Math;
            //double EL = ssl[0].Eng;
            //ssl.Reverse();
            //double CH = ssl[0].Chi;
            //double MH = ssl[0].Math;
            //double EH = ssl[0].Eng;
        }

    }
}
