using System;

namespace Homework_Form
{
    partial class Frm_Notepad
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Notepad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案FToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟OToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.儲存SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.列印PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印VToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.結束XToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯EToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原UToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下TToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.全選AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.工具TToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.選項OToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.格式MToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toUpperUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toLowerLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自動換行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.快選顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明HToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.內容CToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.索引IToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋SToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.關於AToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.新增NToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.開啟OToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.儲存SToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.列印PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.剪下UToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.複製CToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.貼上PToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.說明LToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rTxtBoxContent = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案FToolStripMenuItem,
            this.編輯EToolStripMenuItem,
            this.工具TToolStripMenuItem1,
            this.格式MToolStripMenuItem,
            this.說明HToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案FToolStripMenuItem
            // 
            this.檔案FToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripMenuItem,
            this.開啟OToolStripMenuItem,
            this.toolStripSeparator2,
            this.儲存SToolStripMenuItem,
            this.另存新檔AToolStripMenuItem1,
            this.toolStripSeparator3,
            this.列印PToolStripMenuItem,
            this.預覽列印VToolStripMenuItem1,
            this.toolStripSeparator4,
            this.結束XToolStripMenuItem1});
            this.檔案FToolStripMenuItem.Name = "檔案FToolStripMenuItem";
            this.檔案FToolStripMenuItem.Size = new System.Drawing.Size(57, 22);
            this.檔案FToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增NToolStripMenuItem
            // 
            this.新增NToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripMenuItem.Image")));
            this.新增NToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripMenuItem.Name = "新增NToolStripMenuItem";
            this.新增NToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增NToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新增NToolStripMenuItem.Text = "新增(&N)";
            this.新增NToolStripMenuItem.Click += new System.EventHandler(this.新增NToolStripMenuItem_Click);
            // 
            // 開啟OToolStripMenuItem
            // 
            this.開啟OToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripMenuItem.Image")));
            this.開啟OToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripMenuItem.Name = "開啟OToolStripMenuItem";
            this.開啟OToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟OToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開啟OToolStripMenuItem.Text = "開啟(&O)";
            this.開啟OToolStripMenuItem.Click += new System.EventHandler(this.開啟OToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // 儲存SToolStripMenuItem
            // 
            this.儲存SToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripMenuItem.Image")));
            this.儲存SToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripMenuItem.Name = "儲存SToolStripMenuItem";
            this.儲存SToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存SToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.儲存SToolStripMenuItem.Text = "儲存(&S)";
            this.儲存SToolStripMenuItem.Click += new System.EventHandler(this.儲存SToolStripMenuItem_Click);
            // 
            // 另存新檔AToolStripMenuItem1
            // 
            this.另存新檔AToolStripMenuItem1.Name = "另存新檔AToolStripMenuItem1";
            this.另存新檔AToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.另存新檔AToolStripMenuItem1.Text = "另存新檔(&A)";
            this.另存新檔AToolStripMenuItem1.Click += new System.EventHandler(this.另存新檔AToolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(158, 6);
            // 
            // 列印PToolStripMenuItem
            // 
            this.列印PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripMenuItem.Image")));
            this.列印PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripMenuItem.Name = "列印PToolStripMenuItem";
            this.列印PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印PToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.列印PToolStripMenuItem.Text = "列印(&P)";
            this.列印PToolStripMenuItem.Click += new System.EventHandler(this.列印PToolStripMenuItem_Click);
            // 
            // 預覽列印VToolStripMenuItem1
            // 
            this.預覽列印VToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("預覽列印VToolStripMenuItem1.Image")));
            this.預覽列印VToolStripMenuItem1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.預覽列印VToolStripMenuItem1.Name = "預覽列印VToolStripMenuItem1";
            this.預覽列印VToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.預覽列印VToolStripMenuItem1.Text = "預覽列印(&V)";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(158, 6);
            // 
            // 結束XToolStripMenuItem1
            // 
            this.結束XToolStripMenuItem1.Name = "結束XToolStripMenuItem1";
            this.結束XToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.結束XToolStripMenuItem1.Text = "結束(&X)";
            this.結束XToolStripMenuItem1.Click += new System.EventHandler(this.結束XToolStripMenuItem1_Click);
            // 
            // 編輯EToolStripMenuItem
            // 
            this.編輯EToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原UToolStripMenuItem,
            this.取消復原RToolStripMenuItem,
            this.toolStripSeparator5,
            this.剪下TToolStripMenuItem,
            this.複製CToolStripMenuItem,
            this.貼上PToolStripMenuItem,
            this.toolStripSeparator6,
            this.全選AToolStripMenuItem1});
            this.編輯EToolStripMenuItem.Name = "編輯EToolStripMenuItem";
            this.編輯EToolStripMenuItem.Size = new System.Drawing.Size(58, 22);
            this.編輯EToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原UToolStripMenuItem
            // 
            this.復原UToolStripMenuItem.Name = "復原UToolStripMenuItem";
            this.復原UToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原UToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原UToolStripMenuItem.Text = "復原(&U)";
            this.復原UToolStripMenuItem.Click += new System.EventHandler(this.復原UToolStripMenuItem_Click);
            // 
            // 取消復原RToolStripMenuItem
            // 
            this.取消復原RToolStripMenuItem.Name = "取消復原RToolStripMenuItem";
            this.取消復原RToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原RToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.取消復原RToolStripMenuItem.Text = "取消復原(&R)";
            this.取消復原RToolStripMenuItem.Click += new System.EventHandler(this.取消復原RToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(177, 6);
            // 
            // 剪下TToolStripMenuItem
            // 
            this.剪下TToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪下TToolStripMenuItem.Image")));
            this.剪下TToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下TToolStripMenuItem.Name = "剪下TToolStripMenuItem";
            this.剪下TToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下TToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下TToolStripMenuItem.Text = "剪下(&T)";
            this.剪下TToolStripMenuItem.Click += new System.EventHandler(this.剪下TToolStripMenuItem_Click);
            // 
            // 複製CToolStripMenuItem
            // 
            this.複製CToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripMenuItem.Image")));
            this.複製CToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripMenuItem.Name = "複製CToolStripMenuItem";
            this.複製CToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製CToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.複製CToolStripMenuItem.Text = "複製(&C)";
            this.複製CToolStripMenuItem.Click += new System.EventHandler(this.複製CToolStripMenuItem_Click);
            // 
            // 貼上PToolStripMenuItem
            // 
            this.貼上PToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripMenuItem.Image")));
            this.貼上PToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripMenuItem.Name = "貼上PToolStripMenuItem";
            this.貼上PToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上PToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上PToolStripMenuItem.Text = "貼上(&P)";
            this.貼上PToolStripMenuItem.Click += new System.EventHandler(this.貼上PToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(177, 6);
            // 
            // 全選AToolStripMenuItem1
            // 
            this.全選AToolStripMenuItem1.Name = "全選AToolStripMenuItem1";
            this.全選AToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.全選AToolStripMenuItem1.Text = "全選(&A)";
            this.全選AToolStripMenuItem1.Click += new System.EventHandler(this.全選AToolStripMenuItem1_Click);
            // 
            // 工具TToolStripMenuItem1
            // 
            this.工具TToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂CToolStripMenuItem1,
            this.選項OToolStripMenuItem1});
            this.工具TToolStripMenuItem1.Name = "工具TToolStripMenuItem1";
            this.工具TToolStripMenuItem1.Size = new System.Drawing.Size(58, 22);
            this.工具TToolStripMenuItem1.Text = "工具(&T)";
            // 
            // 自訂CToolStripMenuItem1
            // 
            this.自訂CToolStripMenuItem1.Name = "自訂CToolStripMenuItem1";
            this.自訂CToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.自訂CToolStripMenuItem1.Text = "自訂(&C)";
            // 
            // 選項OToolStripMenuItem1
            // 
            this.選項OToolStripMenuItem1.Name = "選項OToolStripMenuItem1";
            this.選項OToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.選項OToolStripMenuItem1.Text = "選項(&O)";
            // 
            // 格式MToolStripMenuItem
            // 
            this.格式MToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色CToolStripMenuItem,
            this.字型VToolStripMenuItem,
            this.toUpperUToolStripMenuItem,
            this.toLowerLToolStripMenuItem,
            this.自動換行ToolStripMenuItem,
            this.快選顏色ToolStripMenuItem});
            this.格式MToolStripMenuItem.Name = "格式MToolStripMenuItem";
            this.格式MToolStripMenuItem.Size = new System.Drawing.Size(63, 22);
            this.格式MToolStripMenuItem.Text = "格式(M)";
            // 
            // 顏色CToolStripMenuItem
            // 
            this.顏色CToolStripMenuItem.Name = "顏色CToolStripMenuItem";
            this.顏色CToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.顏色CToolStripMenuItem.Text = "顏色(C)...";
            this.顏色CToolStripMenuItem.Click += new System.EventHandler(this.顏色CToolStripMenuItem_Click);
            // 
            // 字型VToolStripMenuItem
            // 
            this.字型VToolStripMenuItem.Name = "字型VToolStripMenuItem";
            this.字型VToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.字型VToolStripMenuItem.Text = "字型(V)...";
            this.字型VToolStripMenuItem.Click += new System.EventHandler(this.字型VToolStripMenuItem_Click);
            // 
            // toUpperUToolStripMenuItem
            // 
            this.toUpperUToolStripMenuItem.Name = "toUpperUToolStripMenuItem";
            this.toUpperUToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toUpperUToolStripMenuItem.Text = "To Upper(U)";
            this.toUpperUToolStripMenuItem.Click += new System.EventHandler(this.toUpperUToolStripMenuItem_Click);
            // 
            // toLowerLToolStripMenuItem
            // 
            this.toLowerLToolStripMenuItem.Name = "toLowerLToolStripMenuItem";
            this.toLowerLToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.toLowerLToolStripMenuItem.Text = "To Lower(L)";
            this.toLowerLToolStripMenuItem.Click += new System.EventHandler(this.toLowerLToolStripMenuItem_Click);
            // 
            // 自動換行ToolStripMenuItem
            // 
            this.自動換行ToolStripMenuItem.Name = "自動換行ToolStripMenuItem";
            this.自動換行ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.自動換行ToolStripMenuItem.Text = "自動換行";
            this.自動換行ToolStripMenuItem.Click += new System.EventHandler(this.自動換行ToolStripMenuItem_Click);
            // 
            // 快選顏色ToolStripMenuItem
            // 
            this.快選顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.快選顏色ToolStripMenuItem.Name = "快選顏色ToolStripMenuItem";
            this.快選顏色ToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.快選顏色ToolStripMenuItem.Text = "快選顏色";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // 說明HToolStripMenuItem1
            // 
            this.說明HToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容CToolStripMenuItem1,
            this.索引IToolStripMenuItem,
            this.搜尋SToolStripMenuItem1,
            this.toolStripSeparator7,
            this.關於AToolStripMenuItem1});
            this.說明HToolStripMenuItem1.Name = "說明HToolStripMenuItem1";
            this.說明HToolStripMenuItem1.Size = new System.Drawing.Size(60, 22);
            this.說明HToolStripMenuItem1.Text = "說明(&H)";
            // 
            // 內容CToolStripMenuItem1
            // 
            this.內容CToolStripMenuItem1.Name = "內容CToolStripMenuItem1";
            this.內容CToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.內容CToolStripMenuItem1.Text = "內容(&C)";
            // 
            // 索引IToolStripMenuItem
            // 
            this.索引IToolStripMenuItem.Name = "索引IToolStripMenuItem";
            this.索引IToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            this.索引IToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋SToolStripMenuItem1
            // 
            this.搜尋SToolStripMenuItem1.Name = "搜尋SToolStripMenuItem1";
            this.搜尋SToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.搜尋SToolStripMenuItem1.Text = "搜尋(&S)";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(120, 6);
            // 
            // 關於AToolStripMenuItem1
            // 
            this.關於AToolStripMenuItem1.Name = "關於AToolStripMenuItem1";
            this.關於AToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.關於AToolStripMenuItem1.Text = "關於(&A)...";
            this.關於AToolStripMenuItem1.Click += new System.EventHandler(this.關於AToolStripMenuItem1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增NToolStripButton,
            this.開啟OToolStripButton,
            this.儲存SToolStripButton,
            this.列印PToolStripButton,
            this.toolStripSeparator,
            this.剪下UToolStripButton,
            this.複製CToolStripButton,
            this.貼上PToolStripButton,
            this.toolStripSeparator1,
            this.說明LToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.toolStrip1.Size = new System.Drawing.Size(800, 31);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // 新增NToolStripButton
            // 
            this.新增NToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.新增NToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("新增NToolStripButton.Image")));
            this.新增NToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.新增NToolStripButton.Name = "新增NToolStripButton";
            this.新增NToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.新增NToolStripButton.Text = "新增(&N)";
            this.新增NToolStripButton.Click += new System.EventHandler(this.新增NToolStripButton_Click);
            // 
            // 開啟OToolStripButton
            // 
            this.開啟OToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.開啟OToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("開啟OToolStripButton.Image")));
            this.開啟OToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.開啟OToolStripButton.Name = "開啟OToolStripButton";
            this.開啟OToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.開啟OToolStripButton.Text = "開啟(&O)";
            this.開啟OToolStripButton.Click += new System.EventHandler(this.開啟OToolStripButton_Click);
            // 
            // 儲存SToolStripButton
            // 
            this.儲存SToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.儲存SToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("儲存SToolStripButton.Image")));
            this.儲存SToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.儲存SToolStripButton.Name = "儲存SToolStripButton";
            this.儲存SToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.儲存SToolStripButton.Text = "儲存(&S)";
            this.儲存SToolStripButton.Click += new System.EventHandler(this.儲存SToolStripButton_Click);
            // 
            // 列印PToolStripButton
            // 
            this.列印PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.列印PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("列印PToolStripButton.Image")));
            this.列印PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.列印PToolStripButton.Name = "列印PToolStripButton";
            this.列印PToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.列印PToolStripButton.Text = "列印(&P)";
            this.列印PToolStripButton.Click += new System.EventHandler(this.列印PToolStripButton_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 31);
            // 
            // 剪下UToolStripButton
            // 
            this.剪下UToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.剪下UToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("剪下UToolStripButton.Image")));
            this.剪下UToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.剪下UToolStripButton.Name = "剪下UToolStripButton";
            this.剪下UToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.剪下UToolStripButton.Text = "剪下(&U)";
            this.剪下UToolStripButton.Click += new System.EventHandler(this.剪下UToolStripButton_Click);
            // 
            // 複製CToolStripButton
            // 
            this.複製CToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.複製CToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("複製CToolStripButton.Image")));
            this.複製CToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.複製CToolStripButton.Name = "複製CToolStripButton";
            this.複製CToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.複製CToolStripButton.Text = "複製(&C)";
            this.複製CToolStripButton.Click += new System.EventHandler(this.複製CToolStripButton_Click);
            // 
            // 貼上PToolStripButton
            // 
            this.貼上PToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.貼上PToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("貼上PToolStripButton.Image")));
            this.貼上PToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.貼上PToolStripButton.Name = "貼上PToolStripButton";
            this.貼上PToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.貼上PToolStripButton.Text = "貼上(&P)";
            this.貼上PToolStripButton.Click += new System.EventHandler(this.貼上PToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // 說明LToolStripButton
            // 
            this.說明LToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.說明LToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("說明LToolStripButton.Image")));
            this.說明LToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.說明LToolStripButton.Name = "說明LToolStripButton";
            this.說明LToolStripButton.Size = new System.Drawing.Size(28, 28);
            this.說明LToolStripButton.Text = "說明(&L)";
            this.說明LToolStripButton.Click += new System.EventHandler(this.說明LToolStripButton_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(0, 428);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "2023/5/5 下午 04:07:25";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rTxtBoxContent
            // 
            this.rTxtBoxContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTxtBoxContent.Location = new System.Drawing.Point(0, 55);
            this.rTxtBoxContent.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rTxtBoxContent.Name = "rTxtBoxContent";
            this.rTxtBoxContent.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rTxtBoxContent.Size = new System.Drawing.Size(800, 373);
            this.rTxtBoxContent.TabIndex = 3;
            this.rTxtBoxContent.Text = "";
            // 
            // Frm_Notepad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rTxtBoxContent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_Notepad";
            this.Text = "Frm_Notepad";
            this.Load += new System.EventHandler(this.Frm_Notepad_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案FToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟OToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem 儲存SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem 列印PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印VToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem 結束XToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 編輯EToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原UToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem 剪下TToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上PToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem 全選AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 工具TToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 自訂CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 選項OToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 格式MToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toUpperUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toLowerLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自動換行ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 快選顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明HToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 內容CToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 索引IToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋SToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem 關於AToolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton 新增NToolStripButton;
        private System.Windows.Forms.ToolStripButton 開啟OToolStripButton;
        private System.Windows.Forms.ToolStripButton 儲存SToolStripButton;
        private System.Windows.Forms.ToolStripButton 列印PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton 剪下UToolStripButton;
        private System.Windows.Forms.ToolStripButton 複製CToolStripButton;
        private System.Windows.Forms.ToolStripButton 貼上PToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton 說明LToolStripButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.RichTextBox rTxtBoxContent;
    }
}