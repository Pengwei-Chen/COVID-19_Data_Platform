
namespace COVID_19_Data_Platform
{
	partial class Query_Interface
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Query_Interface));
			this.Query = new System.Windows.Forms.Button();
			this.Year = new System.Windows.Forms.TextBox();
			this.Country_TextBox = new System.Windows.Forms.TextBox();
			this.Comfirmed = new System.Windows.Forms.CheckBox();
			this.Recovered = new System.Windows.Forms.CheckBox();
			this.Death = new System.Windows.Forms.CheckBox();
			this.Day = new System.Windows.Forms.TextBox();
			this.Month = new System.Windows.Forms.TextBox();
			this.Worldwide = new System.Windows.Forms.CheckBox();
			this.Country_CheckBox = new System.Windows.Forms.CheckBox();
			this.Date = new System.Windows.Forms.CheckBox();
			this.List = new System.Windows.Forms.ListBox();
			this.Header = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// Query
			// 
			this.Query.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Query.Location = new System.Drawing.Point(941, 134);
			this.Query.Name = "Query";
			this.Query.Size = new System.Drawing.Size(149, 68);
			this.Query.TabIndex = 3;
			this.Query.Text = "Query";
			this.Query.UseVisualStyleBackColor = true;
			this.Query.Click += new System.EventHandler(this.Query_Click);
			// 
			// Year
			// 
			this.Year.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Year.Location = new System.Drawing.Point(117, 151);
			this.Year.Name = "Year";
			this.Year.Size = new System.Drawing.Size(93, 37);
			this.Year.TabIndex = 4;
			// 
			// Country_TextBox
			// 
			this.Country_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Country_TextBox.Location = new System.Drawing.Point(389, 203);
			this.Country_TextBox.Name = "Country_TextBox";
			this.Country_TextBox.Size = new System.Drawing.Size(246, 37);
			this.Country_TextBox.TabIndex = 5;
			// 
			// Comfirmed
			// 
			this.Comfirmed.AutoSize = true;
			this.Comfirmed.BackColor = System.Drawing.Color.Transparent;
			this.Comfirmed.Checked = true;
			this.Comfirmed.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Comfirmed.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Comfirmed.Location = new System.Drawing.Point(721, 111);
			this.Comfirmed.Name = "Comfirmed";
			this.Comfirmed.Size = new System.Drawing.Size(149, 33);
			this.Comfirmed.TabIndex = 6;
			this.Comfirmed.Text = "Comfirmed";
			this.Comfirmed.UseVisualStyleBackColor = false;
			// 
			// Recovered
			// 
			this.Recovered.AutoSize = true;
			this.Recovered.BackColor = System.Drawing.Color.Transparent;
			this.Recovered.Checked = true;
			this.Recovered.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Recovered.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Recovered.Location = new System.Drawing.Point(721, 162);
			this.Recovered.Name = "Recovered";
			this.Recovered.Size = new System.Drawing.Size(143, 33);
			this.Recovered.TabIndex = 7;
			this.Recovered.Text = "Recovered";
			this.Recovered.UseVisualStyleBackColor = false;
			// 
			// Death
			// 
			this.Death.AutoSize = true;
			this.Death.BackColor = System.Drawing.Color.Transparent;
			this.Death.Checked = true;
			this.Death.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Death.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Death.Location = new System.Drawing.Point(721, 215);
			this.Death.Name = "Death";
			this.Death.Size = new System.Drawing.Size(99, 33);
			this.Death.TabIndex = 8;
			this.Death.Text = "Death";
			this.Death.UseVisualStyleBackColor = false;
			// 
			// Day
			// 
			this.Day.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Day.Location = new System.Drawing.Point(264, 151);
			this.Day.Name = "Day";
			this.Day.Size = new System.Drawing.Size(42, 37);
			this.Day.TabIndex = 9;
			// 
			// Month
			// 
			this.Month.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Month.Location = new System.Drawing.Point(216, 151);
			this.Month.Name = "Month";
			this.Month.Size = new System.Drawing.Size(42, 37);
			this.Month.TabIndex = 10;
			// 
			// Worldwide
			// 
			this.Worldwide.AutoSize = true;
			this.Worldwide.BackColor = System.Drawing.Color.Transparent;
			this.Worldwide.Checked = true;
			this.Worldwide.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Worldwide.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Worldwide.Location = new System.Drawing.Point(441, 111);
			this.Worldwide.Name = "Worldwide";
			this.Worldwide.Size = new System.Drawing.Size(147, 33);
			this.Worldwide.TabIndex = 11;
			this.Worldwide.Text = "Worldwide";
			this.Worldwide.UseVisualStyleBackColor = false;
			this.Worldwide.CheckedChanged += new System.EventHandler(this.Worldwide_CheckedChanged);
			// 
			// Country_CheckBox
			// 
			this.Country_CheckBox.AutoSize = true;
			this.Country_CheckBox.BackColor = System.Drawing.Color.Transparent;
			this.Country_CheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Country_CheckBox.Location = new System.Drawing.Point(441, 155);
			this.Country_CheckBox.Name = "Country_CheckBox";
			this.Country_CheckBox.Size = new System.Drawing.Size(118, 33);
			this.Country_CheckBox.TabIndex = 12;
			this.Country_CheckBox.Text = "Country";
			this.Country_CheckBox.UseVisualStyleBackColor = false;
			this.Country_CheckBox.CheckedChanged += new System.EventHandler(this.Country_CheckBox_CheckedChanged);
			// 
			// Date
			// 
			this.Date.AutoSize = true;
			this.Date.BackColor = System.Drawing.Color.Transparent;
			this.Date.Checked = true;
			this.Date.CheckState = System.Windows.Forms.CheckState.Checked;
			this.Date.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Date.Location = new System.Drawing.Point(172, 111);
			this.Date.Name = "Date";
			this.Date.Size = new System.Drawing.Size(86, 33);
			this.Date.TabIndex = 14;
			this.Date.Text = "Date";
			this.Date.UseVisualStyleBackColor = false;
			// 
			// List
			// 
			this.List.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.List.FormattingEnabled = true;
			this.List.ItemHeight = 28;
			this.List.Location = new System.Drawing.Point(150, 305);
			this.List.Name = "List";
			this.List.Size = new System.Drawing.Size(921, 256);
			this.List.TabIndex = 13;
			// 
			// Header
			// 
			this.Header.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Header.FormattingEnabled = true;
			this.Header.ItemHeight = 28;
			this.Header.Location = new System.Drawing.Point(150, 267);
			this.Header.Name = "Header";
			this.Header.Size = new System.Drawing.Size(921, 60);
			this.Header.TabIndex = 15;
			// 
			// Query_Interface
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1221, 645);
			this.Controls.Add(this.Header);
			this.Controls.Add(this.Date);
			this.Controls.Add(this.List);
			this.Controls.Add(this.Country_CheckBox);
			this.Controls.Add(this.Worldwide);
			this.Controls.Add(this.Month);
			this.Controls.Add(this.Day);
			this.Controls.Add(this.Death);
			this.Controls.Add(this.Recovered);
			this.Controls.Add(this.Comfirmed);
			this.Controls.Add(this.Country_TextBox);
			this.Controls.Add(this.Year);
			this.Controls.Add(this.Query);
			this.MaximizeBox = false;
			this.Name = "Query_Interface";
			this.ShowIcon = false;
			this.Text = "COVID-19 Data Platform";
			this.Load += new System.EventHandler(this.Form2_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Query;
		private System.Windows.Forms.TextBox Year;
		private System.Windows.Forms.TextBox Country_TextBox;
		private System.Windows.Forms.CheckBox Comfirmed;
		private System.Windows.Forms.CheckBox Recovered;
		private System.Windows.Forms.CheckBox Death;
		private System.Windows.Forms.TextBox Day;
		private System.Windows.Forms.TextBox Month;
		private System.Windows.Forms.CheckBox Worldwide;
		private System.Windows.Forms.CheckBox Country_CheckBox;
		private System.Windows.Forms.CheckBox Date;
		private System.Windows.Forms.ListBox List;
		private System.Windows.Forms.ListBox Header;
	}
}