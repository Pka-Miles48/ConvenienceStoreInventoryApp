namespace ConvenienceStoreInventoryApp
{
    partial class Form1
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
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnRemoveProduct = new Button();
            lstProducts = new ListBox();
            SuspendLayout();
            // 
            // btnAddProduct
            // 
            btnAddProduct.Location = new Point(30, 37);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(120, 56);
            btnAddProduct.TabIndex = 0;
            btnAddProduct.Text = "Add Product";
            btnAddProduct.UseVisualStyleBackColor = true;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnUpdateProduct
            // 
            btnUpdateProduct.Location = new Point(30, 115);
            btnUpdateProduct.Name = "btnUpdateProduct";
            btnUpdateProduct.Size = new Size(120, 50);
            btnUpdateProduct.TabIndex = 1;
            btnUpdateProduct.Text = "Update Product";
            btnUpdateProduct.UseVisualStyleBackColor = true;
            btnUpdateProduct.Click += btnUpdateProduct_Click;
            // 
            // btnRemoveProduct
            // 
            btnRemoveProduct.Location = new Point(30, 189);
            btnRemoveProduct.Name = "btnRemoveProduct";
            btnRemoveProduct.Size = new Size(120, 47);
            btnRemoveProduct.TabIndex = 2;
            btnRemoveProduct.Text = "Remove Product";
            btnRemoveProduct.UseVisualStyleBackColor = true;
            btnRemoveProduct.Click += btnRemoveProduct_Click;
            // 
            // lstProducts
            // 
            lstProducts.FormattingEnabled = true;
            lstProducts.ItemHeight = 15;
            lstProducts.Location = new Point(231, 46);
            lstProducts.Name = "lstProducts";
            lstProducts.Size = new Size(649, 289);
            lstProducts.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 432);
            Controls.Add(lstProducts);
            Controls.Add(btnRemoveProduct);
            Controls.Add(btnUpdateProduct);
            Controls.Add(btnAddProduct);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnAddProduct;
        private Button btnUpdateProduct;
        private Button btnRemoveProduct;
        private ListBox lstProducts;
    }
}