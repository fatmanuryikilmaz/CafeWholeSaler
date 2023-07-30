namespace CafeWholesaler_prosedursuz_
{
    partial class HomePage
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
            this.BtnProductAddUpdate = new System.Windows.Forms.Button();
            this.BtnOrder = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnOrderDetails = new System.Windows.Forms.Button();
            this.BtnCustomerAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnProductAddUpdate
            // 
            this.BtnProductAddUpdate.BackColor = System.Drawing.Color.Brown;
            this.BtnProductAddUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnProductAddUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnProductAddUpdate.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProductAddUpdate.ForeColor = System.Drawing.Color.Bisque;
            this.BtnProductAddUpdate.Location = new System.Drawing.Point(217, 91);
            this.BtnProductAddUpdate.Name = "BtnProductAddUpdate";
            this.BtnProductAddUpdate.Size = new System.Drawing.Size(352, 37);
            this.BtnProductAddUpdate.TabIndex = 0;
            this.BtnProductAddUpdate.Text = "Ürün Ekle / Güncelle";
            this.BtnProductAddUpdate.UseVisualStyleBackColor = false;
            this.BtnProductAddUpdate.Click += new System.EventHandler(this.BtnProductAddUpdate_Click);
            // 
            // BtnOrder
            // 
            this.BtnOrder.BackColor = System.Drawing.Color.Brown;
            this.BtnOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOrder.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrder.ForeColor = System.Drawing.Color.Bisque;
            this.BtnOrder.Location = new System.Drawing.Point(217, 149);
            this.BtnOrder.Name = "BtnOrder";
            this.BtnOrder.Size = new System.Drawing.Size(352, 37);
            this.BtnOrder.TabIndex = 0;
            this.BtnOrder.Text = "Sipariş Ekle";
            this.BtnOrder.UseVisualStyleBackColor = false;
            this.BtnOrder.Click += new System.EventHandler(this.BtnOrder_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.BackColor = System.Drawing.Color.Brown;
            this.BtnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnExit.Font = new System.Drawing.Font("Modern No. 20", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.ForeColor = System.Drawing.Color.Bisque;
            this.BtnExit.Location = new System.Drawing.Point(12, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(120, 37);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Text = "Çıkış yap";
            this.BtnExit.UseVisualStyleBackColor = false;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnOrderDetails
            // 
            this.BtnOrderDetails.BackColor = System.Drawing.Color.Brown;
            this.BtnOrderDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnOrderDetails.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnOrderDetails.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnOrderDetails.ForeColor = System.Drawing.Color.Bisque;
            this.BtnOrderDetails.Location = new System.Drawing.Point(217, 208);
            this.BtnOrderDetails.Name = "BtnOrderDetails";
            this.BtnOrderDetails.Size = new System.Drawing.Size(352, 37);
            this.BtnOrderDetails.TabIndex = 2;
            this.BtnOrderDetails.Text = "Geçmiş Siparişler";
            this.BtnOrderDetails.UseVisualStyleBackColor = false;
            this.BtnOrderDetails.Click += new System.EventHandler(this.BtnOrderDetails_Click);
            // 
            // BtnCustomerAdd
            // 
            this.BtnCustomerAdd.BackColor = System.Drawing.Color.Brown;
            this.BtnCustomerAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCustomerAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnCustomerAdd.Font = new System.Drawing.Font("Modern No. 20", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCustomerAdd.ForeColor = System.Drawing.Color.Bisque;
            this.BtnCustomerAdd.Location = new System.Drawing.Point(217, 271);
            this.BtnCustomerAdd.Name = "BtnCustomerAdd";
            this.BtnCustomerAdd.Size = new System.Drawing.Size(352, 37);
            this.BtnCustomerAdd.TabIndex = 3;
            this.BtnCustomerAdd.Text = "Müşteri Ekle";
            this.BtnCustomerAdd.UseVisualStyleBackColor = false;
            this.BtnCustomerAdd.Click += new System.EventHandler(this.BtnCustomerAdd_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 354);
            this.Controls.Add(this.BtnCustomerAdd);
            this.Controls.Add(this.BtnOrderDetails);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnOrder);
            this.Controls.Add(this.BtnProductAddUpdate);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnProductAddUpdate;
        private System.Windows.Forms.Button BtnOrder;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnOrderDetails;
        private System.Windows.Forms.Button BtnCustomerAdd;
    }
}