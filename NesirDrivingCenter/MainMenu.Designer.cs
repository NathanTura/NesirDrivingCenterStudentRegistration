using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace NesirDrivingCenter
{
    public partial class MainMenu : Form
    {
        private System.ComponentModel.IContainer components = null;


        protected override void Dispose(bool disposing)
        {

        }



        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            TitlePanel = new Panel();
            Sidepopup = new Button();
            TitleLabel = new Label();
            SideBarPanel = new Panel();
            AddDateBTn = new Button();
            Studentreportbtn = new Button();
            AddStudentBtn = new Button();
            Paymentrepbtn = new Button();
            label1 = new Label();
            Enrollessbtn = new Button();
            HomeBtn = new Button();
            CenterPanel = new Panel();
            DashBoardPanel = new Panel();
            DashboardGrid = new DataGridView();
            PaymentReportPanel = new Panel();
            PaymentReportTable = new DataGridView();
            studentreportpanel = new Panel();
            panel6 = new Panel();
            studentreportdata = new DataGridView();
            panel5 = new Panel();
            label5 = new Label();
            Numberofstudentstxt = new TextBox();
            StudentDetailPanel = new Panel();
            EndDatetxt = new TextBox();
            label4 = new Label();
            Startdatetxt = new TextBox();
            label3 = new Label();
            Enrolleddatetxt = new TextBox();
            label2 = new Label();
            Editbutton = new Button();
            Costtxt = new TextBox();
            CostLabel = new Label();
            textBox7 = new TextBox();
            StatusLabel = new Label();
            TrainingTxt = new TextBox();
            TrainDurationlabel = new Label();
            TrainingpakTxt = new TextBox();
            TrainingPacKLabel = new Label();
            AdressTxt = new TextBox();
            AddressLabel = new Label();
            PhoneNUmbertext = new TextBox();
            PhoneNumberLabel = new Label();
            DateofBirthtext = new TextBox();
            Doblabel = new Label();
            GenderText = new TextBox();
            GenderLabel = new Label();
            FullNameTextBox = new TextBox();
            FullNameLabel = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            AddPayment = new Button();
            UpdateBtn = new Button();
            DeleteBtn = new Button();
            PaymentHistoryData = new DataGridView();
            panel4 = new Panel();
            PaymentHistoryLabel = new Label();
            panel1 = new Panel();
            StudentDetailListText = new Label();
            SearchPanel = new Panel();
            YearCombo = new ComboBox();
            Coursecombo = new ComboBox();
            EnteraName = new Label();
            SearchBtn = new Button();
            SearchTextBox = new TextBox();
            sqlCommand1 = new SqlCommand();
            TitlePanel.SuspendLayout();
            SideBarPanel.SuspendLayout();
            CenterPanel.SuspendLayout();
            DashBoardPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DashboardGrid).BeginInit();
            PaymentReportPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentReportTable).BeginInit();
            studentreportpanel.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentreportdata).BeginInit();
            panel5.SuspendLayout();
            StudentDetailPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PaymentHistoryData).BeginInit();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitlePanel
            // 
            TitlePanel.Controls.Add(Sidepopup);
            TitlePanel.Controls.Add(TitleLabel);
            TitlePanel.Dock = DockStyle.Top;
            TitlePanel.Location = new Point(0, 0);
            TitlePanel.Name = "TitlePanel";
            TitlePanel.Size = new Size(1064, 94);
            TitlePanel.TabIndex = 0;
            TitlePanel.Paint += TitlePanel_Paint;
            // 
            // Sidepopup
            // 
            Sidepopup.FlatAppearance.BorderSize = 0;
            Sidepopup.FlatAppearance.MouseDownBackColor = Color.FromArgb(100, 0, 0, 0);
            Sidepopup.FlatAppearance.MouseOverBackColor = Color.FromArgb(50, 0, 0, 0);
            Sidepopup.FlatStyle = FlatStyle.Flat;
            Sidepopup.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            Sidepopup.ForeColor = Color.White;
            Sidepopup.Location = new Point(53, 27);
            Sidepopup.Name = "Sidepopup";
            Sidepopup.Size = new Size(40, 40);
            Sidepopup.TabIndex = 1;
            Sidepopup.Text = "☰";
            Sidepopup.UseVisualStyleBackColor = false;
            Sidepopup.Click += Sidepopup_Click_1;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(127, 30);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(516, 37);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Nesir Driving Center Management App";
            // 
            // SideBarPanel
            // 
            SideBarPanel.Controls.Add(AddDateBTn);
            SideBarPanel.Controls.Add(Studentreportbtn);
            SideBarPanel.Controls.Add(AddStudentBtn);
            SideBarPanel.Controls.Add(Paymentrepbtn);
            SideBarPanel.Controls.Add(label1);
            SideBarPanel.Controls.Add(Enrollessbtn);
            SideBarPanel.Controls.Add(HomeBtn);
            SideBarPanel.Dock = DockStyle.Left;
            SideBarPanel.Location = new Point(0, 94);
            SideBarPanel.Name = "SideBarPanel";
            SideBarPanel.Size = new Size(200, 587);
            SideBarPanel.TabIndex = 1;
            // 
            // AddDateBTn
            // 
            AddDateBTn.FlatAppearance.BorderSize = 0;
            AddDateBTn.FlatStyle = FlatStyle.Flat;
            AddDateBTn.Font = new Font("Segoe UI", 10F);
            AddDateBTn.ForeColor = Color.White;
            AddDateBTn.Location = new Point(0, 129);
            AddDateBTn.Name = "AddDateBTn";
            AddDateBTn.Size = new Size(202, 40);
            AddDateBTn.TabIndex = 9;
            AddDateBTn.Text = "Add Dates";
            AddDateBTn.UseVisualStyleBackColor = true;
            AddDateBTn.MouseClick += AddDateBTn_MouseClick;
            // 
            // Studentreportbtn
            // 
            Studentreportbtn.FlatAppearance.BorderSize = 0;
            Studentreportbtn.FlatStyle = FlatStyle.Flat;
            Studentreportbtn.ForeColor = Color.White;
            Studentreportbtn.Location = new Point(3, 331);
            Studentreportbtn.Name = "Studentreportbtn";
            Studentreportbtn.Size = new Size(202, 40);
            Studentreportbtn.TabIndex = 8;
            Studentreportbtn.Text = "Student Report";
            Studentreportbtn.UseVisualStyleBackColor = true;
            Studentreportbtn.MouseClick += Studentreportbtn_MouseClick;
            // 
            // AddStudentBtn
            // 
            AddStudentBtn.FlatAppearance.BorderSize = 0;
            AddStudentBtn.FlatStyle = FlatStyle.Flat;
            AddStudentBtn.Font = new Font("Segoe UI", 10F);
            AddStudentBtn.ForeColor = Color.White;
            AddStudentBtn.Location = new Point(0, 80);
            AddStudentBtn.Name = "AddStudentBtn";
            AddStudentBtn.Size = new Size(202, 40);
            AddStudentBtn.TabIndex = 7;
            AddStudentBtn.Text = "Add Enrollee";
            AddStudentBtn.UseVisualStyleBackColor = true;
            AddStudentBtn.Click += AddStudentBtn_Click;
            AddStudentBtn.MouseClick += AddStudentBtn_MouseClick;
            // 
            // Paymentrepbtn
            // 
            Paymentrepbtn.FlatAppearance.BorderSize = 0;
            Paymentrepbtn.FlatStyle = FlatStyle.Flat;
            Paymentrepbtn.ForeColor = Color.White;
            Paymentrepbtn.Location = new Point(3, 285);
            Paymentrepbtn.Name = "Paymentrepbtn";
            Paymentrepbtn.Size = new Size(202, 40);
            Paymentrepbtn.TabIndex = 3;
            Paymentrepbtn.Text = "Payment Report";
            Paymentrepbtn.UseVisualStyleBackColor = true;
            Paymentrepbtn.MouseClick += Paymentrepbtn_MouseClick_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(27, 252);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 2;
            label1.Text = "Report";
            // 
            // Enrollessbtn
            // 
            Enrollessbtn.FlatAppearance.BorderSize = 0;
            Enrollessbtn.FlatStyle = FlatStyle.Flat;
            Enrollessbtn.Font = new Font("Segoe UI", 10F);
            Enrollessbtn.ForeColor = Color.White;
            Enrollessbtn.Location = new Point(3, 178);
            Enrollessbtn.Name = "Enrollessbtn";
            Enrollessbtn.Size = new Size(202, 40);
            Enrollessbtn.TabIndex = 0;
            Enrollessbtn.Text = "Enrollee's Detail";
            Enrollessbtn.UseVisualStyleBackColor = true;
            Enrollessbtn.Click += Enrollessbtn_Click;
            Enrollessbtn.MouseClick += EnrollessListMouse_Clicked;
            // 
            // HomeBtn
            // 
            HomeBtn.FlatAppearance.BorderSize = 0;
            HomeBtn.FlatStyle = FlatStyle.Flat;
            HomeBtn.Font = new Font("Segoe UI", 10F);
            HomeBtn.ForeColor = Color.White;
            HomeBtn.Location = new Point(0, 31);
            HomeBtn.Name = "HomeBtn";
            HomeBtn.Size = new Size(202, 40);
            HomeBtn.TabIndex = 0;
            HomeBtn.Text = "DashBoard";
            HomeBtn.UseVisualStyleBackColor = true;
            HomeBtn.Click += HomeBtn_Click;
            HomeBtn.MouseClick += DashBoardMouse_Click;
            // 
            // CenterPanel
            // 
            CenterPanel.Controls.Add(DashBoardPanel);
            CenterPanel.Controls.Add(PaymentReportPanel);
            CenterPanel.Controls.Add(studentreportpanel);
            CenterPanel.Controls.Add(StudentDetailPanel);
            CenterPanel.Controls.Add(SearchPanel);
            CenterPanel.Dock = DockStyle.Fill;
            CenterPanel.Location = new Point(200, 94);
            CenterPanel.Name = "CenterPanel";
            CenterPanel.Size = new Size(864, 587);
            CenterPanel.TabIndex = 2;
            // 
            // DashBoardPanel
            // 
            DashBoardPanel.BackColor = Color.White;
            DashBoardPanel.Controls.Add(DashboardGrid);
            DashBoardPanel.Dock = DockStyle.Fill;
            DashBoardPanel.Location = new Point(0, 62);
            DashBoardPanel.Name = "DashBoardPanel";
            DashBoardPanel.Size = new Size(864, 525);
            DashBoardPanel.TabIndex = 2;
            // 
            // DashboardGrid
            // 
            DashboardGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DashboardGrid.Dock = DockStyle.Fill;
            DashboardGrid.EditMode = DataGridViewEditMode.EditProgrammatically;
            DashboardGrid.Location = new Point(0, 0);
            DashboardGrid.Name = "DashboardGrid";
            DashboardGrid.Size = new Size(864, 525);
            DashboardGrid.TabIndex = 0;
            DashboardGrid.CellDoubleClick += DashboardGrid_CellDoubleClick_1;
            // 
            // PaymentReportPanel
            // 
            PaymentReportPanel.BackColor = Color.White;
            PaymentReportPanel.Controls.Add(PaymentReportTable);
            PaymentReportPanel.Dock = DockStyle.Fill;
            PaymentReportPanel.Location = new Point(0, 62);
            PaymentReportPanel.Name = "PaymentReportPanel";
            PaymentReportPanel.Size = new Size(864, 525);
            PaymentReportPanel.TabIndex = 3;
            // 
            // PaymentReportTable
            // 
            PaymentReportTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentReportTable.Dock = DockStyle.Fill;
            PaymentReportTable.Location = new Point(0, 0);
            PaymentReportTable.Name = "PaymentReportTable";
            PaymentReportTable.Size = new Size(864, 525);
            PaymentReportTable.TabIndex = 0;
            // 
            // studentreportpanel
            // 
            studentreportpanel.Controls.Add(panel6);
            studentreportpanel.Controls.Add(panel5);
            studentreportpanel.Dock = DockStyle.Fill;
            studentreportpanel.Location = new Point(0, 62);
            studentreportpanel.Name = "studentreportpanel";
            studentreportpanel.Size = new Size(864, 525);
            studentreportpanel.TabIndex = 27;
            // 
            // panel6
            // 
            panel6.Controls.Add(studentreportdata);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(0, 0);
            panel6.Name = "panel6";
            panel6.Size = new Size(864, 441);
            panel6.TabIndex = 1;
            // 
            // studentreportdata
            // 
            studentreportdata.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentreportdata.Dock = DockStyle.Fill;
            studentreportdata.Location = new Point(0, 0);
            studentreportdata.Name = "studentreportdata";
            studentreportdata.Size = new Size(864, 441);
            studentreportdata.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.Controls.Add(label5);
            panel5.Controls.Add(Numberofstudentstxt);
            panel5.Dock = DockStyle.Bottom;
            panel5.Location = new Point(0, 441);
            panel5.Name = "panel5";
            panel5.Size = new Size(864, 84);
            panel5.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(6, 31);
            label5.Name = "label5";
            label5.Size = new Size(202, 28);
            label5.TabIndex = 2;
            label5.Text = "Number of students";
            // 
            // Numberofstudentstxt
            // 
            Numberofstudentstxt.BackColor = Color.White;
            Numberofstudentstxt.Font = new Font("Segoe UI", 12F);
            Numberofstudentstxt.ForeColor = Color.Black;
            Numberofstudentstxt.Location = new Point(214, 34);
            Numberofstudentstxt.Name = "Numberofstudentstxt";
            Numberofstudentstxt.Size = new Size(250, 29);
            Numberofstudentstxt.TabIndex = 1;
            // 
            // StudentDetailPanel
            // 
            StudentDetailPanel.BackColor = Color.WhiteSmoke;
            StudentDetailPanel.Controls.Add(EndDatetxt);
            StudentDetailPanel.Controls.Add(label4);
            StudentDetailPanel.Controls.Add(Startdatetxt);
            StudentDetailPanel.Controls.Add(label3);
            StudentDetailPanel.Controls.Add(Enrolleddatetxt);
            StudentDetailPanel.Controls.Add(label2);
            StudentDetailPanel.Controls.Add(Editbutton);
            StudentDetailPanel.Controls.Add(Costtxt);
            StudentDetailPanel.Controls.Add(CostLabel);
            StudentDetailPanel.Controls.Add(textBox7);
            StudentDetailPanel.Controls.Add(StatusLabel);
            StudentDetailPanel.Controls.Add(TrainingTxt);
            StudentDetailPanel.Controls.Add(TrainDurationlabel);
            StudentDetailPanel.Controls.Add(TrainingpakTxt);
            StudentDetailPanel.Controls.Add(TrainingPacKLabel);
            StudentDetailPanel.Controls.Add(AdressTxt);
            StudentDetailPanel.Controls.Add(AddressLabel);
            StudentDetailPanel.Controls.Add(PhoneNUmbertext);
            StudentDetailPanel.Controls.Add(PhoneNumberLabel);
            StudentDetailPanel.Controls.Add(DateofBirthtext);
            StudentDetailPanel.Controls.Add(Doblabel);
            StudentDetailPanel.Controls.Add(GenderText);
            StudentDetailPanel.Controls.Add(GenderLabel);
            StudentDetailPanel.Controls.Add(FullNameTextBox);
            StudentDetailPanel.Controls.Add(FullNameLabel);
            StudentDetailPanel.Controls.Add(panel2);
            StudentDetailPanel.Controls.Add(panel1);
            StudentDetailPanel.Dock = DockStyle.Fill;
            StudentDetailPanel.Font = new Font("Segoe UI", 12F);
            StudentDetailPanel.Location = new Point(0, 62);
            StudentDetailPanel.Name = "StudentDetailPanel";
            StudentDetailPanel.Size = new Size(864, 525);
            StudentDetailPanel.TabIndex = 2;
            StudentDetailPanel.Paint += StudentDetailPanel_Paint_1;
            // 
            // EndDatetxt
            // 
            EndDatetxt.BorderStyle = BorderStyle.None;
            EndDatetxt.Enabled = false;
            EndDatetxt.Location = new Point(677, 213);
            EndDatetxt.Name = "EndDatetxt";
            EndDatetxt.Size = new Size(172, 22);
            EndDatetxt.TabIndex = 26;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(652, 195);
            label4.Name = "label4";
            label4.Size = new Size(65, 19);
            label4.TabIndex = 25;
            label4.Text = "End Date";
            // 
            // Startdatetxt
            // 
            Startdatetxt.BorderStyle = BorderStyle.None;
            Startdatetxt.Enabled = false;
            Startdatetxt.Location = new Point(677, 159);
            Startdatetxt.Name = "Startdatetxt";
            Startdatetxt.Size = new Size(172, 22);
            Startdatetxt.TabIndex = 24;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(652, 141);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 23;
            label3.Text = "Start Date";
            // 
            // Enrolleddatetxt
            // 
            Enrolleddatetxt.BorderStyle = BorderStyle.None;
            Enrolleddatetxt.Enabled = false;
            Enrolleddatetxt.Location = new Point(677, 97);
            Enrolleddatetxt.Name = "Enrolleddatetxt";
            Enrolleddatetxt.Size = new Size(172, 22);
            Enrolleddatetxt.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(652, 79);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 21;
            label2.Text = "Enrolled Date";
            // 
            // Editbutton
            // 
            Editbutton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Editbutton.BackColor = Color.FromArgb(52, 73, 94);
            Editbutton.FlatAppearance.BorderSize = 0;
            Editbutton.FlatStyle = FlatStyle.Flat;
            Editbutton.Font = new Font("Segoe UI", 10F);
            Editbutton.ForeColor = Color.White;
            Editbutton.Location = new Point(798, 55);
            Editbutton.Name = "Editbutton";
            Editbutton.Size = new Size(66, 25);
            Editbutton.TabIndex = 20;
            Editbutton.Text = "Edit";
            Editbutton.UseVisualStyleBackColor = false;
            Editbutton.Click += Editbutton_Click;
            // 
            // Costtxt
            // 
            Costtxt.BorderStyle = BorderStyle.None;
            Costtxt.Enabled = false;
            Costtxt.Location = new Point(457, 213);
            Costtxt.Name = "Costtxt";
            Costtxt.Size = new Size(172, 22);
            Costtxt.TabIndex = 19;
            // 
            // CostLabel
            // 
            CostLabel.AutoSize = true;
            CostLabel.Font = new Font("Segoe UI", 10F);
            CostLabel.Location = new Point(432, 195);
            CostLabel.Name = "CostLabel";
            CostLabel.Size = new Size(37, 19);
            CostLabel.TabIndex = 18;
            CostLabel.Text = "Cost";
            // 
            // textBox7
            // 
            textBox7.BorderStyle = BorderStyle.None;
            textBox7.Enabled = false;
            textBox7.Location = new Point(677, 275);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(172, 22);
            textBox7.TabIndex = 17;
            // 
            // StatusLabel
            // 
            StatusLabel.AutoSize = true;
            StatusLabel.Font = new Font("Segoe UI", 10F);
            StatusLabel.Location = new Point(652, 257);
            StatusLabel.Name = "StatusLabel";
            StatusLabel.Size = new Size(47, 19);
            StatusLabel.TabIndex = 16;
            StatusLabel.Text = "Status";
            // 
            // TrainingTxt
            // 
            TrainingTxt.BorderStyle = BorderStyle.None;
            TrainingTxt.Enabled = false;
            TrainingTxt.Location = new Point(457, 155);
            TrainingTxt.Name = "TrainingTxt";
            TrainingTxt.Size = new Size(172, 22);
            TrainingTxt.TabIndex = 15;
            // 
            // TrainDurationlabel
            // 
            TrainDurationlabel.AutoSize = true;
            TrainDurationlabel.Font = new Font("Segoe UI", 10F);
            TrainDurationlabel.Location = new Point(432, 137);
            TrainDurationlabel.Name = "TrainDurationlabel";
            TrainDurationlabel.Size = new Size(115, 19);
            TrainDurationlabel.TabIndex = 14;
            TrainDurationlabel.Text = "Training Duration";
            // 
            // TrainingpakTxt
            // 
            TrainingpakTxt.BorderStyle = BorderStyle.None;
            TrainingpakTxt.Enabled = false;
            TrainingpakTxt.Location = new Point(457, 97);
            TrainingpakTxt.Name = "TrainingpakTxt";
            TrainingpakTxt.Size = new Size(172, 22);
            TrainingpakTxt.TabIndex = 13;
            // 
            // TrainingPacKLabel
            // 
            TrainingPacKLabel.AutoSize = true;
            TrainingPacKLabel.Font = new Font("Segoe UI", 10F);
            TrainingPacKLabel.Location = new Point(432, 79);
            TrainingPacKLabel.Name = "TrainingPacKLabel";
            TrainingPacKLabel.Size = new Size(111, 19);
            TrainingPacKLabel.TabIndex = 12;
            TrainingPacKLabel.Text = "Training Package";
            // 
            // AdressTxt
            // 
            AdressTxt.BorderStyle = BorderStyle.None;
            AdressTxt.Enabled = false;
            AdressTxt.Location = new Point(250, 97);
            AdressTxt.Name = "AdressTxt";
            AdressTxt.Size = new Size(172, 22);
            AdressTxt.TabIndex = 11;
            // 
            // AddressLabel
            // 
            AddressLabel.AutoSize = true;
            AddressLabel.Font = new Font("Segoe UI", 10F);
            AddressLabel.Location = new Point(225, 79);
            AddressLabel.Name = "AddressLabel";
            AddressLabel.Size = new Size(58, 19);
            AddressLabel.TabIndex = 10;
            AddressLabel.Text = "Address";
            // 
            // PhoneNUmbertext
            // 
            PhoneNUmbertext.BorderStyle = BorderStyle.None;
            PhoneNUmbertext.Enabled = false;
            PhoneNUmbertext.Location = new Point(46, 275);
            PhoneNUmbertext.Name = "PhoneNUmbertext";
            PhoneNUmbertext.Size = new Size(172, 22);
            PhoneNUmbertext.TabIndex = 9;
            // 
            // PhoneNumberLabel
            // 
            PhoneNumberLabel.AutoSize = true;
            PhoneNumberLabel.Font = new Font("Segoe UI", 10F);
            PhoneNumberLabel.Location = new Point(21, 257);
            PhoneNumberLabel.Name = "PhoneNumberLabel";
            PhoneNumberLabel.Size = new Size(102, 19);
            PhoneNumberLabel.TabIndex = 8;
            PhoneNumberLabel.Text = "Phone Number";
            // 
            // DateofBirthtext
            // 
            DateofBirthtext.BorderStyle = BorderStyle.None;
            DateofBirthtext.Enabled = false;
            DateofBirthtext.Location = new Point(46, 213);
            DateofBirthtext.Name = "DateofBirthtext";
            DateofBirthtext.Size = new Size(172, 22);
            DateofBirthtext.TabIndex = 7;
            // 
            // Doblabel
            // 
            Doblabel.AutoSize = true;
            Doblabel.Font = new Font("Segoe UI", 10F);
            Doblabel.Location = new Point(21, 195);
            Doblabel.Name = "Doblabel";
            Doblabel.Size = new Size(87, 19);
            Doblabel.TabIndex = 6;
            Doblabel.Text = "Date of Birth";
            // 
            // GenderText
            // 
            GenderText.BorderStyle = BorderStyle.None;
            GenderText.Enabled = false;
            GenderText.Location = new Point(46, 155);
            GenderText.Name = "GenderText";
            GenderText.Size = new Size(172, 22);
            GenderText.TabIndex = 5;
            // 
            // GenderLabel
            // 
            GenderLabel.AutoSize = true;
            GenderLabel.Font = new Font("Segoe UI", 10F);
            GenderLabel.Location = new Point(21, 137);
            GenderLabel.Name = "GenderLabel";
            GenderLabel.Size = new Size(54, 19);
            GenderLabel.TabIndex = 4;
            GenderLabel.Text = "Gender";
            // 
            // FullNameTextBox
            // 
            FullNameTextBox.BorderStyle = BorderStyle.None;
            FullNameTextBox.Enabled = false;
            FullNameTextBox.Location = new Point(46, 97);
            FullNameTextBox.Name = "FullNameTextBox";
            FullNameTextBox.Size = new Size(172, 22);
            FullNameTextBox.TabIndex = 3;
            // 
            // FullNameLabel
            // 
            FullNameLabel.AutoSize = true;
            FullNameLabel.Font = new Font("Segoe UI", 10F);
            FullNameLabel.Location = new Point(21, 79);
            FullNameLabel.Name = "FullNameLabel";
            FullNameLabel.Size = new Size(70, 19);
            FullNameLabel.TabIndex = 2;
            FullNameLabel.Text = "Full Name";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(PaymentHistoryData);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 315);
            panel2.Name = "panel2";
            panel2.Size = new Size(864, 210);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(AddPayment);
            panel3.Controls.Add(UpdateBtn);
            panel3.Controls.Add(DeleteBtn);
            panel3.Dock = DockStyle.Bottom;
            panel3.Location = new Point(0, 157);
            panel3.Name = "panel3";
            panel3.Size = new Size(864, 53);
            panel3.TabIndex = 3;
            // 
            // AddPayment
            // 
            AddPayment.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddPayment.BackColor = Color.FromArgb(52, 73, 94);
            AddPayment.FlatAppearance.BorderSize = 0;
            AddPayment.FlatStyle = FlatStyle.Flat;
            AddPayment.Font = new Font("Segoe UI", 10F);
            AddPayment.ForeColor = Color.White;
            AddPayment.Location = new Point(23, 10);
            AddPayment.Name = "AddPayment";
            AddPayment.Size = new Size(100, 31);
            AddPayment.TabIndex = 3;
            AddPayment.Text = "Add Payment";
            AddPayment.UseVisualStyleBackColor = false;
            AddPayment.MouseClick += AddPayment_MouseClick;
            // 
            // UpdateBtn
            // 
            UpdateBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            UpdateBtn.BackColor = Color.FromArgb(52, 73, 94);
            UpdateBtn.FlatAppearance.BorderSize = 0;
            UpdateBtn.FlatStyle = FlatStyle.Flat;
            UpdateBtn.Font = new Font("Segoe UI", 10F);
            UpdateBtn.ForeColor = Color.White;
            UpdateBtn.Location = new Point(752, 10);
            UpdateBtn.Name = "UpdateBtn";
            UpdateBtn.Size = new Size(100, 31);
            UpdateBtn.TabIndex = 2;
            UpdateBtn.Text = "Update";
            UpdateBtn.UseVisualStyleBackColor = false;
            UpdateBtn.MouseClick += UpdateBtn_MouseClick;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            DeleteBtn.BackColor = Color.Black;
            DeleteBtn.FlatAppearance.BorderSize = 0;
            DeleteBtn.FlatStyle = FlatStyle.Flat;
            DeleteBtn.Font = new Font("Segoe UI", 10F);
            DeleteBtn.ForeColor = Color.White;
            DeleteBtn.Location = new Point(620, 10);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(100, 31);
            DeleteBtn.TabIndex = 1;
            DeleteBtn.Text = "Delete";
            DeleteBtn.UseVisualStyleBackColor = false;
            DeleteBtn.MouseClick += DeleteBtn_MouseClick;
            // 
            // PaymentHistoryData
            // 
            PaymentHistoryData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PaymentHistoryData.Dock = DockStyle.Fill;
            PaymentHistoryData.Location = new Point(0, 40);
            PaymentHistoryData.Name = "PaymentHistoryData";
            PaymentHistoryData.Size = new Size(864, 170);
            PaymentHistoryData.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.BorderStyle = BorderStyle.Fixed3D;
            panel4.Controls.Add(PaymentHistoryLabel);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(864, 40);
            panel4.TabIndex = 1;
            // 
            // PaymentHistoryLabel
            // 
            PaymentHistoryLabel.AutoSize = true;
            PaymentHistoryLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            PaymentHistoryLabel.Location = new Point(21, 7);
            PaymentHistoryLabel.Name = "PaymentHistoryLabel";
            PaymentHistoryLabel.Size = new Size(171, 28);
            PaymentHistoryLabel.TabIndex = 0;
            PaymentHistoryLabel.Text = "Payment History";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(StudentDetailListText);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 58);
            panel1.TabIndex = 0;
            // 
            // StudentDetailListText
            // 
            StudentDetailListText.AutoSize = true;
            StudentDetailListText.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            StudentDetailListText.Location = new Point(21, 12);
            StudentDetailListText.Name = "StudentDetailListText";
            StudentDetailListText.Size = new Size(158, 28);
            StudentDetailListText.TabIndex = 0;
            StudentDetailListText.Text = "Student Details";
            // 
            // SearchPanel
            // 
            SearchPanel.BackColor = Color.WhiteSmoke;
            SearchPanel.Controls.Add(YearCombo);
            SearchPanel.Controls.Add(Coursecombo);
            SearchPanel.Controls.Add(EnteraName);
            SearchPanel.Controls.Add(SearchBtn);
            SearchPanel.Controls.Add(SearchTextBox);
            SearchPanel.Dock = DockStyle.Top;
            SearchPanel.Location = new Point(0, 0);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(864, 62);
            SearchPanel.TabIndex = 0;
            // 
            // YearCombo
            // 
            YearCombo.Anchor = AnchorStyles.Right;
            YearCombo.DropDownStyle = ComboBoxStyle.DropDownList;
            YearCombo.Font = new Font("Segoe UI", 12F);
            YearCombo.FormattingEnabled = true;
            YearCombo.Location = new Point(356, 24);
            YearCombo.Name = "YearCombo";
            YearCombo.Size = new Size(192, 29);
            YearCombo.TabIndex = 4;
            // 
            // Coursecombo
            // 
            Coursecombo.Anchor = AnchorStyles.Right;
            Coursecombo.DropDownStyle = ComboBoxStyle.DropDownList;
            Coursecombo.Font = new Font("Segoe UI", 12F);
            Coursecombo.FormattingEnabled = true;
            Coursecombo.Items.AddRange(new object[] { "All", "Auto-Mobile", "Cargo 1", "Public 1" });
            Coursecombo.SelectedIndex = 0;
            Coursecombo.Location = new Point(554, 24);
            Coursecombo.Name = "Coursecombo";
            Coursecombo.Size = new Size(192, 29);
            Coursecombo.TabIndex = 3;
            // 
            // EnteraName
            // 
            EnteraName.Anchor = AnchorStyles.Right;
            EnteraName.AutoSize = true;
            EnteraName.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            EnteraName.ForeColor = Color.Red;
            EnteraName.Location = new Point(391, 31);
            EnteraName.Name = "EnteraName";
            EnteraName.Size = new Size(81, 19);
            EnteraName.TabIndex = 2;
            EnteraName.Text = "Enter an ID";
            EnteraName.Visible = false;
            // 
            // SearchBtn
            // 
            SearchBtn.Anchor = AnchorStyles.Right;
            SearchBtn.BackColor = Color.SteelBlue;
            SearchBtn.FlatAppearance.BorderSize = 0;
            SearchBtn.FlatStyle = FlatStyle.Flat;
            SearchBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            SearchBtn.ForeColor = Color.White;
            SearchBtn.Location = new Point(752, 24);
            SearchBtn.Name = "SearchBtn";
            SearchBtn.Size = new Size(100, 30);
            SearchBtn.TabIndex = 1;
            SearchBtn.Text = "Search";
            SearchBtn.UseVisualStyleBackColor = false;
            SearchBtn.MouseClick += SearchBtn_MouseClick;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Right;
            SearchTextBox.BackColor = Color.White;
            SearchTextBox.Font = new Font("Segoe UI", 12F);
            SearchTextBox.ForeColor = Color.Black;
            SearchTextBox.Location = new Point(496, 25);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "Search by ID or Name";
            SearchTextBox.Size = new Size(250, 29);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.KeyPress += SearchTextBox_KeyPress;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // MainMenu
            // 
            BackColor = Color.FromArgb(52, 73, 94);
            ClientSize = new Size(1064, 681);
            Controls.Add(CenterPanel);
            Controls.Add(SideBarPanel);
            Controls.Add(TitlePanel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Load += MainMenu_Load;
            TitlePanel.ResumeLayout(false);
            TitlePanel.PerformLayout();
            SideBarPanel.ResumeLayout(false);
            SideBarPanel.PerformLayout();
            CenterPanel.ResumeLayout(false);
            DashBoardPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)DashboardGrid).EndInit();
            PaymentReportPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PaymentReportTable).EndInit();
            studentreportpanel.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)studentreportdata).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            StudentDetailPanel.ResumeLayout(false);
            StudentDetailPanel.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PaymentHistoryData).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel PaymentReportPanel;
        private Panel studentlistsPanel2;
        private Panel TitlePanel;
        private Panel SideBarPanel;
        private Panel CenterPanel;
        private Label TitleLabel;
        private Panel DashBoardPanel;
        private Panel SearchPanel;
        private Button Sidepopup;
        private Label label1;
        private Button Enrollessbtn;
        private Button HomeBtn;
        private Button Paymentrepbtn;
        private Panel StudentDetailPanel;
        private TextBox textBox7;
        private Label StatusLabel;
        private TextBox TrainingTxt;
        private Label TrainDurationlabel;
        private TextBox TrainingpakTxt;
        private Label TrainingPacKLabel;
        private TextBox AdressTxt;
        private Label AddressLabel;
        private TextBox PhoneNUmbertext;
        private Label PhoneNumberLabel;
        private TextBox DateofBirthtext;
        private Label Doblabel;
        private TextBox GenderText;
        private Label GenderLabel;
        private TextBox FullNameTextBox;
        private Label FullNameLabel;
        private Panel panel2;
        private Panel panel4;
        private Panel panel1;
        private Label StudentDetailListText;
        private TextBox Costtxt;
        private Label CostLabel;
        private Label PaymentHistoryLabel;
        private DataGridView PaymentHistoryData;
        private Button SearchBtn;
        private TextBox SearchTextBox;
        private Panel panel3;
        private DataGridView DashboardGrid;
        private Label EnteraName;
        private DataGridView PaymentReportTable;
        private Button AddStudentBtn;
        private Button UpdateBtn;
        private Button DeleteBtn;
        private Button AddPayment;
        private Button Editbutton;
        private SqlCommand sqlCommand1;
        private TextBox EndDatetxt;
        private Label label4;
        private TextBox Startdatetxt;
        private Label label3;
        private TextBox Enrolleddatetxt;
        private Label label2;
        private Button Studentreportbtn;
        private Panel studentreportpanel;
        private Panel panel6;
        private DataGridView studentreportdata;
        private Panel panel5;
        private Label label5;
        private TextBox Numberofstudentstxt;
        private ComboBox YearCombo;
        private ComboBox Coursecombo;
        private Button AddDateBTn;
    }
}