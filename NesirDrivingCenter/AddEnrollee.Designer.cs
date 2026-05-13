using System.Security.Policy;

namespace NesirDrivingCenter
{
    partial class AddEnrollee
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
            panel1 = new Panel();
            Prefbtn = new Button();
            Nextbrn = new Button();
            TitleLabel = new Label();
            panel2 = new Panel();
            cancelbtn = new Button();
            savebtn = new Button();
            FirstPanel = new Panel();
            OptionalPhoneTxt = new TextBox();
            label8 = new Label();
            StartDate = new DateTimePicker();
            label7 = new Label();
            TrainingComboBox = new ComboBox();
            Training = new Label();
            Nationalitytxt = new TextBox();
            label6 = new Label();
            Phonenumtxt = new TextBox();
            label5 = new Label();
            Dob = new DateTimePicker();
            Femaleradio = new RadioButton();
            Maleradio = new RadioButton();
            label4 = new Label();
            label3 = new Label();
            LastNametxt = new TextBox();
            label2 = new Label();
            MiddleNametxt = new TextBox();
            label1 = new Label();
            Firstnametxt = new TextBox();
            Firstnamelbl = new Label();
            SecondPanel = new Panel();
            Educationlevel = new TextBox();
            label16 = new Label();
            paidamounttxt = new TextBox();
            label15 = new Label();
            Accountinfotxt = new TextBox();
            label14 = new Label();
            PaymentMethodComboBox = new ComboBox();
            label13 = new Label();
            ZipCodetxt = new TextBox();
            label12 = new Label();
            Statetxt = new TextBox();
            label11 = new Label();
            Citytxt = new TextBox();
            label10 = new Label();
            AddressTxt = new TextBox();
            label9 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            FirstPanel.SuspendLayout();
            SecondPanel.SuspendLayout();
            SuspendLayout();
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
            panel1.Size = new Size(800, 64);
            panel1.TabIndex = 0;
            // 
            // Prefbtn
            // 
            Prefbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Prefbtn.BackColor = Color.FromArgb(52, 73, 94);
            Prefbtn.FlatAppearance.BorderSize = 0;
            Prefbtn.FlatStyle = FlatStyle.Flat;
            Prefbtn.Font = new Font("Segoe UI", 10F);
            Prefbtn.ForeColor = Color.White;
            Prefbtn.Location = new Point(593, 15);
            Prefbtn.Name = "Prefbtn";
            Prefbtn.Size = new Size(100, 31);
            Prefbtn.TabIndex = 4;
            Prefbtn.Text = "previous";
            Prefbtn.UseVisualStyleBackColor = false;
            Prefbtn.MouseClick += Prefbtn_MouseClick;
            // 
            // Nextbrn
            // 
            Nextbrn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Nextbrn.BackColor = Color.FromArgb(52, 73, 94);
            Nextbrn.FlatAppearance.BorderSize = 0;
            Nextbrn.FlatStyle = FlatStyle.Flat;
            Nextbrn.Font = new Font("Segoe UI", 10F);
            Nextbrn.ForeColor = Color.White;
            Nextbrn.Location = new Point(688, 15);
            Nextbrn.Name = "Nextbrn";
            Nextbrn.Size = new Size(100, 31);
            Nextbrn.TabIndex = 3;
            Nextbrn.Text = "Next";
            Nextbrn.UseVisualStyleBackColor = false;
            Nextbrn.MouseClick += Nextbrn_MouseClick;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(181, 37);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Add Enrollee";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(cancelbtn);
            panel2.Controls.Add(savebtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 395);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 55);
            panel2.TabIndex = 1;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelbtn.BackColor = Color.FromArgb(64, 64, 64);
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 10F);
            cancelbtn.ForeColor = Color.White;
            cancelbtn.Location = new Point(565, 12);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(100, 31);
            cancelbtn.TabIndex = 5;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.MouseClick += cancelbtn_MouseClick;
            // 
            // savebtn
            // 
            savebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            savebtn.BackColor = Color.FromArgb(0, 192, 192);
            savebtn.FlatAppearance.BorderSize = 0;
            savebtn.FlatStyle = FlatStyle.Flat;
            savebtn.Font = new Font("Segoe UI", 10F);
            savebtn.ForeColor = Color.White;
            savebtn.Location = new Point(688, 12);
            savebtn.Name = "savebtn";
            savebtn.Size = new Size(100, 31);
            savebtn.TabIndex = 4;
            savebtn.Text = "Save";
            savebtn.UseVisualStyleBackColor = false;
            savebtn.MouseClick += savebtn_MouseClick;
            // 
            // FirstPanel
            // 
            FirstPanel.Controls.Add(OptionalPhoneTxt);
            FirstPanel.Controls.Add(label8);
            FirstPanel.Controls.Add(StartDate);
            FirstPanel.Controls.Add(label7);
            FirstPanel.Controls.Add(TrainingComboBox);
            FirstPanel.Controls.Add(Training);
            FirstPanel.Controls.Add(Nationalitytxt);
            FirstPanel.Controls.Add(label6);
            FirstPanel.Controls.Add(Phonenumtxt);
            FirstPanel.Controls.Add(label5);
            FirstPanel.Controls.Add(Dob);
            FirstPanel.Controls.Add(Femaleradio);
            FirstPanel.Controls.Add(Maleradio);
            FirstPanel.Controls.Add(label4);
            FirstPanel.Controls.Add(label3);
            FirstPanel.Controls.Add(LastNametxt);
            FirstPanel.Controls.Add(label2);
            FirstPanel.Controls.Add(MiddleNametxt);
            FirstPanel.Controls.Add(label1);
            FirstPanel.Controls.Add(Firstnametxt);
            FirstPanel.Controls.Add(Firstnamelbl);
            FirstPanel.Dock = DockStyle.Fill;
            FirstPanel.Location = new Point(0, 64);
            FirstPanel.Name = "FirstPanel";
            FirstPanel.Size = new Size(800, 331);
            FirstPanel.TabIndex = 2;
            // 
            // OptionalPhoneTxt
            // 
            OptionalPhoneTxt.BorderStyle = BorderStyle.None;
            OptionalPhoneTxt.Font = new Font("Segoe UI", 12F);
            OptionalPhoneTxt.Location = new Point(493, 87);
            OptionalPhoneTxt.Name = "OptionalPhoneTxt";
            OptionalPhoneTxt.Size = new Size(200, 22);
            OptionalPhoneTxt.TabIndex = 26;
            OptionalPhoneTxt.KeyPress += OptionalPhoneTxt_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.Location = new Point(372, 87);
            label8.Name = "label8";
            label8.Size = new Size(115, 19);
            label8.TabIndex = 25;
            label8.Text = "Second PNumber";
            // 
            // StartDate
            // 
            StartDate.Location = new Point(484, 244);
            StartDate.Name = "StartDate";
            StartDate.Size = new Size(210, 23);
            StartDate.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.Location = new Point(386, 244);
            label7.Name = "label7";
            label7.Size = new Size(71, 19);
            label7.TabIndex = 23;
            label7.Text = "Start Date";
            // 
            // TrainingComboBox
            // 
            TrainingComboBox.FormattingEnabled = true;
            TrainingComboBox.Items.AddRange(new object[] { "Auto-Mobile", "Cargo 1", "Public 1" });
            TrainingComboBox.Location = new Point(484, 191);
            TrainingComboBox.Name = "TrainingComboBox";
            TrainingComboBox.Size = new Size(210, 23);
            TrainingComboBox.TabIndex = 22;
            // 
            // Training
            // 
            Training.AutoSize = true;
            Training.Font = new Font("Segoe UI", 10F);
            Training.Location = new Point(386, 188);
            Training.Name = "Training";
            Training.Size = new Size(57, 19);
            Training.TabIndex = 21;
            Training.Text = "Training";
            // 
            // Nationalitytxt
            // 
            Nationalitytxt.BorderStyle = BorderStyle.None;
            Nationalitytxt.Font = new Font("Segoe UI", 12F);
            Nationalitytxt.Location = new Point(494, 139);
            Nationalitytxt.Name = "Nationalitytxt";
            Nationalitytxt.Size = new Size(200, 22);
            Nationalitytxt.TabIndex = 20;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(386, 137);
            label6.Name = "label6";
            label6.Size = new Size(75, 19);
            label6.TabIndex = 19;
            label6.Text = "Nationality";
            // 
            // Phonenumtxt
            // 
            Phonenumtxt.BorderStyle = BorderStyle.None;
            Phonenumtxt.Font = new Font("Segoe UI", 12F);
            Phonenumtxt.Location = new Point(493, 40);
            Phonenumtxt.Name = "Phonenumtxt";
            Phonenumtxt.Size = new Size(200, 22);
            Phonenumtxt.TabIndex = 18;
            Phonenumtxt.KeyPress += Phonenumtxt_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(385, 38);
            label5.Name = "label5";
            label5.Size = new Size(102, 19);
            label5.TabIndex = 17;
            label5.Text = "Phone Number";
            // 
            // Dob
            // 
            Dob.Location = new Point(109, 247);
            Dob.Name = "Dob";
            Dob.Size = new Size(209, 23);
            Dob.TabIndex = 16;
            // 
            // Femaleradio
            // 
            Femaleradio.AutoSize = true;
            Femaleradio.Location = new Point(166, 193);
            Femaleradio.Name = "Femaleradio";
            Femaleradio.Size = new Size(63, 19);
            Femaleradio.TabIndex = 15;
            Femaleradio.TabStop = true;
            Femaleradio.Text = "Female";
            Femaleradio.UseVisualStyleBackColor = true;
            // 
            // Maleradio
            // 
            Maleradio.AutoSize = true;
            Maleradio.Location = new Point(109, 193);
            Maleradio.Name = "Maleradio";
            Maleradio.Size = new Size(51, 19);
            Maleradio.TabIndex = 14;
            Maleradio.TabStop = true;
            Maleradio.Text = "Male";
            Maleradio.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(11, 247);
            label4.Name = "label4";
            label4.Size = new Size(87, 19);
            label4.TabIndex = 12;
            label4.Text = "Date of birth";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(54, 19);
            label3.TabIndex = 10;
            label3.Text = "Gender";
            // 
            // LastNametxt
            // 
            LastNametxt.BorderStyle = BorderStyle.None;
            LastNametxt.Font = new Font("Segoe UI", 12F);
            LastNametxt.Location = new Point(109, 140);
            LastNametxt.Name = "LastNametxt";
            LastNametxt.Size = new Size(209, 22);
            LastNametxt.TabIndex = 9;
            LastNametxt.KeyPress += LastNametxt_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(12, 137);
            label2.Name = "label2";
            label2.Size = new Size(74, 19);
            label2.TabIndex = 8;
            label2.Text = "Last Name";
            // 
            // MiddleNametxt
            // 
            MiddleNametxt.BorderStyle = BorderStyle.None;
            MiddleNametxt.Font = new Font("Segoe UI", 12F);
            MiddleNametxt.Location = new Point(109, 89);
            MiddleNametxt.Name = "MiddleNametxt";
            MiddleNametxt.Size = new Size(209, 22);
            MiddleNametxt.TabIndex = 7;
            MiddleNametxt.KeyPress += MiddleNametxt_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(91, 19);
            label1.TabIndex = 6;
            label1.Text = "Middle Name";
            // 
            // Firstnametxt
            // 
            Firstnametxt.BorderStyle = BorderStyle.None;
            Firstnametxt.Font = new Font("Segoe UI", 12F);
            Firstnametxt.Location = new Point(109, 41);
            Firstnametxt.Name = "Firstnametxt";
            Firstnametxt.Size = new Size(209, 22);
            Firstnametxt.TabIndex = 5;
            Firstnametxt.KeyPress += Firstnametxt_KeyPress;
            // 
            // Firstnamelbl
            // 
            Firstnamelbl.AutoSize = true;
            Firstnamelbl.Font = new Font("Segoe UI", 10F);
            Firstnamelbl.Location = new Point(12, 39);
            Firstnamelbl.Name = "Firstnamelbl";
            Firstnamelbl.Size = new Size(75, 19);
            Firstnamelbl.TabIndex = 4;
            Firstnamelbl.Text = "First Name";
            // 
            // SecondPanel
            // 
            SecondPanel.Controls.Add(Educationlevel);
            SecondPanel.Controls.Add(label16);
            SecondPanel.Controls.Add(paidamounttxt);
            SecondPanel.Controls.Add(label15);
            SecondPanel.Controls.Add(Accountinfotxt);
            SecondPanel.Controls.Add(label14);
            SecondPanel.Controls.Add(PaymentMethodComboBox);
            SecondPanel.Controls.Add(label13);
            SecondPanel.Controls.Add(ZipCodetxt);
            SecondPanel.Controls.Add(label12);
            SecondPanel.Controls.Add(Statetxt);
            SecondPanel.Controls.Add(label11);
            SecondPanel.Controls.Add(Citytxt);
            SecondPanel.Controls.Add(label10);
            SecondPanel.Controls.Add(AddressTxt);
            SecondPanel.Controls.Add(label9);
            SecondPanel.Dock = DockStyle.Fill;
            SecondPanel.Location = new Point(0, 64);
            SecondPanel.Name = "SecondPanel";
            SecondPanel.Size = new Size(800, 331);
            SecondPanel.TabIndex = 27;
            // 
            // Educationlevel
            // 
            Educationlevel.BorderStyle = BorderStyle.None;
            Educationlevel.Font = new Font("Segoe UI", 12F);
            Educationlevel.Location = new Point(521, 40);
            Educationlevel.Name = "Educationlevel";
            Educationlevel.Size = new Size(172, 22);
            Educationlevel.TabIndex = 37;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Segoe UI", 10F);
            label16.Location = new Point(386, 37);
            label16.Name = "label16";
            label16.Size = new Size(104, 19);
            label16.TabIndex = 36;
            label16.Text = "Education Level";
            // 
            // paidamounttxt
            // 
            paidamounttxt.BorderStyle = BorderStyle.None;

            paidamounttxt.Font = new Font("Segoe UI", 12F);
            paidamounttxt.Location = new Point(521, 190);
            paidamounttxt.Name = "paidamounttxt";
            paidamounttxt.Size = new Size(172, 22);
            paidamounttxt.TabIndex = 35;
            paidamounttxt.KeyPress += paidamounttxt_KeyPress;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 10F);
            label15.Location = new Point(386, 187);
            label15.Name = "label15";
            label15.Size = new Size(129, 19);
            label15.TabIndex = 34;
            label15.Text = "Payment Ammount";
            // 
            // Accountinfotxt
            // 
            Accountinfotxt.BorderStyle = BorderStyle.None;
            Accountinfotxt.Font = new Font("Segoe UI", 12F);
            Accountinfotxt.Location = new Point(521, 142);
            Accountinfotxt.Name = "Accountinfotxt";
            Accountinfotxt.Size = new Size(172, 22);
            Accountinfotxt.TabIndex = 33;
            Accountinfotxt.KeyPress += Accountinfotxt_KeyPress;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 10F);
            label14.Location = new Point(386, 139);
            label14.Name = "label14";
            label14.Size = new Size(86, 19);
            label14.TabIndex = 32;
            label14.Text = "Account info";
            // 
            // PaymentMethodComboBox
            // 
            PaymentMethodComboBox.FormattingEnabled = true;
            PaymentMethodComboBox.Items.AddRange(new object[] { "Bank", "Card","Online" , "Cash", });
            PaymentMethodComboBox.Location = new Point(516, 86);
            PaymentMethodComboBox.SelectedIndex = 0;
            PaymentMethodComboBox.Name = "PaymentMethodComboBox";
            PaymentMethodComboBox.Size = new Size(177, 23);
            PaymentMethodComboBox.TabIndex = 31;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 10F);
            label13.Location = new Point(385, 87);
            label13.Name = "label13";
            label13.Size = new Size(116, 19);
            label13.TabIndex = 30;
            label13.Text = "Payment Method";
            // 
            // ZipCodetxt
            // 
            ZipCodetxt.BorderStyle = BorderStyle.None;
            ZipCodetxt.Font = new Font("Segoe UI", 12F);
            ZipCodetxt.Location = new Point(93, 197);
            ZipCodetxt.Name = "ZipCodetxt";
            ZipCodetxt.Size = new Size(172, 22);
            ZipCodetxt.TabIndex = 29;
            ZipCodetxt.KeyPress += ZipCodetxt_KeyPress;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 10F);
            label12.Location = new Point(12, 193);
            label12.Name = "label12";
            label12.Size = new Size(64, 19);
            label12.TabIndex = 28;
            label12.Text = "Zip Code";
            // 
            // Statetxt
            // 
            Statetxt.BorderStyle = BorderStyle.None;
            Statetxt.Font = new Font("Segoe UI", 12F);
            Statetxt.Location = new Point(92, 141);
            Statetxt.Name = "Statetxt";
            Statetxt.Size = new Size(172, 22);
            Statetxt.TabIndex = 27;
            Statetxt.KeyPress += Statetxt_KeyPress;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.Location = new Point(11, 137);
            label11.Name = "label11";
            label11.Size = new Size(40, 19);
            label11.TabIndex = 26;
            label11.Text = "State";
            // 
            // Citytxt
            // 
            Citytxt.BorderStyle = BorderStyle.None;
            Citytxt.Font = new Font("Segoe UI", 12F);
            Citytxt.Location = new Point(93, 89);
            Citytxt.Name = "Citytxt";
            Citytxt.Size = new Size(172, 22);
            Citytxt.TabIndex = 25;
            Citytxt.KeyPress += Citytxt_KeyPress;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 10F);
            label10.Location = new Point(12, 85);
            label10.Name = "label10";
            label10.Size = new Size(33, 19);
            label10.TabIndex = 24;
            label10.Text = "City";
            // 
            // AddressTxt
            // 
            AddressTxt.BorderStyle = BorderStyle.None;
            AddressTxt.Font = new Font("Segoe UI", 12F);
            AddressTxt.Location = new Point(93, 41);
            AddressTxt.Name = "AddressTxt";
            AddressTxt.Size = new Size(172, 22);
            AddressTxt.TabIndex = 23;
            AddressTxt.KeyPress += AddressTxt_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(12, 37);
            label9.Name = "label9";
            label9.Size = new Size(58, 19);
            label9.TabIndex = 22;
            label9.Text = "Address";
            // 
            // Addenrollee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(FirstPanel);
            Controls.Add(SecondPanel);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AddEnrollee";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddEnrollee";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            FirstPanel.ResumeLayout(false);
            FirstPanel.PerformLayout();
            SecondPanel.ResumeLayout(false);
            SecondPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel FirstPanel;
        private Label TitleLabel;
        private Label label4;
        private Label label3;
        private TextBox LastNametxt;
        private Label label2;
        private TextBox MiddleNametxt;
        private Label label1;
        private TextBox Firstnametxt;
        private Label Firstnamelbl;
        private ComboBox TrainingComboBox;
        private Label Training;
        private TextBox Nationalitytxt;
        private Label label6;
        private TextBox Phonenumtxt;
        private Label label5;
        private DateTimePicker Dob;
        private DateTimePicker StartDate;
        private Label label7;
        private Button Prefbtn;
        private Button Nextbrn;
        private Button cancelbtn;
        private Button savebtn;
        private RadioButton Femaleradio;
        private RadioButton Maleradio;
        private Panel SecondPanel;
        private TextBox Educationlevel;
        private Label label16;
        private TextBox paidamounttxt;
        private Label label15;
        private TextBox Accountinfotxt;
        private Label label14;
        private ComboBox PaymentMethodComboBox;
        private Label label13;
        private TextBox ZipCodetxt;
        private Label label12;
        private TextBox Statetxt;
        private Label label11;
        private TextBox Citytxt;
        private Label label10;
        private TextBox AddressTxt;
        private Label label9;
        private TextBox OptionalPhoneTxt;
        private Label label8;
    }
}