using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace COVID_19_Data_Platform
{
	public partial class Query_Interface : Form
	{

		private static NpgsqlCommand cmd;
		public Query_Interface()
		{
			StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}
		private void Form2_Load(object sender, EventArgs e)
		{
			//Initialize SQL command
			cmd = new NpgsqlCommand
			{
				Connection = Login_Manager.conn,
				CommandType = CommandType.Text
			};

			//Create a table (if not exists) for data of different countries from Data directory
			try
			{
				//Create table
				cmd.CommandText =
					"create table countries_9014" +
					"(" +
					"_date varchar," +
					"country varchar," +
					"confirmed varchar," +
					"recovered varchar," +
					"death varchar," +
					"primary key(_date, country));";
				cmd.ExecuteNonQuery();
				using (StreamReader sr = new StreamReader("../../../Data/countries.txt"))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						string [] values = line.Split(',');
						
						//Insert data
						cmd.CommandText =
							"insert into countries_9014 " +
							"values " +
							"('" + values[0] + "'," +
							"'" + values[1] + "'," +
							"'" + values[2] + "'," +
							"'" + values[3] + "'," +
							"'" + values[4] + "')";
						cmd.ExecuteNonQuery();
					}

				}
			}
			catch (Exception)
			{
			}

			//Create a table (if not exists) for worldwide data from Data directory
			try
			{
				//Create table
				cmd.CommandText =
				"create table worldwide_9014" +
				"(" +
				"_date varchar," +
				"confirmed varchar," +
				"recovered varchar," +
				"death varchar," +
				"primary key(_date));";
				cmd.ExecuteNonQuery();
				using (StreamReader sr = new StreamReader("../../../Data/worldwide.txt"))
				{
					string line;
					while ((line = sr.ReadLine()) != null)
					{
						string[] values = line.Split(',');
						
						//Insert data
						cmd.CommandText =
							"insert into worldwide_9014 " +
							"values " +
							"('" + values[0] + "'," +
							"'" + values[1] + "'," +
							"'" + values[2] + "'," +
							"'" + values[3] + "');";
						cmd.ExecuteNonQuery();
					}
				}
			}
			catch (Exception ex)
			{
			}
		}

		//Make sure worldwide and country will not be selected togather (two events below)
		private void Worldwide_CheckedChanged(object sender, EventArgs e)
		{
			if (Worldwide.Checked == true && Country_CheckBox.Checked == true)
			{
				Country_CheckBox.Checked = false;
			}
		}

		private void Country_CheckBox_CheckedChanged(object sender, EventArgs e)
		{
			if (Worldwide.Checked == true && Country_CheckBox.Checked == true)
			{
				Worldwide.Checked = false;
			}
		}

		private void Query_Click(object sender, EventArgs e)
		{
			try
			{
				Query.Enabled = false;

				//Clear content in the list
				Header.Items.Clear();
				List.Items.Clear();

				//Generate Select statement according to the input
				//Adjustment for empty text box
				if (Year.Text == "" || Month.Text == "" || Day.Text == "")
					Date.Checked = false;
				if (Country_TextBox.Text == "")
					Country_CheckBox.Checked = false;

				//'Select' and 'from'
				if (Date.Checked)
					cmd.CommandText = "select ";
				else
					cmd.CommandText = "select _date, ";
				if (!Comfirmed.Checked && !Recovered.Checked && !Death.Checked)
				{
					Query.Enabled = true;
					return;
				}
				else if (Comfirmed.Checked && Recovered.Checked && Death.Checked)
					cmd.CommandText += "confirmed, recovered, death from ";
				else if (Comfirmed.Checked && Recovered.Checked)
					cmd.CommandText += "confirmed, recovered from ";
				else if (Recovered.Checked && Death.Checked)
					cmd.CommandText += "recovered, death from ";
				else if (Comfirmed.Checked && Death.Checked)
					cmd.CommandText += "confirmed, death from ";
				else if (Comfirmed.Checked)
					cmd.CommandText += "confirmed from ";
				else if (Recovered.Checked)
					cmd.CommandText += "recovered from ";
				else if (Death.Checked)
					cmd.CommandText += "death from ";

				//Return if neither worldwide nor country are selected, or enter 'table_name'
				if (!Worldwide.Checked && !Country_CheckBox.Checked)
				{
					Query.Enabled = true;
					return;
				}
				else if (Worldwide.Checked)
				{
					cmd.CommandText += "worldwide_9014 ";
				}
				else
				{
					cmd.CommandText += "countries_9014 ";
				}

				//'Where'
				if (Date.Checked && Country_CheckBox.Checked)
					cmd.CommandText += "where (_date = '" + Month.Text + "/" + Day.Text + "/" + Year.Text + "' " +
						"or _date = 'Date') " +
						"and (country = '" + Country_TextBox.Text + "'" +
						"or country = 'Country');";
				else if (Date.Checked)
					cmd.CommandText += "where _date = '" + Month.Text + "/" + Day.Text + "/" + Year.Text + "' " +
						"or _date = 'Date';";
				else if (Country_CheckBox.Checked)
					cmd.CommandText += "where country = '" + Country_TextBox.Text + "'" +
						"or country = 'Country';";

				//Execute SQL select statement read the results and output into the lists
				NpgsqlDataReader dr = cmd.ExecuteReader();

				//Read header
				if (dr.Read())
				{
					string header = "";
					for (int i = 0; i < dr.FieldCount; i++)
					{
						header += dr[i].ToString().PadRight(72 / dr.FieldCount, ' ');
					}
					Header.Items.Add(header + "\n");
				}

				//Check if there is any result (if not, return)
				if (!dr.Read())
				{
					List.Items.Add("No results found.");
					Query.Enabled = true;
					return;
				}

				//Output into the list with automatically adjusted format
				do
				{
					string item = "";
					for (int i = 0; i < dr.FieldCount; i++)
					{
						item += dr[i].ToString().PadRight(72 / dr.FieldCount, ' ');
					}
					List.Items.Add(item + "\n");
				}
				while (dr.Read());

				Query.Enabled = true;

				//Close SQL reader
				dr.Close();
			}
			catch (Exception)
			{
			}
		}
	}
}
