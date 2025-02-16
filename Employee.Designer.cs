namespace HostelMangagementSystem
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel2 = new Panel();
            panel1 = new Panel();
            label5 = new Label();
            label1 = new Label();
            EmpAddTb = new TextBox();
            EmpNameTb = new TextBox();
            EmpPhoneTb = new TextBox();
            EmpIdTb = new TextBox();
            EmpPositionCb = new ComboBox();
            label4 = new Label();
            EmpStatusCB = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            bunifuThinButton28 = new Bunifu.Framework.UI.BunifuThinButton2();
            DeleteEmp = new Bunifu.Framework.UI.BunifuThinButton2();
            UpdateEmp = new Bunifu.Framework.UI.BunifuThinButton2();
            AddEmp = new Bunifu.Framework.UI.BunifuThinButton2();
            EmployeeDGV = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 204, 254);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 45);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(890, 11);
            panel2.TabIndex = 22;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 45);
            panel1.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.ForeColor = Color.White;
            label5.Location = new Point(865, 7);
            label5.Name = "label5";
            label5.Size = new Size(12, 15);
            label5.TabIndex = 2;
            label5.Text = "x";
            label5.Click += label5_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(272, 8);
            label1.Name = "label1";
            label1.Size = new Size(333, 30);
            label1.TabIndex = 0;
            label1.Text = "EMPLOYEE INFORMATION";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // EmpAddTb
            // 
            EmpAddTb.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpAddTb.ForeColor = Color.Crimson;
            EmpAddTb.Location = new Point(50, 248);
            EmpAddTb.Margin = new Padding(3, 2, 3, 2);
            EmpAddTb.Name = "EmpAddTb";
            EmpAddTb.Size = new Size(240, 26);
            EmpAddTb.TabIndex = 26;
            EmpAddTb.Text = "Address";
            // 
            // EmpNameTb
            // 
            EmpNameTb.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpNameTb.ForeColor = Color.Crimson;
            EmpNameTb.Location = new Point(50, 146);
            EmpNameTb.Margin = new Padding(3, 2, 3, 2);
            EmpNameTb.Name = "EmpNameTb";
            EmpNameTb.Size = new Size(240, 26);
            EmpNameTb.TabIndex = 25;
            EmpNameTb.Text = "EmployeeName";
            // 
            // EmpPhoneTb
            // 
            EmpPhoneTb.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpPhoneTb.ForeColor = Color.Crimson;
            EmpPhoneTb.Location = new Point(50, 194);
            EmpPhoneTb.Margin = new Padding(3, 2, 3, 2);
            EmpPhoneTb.Name = "EmpPhoneTb";
            EmpPhoneTb.Size = new Size(240, 26);
            EmpPhoneTb.TabIndex = 24;
            EmpPhoneTb.Text = "Phone";
            // 
            // EmpIdTb
            // 
            EmpIdTb.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EmpIdTb.ForeColor = Color.Crimson;
            EmpIdTb.Location = new Point(50, 100);
            EmpIdTb.Margin = new Padding(3, 2, 3, 2);
            EmpIdTb.Name = "EmpIdTb";
            EmpIdTb.Size = new Size(240, 26);
            EmpIdTb.TabIndex = 23;
            EmpIdTb.Text = "Employee ID";
            // 
            // EmpPositionCb
            // 
            EmpPositionCb.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            EmpPositionCb.ForeColor = Color.DodgerBlue;
            EmpPositionCb.FormattingEnabled = true;
            EmpPositionCb.Items.AddRange(new object[] { "Mess Staff", "Accountant", "Cleaner", "Hostel In Charge" });
            EmpPositionCb.Location = new Point(158, 309);
            EmpPositionCb.Margin = new Padding(3, 2, 3, 2);
            EmpPositionCb.Name = "EmpPositionCb";
            EmpPositionCb.Size = new Size(133, 23);
            EmpPositionCb.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Crimson;
            label4.Location = new Point(0, 310);
            label4.Name = "label4";
            label4.Size = new Size(79, 16);
            label4.TabIndex = 27;
            label4.Text = "Position";
            // 
            // EmpStatusCB
            // 
            EmpStatusCB.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 163);
            EmpStatusCB.ForeColor = Color.DodgerBlue;
            EmpStatusCB.FormattingEnabled = true;
            EmpStatusCB.Items.AddRange(new object[] { "Working", "Left" });
            EmpStatusCB.Location = new Point(158, 346);
            EmpStatusCB.Margin = new Padding(3, 2, 3, 2);
            EmpStatusCB.Name = "EmpStatusCB";
            EmpStatusCB.Size = new Size(133, 23);
            EmpStatusCB.TabIndex = 30;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Crimson;
            label2.Location = new Point(0, 347);
            label2.Name = "label2";
            label2.Size = new Size(142, 16);
            label2.TabIndex = 29;
            label2.Text = "Employee Status";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("SimSun", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Crimson;
            label3.Location = new Point(491, 74);
            label3.Name = "label3";
            label3.Size = new Size(221, 30);
            label3.TabIndex = 31;
            label3.Text = "EMPLOYEE LIST";
            // 
            // bunifuThinButton28
            // 
            bunifuThinButton28.ActiveBorderThickness = 1;
            bunifuThinButton28.ActiveCornerRadius = 20;
            bunifuThinButton28.ActiveFillColor = Color.Crimson;
            bunifuThinButton28.ActiveForecolor = Color.White;
            bunifuThinButton28.ActiveLineColor = Color.Crimson;
            bunifuThinButton28.BackColor = SystemColors.Control;
            bunifuThinButton28.BackgroundImage = (Image)resources.GetObject("bunifuThinButton28.BackgroundImage");
            bunifuThinButton28.ButtonText = "BACK";
            bunifuThinButton28.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bunifuThinButton28.ForeColor = Color.Crimson;
            bunifuThinButton28.IdleBorderThickness = 1;
            bunifuThinButton28.IdleCornerRadius = 20;
            bunifuThinButton28.IdleFillColor = Color.White;
            bunifuThinButton28.IdleForecolor = Color.Crimson;
            bunifuThinButton28.IdleLineColor = Color.Crimson;
            bunifuThinButton28.Location = new Point(113, 466);
            bunifuThinButton28.Margin = new Padding(5, 4, 5, 4);
            bunifuThinButton28.Name = "bunifuThinButton28";
            bunifuThinButton28.Size = new Size(79, 30);
            bunifuThinButton28.TabIndex = 36;
            bunifuThinButton28.TextAlign = ContentAlignment.MiddleCenter;
            bunifuThinButton28.Click += bunifuThinButton28_Click;
            // 
            // DeleteEmp
            // 
            DeleteEmp.ActiveBorderThickness = 1;
            DeleteEmp.ActiveCornerRadius = 20;
            DeleteEmp.ActiveFillColor = Color.Crimson;
            DeleteEmp.ActiveForecolor = Color.White;
            DeleteEmp.ActiveLineColor = Color.Crimson;
            DeleteEmp.BackColor = SystemColors.Control;
            DeleteEmp.BackgroundImage = (Image)resources.GetObject("DeleteEmp.BackgroundImage");
            DeleteEmp.ButtonText = "DELETE";
            DeleteEmp.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DeleteEmp.ForeColor = Color.Crimson;
            DeleteEmp.IdleBorderThickness = 1;
            DeleteEmp.IdleCornerRadius = 20;
            DeleteEmp.IdleFillColor = Color.White;
            DeleteEmp.IdleForecolor = Color.Crimson;
            DeleteEmp.IdleLineColor = Color.Crimson;
            DeleteEmp.Location = new Point(203, 417);
            DeleteEmp.Margin = new Padding(5, 4, 5, 4);
            DeleteEmp.Name = "DeleteEmp";
            DeleteEmp.Size = new Size(79, 30);
            DeleteEmp.TabIndex = 35;
            DeleteEmp.TextAlign = ContentAlignment.MiddleCenter;
            DeleteEmp.Click += DeleteEmp_Click;
            // 
            // UpdateEmp
            // 
            UpdateEmp.ActiveBorderThickness = 1;
            UpdateEmp.ActiveCornerRadius = 20;
            UpdateEmp.ActiveFillColor = Color.Crimson;
            UpdateEmp.ActiveForecolor = Color.White;
            UpdateEmp.ActiveLineColor = Color.Crimson;
            UpdateEmp.BackColor = SystemColors.Control;
            UpdateEmp.BackgroundImage = (Image)resources.GetObject("UpdateEmp.BackgroundImage");
            UpdateEmp.ButtonText = "UPDATE";
            UpdateEmp.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UpdateEmp.ForeColor = Color.Crimson;
            UpdateEmp.IdleBorderThickness = 1;
            UpdateEmp.IdleCornerRadius = 20;
            UpdateEmp.IdleFillColor = Color.White;
            UpdateEmp.IdleForecolor = Color.Crimson;
            UpdateEmp.IdleLineColor = Color.Crimson;
            UpdateEmp.Location = new Point(113, 417);
            UpdateEmp.Margin = new Padding(5, 4, 5, 4);
            UpdateEmp.Name = "UpdateEmp";
            UpdateEmp.Size = new Size(79, 30);
            UpdateEmp.TabIndex = 34;
            UpdateEmp.TextAlign = ContentAlignment.MiddleCenter;
            UpdateEmp.Click += UpdateEmp_Click;
            // 
            // AddEmp
            // 
            AddEmp.ActiveBorderThickness = 1;
            AddEmp.ActiveCornerRadius = 20;
            AddEmp.ActiveFillColor = Color.Crimson;
            AddEmp.ActiveForecolor = Color.White;
            AddEmp.ActiveLineColor = Color.Crimson;
            AddEmp.BackColor = SystemColors.Control;
            AddEmp.BackgroundImage = (Image)resources.GetObject("AddEmp.BackgroundImage");
            AddEmp.ButtonText = "ADD";
            AddEmp.Font = new Font("SimSun", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddEmp.ForeColor = Color.Crimson;
            AddEmp.IdleBorderThickness = 1;
            AddEmp.IdleCornerRadius = 20;
            AddEmp.IdleFillColor = Color.White;
            AddEmp.IdleForecolor = Color.Crimson;
            AddEmp.IdleLineColor = Color.Crimson;
            AddEmp.Location = new Point(21, 417);
            AddEmp.Margin = new Padding(5, 4, 5, 4);
            AddEmp.Name = "AddEmp";
            AddEmp.Size = new Size(79, 30);
            AddEmp.TabIndex = 33;
            AddEmp.TextAlign = ContentAlignment.MiddleCenter;
            AddEmp.Click += AddEmp_Click;
            // 
            // EmployeeDGV
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            EmployeeDGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            EmployeeDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            EmployeeDGV.ColumnHeadersHeight = 4;
            EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            EmployeeDGV.DefaultCellStyle = dataGridViewCellStyle3;
            EmployeeDGV.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeDGV.Location = new Point(392, 141);
            EmployeeDGV.Margin = new Padding(3, 2, 3, 2);
            EmployeeDGV.Name = "EmployeeDGV";
            EmployeeDGV.RowHeadersVisible = false;
            EmployeeDGV.RowHeadersWidth = 51;
            EmployeeDGV.RowTemplate.Height = 29;
            EmployeeDGV.Size = new Size(444, 306);
            EmployeeDGV.TabIndex = 37;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.Font = null;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            EmployeeDGV.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            EmployeeDGV.ThemeStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            EmployeeDGV.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            EmployeeDGV.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            EmployeeDGV.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            EmployeeDGV.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            EmployeeDGV.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            EmployeeDGV.ThemeStyle.HeaderStyle.Height = 4;
            EmployeeDGV.ThemeStyle.ReadOnly = false;
            EmployeeDGV.ThemeStyle.RowsStyle.BackColor = Color.White;
            EmployeeDGV.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            EmployeeDGV.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            EmployeeDGV.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            EmployeeDGV.ThemeStyle.RowsStyle.Height = 29;
            EmployeeDGV.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            EmployeeDGV.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            EmployeeDGV.CellContentClick += EmployeeDGV_CellContentClick;
            // 
            // Employee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 522);
            Controls.Add(EmployeeDGV);
            Controls.Add(bunifuThinButton28);
            Controls.Add(DeleteEmp);
            Controls.Add(UpdateEmp);
            Controls.Add(AddEmp);
            Controls.Add(label3);
            Controls.Add(EmpStatusCB);
            Controls.Add(label2);
            Controls.Add(EmpPositionCb);
            Controls.Add(label4);
            Controls.Add(EmpAddTb);
            Controls.Add(EmpNameTb);
            Controls.Add(EmpPhoneTb);
            Controls.Add(EmpIdTb);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Employee";
            Text = "Employee";
            Load += Employee_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)EmployeeDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private Label label5;
        private Label label1;
        private TextBox EmpAddTb;
        private TextBox EmpNameTb;
        private TextBox EmpPhoneTb;
        private TextBox EmpIdTb;
        private ComboBox EmpPositionCb;
        private Label label4;
        private ComboBox EmpStatusCB;
        private Label label2;
        private Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton28;
        private Bunifu.Framework.UI.BunifuThinButton2 DeleteEmp;
        private Bunifu.Framework.UI.BunifuThinButton2 UpdateEmp;
        private Bunifu.Framework.UI.BunifuThinButton2 AddEmp;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeeDGV;
    }
}