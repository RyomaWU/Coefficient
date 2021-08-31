using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RoundBar;

namespace WindowsFormsApp1
{
    public partial class RoundBar_1 : Form
    {
        public RoundBar_1()
        {
            InitializeComponent();
           
        }





        /// <summary>
        /// 限制 button 只能打數字
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Btn_keyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 | (int)e.KeyChar > 57) & (int)e.KeyChar != 8 & (int)e.KeyChar != 46)
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ans = "";

            if (textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty || textBox4.Text == string.Empty)
            {
                MessageBox.Show("請輸入數值!!", "注意", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            else
            {
                
                My_RoundBar rb=new My_RoundBar(Convert.ToDouble(textBox4.Text), Convert.ToInt32(textBox1.Text), Convert.ToDouble(textBox2.Text), Convert.ToDouble(textBox3.Text));
                ans +=string.Format("圓條展開長度="+ rb.Calculation_ThreeSides_RoundBar()+"\t"+"mm") ;
            }
            MessageBox.Show(ans,"計算結果",MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

       
    }
}
