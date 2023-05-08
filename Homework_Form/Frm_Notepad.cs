using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_Form
{
    public partial class Frm_Notepad : Form
    {
        public Frm_Notepad()
        {
            InitializeComponent();
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Start();
            label1.Text = DateTime.Now.ToString("tt hh:mm:ss");
        }

        private void Frm_Notepad_Load(object sender, EventArgs e)
        {
            timer1_Tick(sender, e);
        }

        private void 顏色CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog chooseColor = new ColorDialog();
            chooseColor.ShowDialog();
            rTxtBoxContent.ForeColor = chooseColor.Color;
        }

        private void 字型VToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog chooseFont = new FontDialog();
            chooseFont.ShowDialog();
            rTxtBoxContent.Font = chooseFont.Font;
        }

        private void toUpperUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Text = rTxtBoxContent.Text.ToUpper();
        }

        private void toLowerLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Text = rTxtBoxContent.Text.ToLower();
        }

        private void 自動換行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.WordWrap = false;
            if(!rTxtBoxContent.WordWrap) {
                rTxtBoxContent.ScrollBars = RichTextBoxScrollBars.ForcedBoth;
            }
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.ForeColor = Color.Black;
        }

        private void 剪下TToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Cut();
        }
        private void 剪下UToolStripButton_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Cut();
        }

        private void 複製CToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Copy();
        }
        private void 複製CToolStripButton_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Copy();
        }

        private void 貼上PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Paste();
        }
        private void 貼上PToolStripButton_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Paste();
        }

        private void 全選AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.SelectAll();
        }

        private void 復原UToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Undo();
        }

        private void 取消復原RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTxtBoxContent.Redo();
        }
        OpenFileDialog openFile = new OpenFileDialog();
        
        SaveFileDialog saveFile = new SaveFileDialog();
        void OpenExistFile()
        {
            openFile.ShowDialog();
            StreamReader reader = new StreamReader(openFile.FileName);
            rTxtBoxContent.Text = reader.ReadToEnd();
        }
        private void 開啟OToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenExistFile();
        }
        private void 開啟OToolStripButton_Click(object sender, EventArgs e)
        {
            OpenExistFile();
        }
        void CreatEmptyFile()
        {
            rTxtBoxContent.Text = string.Empty;
        }
        private void 新增NToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatEmptyFile();
        }
        private void 新增NToolStripButton_Click(object sender, EventArgs e)
        {
            CreatEmptyFile();
        }
        
        string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        void SaveFile()
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    StreamWriter sw = new StreamWriter(path, false, Encoding.Default);
                    sw.Write(rTxtBoxContent.Text);
                    sw.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                }

            }
            else
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                saveFile.FilterIndex = 1;
                saveFile.RestoreDirectory = true;
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        path = saveFile.FileName;
                        string fileContent = rTxtBoxContent.Text;
                        File.WriteAllText(path, fileContent);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                    }
                }
            }
        }
        private void 儲存SToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        private void 儲存SToolStripButton_Click(object sender, EventArgs e)
        {
            SaveFile();
        }
        void SaveTheNewFile()
        {
            saveFile.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            saveFile.FilterIndex = 1;
            saveFile.RestoreDirectory = true;
            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    path = saveFile.FileName;
                    string fileContent = rTxtBoxContent.Text;
                    File.WriteAllText(path, fileContent);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not save file. Original error: " + ex.Message);
                }
            }
        }
        private void 另存新檔AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveTheNewFile();
        }
        
        private void 結束XToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
        void print()
        {
            if (!string.IsNullOrEmpty(path))
            {
                try
                {
                    PrintDocument printDocument = new PrintDocument();
                    printDocument.DocumentName = Path.GetFileName(path);


                    PrintDialog printDialog = new PrintDialog();
                    printDialog.Document = printDocument;

                    if (printDialog.ShowDialog() == DialogResult.OK)
                    {
                        printDocument.Print();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not print file. Original error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("請先開啟檔案");
            }
        }
        private void 列印PToolStripMenuItem_Click(object sender, EventArgs e)
        {
            print();
        }

        private void 列印PToolStripButton_Click(object sender, EventArgs e)
        {
            print();
        }
        void About()
        {
            MessageBox.Show("由 MSIT150 C#班 彭亞芝製作,請安心使用", "關於", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void 說明LToolStripButton_Click(object sender, EventArgs e)
        {
            About();
        }

        private void 關於AToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            About();
        }

        
    }
}
