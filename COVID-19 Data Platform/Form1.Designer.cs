
namespace COVID_19_Data_Platform
{
	partial class Login_Manager
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Manager));
			this.Login_Title = new System.Windows.Forms.Label();
			this.User_Label = new System.Windows.Forms.Label();
			this.Password_Label = new System.Windows.Forms.Label();
			this.User_TextBox = new System.Windows.Forms.TextBox();
			this.Password_TextBox = new System.Windows.Forms.TextBox();
			this.Login_Button = new System.Windows.Forms.Button();
			this.Database_TextBox = new System.Windows.Forms.TextBox();
			this.Database_Label = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Login_Title
			// 
			this.Login_Title.AutoSize = true;
			this.Login_Title.BackColor = System.Drawing.Color.Transparent;
			this.Login_Title.Font = new System.Drawing.Font("Calibri", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login_Title.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Login_Title.Location = new System.Drawing.Point(377, 90);
			this.Login_Title.Name = "Login_Title";
			this.Login_Title.Size = new System.Drawing.Size(509, 49);
			this.Login_Title.TabIndex = 0;
			this.Login_Title.Text = "Login To PostgreSQL Database";
			this.Login_Title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// User_Label
			// 
			this.User_Label.AutoSize = true;
			this.User_Label.BackColor = System.Drawing.Color.Transparent;
			this.User_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.User_Label.Location = new System.Drawing.Point(429, 204);
			this.User_Label.Name = "User_Label";
			this.User_Label.Size = new System.Drawing.Size(57, 29);
			this.User_Label.TabIndex = 1;
			this.User_Label.Text = "User";
			// 
			// Password_Label
			// 
			this.Password_Label.AutoSize = true;
			this.Password_Label.BackColor = System.Drawing.Color.Transparent;
			this.Password_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_Label.Location = new System.Drawing.Point(408, 371);
			this.Password_Label.Name = "Password_Label";
			this.Password_Label.Size = new System.Drawing.Size(105, 29);
			this.Password_Label.TabIndex = 2;
			this.Password_Label.Text = "Password";
			// 
			// User_TextBox
			// 
			this.User_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.User_TextBox.Location = new System.Drawing.Point(580, 201);
			this.User_TextBox.Name = "User_TextBox";
			this.User_TextBox.Size = new System.Drawing.Size(265, 37);
			this.User_TextBox.TabIndex = 3;
			this.User_TextBox.Text = "postgres";
			// 
			// Password_TextBox
			// 
			this.Password_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Password_TextBox.Location = new System.Drawing.Point(580, 371);
			this.Password_TextBox.Name = "Password_TextBox";
			this.Password_TextBox.Size = new System.Drawing.Size(265, 37);
			this.Password_TextBox.TabIndex = 4;
			this.Password_TextBox.UseSystemPasswordChar = true;
			// 
			// Login_Button
			// 
			this.Login_Button.Cursor = System.Windows.Forms.Cursors.Default;
			this.Login_Button.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Login_Button.Location = new System.Drawing.Point(546, 477);
			this.Login_Button.Name = "Login_Button";
			this.Login_Button.Size = new System.Drawing.Size(151, 49);
			this.Login_Button.TabIndex = 5;
			this.Login_Button.Text = "Login";
			this.Login_Button.UseVisualStyleBackColor = true;
			this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
			// 
			// Database_TextBox
			// 
			this.Database_TextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Database_TextBox.Location = new System.Drawing.Point(580, 287);
			this.Database_TextBox.Name = "Database_TextBox";
			this.Database_TextBox.Size = new System.Drawing.Size(265, 37);
			this.Database_TextBox.TabIndex = 7;
			this.Database_TextBox.Text = "postgres";
			// 
			// Database_Label
			// 
			this.Database_Label.AutoSize = true;
			this.Database_Label.BackColor = System.Drawing.Color.Transparent;
			this.Database_Label.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Database_Label.Location = new System.Drawing.Point(408, 287);
			this.Database_Label.Name = "Database_Label";
			this.Database_Label.Size = new System.Drawing.Size(106, 29);
			this.Database_Label.TabIndex = 6;
			this.Database_Label.Text = "Database";
			// 
			// Login_Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Window;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1259, 642);
			this.Controls.Add(this.Database_TextBox);
			this.Controls.Add(this.Database_Label);
			this.Controls.Add(this.Login_Button);
			this.Controls.Add(this.Password_TextBox);
			this.Controls.Add(this.User_TextBox);
			this.Controls.Add(this.Password_Label);
			this.Controls.Add(this.User_Label);
			this.Controls.Add(this.Login_Title);
			this.MaximizeBox = false;
			this.Name = "Login_Manager";
			this.ShowIcon = false;
			this.Text = "Login Manager";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label Login_Title;
		private System.Windows.Forms.Label User_Label;
		private System.Windows.Forms.Label Password_Label;
		private System.Windows.Forms.TextBox User_TextBox;
		private System.Windows.Forms.TextBox Password_TextBox;
		private System.Windows.Forms.Button Login_Button;
		private System.Windows.Forms.TextBox Database_TextBox;
		private System.Windows.Forms.Label Database_Label;
	}
}

