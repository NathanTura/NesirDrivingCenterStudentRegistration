using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Drawing;

namespace NesirDrivingCenter
{
    public partial class AddPayment : Form
    {
        string connectionString = "";
        private string _studentId;
        private decimal _paymentLeft;

        public AddPayment(string studentname, string paymentleft, string studentId, string accountinfo)
        {
            InitializeComponent();

            Fullnametxt.Text = studentname;
            Accountinfotxt.Text = accountinfo;
            Paymentlefttxt.Text = paymentleft;

            if (decimal.TryParse(paymentleft, out decimal parsedPaymentLeft))
            {
                _paymentLeft = parsedPaymentLeft;
            }
            else
            {
                _paymentLeft = 0;
                MessageBox.Show("Invalid Payment Left, Please close and try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            _studentId = studentId;
            cmbPaymentMethod.Items.AddRange(new object[] { "Cash", "Card", "Online" }); // Example payment methods
            cmbPaymentMethod.SelectedIndex = 0;
        }


        private void Savebtn_MouseClick(object sender, MouseEventArgs e)
        {
            string paymentMethod = cmbPaymentMethod.SelectedItem?.ToString() ?? "Cash";
            decimal paidAmount;

            if (string.IsNullOrEmpty(Payammounttxt.Text))
            {
                MessageBox.Show("Paid amount cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(Payammounttxt.Text, out paidAmount))
            {
                MessageBox.Show("Invalid paid amount format.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (paidAmount <= 0)
            {
                MessageBox.Show("Paid amount cannot be zero or less.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (paidAmount > _paymentLeft)
            {

                MessageBox.Show("Paid amount cannot be greater than payment left.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlCommand cmd = new MySqlCommand("USP_ADDPAYMENT", connection))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@p_StudentID", _studentId);
                        cmd.Parameters.AddWithValue("@p_PayAmount", paidAmount);
                        cmd.Parameters.AddWithValue("@p_PayMethod", paymentMethod);
                        cmd.Parameters.AddWithValue("@P_AccountInfo", Accountinfotxt.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Payment added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.LoadPaymentHistory(_studentId);
                        cleartext();
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (ex.Number == 1452)
                    {
                        MessageBox.Show($"Make sure the Student Id is correct and has been created", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An unexpected error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void cancelbtn_MouseClick(object sender, MouseEventArgs e)
        {
            cleartext();
            this.Close();
        }
        private void cleartext()
        {
            Fullnametxt.Text = string.Empty;
            Paymentlefttxt.Text = string.Empty;
            Accountinfotxt.Text = string.Empty;
            Payammounttxt.Text = string.Empty;
            cmbPaymentMethod.SelectedIndex = 0;
        }

        private void Payammounttxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                Savebtn.PerformClick();
            }
        }
    }
}