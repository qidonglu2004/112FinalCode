using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Program7_6
{
    public partial class Form1 : Form
    {
        private string[] boyName;
        private List<string> girlName = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            readGirlName();
            readboyName();
        }
        private void readGirlName()
        {
            StreamReader inputFile;
            //*********************************************//
            //**使用OpenFileDialog元件開啟GirlNames.txt檔**//
            //**並將檔案內容讀取至List<string> girlName中**//
            //*********************************************//
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // 設定檔案過濾器，只允許 .txt 檔案
            openFileDialog.Filter = "Text files (*.txt)|*.txt";

            // 顯示對話框並檢查使用者是否選擇了檔案
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // 讀取檔案路徑
                string filePath = openFileDialog.FileName;

                try
                {
                    // 使用 StreamReader 讀取檔案內容
                    using (inputFile = new StreamReader(filePath))
                    {
                        string line;
                        while ((line = inputFile.ReadLine()) != null)
                        {
                            girlName.Add(line);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error reading the file: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("No file selected.");
            }

        }
        private void readboyName()
        {
            try
            {
                StreamReader inputFile;
                inputFile = File.OpenText("BoyNames.txt");

                int num_of_lines = 0;
                while (!inputFile.EndOfStream)
                {
                    inputFile.ReadLine();
                    num_of_lines++;       //BoysNames.txt中資料的筆數
                }

                boyName = new string[num_of_lines];  //宣告string[] boyName的大小

                //*********************************************//
                //**開啟BoysNames.txt檔案餅且讀取資料到陣列中**//
                //*********************************************//
                inputFile.BaseStream.Seek(0, SeekOrigin.Begin);
                // 读取数据到数组中
                for (int i = 0; i < num_of_lines; i++)
                {
                    boyName[i] = inputFile.ReadLine();
                }

                // 关闭文件流
                inputFile.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            if (textBox1.Text != "")
            {
                Boolean popularGirlName = false;

                //***************************************************************//
                //**使用foreach敘述比對textBox1中所輸入的名字是否有出現在檔案中**//
                //***************************************************************//
                foreach (string name in girlName)
                {
                    if (name.Equals(textBox1.Text, StringComparison.OrdinalIgnoreCase))
                    {
                        popularGirlName = true;
                        break;
                    }
                }

                if (popularGirlName == true)
                {
                    label3.Text += textBox1.Text + " is a popular girl name.\n";
                }
                else
                {
                    label3.Text += textBox1.Text + " is not a popular girl name.\n";
                }
            }

            if (textBox2.Text != "")
            {
                Boolean popularBoylName = false;

                //***********************************************************//
                //**使用for敘述比對textBox2中所輸入的名字是否有出現在檔案中**//
                //***********************************************************//
                foreach (string name in boyName)
                {
                    if (textBox2.Text.Trim().Equals(name.Trim(), StringComparison.OrdinalIgnoreCase))
                    {
                        popularBoylName = true;
                        break;
                    }
                }

                if (popularBoylName == true)
                {
                    label3.Text += textBox2.Text + " is a popular boy name.\n";
                }
                else
                {
                    label3.Text += textBox2.Text + " is not a popular boy name.\n";
                }
            }
        }
    }
}
