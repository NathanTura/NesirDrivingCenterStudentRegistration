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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace NesirDrivingCenter
{
    public partial class AddEnrollee : Form
    {
        string connectionString = "";



        public AddEnrollee()
        {
            InitializeComponent();


            Nationalitytxt.Text = "Ethiopian";

            Maleradio.Checked = true;

            TrainingComboBox.SelectedIndex = 0;

    

        }

        private void MiddleNametxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Prefbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!SecondPanel.Visible == false)
            {
                ShowPanel(FirstPanel);
            }
        }

        private void Nextbrn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!FirstPanel.Visible == false)
            {
                ShowPanel(SecondPanel);
            }
        }
        private void ShowPanel(Panel panelToShow)
        {
            SecondPanel.Visible = panelToShow == SecondPanel;
            FirstPanel.Visible = panelToShow == FirstPanel;
            panelToShow.BringToFront();

        }

        private void savebtn_MouseClick(object sender, MouseEventArgs e)
        {
            // Collect data from the form
            string firstName = Firstnametxt.Text;
            string middleName = MiddleNametxt.Text;
            string lastName = LastNametxt.Text;
            DateTime dateOfBirth = Dob.Value;
            string gender = Maleradio.Checked ? "M" : "F";

            string phoneNumber = Phonenumtxt.Text;
            string ophoneNumber = OptionalPhoneTxt.Text;
            string nationality = Nationalitytxt.Text;
            string training = TrainingComboBox.SelectedItem?.ToString();
            DateTime startDate = StartDate.Value;
            string addressLine = AddressTxt.Text;
            string city = Citytxt.Text;
            string state = Statetxt.Text;
            string zipCode = ZipCodetxt.Text;
            string educationLevel = Educationlevel.Text;
            string paymentMethod = PaymentMethodComboBox.SelectedItem?.ToString();
            string accountInfo = Accountinfotxt.Text;
            decimal paidAmount;
            int selectIndex = TrainingComboBox.SelectedIndex;

            if (string.IsNullOrEmpty(paidamounttxt.Text) || !decimal.TryParse(paidamounttxt.Text, out paidAmount))
            {
                MessageBox.Show("Enter a valid amount", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
               string.IsNullOrWhiteSpace(phoneNumber) ||
               string.IsNullOrWhiteSpace(nationality) || string.IsNullOrWhiteSpace(training)
              )
            {
                MessageBox.Show("Please fill all fields", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("USP_ADDSTUDENT", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("@FIRSTNAME", firstName);
                        command.Parameters.AddWithValue("@MIDDLENAME", middleName);
                        command.Parameters.AddWithValue("@LASTNAME", lastName);
                        command.Parameters.AddWithValue("@GENDER", gender);
                        command.Parameters.AddWithValue("@DATEOFBIRTH", dateOfBirth);
                        command.Parameters.AddWithValue("@PHONENUMBER", phoneNumber);
                        command.Parameters.AddWithValue("@OptionalPHONENUMBER", ophoneNumber);
                        command.Parameters.AddWithValue("@NATIONALITY", nationality);
                        command.Parameters.AddWithValue("@TRAINING", training);
                        command.Parameters.AddWithValue("@STARTDATE", startDate);
                        command.Parameters.AddWithValue("@ADDRESS_LINE", addressLine);
                        command.Parameters.AddWithValue("@CITY", city);
                        command.Parameters.AddWithValue("@STATE", state);
                        command.Parameters.AddWithValue("@ZIP_CODE", zipCode);
                        command.Parameters.AddWithValue("@EDUCATIONLEVEL", educationLevel);
                        command.Parameters.AddWithValue("@PAYMENTMETHOD", paymentMethod);
                        command.Parameters.AddWithValue("@ACCOUNTINFO", accountInfo);
                        command.Parameters.AddWithValue("@PAIDAMOUNT", paidAmount);
                        command.Parameters.AddWithValue("@SelectIndex", selectIndex);


                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Enrollee added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearTextBoxes();
                        }
                        else
                        {
                            MessageBox.Show("Payment is not correct, Enrollee not added.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        }


                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error adding enrollee: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void cancelbtn_MouseClick(object sender, MouseEventArgs e)
        {
            ClearTextBoxes();
        }

        private void ClearTextBoxes()
        {
            Nationalitytxt.Text = "Ethiopian";
            AddressTxt.Clear();
            Firstnametxt.Clear();
            LastNametxt.Clear();
            MiddleNametxt.Clear();
            Accountinfotxt.Clear();
            OptionalPhoneTxt.Clear();
            Citytxt.Clear();
            Nationalitytxt.Clear();
            Statetxt.Clear();
            ZipCodetxt.Clear();
            Phonenumtxt.Clear();
            Educationlevel.Clear();
            paidamounttxt.Clear();
            TrainingComboBox.SelectedIndex = 0;
            PaymentMethodComboBox.SelectedIndex = 0;
            Maleradio.Checked = true;
        }

        private void Firstnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                MiddleNametxt.Focus();
            }
        }

        private void MiddleNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                LastNametxt.Focus();
            }
        }

        private void LastNametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                MiddleNametxt.Focus();
            }
        }

        private void Phonenumtxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                OptionalPhoneTxt.Focus();
            }
        }

        private void OptionalPhoneTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Nationalitytxt.Focus();
            }
        }

        private void AddressTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Citytxt.Focus();
            }
        }

        private void Citytxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Statetxt.Focus();
            }
        }

        private void Statetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                ZipCodetxt.Focus();
            }
        }

        private void ZipCodetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Educationlevel.Focus();
            }
        }

        private void Accountinfotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                paidamounttxt.Focus();
            }
        }

        private void paidamounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                savebtn.PerformClick();
            }
        }
    }
}