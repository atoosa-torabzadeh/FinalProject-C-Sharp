namespace View
{
    partial class ProductForm
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
            dgvProduct = new DataGridView();
            btnPost = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            btnRefresh = new Button();
            btnBackToMain = new Button();
            txtTitle = new TextBox();
            txtUnitPrice = new TextBox();
            txtCode = new TextBox();
            txtQuantity = new TextBox();
            lblTitle = new Label();
            lblPrice = new Label();
            lblCode = new Label();
            lblQuantity = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            SuspendLayout();
            // 
            // dgvProduct
            // 
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProduct.Location = new Point(167, 397);
            dgvProduct.Name = "dgvProduct";
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.Size = new Size(822, 242);
            dgvProduct.TabIndex = 0;
            dgvProduct.CellContentClick += dgvProduct_CellClick;
            // 
            // btnPost
            // 
            btnPost.Location = new Point(12, 52);
            btnPost.Name = "btnPost";
            btnPost.Size = new Size(128, 50);
            btnPost.TabIndex = 1;
            btnPost.Text = "Save";
            btnPost.UseVisualStyleBackColor = true;
            btnPost.Click += btnPost_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(167, 52);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(155, 50);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(375, 52);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(159, 50);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(600, 52);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(219, 50);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // btnBackToMain
            // 
            btnBackToMain.Location = new Point(969, 52);
            btnBackToMain.Name = "btnBackToMain";
            btnBackToMain.Size = new Size(217, 50);
            btnBackToMain.TabIndex = 5;
            btnBackToMain.Text = "بازگشت به صفحه اصلی";
            btnBackToMain.UseVisualStyleBackColor = true;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(167, 135);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(392, 51);
            txtTitle.TabIndex = 6;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.Location = new Point(167, 226);
            txtUnitPrice.Multiline = true;
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(392, 51);
            txtUnitPrice.TabIndex = 7;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(804, 144);
            txtCode.Multiline = true;
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(392, 51);
            txtCode.TabIndex = 8;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(804, 236);
            txtQuantity.Multiline = true;
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(392, 51);
            txtQuantity.TabIndex = 9;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(49, 145);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 10;
            lblTitle.Text = "Title";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(49, 239);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 11;
            lblPrice.Text = "Price";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.Location = new Point(697, 147);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(44, 20);
            lblCode.TabIndex = 12;
            lblCode.Text = "Code";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(697, 257);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 13;
            lblQuantity.Text = "Quantity";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1218, 660);
            Controls.Add(lblQuantity);
            Controls.Add(lblCode);
            Controls.Add(lblPrice);
            Controls.Add(lblTitle);
            Controls.Add(txtQuantity);
            Controls.Add(txtCode);
            Controls.Add(txtUnitPrice);
            Controls.Add(txtTitle);
            Controls.Add(btnBackToMain);
            Controls.Add(btnRefresh);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnPost);
            Controls.Add(dgvProduct);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvProduct;
        private Button btnPost;
        private Button btnUpdate;
        private Button btnDelete;
        private Button btnRefresh;
        private Button btnBackToMain;
        private TextBox txtTitle;
        private TextBox txtUnitPrice;
        private TextBox txtCode;
        private TextBox txtQuantity;
        private Label lblTitle;
        private Label lblPrice;
        private Label lblCode;
        private Label lblQuantity;
    }
}