using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_H08_ForDoWhileMethod : Form
    {
        public Frm_H08_ForDoWhileMethod()
        {
            InitializeComponent();
        }

        private void btnOddEven_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtOddEven.Text, out int num))
            {
                if (num % 2 == 0 && num > 0)
                {
                    labShowResult.Text = $"輸入的數字為：{num},為偶數";
                }
                else if (num % 2 == 1 && num > 0)
                {
                    labShowResult.Text = $"輸入的數字為：{num},為奇數";
                }
                else
                {
                    MessageBox.Show("0為自然數");
                    txtOddEven.Text = "";
                    txtOddEven.Focus();
                }
            }
            else
            {
                MessageBox.Show("請輸入數值");
                txtOddEven.Text = "";
                txtOddEven.Focus();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "結果";
        }
        int[] arr0711 = { 1, 5, 6, 8, 7, 97, 54, 887, 65, 578 };
        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            int max = arr0711[0];
            int min = arr0711[0];
            foreach (int i in arr0711)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            foreach (int i in arr0711)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            labShowResult.Text = $"int陣列0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為：{max}\n最小值為：{min}";

        }

        private void btnNumOfOddEven_Click(object sender, EventArgs e)
        {
            int even = 0;
            int odd = 0;
            foreach (int i in arr0711)
            {
                if (i % 2 == 0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            labShowResult.Text = $"int陣列0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n偶數值有：{even}個\n奇數值有：{odd}個";
        }
        string[] name0711 = { "mother張", "emma", "迪克蕭", "J04", "Candy", "Cindy", "Coconut", "Motherfacker" };
        private void btnLongestName_Click(object sender, EventArgs e)
        {
            string longestChar = "";
            foreach (string i in name0711)
            {
                if (i.Length > longestChar.Length)
                {
                    longestChar = i;
                }
            }
            labShowResult.Text = $"陣列arr0711_Str [ mother張 \n,emma, 迪克蕭, J04, Candy,Cindy, Coconut, Motherfacker ]\n最長的名字為{longestChar}";
        }

        private void btnContainCc_Click(object sender, EventArgs e)
        {
            int num = 0;
            foreach (string i in name0711)
            {
                if (i.Contains("C") || i.Contains("c"))
                {
                    num++;
                }
            }
            labShowResult.Text = $"陣列arr0711_Str [ mother張 \n,emma, 迪克蕭, J04, Candy,Cindy, Coconut, Motherfacker ]\n有C或c的名字共有{num}個";
        }
        int[,] arr = new int[10, 10];//int[i,j]
        void DisplayArr()
        {
            labShowResult.Text = "";
            for (int i = 0; i < arr.GetLength(0); i++)//參數0為第一維度=10
            {
                for (int j = 0; j < arr.GetLength(1); j++)//參數1為第二維度=10
                {
                    labShowResult.Text += arr[i, j].ToString() + "   ";
                }
                labShowResult.Text += "\n";
            }
        }
        private void btnOutsideOne_Click(object sender, EventArgs e)
        {

            //row
            for (int j = 0; j < 10; j++)
            {
                arr[0, j] = 1;
                arr[9, j] = 1;
            }
            for (int i = 1; i < 9; i++)
            {
                arr[i, 0] = 1;
                arr[i, 9] = 1;
            }
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    arr[i, j] = 0;

                }
            }
            DisplayArr();
        }

        private void btnInsideOne_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 10; j++)
            {
                arr[0, j] = 0;
                arr[9, j] = 0;
            }
            for (int i = 1; i < 9; i++)
            {
                arr[i, 0] = 0;
                arr[i, 9] = 0;
            }
            for (int i = 1; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    arr[i, j] = 1;

                }
            }
            DisplayArr();
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            //[i,j]
            for (int i = 0; i < 10; i += 2)
            {
                for (int j = 0; j < 10; j += 2)
                {
                    arr[i, j] = 1;
                }
            }
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = 1; j < 10; j += 2)
                {
                    arr[i, j] = 1;
                }
            }
            for (int i = 0; i < 10; i += 2)
            {
                for (int j = 1; j < 10; j += 2)
                {
                    arr[i, j] = 0;
                }
            }
            for (int i = 1; i < 10; i += 2)
            {
                for (int j = 0; j < 10; j += 2)
                {
                    arr[i, j] = 0;
                }
            }

            DisplayArr();
        }

        private void btnSumArr2_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (int i in arr0711)
            {
                sum += i;
            }
            labShowResult.Text = $"int陣列0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n的加總為：{sum}";
        }

        private void btnbtnMaxArr2_Click(object sender, EventArgs e)
        {
            int max = arr0711[0];
            foreach (int i in arr0711)
            {
                if (i > max)
                {
                    max = i;
                }
            }
            labShowResult.Text = $"int陣列0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最大值為：{max}";
        }

        private void btnMinArr2_Click(object sender, EventArgs e)
        {
            int min = arr0711[0];

            foreach (int i in arr0711)
            {
                if (i < min)
                {
                    min = i;
                }
            }
            labShowResult.Text = $"int陣列0711[1, 5, 6, 8, 7, 97, 54, 887, 65, 578]\n最小值為：{min}";
        }

        private void btnSwap_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "";
            int n1 = 100;
            int n2 = 200;
            labShowResult.Text += $"換位前n1={n1} , n2={n2}\n";
            Swap(ref n1, ref n2);
            labShowResult.Text += $"換位後n1={n1} , n2={n2}";
        }
        void Swap(ref int n1, ref int n2)
        {
            int T = n1;
            n1 = n2;
            n2 = T;
        }

        private void btnShowTree_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "";
            if (int.TryParse(txtRowMaxsTree.Text, out int num))
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= i; j++) //隨著i變大,j一行的數量會增加
                    {
                        labShowResult.Text += "*";
                    }
                    labShowResult.Text += "\n";
                }

            }
            else
            {
                MessageBox.Show("請輸入正整數");
                txtRowMaxsTree.Text = "";
                txtRowMaxsTree.Focus();
            }
        }

        private void btnBinary_Click(object sender, EventArgs e)
        {
            int number = 100;
            string binary = "";
            int number_s = number / 2;

            //100/2=50...0
            //50/2=25...0
            //25/2=12...1
            //12/2=6...0
            //6/2=3...0
            //3/2=1...1
            //1/2=0...1
            while (number - number_s > 0)
            {
                if (number % 2 == 0)
                {
                    number = number_s;
                    binary += "0";
                }
                else if (number % 2 == 1)
                {
                    number = number_s;
                    binary += "1";
                }
                number_s = number / 2;
            }
            char[] charArray = binary.ToCharArray();
            Array.Reverse(charArray);
            string answer = new string(charArray);
            labShowResult.Text = answer;



            //for (int i = 31; i >= 0; i--)
            //{
            //    int bit = (number >> i) & 1;
            //    binary += bit;
            //}
            //int numBitsToKeep = 7;
            //string binarySuffix = binary.Substring(binary.Length - numBitsToKeep);


        }

        private void btnLottery_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "樂透號碼為\n";
            //1~49取6個不重複的數字
            List<int> total = new List<int>();
            List<int> lottery = new List<int>();
            for (int i = 1; i <= 49; i++)
            {
                total.Add(i);
            }
            Random num = new Random();
            for (int i = 0; i < 6; i++)
            {
                int ranNum = num.Next(total.Count);
                lottery.Add(total[ranNum]);
                total.RemoveAt(ranNum);
                labShowResult.Text += $"{lottery[i]}  ";
            }
        }

        private void btnMultiplicationTable_Click(object sender, EventArgs e)
        {
            labShowResult.Text = "九九乘法表\n";
            //List<int> arr = new List<int>();
            for(int i = 1; i <=9; i++)
            {
                for(int j = 2; j <= 9; j++)
                {
                    int result = i * j;

                    labShowResult.Text += $"{string.Format("{0,2}{1,2}{2,2}{3,2}{4,2}{5,2}", j,"x", i,"=", result,"|")}";
                }
                labShowResult.Text +="\n";
            }
            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        int result = i * j;

            //    }
            //}
            //StringBuilder sb = new StringBuilder();

            //for (int i = 2; i <= 9; i++)
            //{
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        sb.Append($"{i}x{j} = {i * j} | ");
            //    }
            //    sb.Append(Environment.NewLine); // 換行
            //}

            //string result = sb.ToString();
            //labShowResult.Text = result;

        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (int.TryParse(txtFrom.Text,out int form) && int.TryParse(txtTo.Text, out int to) && int.TryParse(txtStep.Text, out int step))
            {
                for(int i = form; i <= to; i+= step)
                {
                    total += i;
                }
                labShowResult.Text = $" {form} 到 {to} 相隔 {step-1}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int total = 0;
            if (int.TryParse(txtFrom.Text, out int form) && int.TryParse(txtTo.Text, out int to) && int.TryParse(txtStep.Text, out int step))
            {
                int start = form;
                while (form <= to)
                {
                    total += form;
                    form += step;
                }
                labShowResult.Text = $" {start} 到 {to} 相隔 {step - 1}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {

            int total = 0;
            if (int.TryParse(txtFrom.Text, out int form) && int.TryParse(txtTo.Text, out int to) && int.TryParse(txtStep.Text, out int step))
            {
                int start = form;
                do
                {
                    total += form;
                    form += step;
                } while (form <= to);
                
                labShowResult.Text = $" {start} 到 {to} 相隔 {step - 1}\n加總為 {total}";
            }
            else
            {
                MessageBox.Show("請輸入數值");
            }
        }
    }
}

   
