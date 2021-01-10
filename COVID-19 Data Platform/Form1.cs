using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace COVID_19_Data_Platform
{

	public partial class Login_Manager : Form
	{
        private static string connStr;
        public static NpgsqlConnection conn;
        public Login_Manager()
		{
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
		}

        private void Login_Button_Click(object sender, EventArgs e)
        {
            Login_Button.Enabled = false;
            //Establish connection
            connStr =
                @"PORT=5432;DATABASE=" + Database_TextBox.Text +
                ";HOST=127.0.0.1;PASSWORD=" + Password_TextBox.Text +
                @";USER ID=" + User_TextBox.Text;
            conn = new NpgsqlConnection(connStr);
            try
            {
                conn.Open();
            }
            catch (Exception)
			{
                MessageBox.Show("Error! Incorrect username, database name or password");
                Login_Button.Enabled = true;
                return;
			}

            //Switch to the main form
            Hide();
            new Query_Interface().ShowDialog();

            //Close connection and the Login Manager after usage
            conn.Close();
            Close();
        }
	}
}
