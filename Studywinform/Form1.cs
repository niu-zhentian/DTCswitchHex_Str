using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Studywinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       

        private void button2_Click(object sender, EventArgs e)
        {
           
            Dictionary<string, string> dic_hex2str = new Dictionary<string, string>
        {
            { "00", "P" },
            { "01", "C" },
            { "10", "B" },
            { "11", "U" }
        };


            int h = Convert.ToInt32(textBox1.Text,16);
            int a = h >> 20;
            string c = Convert.ToString(a, 2);
            string d = c.Substring(0, 2);
            string f = Convert.ToString(Convert.ToInt32(c.Substring(2),2),10);
            string les_h = Convert.ToString(h, 16).Substring(1);
            richTextBox1.Text = dic_hex2str[d] + f + les_h;

            //MessageBox.Show(dic_hex2str[d]+f+les_h);
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> dic_str2hex = new Dictionary<string, string>
        {
            { "P", "00" },
            { "C", "01" },
            { "B", "10" },
            { "U", "11" }
        };



            string a = textBox2.Text;
            string b = a.Substring(0, 2);
            string c = dic_str2hex[b.Substring(0, 1)];  
            string d = Convert.ToString(Convert.ToInt32(b.Substring(1), 10), 2);
            int number = Convert.ToInt32(c+d, 2); // 将二进制字符串转换为整数
            string hexOutput = number.ToString("X"); // 将整数转换为十六进制字符串
            string total = hexOutput + a.Substring(2);

            richTextBox1.Text = total;
            //MessageBox.Show(total);
        }
    }
}
