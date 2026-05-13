namespace NesirDrivingCenter
{
    partial class AddPayment
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
            TitleLabel = new Label();
            label1 = new Label();
            Fullnametxt = new TextBox();
            panel2 = new Panel();
            Savebtn = new Button();
            cancelbtn = new Button();
            Paymentlefttxt = new TextBox();
            label2 = new Label();
            label3 = new Label();
            cmbPaymentMethod = new ComboBox();
            Accountinfotxt = new TextBox();
            label4 = new Label();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            Payammounttxt = new TextBox();
            label5 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(52, 73, 94);
            panel1.Controls.Add(TitleLabel);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 62);
            panel1.TabIndex = 0;
            // 
            // TitleLabel
            // 
            TitleLabel.AutoSize = true;
            TitleLabel.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.White;
            TitleLabel.Location = new Point(12, 9);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(139, 28);
            TitleLabel.TabIndex = 1;
            TitleLabel.Text = "Add Payment";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Window;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 87);
            label1.Name = "label1";
            label1.Size = new Size(81, 21);
            label1.TabIndex = 2;
            label1.Text = "Full Name";
            // 
            // Fullnametxt
            // 
            Fullnametxt.BackColor = Color.White;
            Fullnametxt.Enabled = false;
            Fullnametxt.Location = new Point(118, 89);
            Fullnametxt.Name = "Fullnametxt";
            Fullnametxt.Size = new Size(185, 23);
            Fullnametxt.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(52, 73, 94);
            panel2.Controls.Add(Savebtn);
            panel2.Controls.Add(cancelbtn);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 58);
            panel2.TabIndex = 4;
            // 
            // Savebtn
            // 
            Savebtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            Savebtn.BackColor = Color.Teal;
            Savebtn.FlatAppearance.BorderSize = 0;
            Savebtn.FlatStyle = FlatStyle.Flat;
            Savebtn.Font = new Font("Segoe UI", 10F);
            Savebtn.ForeColor = Color.White;
            Savebtn.Location = new Point(221, 10);
            Savebtn.Name = "Savebtn";
            Savebtn.Size = new Size(105, 36);
            Savebtn.TabIndex = 7;
            Savebtn.Text = "Save";
            Savebtn.UseVisualStyleBackColor = false;
            Savebtn.MouseClick += Savebtn_MouseClick;
            // 
            // cancelbtn
            // 
            cancelbtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelbtn.BackColor = Color.FromArgb(64, 64, 64);
            cancelbtn.FlatAppearance.BorderSize = 0;
            cancelbtn.FlatStyle = FlatStyle.Flat;
            cancelbtn.Font = new Font("Segoe UI", 10F);
            cancelbtn.ForeColor = Color.White;
            cancelbtn.Location = new Point(96, 10);
            cancelbtn.Name = "cancelbtn";
            cancelbtn.Size = new Size(105, 36);
            cancelbtn.TabIndex = 6;
            cancelbtn.Text = "Cancel";
            cancelbtn.UseVisualStyleBackColor = false;
            cancelbtn.MouseClick += cancelbtn_MouseClick;
            // 
            // Paymentlefttxt
            // 
            Paymentlefttxt.BackColor = Color.White;
            Paymentlefttxt.Enabled = false;
            Paymentlefttxt.Location = new Point(118, 251);
            Paymentlefttxt.Name = "Paymentlefttxt";
            Paymentlefttxt.Size = new Size(185, 23);
            Paymentlefttxt.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.Window;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(12, 249);
            label2.Name = "label2";
            label2.Size = new Size(100, 21);
            label2.TabIndex = 5;
            label2.Text = "Payment Left";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.Window;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(12, 192);
            label3.Name = "label3";
            label3.Size = new Size(128, 21);
            label3.TabIndex = 7;
            label3.Text = "Payment Method";
            // 
            // cmbPaymentMethod
            // 
            cmbPaymentMethod.Font = new Font("Segoe UI", 12F);
            cmbPaymentMethod.FormattingEnabled = true;
            cmbPaymentMethod.Items.AddRange(new object[] { "Bank", "Cash", "Card" });
            cmbPaymentMethod.Location = new Point(146, 194);
            cmbPaymentMethod.Name = "cmbPaymentMethod";
            cmbPaymentMethod.Size = new Size(157, 29);
            cmbPaymentMethod.TabIndex = 8;
            // 
            // Accountinfotxt
            // 
            Accountinfotxt.BackColor = Color.White;
            Accountinfotxt.Location = new Point(118, 142);
            Accountinfotxt.Name = "Accountinfotxt";
            Accountinfotxt.Size = new Size(185, 23);
            Accountinfotxt.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.Window;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(12, 140);
            label4.Name = "label4";
            label4.Size = new Size(97, 21);
            label4.TabIndex = 9;
            label4.Text = "Account info";
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // Payammounttxt
            // 
            Payammounttxt.BackColor = Color.White;
            Payammounttxt.Location = new Point(162, 306);
            Payammounttxt.Name = "Payammounttxt";
            Payammounttxt.Size = new Size(141, 23);
            Payammounttxt.TabIndex = 12;
            Payammounttxt.KeyPress += Payammounttxt_KeyPress;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.Window;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(12, 304);
            label5.Name = "label5";
            label5.Size = new Size(144, 21);
            label5.TabIndex = 11;
            label5.Text = "Payment Ammount";
            // 
            // AddPayment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(338, 425);
            Controls.Add(Payammounttxt);
            Controls.Add(label5);
            Controls.Add(Accountinfotxt);
            Controls.Add(label4);
            Controls.Add(cmbPaymentMethod);
            Controls.Add(label3);
            Controls.Add(Paymentlefttxt);
            Controls.Add(label2);
            Controls.Add(panel2);
            Controls.Add(Fullnametxt);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            Name = "AddPayment";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPayment";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label TitleLabel;
        private Label label1;
        private TextBox Fullnametxt;
        private Panel panel2;
        private TextBox Paymentlefttxt;
        private Label label2;
        private Label label3;
        private ComboBox cmbPaymentMethod;
        private TextBox Accountinfotxt;
        private Label label4;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private TextBox Payammounttxt;
        private Label label5;
        private Button Savebtn;
        private Button cancelbtn;
    }
}