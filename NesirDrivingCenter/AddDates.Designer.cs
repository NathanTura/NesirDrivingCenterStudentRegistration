namespace NesirDrivingCenter
{
    partial class AddDates
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
            panel2 = new Panel();
            Canceldatebtn = new Button();
            saveDatebtn = new Button();
            cancelbtn = new Button();
            savebtn = new Button();
            panel1 = new Panel();
            Prefbtn = new Button();
            Nextbrn = new Button();
            TitleLabel = new Label();
            FirstPanel = new Panel();
            Addbtn = new Button();
            startData = new DateTimePicker();
            AddedStudentData = new DataGridView();
            comboBoxStudents = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            FirstPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AddedStudentData).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(Canceldatebtn);
            panel2.Controls.Add(saveDatebtn);
            panel2.Controls.Add(cancelbtn);
            panel2.Controls.Add(savebtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 422);
            panel2.Name = "panel2";
            panel2.Size = new Size(843, 55);
            panel2.TabIndex = 4;
            // 
            // Canceldatebtn
            // 
            Canceldatebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Canceldatebtn.BackColor = Color.FromArgb(64, 64, 64);
            Canceldatebtn.FlatAppearance.BorderSize = 0;
            Canceldatebtn.FlatStyle = FlatStyle.Flat;
            Canceldatebtn.Font = new Font("Segoe UI", 10F);
            Canceldatebtn.ForeColor = Color.White;
            Canceldatebtn.Location = new Point(611, 12);
            Canceldatebtn.Name = "Canceldatebtn";
            Canceldatebtn.Size = new Size(100, 31);
            Canceldatebtn.TabIndex = 7;
            Canceldatebtn.Text = "Cancel";
            Canceldatebtn.UseVisualStyleBackColor = false;
            Canceldatebtn.MouseClick += Canceldatebtn_MouseClick;
            // 
            // saveDatebtn
            // 
            saveDatebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            saveDatebtn.BackColor = Color.FromArgb(0, 192, 192);
            saveDatebtn.FlatAppearance.BorderSize = 0;
            saveDatebtn.FlatStyle = FlatStyle.Flat;
            saveDatebtn.Font = new Font("Segoe UI", 10F);
            saveDatebtn.ForeColor = Color.White;
            saveDatebtn.Location = new Point(731, 12);
            saveDatebtn.Name = "saveDatebtn";
            saveDatebtn.Size = new Size(100, 31);
            saveDatebtn.TabIndex = 6;
            saveDatebtn.Text = "Save";
            saveDatebtn.UseVisualStyleBackColor = false;
            saveDatebtn.MouseClick += saveDatebtn_MouseClick;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelbtn.BackColor = Color.FromArgb(64, 64, 64);
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 10F);
            cancelbtn.ForeColor = Color.White;
            cancelbtn.Location = new Point(1208, -33);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(100, 31);
            cancelbtn.TabIndex = 5;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savebtn.BackColor = Color.FromArgb(0, 192, 192);
            savebtn.FlatAppearance.BorderSize = 0;
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Segoe UI", 10F);
            savebtn.ForeColor = Color.White;
            savebtn.Location = new Point(1331, -33);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(100, 31);
            savebtn.TabIndex = 4;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(Prefbtn);
            panel1.Controls.Add(Nextbrn);
            panel1.Controls.Add(TitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(843, 64);
            panel1.TabIndex = 3;
            // 
            // Prefbtn
            // 
            Prefbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Prefbtn.BackColor = Color.FromArgb(52, 73, 94);
            Prefbtn.FlatAppearance.BorderSize = 0;
            Prefbtn.FlatStyle = FlatStyle.Flat;
            Prefbtn.Font = new Font("Segoe UI", 10F);
            Prefbtn.ForeColor = Color.White;
            Prefbtn.Location = new Point(1236, -21);
            Prefbtn.Name = "Prefbtn";
            Prefbtn.Size = new Size(100, 31);
            Prefbtn.TabIndex = 4;
            Prefbtn.Text = "previous";
            Prefbtn.UseVisualStyleBackColor = false;
            // 
            // Nextbrn
            // 
            Nextbrn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Nextbrn.BackColor = Color.FromArgb(52, 73, 94);
            Nextbrn.FlatAppearance.BorderSize = 0;
            Nextbrn.FlatStyle = FlatStyle.Flat;
            Nextbrn.Font = new Font("Segoe UI", 10F);
            Nextbrn.ForeColor = Color.White;
            Nextbrn.Location = new Point(1331, -21);
            Nextbrn.Name = "Nextbrn";
            Nextbrn.Size = new Size(100, 31);
            Nextbrn.TabIndex = 3;
            Nextbrn.Text = "Next";
            Nextbrn.UseVisualStyleBackColor = false;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(150, 37);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Add Dates";
            // 
            // FirstPanel
            // 
            FirstPanel.Controls.Add(Addbtn);
            FirstPanel.Controls.Add(startData);
            FirstPanel.Controls.Add(AddedStudentData);
            FirstPanel.Controls.Add(comboBoxStudents);
            FirstPanel.Controls.Add(label2);
            FirstPanel.Controls.Add(label1);
            FirstPanel.Dock = DockStyle.Fill;
            FirstPanel.Location = new Point(0, 64);
            FirstPanel.Name = "FirstPanel";
            FirstPanel.Size = new Size(843, 358);
            FirstPanel.TabIndex = 5;
            // 
            // Addbtn
            // 
            Addbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Addbtn.BackColor = Color.FromArgb(0, 192, 192);
            Addbtn.FlatAppearance.BorderSize = 0;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 9F);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(373, 44);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(100, 23);
            Addbtn.TabIndex = 18;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.MouseClick += Addbtn_MouseClick;
            // 
            // startData
            // 
            startData.Location = new Point(158, 5);
            startData.Name = "startData";
            startData.Size = new Size(209, 23);
            startData.TabIndex = 17;
            // 
            // AddedStudentData
            // 
            AddedStudentData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AddedStudentData.Location = new Point(3, 73);
            AddedStudentData.Name = "AddedStudentData";
            AddedStudentData.Size = new Size(837, 279);
            AddedStudentData.TabIndex = 9;
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.DropDownHeight = 110;
            comboBoxStudents.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.IntegralHeight = false;
            comboBoxStudents.ItemHeight = 15;
            comboBoxStudents.Location = new Point(158, 44);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(209, 23);
            comboBoxStudents.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(3, 42);
            label2.Name = "label2";
            label2.Size = new Size(118, 25);
            label2.TabIndex = 7;
            label2.Text = "Add Enrolles";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(149, 25);
            label1.TabIndex = 6;
            label1.Text = "Select Start Date";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // AddDates
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(843, 477);
            Controls.Add(FirstPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddDates";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddDates";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            FirstPanel.ResumeLayout(false);
            FirstPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AddedStudentData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button cancelbtn;
        private Button savebtn;
        private Panel panel1;
        private Button Prefbtn;
        private Button Nextbrn;
        private Label TitleLabel;
        private Panel FirstPanel;
        private DataGridView AddedStudentData;
        private ComboBox comboBoxStudents;
        private Label label2;
        private Label label1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private Button Canceldatebtn;
        private Button saveDatebtn;
        private DateTimePicker startData;
        private Button Addbtn;
    }
}