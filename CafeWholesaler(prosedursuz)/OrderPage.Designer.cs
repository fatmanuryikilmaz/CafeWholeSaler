namespace CafeWholesaler_prosedursuz_
{
    partial class OrderPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.CmbProduct = new System.Windows.Forms.ComboBox();
            this.CmbCustomer = new System.Windows.Forms.ComboBox();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.Fatura = new System.Windows.Forms.ListBox();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnGoHomePage = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Müşteri:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(326, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 22);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ürün Adedi:";
            // 
            // TxtCount
            // 
            this.TxtCount.BackColor = System.Drawing.Color.Bisque;
            this.TxtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCount.ForeColor = System.Drawing.Color.Brown;
            this.TxtCount.Location = new System.Drawing.Point(456, 147);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(172, 22);
            this.TxtCount.TabIndex = 1;
            // 
            // CmbProduct
            // 
            this.CmbProduct.BackColor = System.Drawing.Color.Bisque;
            this.CmbProduct.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbProduct.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbProduct.ForeColor = System.Drawing.Color.Brown;
            this.CmbProduct.FormattingEnabled = true;
            this.CmbProduct.Location = new System.Drawing.Point(456, 14);
            this.CmbProduct.Name = "CmbProduct";
            this.CmbProduct.Size = new System.Drawing.Size(172, 30);
            this.CmbProduct.TabIndex = 2;
            this.CmbProduct.SelectedIndexChanged += new System.EventHandler(this.CmbProduct_SelectedIndexChanged);
            // 
            // CmbCustomer
            // 
            this.CmbCustomer.BackColor = System.Drawing.Color.Bisque;
            this.CmbCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbCustomer.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCustomer.ForeColor = System.Drawing.Color.Brown;
            this.CmbCustomer.FormattingEnabled = true;
            this.CmbCustomer.Location = new System.Drawing.Point(456, 59);
            this.CmbCustomer.Name = "CmbCustomer";
            this.CmbCustomer.Size = new System.Drawing.Size(172, 30);
            this.CmbCustomer.TabIndex = 2;
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Bisque;
            this.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOrder.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.Brown;
            this.BtnOrder.Location = new System.Drawing.Point(456, 204);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(172, 44);
            this.BtnOrder.TabIndex = 3;
            this.BtnOrder.Text = "Sipariş Oluştur";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Bisque;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Brown;
            this.dataGridView1.Location = new System.Drawing.Point(12, 273);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(616, 205);
            this.dataGridView1.TabIndex = 4;
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.Bisque;
            this.BtnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddCustomer.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddCustomer.ForeColor = System.Drawing.Color.Brown;
            this.BtnAddCustomer.Location = new System.Drawing.Point(12, 14);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(164, 43);
            this.BtnAddCustomer.TabIndex = 3;
            this.BtnAddCustomer.Text = "Müşteri Ekle";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.BackColor = System.Drawing.Color.Bisque;
            this.BtnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAdd.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAdd.ForeColor = System.Drawing.Color.Brown;
            this.BtnAdd.Location = new System.Drawing.Point(326, 204);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(124, 44);
            this.BtnAdd.TabIndex = 5;
            this.BtnAdd.Text = "Ürün Ekle";
            this.BtnAdd.UseVisualStyleBackColor = false;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // Fatura
            // 
            this.Fatura.BackColor = System.Drawing.Color.Brown;
            this.Fatura.FormattingEnabled = true;
            this.Fatura.ItemHeight = 16;
            this.Fatura.Location = new System.Drawing.Point(673, 14);
            this.Fatura.Name = "Fatura";
            this.Fatura.Size = new System.Drawing.Size(388, 468);
            this.Fatura.TabIndex = 6;
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.Bisque;
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrice.Enabled = false;
            this.TxtPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.ForeColor = System.Drawing.Color.Brown;
            this.TxtPrice.Location = new System.Drawing.Point(456, 105);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(172, 22);
            this.TxtPrice.TabIndex = 7;
            // 
            // BtnGoHomePage
            // 
            this.BtnGoHomePage.BackColor = System.Drawing.Color.Bisque;
            this.BtnGoHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoHomePage.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoHomePage.ForeColor = System.Drawing.Color.Brown;
            this.BtnGoHomePage.Location = new System.Drawing.Point(12, 70);
            this.BtnGoHomePage.Name = "BtnGoHomePage";
            this.BtnGoHomePage.Size = new System.Drawing.Size(164, 41);
            this.BtnGoHomePage.TabIndex = 8;
            this.BtnGoHomePage.Text = "Ana Sayfa";
            this.BtnGoHomePage.UseVisualStyleBackColor = false;
            this.BtnGoHomePage.Click += new System.EventHandler(this.BtnGoHomePage_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // OrderPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Brown;
            this.ClientSize = new System.Drawing.Size(1077, 493);
            this.Controls.Add(this.BtnGoHomePage);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.Fatura);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.CmbCustomer);
            this.Controls.Add(this.CmbProduct);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OrderPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrderPage";
            this.Load += new System.EventHandler(this.OrderPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.ComboBox CmbProduct;
        private System.Windows.Forms.ComboBox CmbCustomer;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ListBox Fatura;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnGoHomePage;
        private System.Windows.Forms.Label label4;
    }
}