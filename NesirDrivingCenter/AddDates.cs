using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace NesirDrivingCenter
{
    public partial class AddDates : Form
    {
        private string _connectionString = "";

        public AddDates()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            LoadUnassignedStudents();
            comboBoxStudents.MouseWheel += ComboBoxStudents_MouseWheel;
        }

        private void InitializeDeleteButtonColumn()
        {
            if (!AddedStudentData.Columns.Contains("DeleteButton") && AddedStudentData.Rows.Count > 0)
            {

                DataGridViewButtonColumn deleteButtonColumn = new DataGridViewButtonColumn
                {
                    Name = "DeleteButton",
                    HeaderText = "Delete",
                    Text = "Delete",
                    UseColumnTextForButtonValue = true,
                    Width = 60
                };
                AddedStudentData.Columns.Add(deleteButtonColumn);
                AddedStudentData.CellContentClick += AddedStudentData_CellContentClick;
            }
        }

        private void RemoveDeleteButtonColumn()
        {
            if (AddedStudentData.Columns.Contains("DeleteButton"))
            {
                AddedStudentData.Columns.Remove("DeleteButton");
            }
        }

        private void AddedStudentData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.ColumnIndex == AddedStudentData.Columns["DeleteButton"].Index && e.RowIndex >= 0)
            {
       
                var confirmResult = MessageBox.Show("Are you sure you want to delete this row?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirmResult == DialogResult.Yes)
                {
                    if (AddedStudentData.DataSource is DataTable dataTable)
                    {
                        DataRow dataRowToDelete = dataTable.Rows[e.RowIndex];
                        dataRowToDelete.Delete();
                        dataTable.AcceptChanges(); 
                        AddedStudentData.DataSource = dataTable;  
                        UpdateDeleteButtonVisibility();
                    }
                }
            }
        }
        private void UpdateDeleteButtonVisibility()
        {
            if (AddedStudentData.Rows.Count <= 0)
            {
                RemoveDeleteButtonColumn();
            }
            else
            {
                InitializeDeleteButtonColumn();
            }
        }

        private void Addbtn_MouseClick(object sender, MouseEventArgs e)
        {
            if (comboBoxStudents.SelectedItem == null) return;

            string selectedStudentName = comboBoxStudents.SelectedItem.ToString();
            if (IsStudentAlreadyAdded(selectedStudentName))
            {
                MessageBox.Show("This student has already been added.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Updated SQL Query to join the tables
            string query = $"SELECT SI.StudentID, CONCAT(SI.FirstName, ' ', SI.LastName) AS FullName, SI.Gender, SI.DateOfBirth, SI.PhoneNumber, SI.EnrolledDate, SI.Status, " +
                           $"T.TrainingCourse, T.TrainingDuration, T.Price " +
                           $"FROM STUDENTINFO SI " +
                           $"JOIN TRAINING T ON SI.StudentID = T.StudentID " +
                           $"WHERE CONCAT(SI.FirstName, ' ', SI.LastName) = '{selectedStudentName}'";

            AppendData(AddedStudentData, query, startData.Value);
            UpdateDeleteButtonVisibility();

        }
        private bool IsStudentAlreadyAdded(string studentName)
        {
            if (AddedStudentData.DataSource is DataTable dataTable)
            {
                foreach (DataRow row in dataTable.Rows)
                {
                    if (row["FullName"] != null && row["FullName"].ToString() == studentName)
                    {
                        return true;
                    }
                }
            }
            return false; // If data source is null or student is not in table.
        }

        private void AppendData(DataGridView dataGridView, string query, DateTime startDate)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                     
                        if (dataGridView.DataSource == null)
                        {
                            dataGridView.DataSource = dataTable; 
                        }
                        else
                        {
                            DataTable existingTable = (DataTable)dataGridView.DataSource; 
                            foreach (DataRow row in dataTable.Rows)
                            {
                                existingTable.ImportRow(row);
                            }
                            dataGridView.DataSource = existingTable;
                        }
                    }
                }
                SetDataGridViewStyle(dataGridView); 
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView.RowHeadersVisible = false; // Remove default row header
        }

        private void LoadUnassignedStudents()
        {
            comboBoxStudents.Items.Clear(); // Clear previous items
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand("USP_GETUNASSIGNEDSTUDENTS", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure;
                        command.Parameters.AddWithValue("showAssigned", 1); 
                        using (var reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string fullName = reader["FullName"].ToString();
                                comboBoxStudents.Items.Add(fullName); 
                            }

                            if (comboBoxStudents.Items.Count > 0)
                            {
                                comboBoxStudents.SelectedIndex = 0; 
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Database error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading students: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ComboBoxStudents_MouseWheel(object sender, MouseEventArgs e)
        {
            if (comboBoxStudents.Items.Count == 0) return; // If no items in combo box, do nothing


            int newIndex = comboBoxStudents.SelectedIndex - (e.Delta > 0 ? 1 : -1);


            if (newIndex < 0)
            {
                newIndex = comboBoxStudents.Items.Count - 1; // Scroll to last item from top
            }
            else if (newIndex >= comboBoxStudents.Items.Count)
            {
                newIndex = 0; // Scroll to the top from last
            }
            comboBoxStudents.SelectedIndex = newIndex;
        }

        private void Canceldatebtn_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Cancel", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (AddedStudentData.DataSource is DataTable dataTable)
                {
                    dataTable.Rows.Clear();
                    AddedStudentData.DataSource = null;
                    UpdateDeleteButtonVisibility();
                }
            }

        }
        private void saveDatebtn_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to Save", "Save", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                if (AddedStudentData.DataSource is DataTable dataTable)
                {
                    List<(string studentId, DateTime startDate)> studentUpdates = new List<(string, DateTime)>(); 
                    foreach (DataRow row in dataTable.Rows)
                    {
                        if (row["StudentID"] != null)
                        {
                            string studentId = row["StudentID"].ToString();
                            DateTime startDate = startData.Value;

                            studentUpdates.Add((studentId, startDate)); 
                        }
                    }
                    if (studentUpdates.Count > 0)
                    {
                        UpdateStartDates(studentUpdates); 
                        dataTable.Rows.Clear(); 
                        AddedStudentData.DataSource = dataTable; 
                        UpdateDeleteButtonVisibility(); 
                        MessageBox.Show($"Successfully updated start date for {studentUpdates.Count} students", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUnassignedStudents();
                    }
                }
            }
        }
        private void UpdateStartDates(List<(string studentId, DateTime startDate)> studentUpdates)
        {
            try
            {
                using (var connection = new MySqlConnection(_connectionString))
                {
                    connection.Open();
                    using (var command = new MySqlCommand("USP_UPDATEDATE", connection))
                    {
                        command.CommandType = CommandType.StoredProcedure; //Specify stored procedure

                        //Loop through the list and call it once for each record
                        foreach (var update in studentUpdates)
                        {
                            command.Parameters.Clear(); //clear parameters, so we dont send data from previous record
                            command.Parameters.AddWithValue("STUDENT_ID", update.studentId);
                            command.Parameters.AddWithValue("UPDATEDATE", update.startDate);
                            command.ExecuteNonQuery();

                        }
                    }

                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show($"Error while updating start date: {ex.Message}", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error while updating start date: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}