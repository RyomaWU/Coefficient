using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IronPlateFactor;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button4_Click(object sender, EventArgs e)
        {
            string result = "";
            result += "4V\r\n";
            result += "6V\r\n";
            result += "7V\r\n";
            result += "8V\r\n";
            result += "9V\r\n";
            result += "10V\r\n";
            result += "12V\r\n";
            result += "14V\r\n";
            result += "16V\r\n";
            result += "20V\r\n";
            result += "25V\r\n";
            result += "32V\r\n";
            result += "40V\r\n";
            result += "50V\r\n";
            result += "63V\r\n";
            result += "70V\r\n";
            result += "80V\r\n";
            result += "100V\r\n";
            result += "120V\r\n";
            MessageBox.Show(result, "廠內現有下模", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = "";

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值!!","注意",MessageBoxButtons.OK,MessageBoxIcon.Question);
            }
            else
            {
                
                Coefficient coe = new Coefficient(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox6.Text));
                
                ans +=string.Format( "黑鐵 1折扣料:" + coe.Get_CoefficientValue("OT")) + "\r\n";
                ans +=string.Format("黑鐵 1邊扣料:" + coe.Get_HelfCoefficient("OT"))+ "\r\n";
            }
           
            textBox5.Text = ans;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string ans = "";

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值!!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Coefficient coe = new Coefficient(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox6.Text));

                ans += string.Format("白鐵 1折扣料:" + coe.Get_CoefficientValue("ST")) + "\r\n";
                ans += string.Format("白鐵 1邊扣料:" + coe.Get_HelfCoefficient("ST")) + "\r\n";
            }

            textBox5.Text = ans;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string ans = "";

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox6.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值!!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                Coefficient coe = new Coefficient(Convert.ToDouble(textBox1.Text), Convert.ToInt32(textBox2.Text), Convert.ToDouble(textBox6.Text));

                ans += string.Format("鋁板 1折扣料:" + coe.Get_CoefficientValue("AL")) + "\r\n";
                ans += string.Format("鋁板 1邊扣料:" + coe.Get_HelfCoefficient("AL")) + "\r\n";
            }
            textBox5.Text = ans;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }

        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }


        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }


        }

        private void button6_Click(object sender, EventArgs e)
        {
            string ans = "";
            ans += string.Format("本程式僅供萬越人員使用\r\n");
            ans += string.Format("希望在用本程式之前，請先學會基本功\r\n");

            MessageBox.Show(ans, "說明", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string ans = "";
            ans += string.Format("1T的正常溝=8V\r\n");
            ans += string.Format("1.2T的正常溝=10V\r\n");
            ans += string.Format("1.5T的正常溝=12V\r\n");
            ans += string.Format("1.6T的正常溝=12V\r\n");
            ans += string.Format("2T的正常溝=16V\r\n");
            ans += string.Format("2.3T的正常溝=16V\r\n");
            ans += string.Format("2.5T的正常溝=20V\r\n");
            ans += string.Format("3T的正常溝=25V\r\n");
            ans += string.Format("3.2T的正常溝=25V\r\n");
            ans += string.Format("4T的正常溝=32V\r\n");
            ans += string.Format("4.5T的正常溝=32V\r\n");
            ans += string.Format("5T的正常溝=40V\r\n");
            ans += string.Format("6T的正常溝=50V\r\n");

            MessageBox.Show(ans, "正常溝數", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RoundBar_1 rb1 = new RoundBar_1();
            rb1.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            RoundBar_2 rb2 = new RoundBar_2();
            rb2.ShowDialog();
        }

        ////遞廻

        //int MyPro(int x)
        //{
        //    if (x == 1 || x == 0)
        //    {
        //        return 1;
        //    }
        //    else
        //        x = (MyPro(x - 1) + MyPro(x - 2));
        //    return x;
        //}
        //private void button6_Click(object sender, EventArgs e)
        //{
        //   textBox5.Text=MyPro(10).ToString();

        //}
    }
}
