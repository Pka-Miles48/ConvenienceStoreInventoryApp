namespace ConvenienceStoreInventoryApp
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnLookupProduct = new Button();
            btnProcessSale = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 59);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 123);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 1;
            label2.Text = "Category:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(56, 187);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 2;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(56, 251);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 3;
            label4.Text = "Stock:";
            // 
            // txtName
            // 
            txtName.Location = new Point(150, 56);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(150, 120);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 5;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(150, 184);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 6;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(150, 248);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 7;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(314, 44);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(103, 45);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(314, 107);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(103, 45);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnLookupProduct
            // 
            btnLookupProduct.Location = new Point(314, 170);
            btnLookupProduct.Name = "btnLookupProduct";
            btnLookupProduct.Size = new Size(103, 45);
            btnLookupProduct.TabIndex = 10;
            btnLookupProduct.Text = "Lookup Product";
            btnLookupProduct.UseVisualStyleBackColor = true;
            btnLookupProduct.Click += btnLookupProduct_Click;
            // 
            // btnProcessSale
            // 
            btnProcessSale.Location = new Point(314, 233);
            btnProcessSale.Name = "btnProcessSale";
            btnProcessSale.Size = new Size(103, 45);
            btnProcessSale.TabIndex = 11;
            btnProcessSale.Text = "Process Sale";
            btnProcessSale.UseVisualStyleBackColor = true;
            btnProcessSale.Click += btnProcessSale_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 323);
            Controls.Add(btnProcessSale);
            Controls.Add(btnLookupProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtCategory;
        private TextBox txtPrice;
        private TextBox txtStock;
        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnLookupProduct;
        private Button btnProcessSale;
    }
}
