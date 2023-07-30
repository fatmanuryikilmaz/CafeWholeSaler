namespace CafeWholesaler_prosedursuz_
{
    partial class Product
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbCategory = new System.Windows.Forms.ComboBox();
            this.BtnAddUpdate = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtPrice = new System.Windows.Forms.TextBox();
            this.BtnGoHomePage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Brown;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Bisque;
            this.dataGridView1.Location = new System.Drawing.Point(12, 297);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(666, 173);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(373, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün Adı:";
            // 
            // TxtName
            // 
            this.TxtName.BackColor = System.Drawing.Color.Firebrick;
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.ForeColor = System.Drawing.Color.Bisque;
            this.TxtName.Location = new System.Drawing.Point(496, 148);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(182, 22);
            this.TxtName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ürün Adedi:";
            // 
            // TxtCount
            // 
            this.TxtCount.BackColor = System.Drawing.Color.Firebrick;
            this.TxtCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtCount.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCount.ForeColor = System.Drawing.Color.Bisque;
            this.TxtCount.Location = new System.Drawing.Point(496, 189);
            this.TxtCount.Name = "TxtCount";
            this.TxtCount.Size = new System.Drawing.Size(182, 22);
            this.TxtCount.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(381, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kategori:";
            // 
            // CmbCategory
            // 
            this.CmbCategory.BackColor = System.Drawing.Color.Firebrick;
            this.CmbCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CmbCategory.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbCategory.ForeColor = System.Drawing.Color.Bisque;
            this.CmbCategory.FormattingEnabled = true;
            this.CmbCategory.Items.AddRange(new object[] {
            "Kahveler",
            "Çaylar",
            "Tatlılar",
            "tuzlular"});
            this.CmbCategory.Location = new System.Drawing.Point(496, 102);
            this.CmbCategory.Name = "CmbCategory";
            this.CmbCategory.Size = new System.Drawing.Size(182, 30);
            this.CmbCategory.TabIndex = 3;
            // 
            // BtnAddUpdate
            // 
            this.BtnAddUpdate.BackColor = System.Drawing.Color.Brown;
            this.BtnAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnAddUpdate.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddUpdate.ForeColor = System.Drawing.Color.Bisque;
            this.BtnAddUpdate.Location = new System.Drawing.Point(484, 236);
            this.BtnAddUpdate.Name = "BtnAddUpdate";
            this.BtnAddUpdate.Size = new System.Drawing.Size(194, 31);
            this.BtnAddUpdate.TabIndex = 4;
            this.BtnAddUpdate.Text = "Ekle / Güncelle";
            this.BtnAddUpdate.UseVisualStyleBackColor = false;
            this.BtnAddUpdate.Click += new System.EventHandler(this.BtnAddUpdate_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.BackColor = System.Drawing.Color.Brown;
            this.BtnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnDelete.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDelete.ForeColor = System.Drawing.Color.Bisque;
            this.BtnDelete.Location = new System.Drawing.Point(359, 236);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 31);
            this.BtnDelete.TabIndex = 5;
            this.BtnDelete.Text = "Sil";
            this.BtnDelete.UseVisualStyleBackColor = false;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ürün Fiyatı:";
            // 
            // TxtPrice
            // 
            this.TxtPrice.BackColor = System.Drawing.Color.Firebrick;
            this.TxtPrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPrice.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtPrice.ForeColor = System.Drawing.Color.Bisque;
            this.TxtPrice.Location = new System.Drawing.Point(496, 65);
            this.TxtPrice.Name = "TxtPrice";
            this.TxtPrice.Size = new System.Drawing.Size(182, 22);
            this.TxtPrice.TabIndex = 2;
            // 
            // BtnGoHomePage
            // 
            this.BtnGoHomePage.BackColor = System.Drawing.Color.Brown;
            this.BtnGoHomePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnGoHomePage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnGoHomePage.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGoHomePage.ForeColor = System.Drawing.Color.Bisque;
            this.BtnGoHomePage.Location = new System.Drawing.Point(12, 12);
            this.BtnGoHomePage.Name = "BtnGoHomePage";
            this.BtnGoHomePage.Size = new System.Drawing.Size(141, 31);
            this.BtnGoHomePage.TabIndex = 6;
            this.BtnGoHomePage.Text = "Ana Sayfa";
            this.BtnGoHomePage.UseVisualStyleBackColor = false;
            this.BtnGoHomePage.Click += new System.EventHandler(this.BtnGoHomePage_Click);
            // 
            // Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(696, 482);
            this.Controls.Add(this.BtnGoHomePage);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAddUpdate);
            this.Controls.Add(this.CmbCategory);
            this.Controls.Add(this.TxtPrice);
            this.Controls.Add(this.TxtCount);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Product";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product";
            this.Load += new System.EventHandler(this.Product_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbCategory;
        private System.Windows.Forms.Button BtnAddUpdate;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtPrice;
        private System.Windows.Forms.Button BtnGoHomePage;
    }
}