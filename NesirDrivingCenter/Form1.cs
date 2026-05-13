namespace NesirDrivingCenter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        bool isPasswordVisible = true;


        private void EyeofRah_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPasswordVisible)
            {
                EyeofRah.Image = Properties.Resources.icons8_closed_eye_50__1_;
                passwordTextBox.UseSystemPasswordChar = true;
            }
            else
            {
                EyeofRah.Image = Properties.Resources.icons8_eye_50;
                passwordTextBox.UseSystemPasswordChar = false;
            }
            isPasswordVisible = !isPasswordVisible;
        }

        private void usernameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                passwordTextBox.Focus();
            }
            else if (e.KeyChar == (char)Keys.Down)
            {
                e.Handled = true;
             
                passwordTextBox.Focus(); 
            }
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
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
        }
    }
}
