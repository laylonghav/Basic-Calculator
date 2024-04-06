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
    public partial class Select_Data : Form
    {
  
        public Select_Data()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {

            var connection = new MySqlConnection("Server=localhost;User ID=root;Password=;Database=npic_db");
            connection.Open();
            String id = txt_Search.Text;
            var command = new MySqlCommand("SELECT `Id`, `Username`, `Password`, `Email` FROM `user` WHERE id=" + id + ";", connection);
            var reader = command.ExecuteReader();
            if (reader.Read())
            {
                txt_User_name.Text = reader.GetString(1);
                txt_Password.Text = reader.GetString(2);
                txt_Email.Text = reader.GetString(3);
            }
            else
            {
                MessageBox.Show("There is no data");
            }
            connection.Close();
        }
    }
}
