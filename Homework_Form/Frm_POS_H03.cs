using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_POS_H03 : Form
    {
        public Frm_POS_H03()
        {
            InitializeComponent();
        }
        //string btnMenuText;
        
        //int CountBeer = 0; //beer總數量
        //int Beer_Total = 0; //beer總金額
        

        //int CountRedWine = 0;//紅酒總數量
        //int RedWine_Total = 0;//紅酒總金額
        //string szRedWine = "";//顯示在list
        //string szJinLu= "";//顯示在list
        //string szWhisky = "";//顯示在list
        //string szBeer = ""; //顯示在list

        string ListAll = "";//list明細
        int total_num = 0; //算中間總金額
        int CountBeer = 0;
        int CountJinLu = 0;
        int CountWhisky = 0;
        int CountRedWine = 0;
        private void btnMenuBeer_Click(object sender, EventArgs e)
        {
            CountBeer += 1;
            DISPLAY();
            //Beer_Total += 160;
            //labTotalPrice.Text = "NT$" + Beer_Total.ToString();

            //szBeer = $"啤酒X{CountBeer}共NT${"

            //Menu menu = new Menu();
            //btnMenuText = btnMenuBeer.Text;
            //string[] fields = btnMenuText.Split(new string[] { "\n" }, StringSplitOptions.None);

            //menu.ProductName = fields[0];
            //menu.ProductEngName = fields[1];
            //menu.PriceOfProduct = fields[2];
            //labMenuList.Text = $"{menu.ProductName}{menu.PriceOfProduct}";
        }

        private void btnCleanMenuList_Click(object sender, EventArgs e)//清除按鈕,全部歸0
        {
            total_num = 0;

            //Beer_Total = 0;
            //RedWine_Total = 0;

            CountBeer = 0;
            CountRedWine = 0 ;
            CountJinLu = 0;
            CountWhisky = 0;

            ListAll="";
            labTotalPrice.Text = "NT$ 0";
            DISPLAY();
        }
        #region 通用
        private void DISPLAY()
        {
            total_num = 0;
            ListAll = "";
            const int BeerPrice = 160;
            const int JinLuPrice = 220;
            const int WhiskyPrice = 250;
            const int RedWinePrice = 130;
            int TotalPriceBeer = CountBeer * BeerPrice;
            int TotalPriceJinLu = CountJinLu * JinLuPrice;
            int TotalPriceWhisky = CountWhisky * WhiskyPrice;
            int TotalPriceRedWine = CountRedWine * RedWinePrice;
            total_num += TotalPriceBeer ;
            total_num += TotalPriceJinLu;
            total_num += TotalPriceWhisky;
            total_num += TotalPriceRedWine;


            if (CountBeer > 0)
            {
                ListAll = $"啤酒Beer x {CountBeer}共NT${TotalPriceBeer}\n";
            }
            if (CountJinLu > 0)
            {
                ListAll += $"真露JinLu x {CountJinLu}共NT${TotalPriceJinLu}\n";
            }
            if (CountRedWine > 0)
            {
                ListAll += $"紅酒RedWine x {CountRedWine}共NT${TotalPriceRedWine}\n";
            }
            if (CountWhisky > 0)
            {
                ListAll += $"威士忌Whisky x {CountWhisky}共NT${TotalPriceWhisky}\n";
            }
            if (string.IsNullOrEmpty(ListAll))
            {
                ListAll = "尚未點餐";
            }
            labMenuList.Text = ListAll;
            labTotalPrice.Text = "NT$" + total_num.ToString();
        }
        #endregion 通用
        private void btnMenuRedWine_Click(object sender, EventArgs e)
        {

            CountRedWine += 1;
            DISPLAY();
            //RedWine_Total += 220;
            //labTotalPrice.Text = "NT$" + RedWine_Total.ToString();

            //szRedWine = $"紅酒X{CountRedWine}共NT${RedWine_Total}";

        }

        private void btnMenuJinLu_Click(object sender, EventArgs e)
        {
            CountJinLu += 1;
            DISPLAY();
        }

        private void btnMenuWhisky_Click(object sender, EventArgs e)
        {
            CountWhisky += 1;
            DISPLAY();
        }

        private void btnPayByCash_Click(object sender, EventArgs e)
        {
            if (total_num > 0)
            {
                MessageBox.Show($"總共收現金{total_num}元。", "付款確認", MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show($"尚未點餐");
            }
        }

        private void btnPayByCredit_Click(object sender, EventArgs e)
        {
            if (total_num > 0)
            {
                MessageBox.Show($"信用卡享9折優惠!\n總共收信用卡{total_num * 0.9}元。","付款確認",MessageBoxButtons.OKCancel);
            }
            else
            {
                MessageBox.Show($"尚未點餐");
            }
                
        }
    }
}
