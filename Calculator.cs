using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        private void btn_doc_Click(object sender, EventArgs e)
        {
            if (!label1.Text.Contains("."))
            {
                label1.Text += ".";
            }
            else

                label1.Text = label1.Text + ".";
        }
    }
}
