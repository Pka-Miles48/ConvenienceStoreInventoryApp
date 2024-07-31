namespace ConvenienceStoreInventoryApp
{
    partial class AddProductForm
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
            lblProductName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            txtProductName = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            btnAddProduct = new Button();
            txtCategory = new TextBox();
            lblCategory = new Label();
            txtDescription = new TextBox();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(32, 52);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(84, 15);
            lblProductName.TabIndex = 0;
            lblProductName.Text = "Product Name";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(32, 101);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(33, 15);
            lblPrice.TabIndex = 1;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(32, 154);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(53, 15);
            lblQuantity.TabIndex = 2;
            lblQuantity.Text = "Quantity";
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(135, 49);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(193, 23);
            txtProductName.TabIndex = 1;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(135, 98);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(193, 23);
            txtPrice.TabIndex = 2;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(135, 151);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(193, 23);
            txtQuantity.TabIndex = 3;
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(47, 341);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(266, 63);
            btnAddProduct.TabIndex = 6;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // txtCategory
            // 
            txtCategory.Location = new Point(135, 213);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(193, 23);
            txtCategory.TabIndex = 4;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(32, 216);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(55, 15);
            lblCategory.TabIndex = 8;
            lblCategory.Text = "Category";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(135, 272);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(193, 23);
            txtDescription.TabIndex = 5;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(32, 275);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 10;
            lblDescription.Text = "Description";
            // 
            // AddProductForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 439);
            Controls.Add(lblDescription);
            Controls.Add(txtDescription);
            Controls.Add(lblCategory);
            Controls.Add(txtCategory);
            Controls.Add(btnAddProduct);
            Controls.Add(txtQuantity);
            Controls.Add(txtPrice);
            Controls.Add(txtProductName);
            Controls.Add(lblQuantity);
            Controls.Add(lblPrice);
            Controls.Add(lblProductName);
            Name = "AddProductForm";
            Text = "AddProductForm";
            Load += AddProductForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductName;
        private Label lblPrice;
        private Label lblQuantity;
        private TextBox txtProductName;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private Button btnAddProduct;
        private TextBox txtCategory;
        private Label lblCategory;
        private TextBox txtDescription;
        private Label lblDescription;
    }
}