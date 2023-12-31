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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e) {

            this.BackColor = Color.Brown;
            
        }

        private void btn_M_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello wouid");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.AliceBlue;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text="HEllo world";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog();
        }     
    }
}
