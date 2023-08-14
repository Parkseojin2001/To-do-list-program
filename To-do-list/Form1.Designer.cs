namespace To_do_list
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtTask = new TextBox();
            txtImportance = new TextBox();
            txtDeadLine = new TextBox();
            txtStart = new TextBox();
            txtClassification = new TextBox();
            btnRegister = new Button();
            btnModify = new Button();
            btnDelete = new Button();
            dgv = new DataGridView();
            task = new DataGridViewTextBoxColumn();
            classification = new DataGridViewTextBoxColumn();
            startdate = new DataGridViewTextBoxColumn();
            deadline = new DataGridViewTextBoxColumn();
            importance = new DataGridViewTextBoxColumn();
            label7 = new Label();
            txtStartTime = new TextBox();
            startTime = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("맑은 고딕", 24F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Yellow;
            label1.Location = new Point(320, 0);
            label1.Name = "label1";
            label1.Size = new Size(166, 45);
            label1.TabIndex = 0;
            label1.Text = "To do list";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 71);
            label2.Name = "label2";
            label2.Size = new Size(58, 25);
            label2.TabIndex = 1;
            label2.Text = "Task:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(58, 175);
            label3.Name = "label3";
            label3.Size = new Size(120, 25);
            label3.TabIndex = 2;
            label3.Text = "Importance:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(365, 119);
            label4.Name = "label4";
            label4.Size = new Size(100, 25);
            label4.TabIndex = 3;
            label4.Text = "DeadLine:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.White;
            label5.Location = new Point(58, 124);
            label5.Name = "label5";
            label5.Size = new Size(107, 25);
            label5.TabIndex = 4;
            label5.Text = "Start Date:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.White;
            label6.Location = new Point(365, 66);
            label6.Name = "label6";
            label6.Size = new Size(134, 25);
            label6.TabIndex = 5;
            label6.Text = "Classification:";
            // 
            // txtTask
            // 
            txtTask.BackColor = Color.White;
            txtTask.BorderStyle = BorderStyle.FixedSingle;
            txtTask.Location = new Point(180, 64);
            txtTask.Name = "txtTask";
            txtTask.Size = new Size(169, 32);
            txtTask.TabIndex = 6;
            txtTask.TextAlign = HorizontalAlignment.Center;
            // 
            // txtImportance
            // 
            txtImportance.BackColor = Color.White;
            txtImportance.BorderStyle = BorderStyle.FixedSingle;
            txtImportance.Location = new Point(180, 168);
            txtImportance.Name = "txtImportance";
            txtImportance.Size = new Size(169, 32);
            txtImportance.TabIndex = 7;
            txtImportance.TextAlign = HorizontalAlignment.Center;
            // 
            // txtDeadLine
            // 
            txtDeadLine.BackColor = Color.White;
            txtDeadLine.BorderStyle = BorderStyle.FixedSingle;
            txtDeadLine.Location = new Point(514, 117);
            txtDeadLine.Name = "txtDeadLine";
            txtDeadLine.Size = new Size(169, 32);
            txtDeadLine.TabIndex = 8;
            txtDeadLine.TextAlign = HorizontalAlignment.Center;
            // 
            // txtStart
            // 
            txtStart.BackColor = Color.White;
            txtStart.BorderStyle = BorderStyle.FixedSingle;
            txtStart.Location = new Point(180, 117);
            txtStart.Name = "txtStart";
            txtStart.Size = new Size(169, 32);
            txtStart.TabIndex = 9;
            txtStart.TextAlign = HorizontalAlignment.Center;
            // 
            // txtClassification
            // 
            txtClassification.BackColor = Color.White;
            txtClassification.BorderStyle = BorderStyle.FixedSingle;
            txtClassification.Location = new Point(514, 64);
            txtClassification.Name = "txtClassification";
            txtClassification.Size = new Size(169, 32);
            txtClassification.TabIndex = 10;
            txtClassification.TextAlign = HorizontalAlignment.Center;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.Blue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(135, 256);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(115, 38);
            btnRegister.TabIndex = 11;
            btnRegister.Text = "Register";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // btnModify
            // 
            btnModify.BackColor = Color.FromArgb(0, 192, 0);
            btnModify.Cursor = Cursors.Hand;
            btnModify.FlatStyle = FlatStyle.Flat;
            btnModify.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            btnModify.ForeColor = Color.White;
            btnModify.Location = new Point(336, 256);
            btnModify.Name = "btnModify";
            btnModify.Size = new Size(115, 38);
            btnModify.TabIndex = 12;
            btnModify.Text = "Modify";
            btnModify.UseVisualStyleBackColor = false;
            btnModify.Click += btnModify_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Red;
            btnDelete.Cursor = Cursors.Hand;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(544, 256);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(115, 38);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.Silver;
            dataGridViewCellStyle1.SelectionBackColor = Color.Silver;
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv.Columns.AddRange(new DataGridViewColumn[] { task, classification, startdate, deadline, importance, startTime });
            dgv.Dock = DockStyle.Bottom;
            dgv.Location = new Point(0, 332);
            dgv.Name = "dgv";
            dgv.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle2;
            dgv.RowTemplate.Height = 25;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(829, 174);
            dgv.TabIndex = 14;
            dgv.SelectionChanged += dgv_SelectionChanged;
            // 
            // task
            // 
            task.HeaderText = "Task";
            task.Name = "task";
            task.ReadOnly = true;
            // 
            // classification
            // 
            classification.HeaderText = "Classification";
            classification.Name = "classification";
            classification.ReadOnly = true;
            // 
            // startdate
            // 
            startdate.HeaderText = "Start Date";
            startdate.Name = "startdate";
            startdate.ReadOnly = true;
            // 
            // deadline
            // 
            deadline.HeaderText = "DeadLine";
            deadline.Name = "deadline";
            deadline.ReadOnly = true;
            // 
            // importance
            // 
            importance.HeaderText = "Importance";
            importance.Name = "importance";
            importance.ReadOnly = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("맑은 고딕", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.White;
            label7.Location = new Point(365, 175);
            label7.Name = "label7";
            label7.Size = new Size(110, 25);
            label7.TabIndex = 15;
            label7.Text = "Start Time:";
            // 
            // txtStartTime
            // 
            txtStartTime.BackColor = Color.White;
            txtStartTime.BorderStyle = BorderStyle.FixedSingle;
            txtStartTime.Location = new Point(514, 168);
            txtStartTime.Name = "txtStartTime";
            txtStartTime.Size = new Size(169, 32);
            txtStartTime.TabIndex = 16;
            txtStartTime.TextAlign = HorizontalAlignment.Center;
            // 
            // startTime
            // 
            startTime.HeaderText = "Start Time";
            startTime.Name = "startTime";
            startTime.ReadOnly = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(829, 506);
            Controls.Add(txtStartTime);
            Controls.Add(label7);
            Controls.Add(dgv);
            Controls.Add(btnDelete);
            Controls.Add(btnModify);
            Controls.Add(btnRegister);
            Controls.Add(txtClassification);
            Controls.Add(txtStart);
            Controls.Add(txtDeadLine);
            Controls.Add(txtImportance);
            Controls.Add(txtTask);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("맑은 고딕", 14F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.Cyan;
            Margin = new Padding(5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "To Do List";
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtTask;
        private TextBox txtImportance;
        private TextBox txtDeadLine;
        private TextBox txtStart;
        private TextBox txtClassification;
        private Button btnRegister;
        private Button btnModify;
        private Button btnDelete;
        private DataGridView dgv;
        private DataGridViewTextBoxColumn task;
        private DataGridViewTextBoxColumn classification;
        private DataGridViewTextBoxColumn startdate;
        private DataGridViewTextBoxColumn deadline;
        private DataGridViewTextBoxColumn importance;
        private Label label7;
        private DataGridViewTextBoxColumn startTime;
        private TextBox txtStartTime;
    }
}