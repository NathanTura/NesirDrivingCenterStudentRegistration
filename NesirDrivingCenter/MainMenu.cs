using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Linq;
using System.Collections;
using System.Linq.Expressions;
using Mysqlx.Crud;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace NesirDrivingCenter
{
    public partial class MainMenu : Form
    {
        private const int SidebarExpandedWidth = 200;
        private const int SidebarCollapsedWidth = 0;
        int filteredCount;
        private string currentStudentId;
        string connectionString = "";


        public MainMenu()
        {
            InitializeComponent();

            InitializeUI();

            SearchBtn.Text = "Search";
            Coursecombo.Visible = false;
            YearCombo.Visible = false;


            string proc = "USP_UPDATE_STUDENT_STATUS";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(proc, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure; 
                        command.ExecuteNonQuery(); 

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void InitializeUI()
        {
            SideBarPanel.Width = SidebarCollapsedWidth;
            DashBoardPanel.Visible = true;
            StudentDetailPanel.Visible = false;
            PaymentReportPanel.Visible = false;
            SetUIStyle();
            FormClosing += MainForm_FormClosing;
            ShowPanel(DashBoardPanel);
            string query = " SELECT StudentID, CONCAT(FirstName, ' ', MiddleName) AS FullName, Gender, PhoneNumber, OptionalPhoneNumber, Nationality, EnrolledDate, StartDate, Status FROM STUDENTINFO";

            LoadData(DashboardGrid, query);


            AssignScrollHandlers(this.Controls);
        }


        private void AssignScrollHandlers(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is DataGridView grid)
                {
                    grid.MouseWheel += DataGridView_MouseWheel;
                }

                // Recursively check child controls
                if (control.HasChildren)
                {
                    AssignScrollHandlers(control.Controls);
                }
            }
        }

        // Generic MouseWheel event handler for all DataGridViews
        private void DataGridView_MouseWheel(object sender, MouseEventArgs e)
        {
            if (sender is DataGridView dataGridView)
            {
                if (e.Delta > 0) // Scroll up
                {
                    dataGridView.FirstDisplayedScrollingRowIndex =
                        Math.Max(0, dataGridView.FirstDisplayedScrollingRowIndex - 1);
                }
                else if (e.Delta < 0) // Scroll down
                {
                    dataGridView.FirstDisplayedScrollingRowIndex =
                        Math.Min(dataGridView.RowCount - 1, dataGridView.FirstDisplayedScrollingRowIndex + 1);
                }
            }
        }

        private void ToggleSidebar()
        {
            SideBarPanel.Width = SideBarPanel.Width == SidebarExpandedWidth ? SidebarCollapsedWidth : SidebarExpandedWidth;
        }

        private void Sidepopup_Click_1(object sender, EventArgs e)
        {
            ToggleSidebar();
        }

        private void ShowPanel(Panel panelToShow)
        {
            DashBoardPanel.Visible = panelToShow == DashBoardPanel;
            StudentDetailPanel.Visible = panelToShow == StudentDetailPanel;
            PaymentReportPanel.Visible = panelToShow == PaymentReportPanel;
            studentreportpanel.Visible = panelToShow == studentreportpanel;

            ClearSearch();
            panelToShow.BringToFront();
            SideBarPanel.Width = SidebarCollapsedWidth;
        }
        private void ClearSearch()
        {
            SearchTextBox.Text = string.Empty;
            EnteraName.Visible = false;
            PaymentHistoryData.DataSource = null;
            DashboardGrid.DataSource = null;
            ClearTextBoxes();
        }

        private void DashBoardMouse_Click(object sender, MouseEventArgs e)
        {
            SearchBtn.Text = "Search";
            SearchTextBox.Visible = true;
            Coursecombo.Visible = false;
            YearCombo.Visible = false;
            ShowPanel(DashBoardPanel);
            string query = " SELECT StudentID, CONCAT(FirstName, ' ', MiddleName) AS FullName, Gender, PhoneNumber, OptionalPhoneNumber, Nationality, EnrolledDate, StartDate, Status FROM STUDENTINFO";

            LoadData(DashboardGrid, query);
        }

        private void EnrollessListMouse_Clicked(object sender, MouseEventArgs e)
        {
            SearchBtn.Text = "Search";
            SearchTextBox.Visible = true;
            Coursecombo.Visible = false;
            YearCombo.Visible = false;
            ShowPanel(StudentDetailPanel);

        }

        private void Paymentrepbtn_MouseClick_1(object sender, MouseEventArgs e)
        {
            SearchBtn.Text = "Search";
            SearchTextBox.Visible = true;
            Coursecombo.Visible = false;
            YearCombo.Visible = false;
            ShowPanel(PaymentReportPanel);

            string query = @"
            SELECT 
                p.StudentID,
                ANY_VALUE(p.StudentName) As StudentName,
                ANY_VALUE(p.PaymentDate) As PaymentDate,
                ANY_VALUE(p.PaymentMethod) As PaymentMethod,
                ANY_VALUE(p.AccountInfo) As Accountinfo,
                ANY_VALUE(p.PaidAmount) AS PaymentAmmount,
                MAX(p.PaymentLeft) AS PaymentLeft,
       	        ANY_VALUE(p.PaymentStatus)  As PaymentStatus
            FROM PAYMENT p
            INNER JOIN (
                SELECT StudentID, MAX(PaymentLeft) AS MaxPaymentLeft
                FROM PAYMENT
                WHERE PaymentLeft > 0
                GROUP BY StudentID
            ) AS subquery ON p.StudentID = subquery.StudentID AND p.PaymentLeft = subquery.MaxPaymentLeft
            GROUP BY p.StudentID
             ORDER BY p.StudentID;
        ";
            LoadData(PaymentReportTable, query);
        }
        private void SearchBtn_MouseClick(object sender, MouseEventArgs e)
        {
            string searchTerm = SearchTextBox.Text.Trim();

            if (studentreportpanel.Visible)
            {
                PerformStudentReportSearch();
            }
            else if (string.IsNullOrWhiteSpace(searchTerm) && !StudentDetailPanel.Visible)
            {
                LoadDashboardData(null);
                ClearTextBoxes();
                EnteraName.Visible = false;

            }
         
            else if (string.IsNullOrWhiteSpace(searchTerm) && StudentDetailPanel.Visible)
            {
                HandleEmptySearchTerm();
            }
            else if (StudentDetailPanel.Visible)
            {
                PerformStudentDetailSearch(searchTerm);
                EnteraName.Visible = false;
            }

            else if (string.IsNullOrWhiteSpace(searchTerm) && !StudentDetailPanel.Visible && PaymentReportPanel.Visible)
            {
                PaymentReport(null);
                ClearTextBoxes();
                EnteraName.Visible = false;
            }
            else if (PaymentReportPanel.Visible)
            {
                PaymentReport(searchTerm);
            }

            else
            {
                PerformGeneralSearch(searchTerm);
                EnteraName.Visible = false;
            }
        }
        private void HandleEmptySearchTerm()
        {
            EnteraName.Visible = true;
            PaymentHistoryData.DataSource = null;
            DashboardGrid.DataSource = null;
            ClearTextBoxes();
        }

        public void PaymentReport(string studentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("FilterPaymentsByStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        if (string.IsNullOrWhiteSpace(studentId))
                        {
                            command.Parameters.AddWithValue("StudentFilter", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("StudentFilter", studentId);
                        }

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            DataTable paymentData = new DataTable();
                            paymentData.Load(reader);

                            if (!string.IsNullOrWhiteSpace(studentId))
                            {
                                DataRow[] foundRows = paymentData.Select($"StudentID = '{studentId}' OR StudentName LIKE '%{studentId}%'");
                                DataTable filteredData = new DataTable();
                                if (foundRows.Length > 0)
                                {
                                    filteredData = foundRows.CopyToDataTable();
                                    foreach (DataRow row in foundRows)
                                    {
                                        paymentData.Rows.Remove(row);
                                    }

                                    filteredData.DefaultView.Sort = "StudentID ASC";
                                    paymentData.DefaultView.Sort = "StudentID ASC";

                                    filteredData.Merge(paymentData);
                                    PaymentReportTable.DataSource = filteredData;
                                }
                                else
                                {
                                    paymentData.DefaultView.Sort = "StudentID ASC";
                                    PaymentReportTable.DataSource = paymentData;
                                }


                            }

                            else
                            {

                                paymentData.DefaultView.Sort = "StudentID ASC";
                                DashboardGrid.DataSource = paymentData;
                            }
                        }
                    }
                    SetDataGridViewStyle(PaymentReportTable);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PerformStudentReportSearch()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand("FilterDataByDateAndCourse_Report", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        string selectedYear = YearCombo.SelectedItem?.ToString();
                        string selectedCourse = Coursecombo.SelectedItem?.ToString();

                        AddDateParameter(command, selectedYear);
                        AddCourseParameter(command, selectedCourse);

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            if (reader.NextResult() && reader.Read())
                            {
                                filteredCount = Convert.ToInt32(reader["FilteredRowCount"]);
                                Numberofstudentstxt.Text = filteredCount.ToString();
                            }
                            else
                            {
                                Numberofstudentstxt.Text = "0";
                            }
                        }

                        using (MySqlDataReader readers = command.ExecuteReader())
                        {
                            DataTable dt = new DataTable();
                            dt.Load(readers);
                            studentreportdata.DataSource = dt;
                            SetDataGridViewStyle(studentreportdata);
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AddDateParameter(MySqlCommand command, string selectedYear)
        {
            if (selectedYear == "All")
            {
                command.Parameters.AddWithValue("DateFilter", DBNull.Value);
            }
            else if (DateTime.TryParse(selectedYear, out DateTime yearFilter))
            {
                command.Parameters.AddWithValue("DateFilter", yearFilter);
            }
            else
            {
                command.Parameters.AddWithValue("DateFilter", DBNull.Value);
            }
        }
        private void AddCourseParameter(MySqlCommand command, string selectedCourse)
        {
            if (selectedCourse == "All" || string.IsNullOrWhiteSpace(selectedCourse))
            {
                command.Parameters.AddWithValue("CourseFilter", DBNull.Value);
            }
            else
            {
                command.Parameters.AddWithValue("CourseFilter", selectedCourse);
            }
        }
        private void PerformStudentDetailSearch(string searchTerm)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string studentQuery = @"SELECT s.StudentID, CONCAT(s.FirstName, ' ', IFNULL(s.MiddleName, ''), ' ', s.LastName) AS FullName, s.Gender, s.DateOfBirth, s.PhoneNumber, a.AddressLine, t.TrainingCourse, t.TrainingDuration ,t.Price, s.Status, s.EnrolledDate, s.StartDate, s.EndDate
                                  FROM STUDENTINFO s 
                                  LEFT JOIN ADDRESSES a ON s.StudentID = a.StudentID 
                                  LEFT JOIN TRAINING t ON s.StudentID = t.StudentID 
                                  LEFT JOIN PROFTRAIN pt ON s.StudentID = pt.StudentID 
                                  LEFT JOIN PAYMENT p ON s.StudentID = p.StudentID 
                                  WHERE s.StudentID = @searchTerm";
                    using (MySqlCommand studentCommand = new MySqlCommand(studentQuery, connection))
                    {
                        studentCommand.Parameters.AddWithValue("@searchTerm", searchTerm);

                        using (MySqlDataReader reader = studentCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentStudentId = reader["StudentID"].ToString();
                                FullNameTextBox.Text = reader["FullName"].ToString();
                                GenderText.Text = reader["Gender"].ToString();
                                DateofBirthtext.Text = reader["DateOfBirth"] != DBNull.Value ? ((DateTime)reader["DateOfBirth"]).ToShortDateString() : "";
                                PhoneNUmbertext.Text = reader["PhoneNumber"].ToString();
                                AdressTxt.Text = reader["AddressLine"].ToString();
                                TrainingpakTxt.Text = reader["TrainingCourse"].ToString();
                                TrainingTxt.Text = reader["TrainingDuration"].ToString();
                                Costtxt.Text = reader["Price"].ToString();
                                textBox7.Text = reader["Status"].ToString();
                                Enrolleddatetxt.Text = reader["EnrolledDate"] != DBNull.Value ? ((DateTime)reader["EnrolledDate"]).ToShortDateString() : "";
                                Startdatetxt.Text = reader["StartDate"] != DBNull.Value ? ((DateTime)reader["StartDate"]).ToShortDateString() : "";
                                EndDatetxt.Text = reader["EndDate"] != DBNull.Value ? ((DateTime)reader["EndDate"]).ToShortDateString() : "";
                            }
                            else
                            {
                                MessageBox.Show("No student data found for this ID.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBoxes();
                            }
                        }

                    }
                    LoadPaymentHistory(searchTerm);

                    LoadDashboardData(searchTerm);

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
        }

        private void PerformGeneralSearch(string searchTerm)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string studentQuery = @"SELECT s.StudentID, CONCAT(s.FirstName, ' ', IFNULL(s.MiddleName, ''), ' ', s.LastName) AS FullName, s.Gender, s.DateOfBirth, s.PhoneNumber, a.AddressLine, t.TrainingCourse, t.TrainingDuration ,t.Price, s.Status,  s.EnrolledDate, s.StartDate, s.EndDate
                                 FROM STUDENTINFO s 
                                 LEFT JOIN ADDRESSES a ON s.StudentID = a.StudentID 
                                 LEFT JOIN TRAINING t ON s.StudentID = t.StudentID 
                                 LEFT JOIN PROFTRAIN pt ON s.StudentID = pt.StudentID 
                                 LEFT JOIN PAYMENT p ON s.StudentID = p.StudentID 
                                 WHERE s.StudentID = @searchTerm OR s.FirstName LIKE @searchTermLike";

                    using (MySqlCommand studentCommand = new MySqlCommand(studentQuery, connection))
                    {
                        studentCommand.Parameters.AddWithValue("@searchTerm", searchTerm);
                        studentCommand.Parameters.AddWithValue("@searchTermLike", $"%{searchTerm}%");

                        using (MySqlDataReader reader = studentCommand.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                currentStudentId = reader["StudentID"].ToString();
                                FullNameTextBox.Text = reader["FullName"].ToString();
                                GenderText.Text = reader["Gender"].ToString();
                                DateofBirthtext.Text = reader["DateOfBirth"] != DBNull.Value ? ((DateTime)reader["DateOfBirth"]).ToShortDateString() : "";
                                PhoneNUmbertext.Text = reader["PhoneNumber"].ToString();
                                AdressTxt.Text = reader["AddressLine"].ToString();
                                TrainingpakTxt.Text = reader["TrainingCourse"].ToString();
                                TrainingTxt.Text = reader["TrainingDuration"].ToString();
                                Costtxt.Text = reader["Price"].ToString();
                                textBox7.Text = reader["Status"].ToString();
                                Enrolleddatetxt.Text = reader["EnrolledDate"] != DBNull.Value ? ((DateTime)reader["EnrolledDate"]).ToShortDateString() : "";
                                Startdatetxt.Text = reader["StartDate"] != DBNull.Value ? ((DateTime)reader["StartDate"]).ToShortDateString() : "";
                                EndDatetxt.Text = reader["EndDate"] != DBNull.Value ? ((DateTime)reader["EndDate"]).ToShortDateString() : "";
                            }
                            else
                            {
                                MessageBox.Show("No student data found for this ID or Name.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearTextBoxes();
                            }
                        }
                    }
                    LoadPaymentHistory(searchTerm);
                    LoadDashboardData(searchTerm);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }
        }

        public void LoadPaymentHistory(string studentId)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("FilterPaymentsByStudent", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;


                        if (string.IsNullOrWhiteSpace(studentId))
                        {
                            command.Parameters.AddWithValue("StudentFilter", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("StudentFilter", studentId);
                        }


                        using (MySqlDataReader reader = command.ExecuteReader())
                        {

                            DataTable paymentData = new DataTable();
                            paymentData.Load(reader);

                            if (!string.IsNullOrWhiteSpace(studentId))
                            {
                                DataRow[] foundRows = paymentData.Select($"StudentID = '{studentId}' OR StudentName LIKE '%{studentId}%'");

                                DataTable filteredDatas = new DataTable();
                                if (foundRows.Length > 0)
                                {
                                    filteredDatas = foundRows.CopyToDataTable();
                                    foreach (DataRow foundRow in foundRows)
                                    {
                                        paymentData.Rows.Remove(foundRow);
                                    }

                                    filteredDatas.Merge(paymentData);
                                }
                                else
                                {
                                    filteredDatas = paymentData;
                                }

                                PaymentHistoryData.DataSource = filteredDatas;
                            }
                            else
                            {
                                PaymentHistoryData.DataSource = paymentData;
                            }
                        }
                    }
                    SetDataGridViewStyle(PaymentHistoryData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ClearTextBoxes();
            }

        }
        private void LoadDashboardData(string searchTerm)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string dashboardQuery = " SELECT StudentID, CONCAT(FirstName, ' ', MiddleName) AS FullName, Gender, PhoneNumber, OptionalPhoneNumber, Nationality, EnrolledDate, StartDate, Status FROM STUDENTINFO";

                    using (MySqlCommand dashboardCommand = new MySqlCommand(dashboardQuery, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(dashboardCommand))
                        {
                            DataTable dashboardData = new DataTable();
                            adapter.Fill(dashboardData);
                            if (!string.IsNullOrWhiteSpace(searchTerm))
                            {
                                DataRow[] foundRows = dashboardData.Select($"StudentID = '{searchTerm}' OR FullName LIKE '%{searchTerm}%'");
                                DataTable filteredData = new DataTable();
                                if (foundRows.Length > 0)
                                {
                                    filteredData = foundRows.CopyToDataTable();
                                    foreach (DataRow foundRow in foundRows)
                                    {
                                        dashboardData.Rows.Remove(foundRow);
                                    }
                                    dashboardData.DefaultView.Sort = "StudentID ASC";
                                    filteredData.Merge(dashboardData);
                                }
                                else
                                {
                                    dashboardData.DefaultView.Sort = "StudentID ASC";
                                    filteredData = dashboardData;
                                }
                                DashboardGrid.DataSource = filteredData;
                            }

                            else
                            {
                           
                                dashboardData.DefaultView.Sort = "StudentID ASC";
                                DashboardGrid.DataSource = dashboardData;
                            }
                        }
                    }
                    SetDataGridViewStyle(DashboardGrid);
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadData(DataGridView dataGridView, string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dataGridView.DataSource = dataTable;
                    }
                }
                SetDataGridViewStyle(dataGridView);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SetDataGridViewStyle(DataGridView dataGridView)
        {
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView.BackgroundColor = Color.White;
            dataGridView.EnableHeadersVisualStyles = false;
            dataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void SetUIStyle()
        {
            this.BackColor = Color.FromArgb(52, 73, 94);
            TitlePanel.BackColor = Color.FromArgb(52, 73, 94);
            SideBarPanel.BackColor = Color.FromArgb(52, 73, 94);
            SearchPanel.BackColor = Color.WhiteSmoke;

            TitleLabel.ForeColor = Color.White;
            label1.ForeColor = Color.LightGray;


            foreach (Control control in SideBarPanel.Controls)
            {
                if (control is Button button)
                {
                    button.ForeColor = Color.White;
                    button.FlatAppearance.MouseOverBackColor = Color.FromArgb(70, 90, 120);
                    button.FlatAppearance.MouseDownBackColor = Color.FromArgb(60, 80, 110);
                }
            }

            foreach (Control control in SearchPanel.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.BackColor = Color.White;
                    textBox.ForeColor = Color.Black;
                }
                else if (control is Button button)
                {
                    button.BackColor = Color.SteelBlue;
                    button.ForeColor = Color.White;
                }
            }
        }

        private void MainForm_FormClosing(object? sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void Userbtn_MouseClick(object sender, MouseEventArgs e)
        {
            string newFirstName = FullNameTextBox.Text.Split(' ').Length > 0 ? FullNameTextBox.Text.Split(' ')[0] : string.Empty;
            string newMiddleName = FullNameTextBox.Text.Split(' ').Length > 2 ? FullNameTextBox.Text.Split(' ')[1] : null;
            string newLastName = FullNameTextBox.Text.Split(' ').Length > 1 ? FullNameTextBox.Text.Split(' ')[FullNameTextBox.Text.Split(' ').Length - 1] : string.Empty;
            string newGender = GenderText.Text ?? string.Empty;
            DateTime? newDateOfBirth = !string.IsNullOrEmpty(DateofBirthtext.Text) ? DateTime.Parse(DateofBirthtext.Text) : null;
            string newPhoneNumber = PhoneNUmbertext.Text ?? string.Empty;
            string newAddressLine = AdressTxt.Text ?? string.Empty;
            string newTrainingCourse = TrainingpakTxt.Text ?? string.Empty;
            string newTrainingDuration = TrainingTxt.Text ?? string.Empty;
            decimal newPrice = string.IsNullOrEmpty(Costtxt.Text) ? 0 : decimal.Parse(Costtxt.Text);
            string newStatus = textBox7.Text ?? string.Empty;
        }

        private void ClearTextBoxes()
        {
            FullNameTextBox.Text = string.Empty;
            GenderText.Text = string.Empty;
            DateofBirthtext.Text = string.Empty;
            PhoneNUmbertext.Text = string.Empty;
            AdressTxt.Text = string.Empty;
            TrainingpakTxt.Text = string.Empty;
            Costtxt.Text = string.Empty;
            textBox7.Text = string.Empty;
            Enrolleddatetxt.Text = string.Empty;
            Startdatetxt.Text = string.Empty;
            EndDatetxt.Text = string.Empty;
            PaymentHistoryData.DataSource = null;
        }

        private void DeleteBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                MessageBox.Show("Please search for a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string studentId = SearchTextBox.Text.Trim();
            DialogResult result = MessageBox.Show($"Are you sure you want to delete student with ID: {studentId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();
                        string deletePaymentQuery = "DELETE FROM PAYMENT WHERE StudentID = @studentId";
                        using (MySqlCommand deletePaymentCommand = new MySqlCommand(deletePaymentQuery, connection))
                        {
                            deletePaymentCommand.Parameters.AddWithValue("@studentId", studentId);
                            deletePaymentCommand.ExecuteNonQuery();
                        }
                        string deleteProfTrainQuery = "DELETE FROM PROFTRAIN WHERE StudentID = @studentId";
                        using (MySqlCommand deleteProfTrainCommand = new MySqlCommand(deleteProfTrainQuery, connection))
                        {
                            deleteProfTrainCommand.Parameters.AddWithValue("@studentId", studentId);
                            deleteProfTrainCommand.ExecuteNonQuery();
                        }
                        string deleteTrainingQuery = "DELETE FROM TRAINING WHERE StudentID = @studentId";
                        using (MySqlCommand deleteTrainingCommand = new MySqlCommand(deleteTrainingQuery, connection))
                        {
                            deleteTrainingCommand.Parameters.AddWithValue("@studentId", studentId);
                            deleteTrainingCommand.ExecuteNonQuery();
                        }
                        string deleteAddressesQuery = "DELETE FROM ADDRESSES WHERE StudentID = @studentId";
                        using (MySqlCommand deleteAddressesCommand = new MySqlCommand(deleteAddressesQuery, connection))
                        {
                            deleteAddressesCommand.Parameters.AddWithValue("@studentId", studentId);
                            deleteAddressesCommand.ExecuteNonQuery();
                        }
                        string deleteStudentQuery = "DELETE FROM STUDENTINFO WHERE StudentID = @studentId";
                        using (MySqlCommand deleteStudentCommand = new MySqlCommand(deleteStudentQuery, connection))
                        {
                            deleteStudentCommand.Parameters.AddWithValue("@studentId", studentId);
                            int rowsAffected = deleteStudentCommand.ExecuteNonQuery();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show($"Student with ID: {studentId} has been deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                ClearSearch();
                                string query = " SELECT StudentID, CONCAT(FirstName, ' ', MiddleName) AS FullName, Gender, PhoneNumber, OptionalPhoneNumber, Nationality, EnrolledDate, StartDate, Status FROM STUDENTINFO";

                                LoadData(DashboardGrid, query);
                            }
                            else
                            {
                                MessageBox.Show($"Student with ID: {studentId} not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }


        private bool isEditing = false;

        private void Editbutton_Click(object sender, EventArgs e)
        {
            isEditing = !isEditing;

            FullNameTextBox.ReadOnly = !isEditing;
            GenderText.ReadOnly = !isEditing;
            DateofBirthtext.ReadOnly = !isEditing;
            PhoneNUmbertext.ReadOnly = !isEditing;
            AdressTxt.ReadOnly = !isEditing;
            TrainingpakTxt.ReadOnly = !isEditing;
            TrainingTxt.ReadOnly = !isEditing;
            Costtxt.ReadOnly = !isEditing;
            textBox7.ReadOnly = !isEditing;

            if (isEditing)
            {
                Editbutton.Text = "Cancel";
                UpdateBtn.Enabled = true;
            }
            else
            {
                Editbutton.Text = "Edit";
                UpdateBtn.Enabled = false;
            }
            TrainingpakTxt.Visible = false;


            FullNameTextBox.Enabled = true;
            GenderText.Enabled = true;
            DateofBirthtext.Enabled = true;
            PhoneNUmbertext.Enabled = true;
            AdressTxt.Enabled = true;


        }

        private async void UpdateBtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isEditing)
            {
                MessageBox.Show("Please click the 'Edit' button to make changes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
            {
                MessageBox.Show("Please search for a student to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string studentId = SearchTextBox.Text.Trim();

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    string selectQuery = @"SELECT s.FirstName, IFNULL(s.MiddleName, ''), s.LastName, s.Gender, s.DateOfBirth, s.PhoneNumber, a.AddressLine, t.TrainingCourse, t.TrainingDuration, t.Price, s.Status
                           FROM STUDENTINFO s
                           LEFT JOIN ADDRESSES a ON s.StudentID = a.StudentID
                           LEFT JOIN TRAINING t ON s.StudentID = t.StudentID
                           WHERE s.StudentID = @studentId";


                    MySqlCommand selectCommand = new MySqlCommand(selectQuery, connection);
                    selectCommand.Parameters.AddWithValue("@studentId", studentId);

                    MySqlDataReader reader = (MySqlDataReader)await selectCommand.ExecuteReaderAsync();

                    if (!reader.HasRows)
                    {
                        MessageBox.Show("No student found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    await reader.ReadAsync();

                    string originalFirstName = reader["FirstName"].ToString();
                    string originalMiddleName = reader[1].ToString();
                    string originalLastName = reader["LastName"].ToString();
                    string originalGender = reader["Gender"].ToString();
                    DateTime? originalDateOfBirth = reader["DateOfBirth"] != DBNull.Value ? (DateTime?)reader.GetDateTime(reader.GetOrdinal("DateOfBirth")) : null;
                    string originalPhoneNumber = reader["PhoneNumber"].ToString();
                    string originalAddressLine = reader["AddressLine"].ToString();
                    string originalTrainingCourse = reader["TrainingCourse"].ToString();
                    string originalTrainingDuration = reader["TrainingDuration"].ToString();
                    decimal originalPrice = (decimal)reader["Price"];
                    string originalStatus = reader["Status"].ToString();
                    reader.Close();

                    string newFirstName = FullNameTextBox.Text.Split(' ').Length > 0 ? FullNameTextBox.Text.Split(' ')[0] : string.Empty;
                    string newMiddleName = FullNameTextBox.Text.Split(' ').Length > 2 ? FullNameTextBox.Text.Split(' ')[1] : null;
                    string newLastName = FullNameTextBox.Text.Split(' ').Length > 1 ? FullNameTextBox.Text.Split(' ')[FullNameTextBox.Text.Split(' ').Length - 1] : string.Empty;
                    string newGender = GenderText.Text;
                    DateTime? newDateOfBirth = !string.IsNullOrEmpty(DateofBirthtext.Text) ? DateTime.Parse(DateofBirthtext.Text) : null;
                    string newPhoneNumber = PhoneNUmbertext.Text;
                    string newAddressLine = AdressTxt.Text;
                    string newTrainingCourse = TrainingpakTxt.Text;
                    string newTrainingDuration = TrainingTxt.Text;
                    decimal newPrice = string.IsNullOrEmpty(Costtxt.Text) ? 0 : decimal.Parse(Costtxt.Text);
                    string newStatus = textBox7.Text;

                    List<string> updateStatements = new List<string>();
                    List<MySqlParameter> sqlParams = new List<MySqlParameter>();

                    if (originalFirstName != newFirstName)
                    {
                        updateStatements.Add("FirstName = @FirstName");
                        sqlParams.Add(new MySqlParameter("@FirstName", newFirstName));
                    }
                    if (originalMiddleName != newMiddleName)
                    {
                        updateStatements.Add("MiddleName = @MiddleName");
                        sqlParams.Add(new MySqlParameter("@MiddleName", (object)newMiddleName ?? DBNull.Value));
                    }
                    if (originalLastName != newLastName)
                    {
                        updateStatements.Add("LastName = @LastName");
                        sqlParams.Add(new MySqlParameter("@LastName", newLastName));
                    }
                    if (originalGender != newGender)
                    {
                        updateStatements.Add("Gender = @Gender");
                        sqlParams.Add(new MySqlParameter("@Gender", newGender));
                    }
                    if (originalDateOfBirth != newDateOfBirth)
                    {
                        updateStatements.Add("DateOfBirth = @DateOfBirth");
                        sqlParams.Add(new MySqlParameter("@DateOfBirth", (object)newDateOfBirth ?? DBNull.Value));
                    }
                    if (originalPhoneNumber != newPhoneNumber)
                    {
                        updateStatements.Add("PhoneNumber = @PhoneNumber");
                        sqlParams.Add(new MySqlParameter("@PhoneNumber", newPhoneNumber));
                    }
                    if (originalAddressLine != newAddressLine)
                    {
                        updateStatements.Add("AddressLine = @AddressLine");
                        sqlParams.Add(new MySqlParameter("@AddressLine", newAddressLine));
                    }
                    if (originalTrainingCourse != newTrainingCourse)
                    {
                        updateStatements.Add("TrainingCourse = @TrainingCourse");
                        sqlParams.Add(new MySqlParameter("@TrainingCourse", newTrainingCourse));
                    }
                    if (originalTrainingDuration != newTrainingDuration)
                    {
                        updateStatements.Add("TrainingDuration = @TrainingDuration");
                        sqlParams.Add(new MySqlParameter("@TrainingDuration", newTrainingDuration));
                    }
                    if (originalPrice != newPrice)
                    {
                        updateStatements.Add("Price = @Price");
                        sqlParams.Add(new MySqlParameter("@Price", newPrice));
                    }
                    if (originalStatus != newStatus)
                    {
                        updateStatements.Add("Status = @Status");
                        sqlParams.Add(new MySqlParameter("@Status", newStatus));
                    }
                    if (updateStatements.Count > 0)
                    {
                        string updateQuery = "UPDATE STUDENTINFO SET " + string.Join(", ", updateStatements) + " WHERE StudentID = @studentId";
                        string updateAddressQuery = "UPDATE ADDRESSES SET " + string.Join(", ", updateStatements.Where(item => item.Contains("AddressLine"))) + " WHERE StudentID = @studentId";
                        string updateTrainingQuery = "UPDATE TRAINING SET " + string.Join(", ", updateStatements.Where(item => item.Contains("TrainingCourse") || item.Contains("TrainingDuration") || item.Contains("Price"))) + " WHERE StudentID = @studentId";
                        sqlParams.Add(new MySqlParameter("@studentId", studentId));
                        if (updateStatements.Any(item => item.Contains("AddressLine")))
                        {
                            using (MySqlCommand updateAddressCommand = new MySqlCommand(updateAddressQuery, connection))
                            {
                                updateAddressCommand.Parameters.AddRange(sqlParams.ToArray());
                                await updateAddressCommand.ExecuteNonQueryAsync();
                            }
                        }
                        if (updateStatements.Any(item => item.Contains("TrainingCourse") || item.Contains("TrainingDuration") || item.Contains("Price")))
                        {
                            using (MySqlCommand updateTrainingCommand = new MySqlCommand(updateTrainingQuery, connection))
                            {
                                updateTrainingCommand.Parameters.AddRange(sqlParams.ToArray());
                                await updateTrainingCommand.ExecuteNonQueryAsync();
                            }
                        }


                        using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                        {
                            updateCommand.Parameters.AddRange(sqlParams.ToArray());
                            int rowsAffected = await updateCommand.ExecuteNonQueryAsync();

                            if (rowsAffected > 0)
                            {
                                MessageBox.Show("Student details have been updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                string query = " SELECT StudentID, CONCAT(FirstName, ' ', MiddleName) AS FullName, Gender, PhoneNumber, OptionalPhoneNumber, Nationality, EnrolledDate, StartDate, Status FROM STUDENTINFO";

                                LoadData(DashboardGrid, query);
                            }
                            else
                            {
                                MessageBox.Show("No student found with the provided ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("No changes detected for student details.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void AddPayment_MouseClick(object sender, MouseEventArgs e)
        {

            string query = "SELECT PaymentLeft \r\nFROM PAYMENT \r\nWHERE STUDENTID = @STUDENTID\r\nORDER BY PaymentDate DESC;";

            string studentId = SearchTextBox.Text;

            double paymentStatus = 0;

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@STUDENTID", studentId);

                    var result = command.ExecuteScalar();


                    if (result != DBNull.Value && result != null)
                    {
                        paymentStatus = double.Parse(result.ToString());
                    }
                }
            }

            if (paymentStatus > 0)
            {
                if (string.IsNullOrWhiteSpace(SearchTextBox.Text))
                {
                    MessageBox.Show("Please search for a student to add payment.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (string.IsNullOrWhiteSpace(currentStudentId))
                {
                    MessageBox.Show("No Student has been selected from the search please select one.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (MySqlConnection connections = new MySqlConnection(connectionString))
                    {
                        connections.Open();
                        string studentQuery = "SELECT CONCAT(s.FirstName, ' ', s.LastName) AS FullName ,p.paymentLeft , p.AccountInfo FROM STUDENTINFO s LEFT JOIN PAYMENT p ON s.StudentID = p.StudentID WHERE s.StudentID = @studentId";
                        using (MySqlCommand studentCommand = new MySqlCommand(studentQuery, connections))
                        {
                            studentCommand.Parameters.AddWithValue("@studentId", currentStudentId);
                            using (MySqlDataReader reader = studentCommand.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    string studentName = reader["FullName"].ToString();
                                    string paymentLeft = reader["paymentLeft"].ToString();
                                    string accountinfo = reader["AccountInfo"].ToString();
                                    AddPayment addPayment = new AddPayment(studentName, paymentLeft, currentStudentId, accountinfo);
                                    addPayment.Show();
                                }
                                else
                                {
                                    MessageBox.Show("No student data found for this ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }

                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show($"Payment has already been completed");
            }
        }



        private void UpdateStudentStatus(string studentId, string status, MySqlConnection connection)
        {
            string updateStatusQuery = "UPDATE STUDENTINFO SET Status = @status WHERE StudentID = @studentId";
            using (MySqlCommand updateStatusCommand = new MySqlCommand(updateStatusQuery, connection))
            {
                updateStatusCommand.Parameters.AddWithValue("@status", status);
                updateStatusCommand.Parameters.AddWithValue("@studentId", studentId);
                updateStatusCommand.ExecuteNonQuery();
            }
        }

        private void Enrollessbtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.PlaceholderText = "Search by ID";
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            SearchTextBox.PlaceholderText = "Search by ID or Name";

            string proc = "USP_UPDATE_STUDENT_STATUS";

            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    using (MySqlCommand command = new MySqlCommand(proc, connection))
                    {
                        command.CommandType = System.Data.CommandType.StoredProcedure;
                        command.ExecuteNonQuery();

                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void TitlePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void AddStudentBtn_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBtn.Text = "Search";
            SearchTextBox.Visible = true;
            Coursecombo.Visible = false;
            YearCombo.Visible = false;
            AddEnrollee addEnrollee = new AddEnrollee();
            addEnrollee.Show();
        }


        private void StudentDetailPanel_Paint(object sender, PaintEventArgs e)
        {
            //This is intentionally left blank, if you require any logic you can add it here
        }

        private void StudentDetailPanel_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Studentreportbtn_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBtn.Text = "Filter";
            SearchTextBox.Visible = false;
            Coursecombo.Visible = true;
            YearCombo.Visible = true;
            SideBarPanel.Width = 0;

          
            if (YearCombo.Items.Count == 0 || YearCombo.Items[0].ToString() != "All")
            {
                YearCombo.Items.Clear();
                YearCombo.Items.Add("All");
            }
            YearCombo.SelectedIndex = 0;

            ShowPanel(studentreportpanel);


            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    using (MySqlCommand command = new MySqlCommand("GetUniqueDates", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            // Use a HashSet to track added dates
                            HashSet<string> addedDates = new HashSet<string>();

                            // Clear existing dates before adding new dates, except the "All" at index 0.
                            for (int i = YearCombo.Items.Count - 1; i > 0; i--)
                            {
                                YearCombo.Items.RemoveAt(i);
                            }

                            while (reader.Read())
                            {
                                if (reader["StartDate"] != DBNull.Value)
                                {
                                    DateTime startDate = Convert.ToDateTime(reader["StartDate"]);
                                    string dateString = startDate.ToString("yyyy-MM-dd");
                                    if (addedDates.Add(dateString))
                                    {
                                        YearCombo.Items.Add(dateString);
                                    }

                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database Error:\nError Code: {ex.Number}\nMessage: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DashboardGrid_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Ensure a valid row is clicked
            {
                DataGridViewRow row = DashboardGrid.Rows[e.RowIndex];
                string cellValue = row.Cells[0].Value?.ToString(); // Assuming the first column contains the StudentID

                if (!string.IsNullOrEmpty(cellValue))
                {
                    using (MySqlConnection connection = new MySqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "SELECT * FROM STUDENTINFO WHERE StudentID = @StudentID";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@StudentID", cellValue);

                            using (MySqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    // Example: Fetching student information from the database
                                    string id = reader["StudentID"].ToString();
                                    string firstName = reader["FirstName"].ToString();
                                    string lastName = reader["LastName"].ToString();
                                    string phoneNumber = reader["PhoneNumber"].ToString();
                                    string status = reader["Status"].ToString();

                                    ShowPanel(StudentDetailPanel);
                                    SearchTextBox.Text = id;
                                    PerformStudentDetailSearch(id);
                                }
                                else
                                {
                                    MessageBox.Show("No data found for the selected Student ID.");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Cell value is empty or null.");
                }
            }
        }

        private void AddDateBTn_MouseClick(object sender, MouseEventArgs e)
        {
            AddDates addDates = new AddDates();
            addDates.Show();
        }

        private void SearchTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true; // Suppress the beep sound

                string searchTerm = SearchTextBox.Text.Trim();
                if (studentreportpanel.Visible)
                {
                    PerformStudentReportSearch();
                }
                else if (string.IsNullOrWhiteSpace(searchTerm) && !StudentDetailPanel.Visible)
                {
                    LoadDashboardData(null);
                    ClearTextBoxes();
                    EnteraName.Visible = false;
                }
                else if (string.IsNullOrWhiteSpace(searchTerm) && StudentDetailPanel.Visible)
                {
                    HandleEmptySearchTerm();
                }
                else if (StudentDetailPanel.Visible)
                {
                    PerformStudentDetailSearch(searchTerm);
                    EnteraName.Visible = false;
                }
            
                else if (string.IsNullOrWhiteSpace(searchTerm) && !StudentDetailPanel.Visible && PaymentReportPanel.Visible)
                {
                    PaymentReport(null);
                    ClearTextBoxes();
                    EnteraName.Visible = false;
                }
                else if (PaymentReportPanel.Visible)
                {
                    PaymentReport(searchTerm);
                }
                else
                {
                    PerformGeneralSearch(searchTerm);
                    EnteraName.Visible = false;
                }
            }
        }
    }
}
