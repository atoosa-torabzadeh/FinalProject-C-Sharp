namespace View
{
    partial class PersonForm
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
            btnPost = new Button();
            btnUpdate = new Button();
            button3 = new Button();
            btnRefresh = new Button();
            btnBackToMain = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            dgvPerson = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            SuspendLayout();
            // 
            // btnPost
            // 
            btnPost.Location = new Point(165, 27);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(75, 23);
            btnPost.TabIndex = 0;
            btnPost.Text = "Save";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Enabled = false;
            btnUpdate.Location = new Point(255, 27);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // button3
            // 
            button3.Location = new Point(357, 27);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnDelete_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(454, 27);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(100, 23);
            btnRefresh.TabIndex = 3;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(627, 18);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(177, 40);
            btnBackToMain.TabIndex = 4;
            btnBackToMain.Text = "بازگشت به صفحه اصلی";
            btnBackToMain.UseVisualStyleBackColor = true;
            btnBackToMain.Click += btnBackToMain_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(165, 120);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(61, 15);
            lblFirstName.TabIndex = 5;
            lblFirstName.Text = "FirstName";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(165, 155);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(60, 15);
            lblLastName.TabIndex = 6;
            lblLastName.Text = "LastName";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(276, 105);
            txtFirstName.Multiline = true;
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(368, 41);
            txtFirstName.TabIndex = 7;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(276, 152);
            txtLastName.Multiline = true;
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(368, 35);
            txtLastName.TabIndex = 8;
            // 
            // dgvPerson
            // 
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPerson.Location = new Point(165, 215);
            dgvPerson.Name = "dgvPerson";
            dgvPerson.Size = new Size(525, 186);
            dgvPerson.TabIndex = 9;
            dgvPerson.CellClick += dgvPersonClick;
            // 
            // PersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 462);
            ControlBox = false;
            Controls.Add(dgvPerson);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnBackToMain);
            Controls.Add(btnRefresh);
            Controls.Add(button3);
            Controls.Add(btnUpdate);
            Controls.Add(btnPost);
            Name = "PersonForm";
            Text = "PersonForm";
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPost;
        private Button btnUpdate;
        private Button button3;
        private Button btnRefresh;
        private Button btnBackToMain;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private DataGridView dgvPerson;
    }
}
