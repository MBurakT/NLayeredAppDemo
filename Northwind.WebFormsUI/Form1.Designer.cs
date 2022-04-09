namespace Northwind.WebFormsUI
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
            this.dgwProduct = new System.Windows.Forms.DataGridView();
            this.gbxCategory = new System.Windows.Forms.GroupBox();
            this.cbxCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.gbxProductName = new System.Windows.Forms.GroupBox();
            this.tbxProductName = new System.Windows.Forms.TextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.gbxAddProduct = new System.Windows.Forms.GroupBox();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddCategory = new System.Windows.Forms.Label();
            this.lblAddProductName = new System.Windows.Forms.Label();
            this.lblAddStock = new System.Windows.Forms.Label();
            this.lblAddQuantity = new System.Windows.Forms.Label();
            this.tbxAddProductName = new System.Windows.Forms.TextBox();
            this.tbxAddStock = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxAddQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbxAddCategory = new System.Windows.Forms.ComboBox();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.cbxUpdateCategory = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateQuantity = new System.Windows.Forms.TextBox();
            this.tbxUpdateStock = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.tbxUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateQuantity = new System.Windows.Forms.Label();
            this.lblUpdateStock = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateCategory = new System.Windows.Forms.Label();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).BeginInit();
            this.gbxCategory.SuspendLayout();
            this.gbxProductName.SuspendLayout();
            this.gbxAddProduct.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProduct
            // 
            this.dgwProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProduct.Location = new System.Drawing.Point(12, 205);
            this.dgwProduct.Name = "dgwProduct";
            this.dgwProduct.Size = new System.Drawing.Size(1221, 213);
            this.dgwProduct.TabIndex = 0;
            this.dgwProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProduct_CellClick);
            // 
            // gbxCategory
            // 
            this.gbxCategory.Controls.Add(this.cbxCategory);
            this.gbxCategory.Controls.Add(this.lblCategory);
            this.gbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxCategory.Location = new System.Drawing.Point(12, 12);
            this.gbxCategory.Name = "gbxCategory";
            this.gbxCategory.Size = new System.Drawing.Size(1221, 90);
            this.gbxCategory.TabIndex = 1;
            this.gbxCategory.TabStop = false;
            this.gbxCategory.Text = "Kategori";
            // 
            // cbxCategory
            // 
            this.cbxCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCategory.FormattingEnabled = true;
            this.cbxCategory.Location = new System.Drawing.Point(111, 37);
            this.cbxCategory.Name = "cbxCategory";
            this.cbxCategory.Size = new System.Drawing.Size(224, 28);
            this.cbxCategory.TabIndex = 1;
            this.cbxCategory.SelectedIndexChanged += new System.EventHandler(this.cbxCategory_SelectedIndexChanged);
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(6, 40);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(72, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "Kategori:";
            // 
            // gbxProductName
            // 
            this.gbxProductName.Controls.Add(this.tbxProductName);
            this.gbxProductName.Controls.Add(this.lblProductName);
            this.gbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProductName.Location = new System.Drawing.Point(12, 109);
            this.gbxProductName.Name = "gbxProductName";
            this.gbxProductName.Size = new System.Drawing.Size(1221, 90);
            this.gbxProductName.TabIndex = 2;
            this.gbxProductName.TabStop = false;
            this.gbxProductName.Text = "Ürün Adı";
            // 
            // tbxProductName
            // 
            this.tbxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxProductName.Location = new System.Drawing.Point(111, 41);
            this.tbxProductName.Name = "tbxProductName";
            this.tbxProductName.Size = new System.Drawing.Size(224, 26);
            this.tbxProductName.TabIndex = 1;
            this.tbxProductName.TextChanged += new System.EventHandler(this.tbxProductName_TextChanged);
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(6, 44);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(75, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Ürün Adı:";
            // 
            // gbxAddProduct
            // 
            this.gbxAddProduct.Controls.Add(this.cbxAddCategory);
            this.gbxAddProduct.Controls.Add(this.btnAdd);
            this.gbxAddProduct.Controls.Add(this.tbxAddQuantity);
            this.gbxAddProduct.Controls.Add(this.tbxAddStock);
            this.gbxAddProduct.Controls.Add(this.tbxAddUnitPrice);
            this.gbxAddProduct.Controls.Add(this.tbxAddProductName);
            this.gbxAddProduct.Controls.Add(this.lblAddQuantity);
            this.gbxAddProduct.Controls.Add(this.lblAddStock);
            this.gbxAddProduct.Controls.Add(this.lblAddUnitPrice);
            this.gbxAddProduct.Controls.Add(this.lblAddCategory);
            this.gbxAddProduct.Controls.Add(this.lblAddProductName);
            this.gbxAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAddProduct.Location = new System.Drawing.Point(12, 424);
            this.gbxAddProduct.Name = "gbxAddProduct";
            this.gbxAddProduct.Size = new System.Drawing.Size(490, 270);
            this.gbxAddProduct.TabIndex = 3;
            this.gbxAddProduct.TabStop = false;
            this.gbxAddProduct.Text = "Ekleme";
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUnitPrice.Location = new System.Drawing.Point(6, 110);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(89, 20);
            this.lblAddUnitPrice.TabIndex = 2;
            this.lblAddUnitPrice.Text = "Birim Fiyatı:";
            // 
            // lblAddCategory
            // 
            this.lblAddCategory.AutoSize = true;
            this.lblAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddCategory.Location = new System.Drawing.Point(6, 70);
            this.lblAddCategory.Name = "lblAddCategory";
            this.lblAddCategory.Size = new System.Drawing.Size(72, 20);
            this.lblAddCategory.TabIndex = 1;
            this.lblAddCategory.Text = "Kategori:";
            // 
            // lblAddProductName
            // 
            this.lblAddProductName.AutoSize = true;
            this.lblAddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddProductName.Location = new System.Drawing.Point(6, 30);
            this.lblAddProductName.Name = "lblAddProductName";
            this.lblAddProductName.Size = new System.Drawing.Size(75, 20);
            this.lblAddProductName.TabIndex = 0;
            this.lblAddProductName.Text = "Ürün Adı:";
            // 
            // lblAddStock
            // 
            this.lblAddStock.AutoSize = true;
            this.lblAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddStock.Location = new System.Drawing.Point(6, 150);
            this.lblAddStock.Name = "lblAddStock";
            this.lblAddStock.Size = new System.Drawing.Size(87, 20);
            this.lblAddStock.TabIndex = 3;
            this.lblAddStock.Text = "Stok Adeti:";
            // 
            // lblAddQuantity
            // 
            this.lblAddQuantity.AutoSize = true;
            this.lblAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQuantity.Location = new System.Drawing.Point(6, 190);
            this.lblAddQuantity.Name = "lblAddQuantity";
            this.lblAddQuantity.Size = new System.Drawing.Size(85, 20);
            this.lblAddQuantity.TabIndex = 4;
            this.lblAddQuantity.Text = "Birim Adeti";
            // 
            // tbxAddProductName
            // 
            this.tbxAddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddProductName.Location = new System.Drawing.Point(111, 27);
            this.tbxAddProductName.Name = "tbxAddProductName";
            this.tbxAddProductName.Size = new System.Drawing.Size(370, 26);
            this.tbxAddProductName.TabIndex = 4;
            // 
            // tbxAddStock
            // 
            this.tbxAddStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddStock.Location = new System.Drawing.Point(111, 147);
            this.tbxAddStock.Name = "tbxAddStock";
            this.tbxAddStock.Size = new System.Drawing.Size(370, 26);
            this.tbxAddStock.TabIndex = 7;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(111, 107);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(370, 26);
            this.tbxAddUnitPrice.TabIndex = 6;
            // 
            // tbxAddQuantity
            // 
            this.tbxAddQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddQuantity.Location = new System.Drawing.Point(111, 187);
            this.tbxAddQuantity.Name = "tbxAddQuantity";
            this.tbxAddQuantity.Size = new System.Drawing.Size(370, 26);
            this.tbxAddQuantity.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(10, 219);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(474, 44);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbxAddCategory
            // 
            this.cbxAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxAddCategory.FormattingEnabled = true;
            this.cbxAddCategory.Location = new System.Drawing.Point(111, 67);
            this.cbxAddCategory.Name = "cbxAddCategory";
            this.cbxAddCategory.Size = new System.Drawing.Size(370, 28);
            this.cbxAddCategory.TabIndex = 5;
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.cbxUpdateCategory);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.tbxUpdateStock);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.tbxUpdateProductName);
            this.gbxUpdate.Controls.Add(this.lblUpdateQuantity);
            this.gbxUpdate.Controls.Add(this.lblUpdateStock);
            this.gbxUpdate.Controls.Add(this.lblUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lblUpdateCategory);
            this.gbxUpdate.Controls.Add(this.lblUpdateProductName);
            this.gbxUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(530, 424);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(490, 270);
            this.gbxUpdate.TabIndex = 4;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Güncelleme";
            // 
            // cbxUpdateCategory
            // 
            this.cbxUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxUpdateCategory.FormattingEnabled = true;
            this.cbxUpdateCategory.Location = new System.Drawing.Point(111, 67);
            this.cbxUpdateCategory.Name = "cbxUpdateCategory";
            this.cbxUpdateCategory.Size = new System.Drawing.Size(370, 28);
            this.cbxUpdateCategory.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(10, 219);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(471, 44);
            this.btnUpdate.TabIndex = 9;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateQuantity
            // 
            this.tbxUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateQuantity.Location = new System.Drawing.Point(111, 187);
            this.tbxUpdateQuantity.Name = "tbxUpdateQuantity";
            this.tbxUpdateQuantity.Size = new System.Drawing.Size(370, 26);
            this.tbxUpdateQuantity.TabIndex = 8;
            // 
            // tbxUpdateStock
            // 
            this.tbxUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateStock.Location = new System.Drawing.Point(111, 147);
            this.tbxUpdateStock.Name = "tbxUpdateStock";
            this.tbxUpdateStock.Size = new System.Drawing.Size(370, 26);
            this.tbxUpdateStock.TabIndex = 7;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(111, 107);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(370, 26);
            this.tbxUpdateUnitPrice.TabIndex = 6;
            // 
            // tbxUpdateProductName
            // 
            this.tbxUpdateProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateProductName.Location = new System.Drawing.Point(111, 27);
            this.tbxUpdateProductName.Name = "tbxUpdateProductName";
            this.tbxUpdateProductName.Size = new System.Drawing.Size(370, 26);
            this.tbxUpdateProductName.TabIndex = 4;
            // 
            // lblUpdateQuantity
            // 
            this.lblUpdateQuantity.AutoSize = true;
            this.lblUpdateQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateQuantity.Location = new System.Drawing.Point(6, 190);
            this.lblUpdateQuantity.Name = "lblUpdateQuantity";
            this.lblUpdateQuantity.Size = new System.Drawing.Size(85, 20);
            this.lblUpdateQuantity.TabIndex = 4;
            this.lblUpdateQuantity.Text = "Birim Adeti";
            // 
            // lblUpdateStock
            // 
            this.lblUpdateStock.AutoSize = true;
            this.lblUpdateStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateStock.Location = new System.Drawing.Point(6, 150);
            this.lblUpdateStock.Name = "lblUpdateStock";
            this.lblUpdateStock.Size = new System.Drawing.Size(87, 20);
            this.lblUpdateStock.TabIndex = 3;
            this.lblUpdateStock.Text = "Stok Adeti:";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(6, 110);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(89, 20);
            this.lblUpdateUnitPrice.TabIndex = 2;
            this.lblUpdateUnitPrice.Text = "Birim Fiyatı:";
            // 
            // lblUpdateCategory
            // 
            this.lblUpdateCategory.AutoSize = true;
            this.lblUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateCategory.Location = new System.Drawing.Point(6, 70);
            this.lblUpdateCategory.Name = "lblUpdateCategory";
            this.lblUpdateCategory.Size = new System.Drawing.Size(72, 20);
            this.lblUpdateCategory.TabIndex = 1;
            this.lblUpdateCategory.Text = "Kategori:";
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProductName.Location = new System.Drawing.Point(6, 30);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(75, 20);
            this.lblUpdateProductName.TabIndex = 0;
            this.lblUpdateProductName.Text = "Ürün Adı:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(1026, 424);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(207, 53);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Kaldır";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 705);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAddProduct);
            this.Controls.Add(this.gbxProductName);
            this.Controls.Add(this.gbxCategory);
            this.Controls.Add(this.dgwProduct);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProduct)).EndInit();
            this.gbxCategory.ResumeLayout(false);
            this.gbxCategory.PerformLayout();
            this.gbxProductName.ResumeLayout(false);
            this.gbxProductName.PerformLayout();
            this.gbxAddProduct.ResumeLayout(false);
            this.gbxAddProduct.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProduct;
        private System.Windows.Forms.GroupBox gbxCategory;
        private System.Windows.Forms.ComboBox cbxCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.GroupBox gbxProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox tbxProductName;
        private System.Windows.Forms.GroupBox gbxAddProduct;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddCategory;
        private System.Windows.Forms.Label lblAddProductName;
        private System.Windows.Forms.Label lblAddStock;
        private System.Windows.Forms.Label lblAddQuantity;
        private System.Windows.Forms.TextBox tbxAddQuantity;
        private System.Windows.Forms.TextBox tbxAddStock;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.TextBox tbxAddProductName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbxAddCategory;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.ComboBox cbxUpdateCategory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateQuantity;
        private System.Windows.Forms.TextBox tbxUpdateStock;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.TextBox tbxUpdateProductName;
        private System.Windows.Forms.Label lblUpdateQuantity;
        private System.Windows.Forms.Label lblUpdateStock;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateCategory;
        private System.Windows.Forms.Label lblUpdateProductName;
        private System.Windows.Forms.Button btnDelete;
    }
}

