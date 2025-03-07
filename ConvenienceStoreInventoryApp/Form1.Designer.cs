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
            label5 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            txtName = new TextBox();
            txtCategory = new TextBox();
            txtPrice = new TextBox();
            txtStock = new TextBox();
            txtQuantity = new TextBox();
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnLookupProduct = new Button();
            btnProcessSale = new Button();
            btnTotalPrice = new Button();
            lstProducts = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(51, 32);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "Id:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 84);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 1;
            label2.Text = "Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(51, 136);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(51, 188);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 3;
            label4.Text = "Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(51, 240);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 12;
            label5.Text = "Stock:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 292);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 14;
            label6.Text = "Quantity:";
            // 
            // txtId
            // 
            txtId.Location = new Point(155, 24);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 4;
            // 
            // txtName
            // 
            txtName.Location = new Point(155, 76);
            txtName.Name = "txtName";
            txtName.Size = new Size(100, 23);
            txtName.TabIndex = 5;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(155, 128);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(100, 23);
            txtCategory.TabIndex = 6;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(155, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(100, 23);
            txtPrice.TabIndex = 7;
            // 
            // txtStock
            // 
            txtStock.Location = new Point(155, 232);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(100, 23);
            txtStock.TabIndex = 13;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(155, 284);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(100, 23);
            txtQuantity.TabIndex = 15;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(312, 64);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(103, 45);
            btnAddProduct.TabIndex = 8;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(312, 116);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(103, 45);
            btnUpdateProduct.TabIndex = 9;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnLookupProduct
            // 
            btnLookupProduct.Location = new Point(312, 168);
            btnLookupProduct.Name = "btnLookupProduct";
            btnLookupProduct.Size = new Size(103, 45);
            btnLookupProduct.TabIndex = 10;
            btnLookupProduct.Text = "Lookup Product";
            btnLookupProduct.UseVisualStyleBackColor = true;
            btnLookupProduct.Click += btnLookupProduct_Click;
            // 
            // btnProcessSale
            // 
            btnProcessSale.Location = new Point(312, 220);
            btnProcessSale.Name = "btnProcessSale";
            btnProcessSale.Size = new Size(103, 45);
            btnProcessSale.TabIndex = 11;
            btnProcessSale.Text = "Process Sale";
            btnProcessSale.UseVisualStyleBackColor = true;
            btnProcessSale.Click += btnProcessSale_Click;
            // 
            // btnTotalPrice
            // 
            btnTotalPrice.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTotalPrice.Location = new Point(308, 252);
            btnTotalPrice.Name = "btnTotalPrice";
            btnTotalPrice.Size = new Size(103, 45);
            btnTotalPrice.TabIndex = 16;
            btnTotalPrice.Text = "Total Price";
            btnTotalPrice.UseVisualStyleBackColor = true;
            btnTotalPrice.Click += btnTotalPrice_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(22, 44);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(263, 214);
            lstProducts.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(486, 331);
            Controls.Add(btnTotalPrice);
            Controls.Add(txtQuantity);
            Controls.Add(label6);
            Controls.Add(txtStock);
            Controls.Add(label5);
            Controls.Add(btnProcessSale);
            Controls.Add(btnLookupProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(txtPrice);
            Controls.Add(txtCategory);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lstProducts);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
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
        private TextBox txtId;
        private TextBox txtName;
