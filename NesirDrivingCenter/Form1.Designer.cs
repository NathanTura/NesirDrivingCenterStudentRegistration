using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.Data.SqlClient;  // Using Microsoft.Data.SqlClient

namespace NesirDrivingCenter
{
    public partial class Form1 : Form
    {
        // Designer variables
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Button loginButton;
        private PictureBox pictureBox1;
        private Label titleLabel;



        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            loginButton = new Button();
            pictureBox1 = new PictureBox();
            titleLabel = new Label();
            EyeofRah = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)EyeofRah).BeginInit();
            SuspendLayout();
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            usernameLabel.ForeColor = Color.Black;
            usernameLabel.Location = new Point(44, 277);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 21);
            usernameLabel.TabIndex = 0;
            usernameLabel.Text = "Username:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            passwordLabel.ForeColor = Color.Black;
            passwordLabel.Location = new Point(44, 327);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(86, 21);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.BackColor = Color.White;
            usernameTextBox.Font = new Font("Segoe UI", 12F);
            usernameTextBox.ForeColor = Color.Black;
            usernameTextBox.Location = new Point(154, 277);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(250, 29);
            usernameTextBox.TabIndex = 2;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            usernameTextBox.KeyPress += usernameTextBox_KeyPress;
            // 
            // passwordTextBox
            // 
            passwordTextBox.BackColor = Color.White;
            passwordTextBox.Font = new Font("Segoe UI", 12F);
            passwordTextBox.ForeColor = Color.Black;
            passwordTextBox.Location = new Point(154, 327);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(250, 29);
            passwordTextBox.TabIndex = 3;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.KeyPress += passwordTextBox_KeyPress;
            // 
            // loginButton
            // 
            loginButton.BackColor = Color.SteelBlue;
            loginButton.FlatAppearance.BorderSize = 0;
            loginButton.FlatStyle = FlatStyle.Flat;
            loginButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginButton.ForeColor = Color.White;
            loginButton.Location = new Point(154, 405);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(250, 40);
            loginButton.TabIndex = 4;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = false;
            loginButton.Click += LoginButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.photo_2024_12_10_19_19_25_removebg;
            pictureBox1.Location = new Point(-161, -107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(809, 428);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click_2;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            titleLabel.ForeColor = Color.Black;
            titleLabel.Location = new Point(140, 220);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(224, 30);
            titleLabel.TabIndex = 6;
            titleLabel.Text = "Nesir Driving Center";
            // 
            // EyeofRah
            // 
            EyeofRah.BackColor = Color.White;
            EyeofRah.BorderStyle = BorderStyle.FixedSingle;
            EyeofRah.Image = Properties.Resources.icons8_closed_eye_50__1_;
            EyeofRah.Location = new Point(360, 327);
            EyeofRah.Name = "EyeofRah";
            EyeofRah.Size = new Size(44, 29);
            EyeofRah.SizeMode = PictureBoxSizeMode.Zoom;
            EyeofRah.TabIndex = 7;
            EyeofRah.TabStop = false;
            EyeofRah.MouseClick += EyeofRah_MouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 561);
            Controls.Add(EyeofRah);
            Controls.Add(titleLabel);
            Controls.Add(loginButton);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)EyeofRah).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (AuthenticateUser(username, password))
            {
              
                MainMenu mainForm = new MainMenu();
                mainForm.Show();

          
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            bool isAuthenticated = false;


            string connectionString = "";


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM USERSLIST WHERE FirstName = @Username AND PhoneNumber = @Password";

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                       
                        int userCount = Convert.ToInt32(command.ExecuteScalar());
                        isAuthenticated = userCount > 0;
                    }
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine("SQL Error Code: " + ex.Number);
                Console.WriteLine("Error Message: " + ex.Message);
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}",
                                "Database Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                MessageBox.Show($"An error occurred while connecting to the database:\n{ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return isAuthenticated;
        }

        private PictureBox EyeofRah;
    }
}
    
