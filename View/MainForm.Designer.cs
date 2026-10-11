namespace View
{
    partial class MainForm
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
            btnOpenPerson = new Button();
            btnOpenProduct = new Button();
            SuspendLayout();
            // 
            // btnOpenPerson
            // 
            btnOpenPerson.Font = new Font("Segoe UI", 14F);
            btnOpenPerson.Location = new Point(111, 107);
            btnOpenPerson.Name = "btnOpenPerson";
            btnOpenPerson.Size = new Size(234, 75);
            btnOpenPerson.TabIndex = 0;
            btnOpenPerson.Text = "مدیریت اشخاص";
            btnOpenPerson.UseVisualStyleBackColor = true;
            btnOpenPerson.Click += btnOpenPerson_Click;
            // 
            // btnOpenProduct
            // 
            btnOpenProduct.Font = new Font("Segoe UI", 14F);
            btnOpenProduct.Location = new Point(410, 107);
            btnOpenProduct.Name = "btnOpenProduct";
            btnOpenProduct.Size = new Size(206, 75);
            btnOpenProduct.TabIndex = 1;
            btnOpenProduct.Text = "مدیریت محصولات";
            btnOpenProduct.UseVisualStyleBackColor = true;
            btnOpenProduct.Click += btnOpenProduct_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnOpenProduct);
            Controls.Add(btnOpenPerson);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOpenPerson;
        private Button btnOpenProduct;
    }
}