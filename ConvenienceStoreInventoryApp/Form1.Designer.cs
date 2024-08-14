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
            btnAddProduct = new Button();
            btnUpdateProduct = new Button();
            btnLookupProduct = new Button();
            btnProcessSale = new Button();
            lstProducts = new ListBox();
            SuspendLayout();
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
            ClientSize = new Size(486, 323);
            Controls.Add(lstProducts);
            Controls.Add(btnProcessSale);
            Controls.Add(btnLookupProduct);
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
        private Button btnLookupProduct;
        private Button btnProcessSale;
        private ListBox lstProducts;
    }
}
