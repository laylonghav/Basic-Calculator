using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp_001
{
    public partial class Calculator : Form
    {
        

        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }


        private void Number_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (label1.Text=="0")
            {
                label1.Text = "";
                label1.Text += b.Text;
                //label1.Text = label1.Text + button.Text;
            }
            else
            {
                label1.Text += b.Text;
            }
        }


        string num1, num2,op;
        private void btn_op_Click(object sender, EventArgs e)
        {
            num1 = label1.Text;
            label1.Text = "0";
            Button b = (Button)sender;
            op = b.Text;
        }

        private void btn_equal_Click(object sender, EventArgs e)
        {
            //equal
            num2 = label1.Text;
            if(op == "+")
            {
                label1.Text = ((Convert.ToDouble(num1) + Convert.ToDouble(num2))).ToString();
            } else if (op == "-")
            {
                label1.Text = ((Convert.ToDouble(num1) -+ Convert.ToDouble(num2))).ToString();
            }
            else if (op == "*")
            {
                label1.Text = ((Convert.ToDouble(num1) * Convert.ToDouble(num2))).ToString();
            }
            else if (op == "/")
            {
                label1.Text = ((Convert.ToDouble(num1) / Convert.ToDouble(num2))).ToString();
            }
        }

        private void btn_AC(object sender, EventArgs e)
        {
            label1.Text = "0";
            num1 = "0";
            num2 = "0";
            op = "";
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            int length = label1.Text.Length-1;
            Console.WriteLine(length);
            label1.Text =label1.Text.Substring(0, length);
            if (label1.Text.Length == 0)
            {
                label1.Text = "0";
            }
        }

        private void btn_Percentage_Click(object sender, EventArgs e)
        {
            label1.Text= (Convert.ToDouble(label1.Text) / 100).ToString();
        }

        private void btn_squaeRoot_Click(object sender, EventArgs e)
        {
            label1.Text = Math.Sqrt(Convert.ToDouble(label1.Text)).ToString();

        }

        private void btn_doc_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
            {
                label1.Text += ".";
            }
            else
                label1.Text = label1.Text + ".";
        }

        private void btn4_Click(object sender, EventArgs e)
        {


        }
    }
}
