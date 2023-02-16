namespace HW_08_Data_transfer
{
    partial class ComputerShop
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
            this.listBoxShop = new System.Windows.Forms.ListBox();
            this.listBoxMyElement = new System.Windows.Forms.ListBox();
            this.Price = new System.Windows.Forms.Button();
            this.priceElement = new System.Windows.Forms.Button();
            this.addItem = new System.Windows.Forms.Button();
            this.InfoItem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonReadItem = new System.Windows.Forms.Button();
            this.buttonPassword = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBoxShop
            // 
            this.listBoxShop.FormattingEnabled = true;
            this.listBoxShop.ItemHeight = 15;
            this.listBoxShop.Location = new System.Drawing.Point(12, 14);
            this.listBoxShop.Name = "listBoxShop";
            this.listBoxShop.Size = new System.Drawing.Size(560, 214);
            this.listBoxShop.TabIndex = 0;
            // 
            // listBoxMyElement
            // 
            this.listBoxMyElement.FormattingEnabled = true;
            this.listBoxMyElement.ItemHeight = 15;
            this.listBoxMyElement.Location = new System.Drawing.Point(677, 12);
            this.listBoxMyElement.Name = "listBoxMyElement";
            this.listBoxMyElement.Size = new System.Drawing.Size(541, 214);
            this.listBoxMyElement.TabIndex = 1;
            // 
            // Price
            // 
            this.Price.Location = new System.Drawing.Point(884, 232);
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(172, 39);
            this.Price.TabIndex = 2;
            this.Price.Text = "Ціна";
            this.Price.UseVisualStyleBackColor = true;
            this.Price.Click += new System.EventHandler(this.Price_Click);
            // 
            // priceElement
            // 
            this.priceElement.Location = new System.Drawing.Point(12, 234);
            this.priceElement.Name = "priceElement";
            this.priceElement.Size = new System.Drawing.Size(271, 82);
            this.priceElement.TabIndex = 3;
            this.priceElement.Text = "Ціна Товару";
            this.priceElement.UseVisualStyleBackColor = true;
            this.priceElement.Click += new System.EventHandler(this.priceElement_Click);
            // 
            // addItem
            // 
            this.addItem.Location = new System.Drawing.Point(12, 322);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(271, 75);
            this.addItem.TabIndex = 4;
            this.addItem.Text = "Добавити";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // InfoItem
            // 
            this.InfoItem.Location = new System.Drawing.Point(304, 234);
            this.InfoItem.Name = "InfoItem";
            this.InfoItem.Size = new System.Drawing.Size(268, 82);
            this.InfoItem.TabIndex = 5;
            this.InfoItem.Text = "Інформація";
            this.InfoItem.UseVisualStyleBackColor = true;
            this.InfoItem.Click += new System.EventHandler(this.InfoItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(24, 452);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Admin Password";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(235, 461);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 7;
            // 
            // buttonReadItem
            // 
            this.buttonReadItem.Location = new System.Drawing.Point(24, 517);
            this.buttonReadItem.Name = "buttonReadItem";
            this.buttonReadItem.Size = new System.Drawing.Size(179, 72);
            this.buttonReadItem.TabIndex = 8;
            this.buttonReadItem.Text = "Редагувати елемент";
            this.buttonReadItem.UseVisualStyleBackColor = true;
            this.buttonReadItem.Click += new System.EventHandler(this.buttonReadItem_Click);
            // 
            // buttonPassword
            // 
            this.buttonPassword.Location = new System.Drawing.Point(366, 460);
            this.buttonPassword.Name = "buttonPassword";
            this.buttonPassword.Size = new System.Drawing.Size(97, 24);
            this.buttonPassword.TabIndex = 9;
            this.buttonPassword.Text = "Enter";
            this.buttonPassword.UseVisualStyleBackColor = true;
            this.buttonPassword.Click += new System.EventHandler(this.buttonPassword_Click);
            // 
            // ComputerShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 635);
            this.Controls.Add(this.buttonPassword);
            this.Controls.Add(this.buttonReadItem);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InfoItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.priceElement);
            this.Controls.Add(this.Price);
            this.Controls.Add(this.listBoxMyElement);
            this.Controls.Add(this.listBoxShop);
            this.Name = "ComputerShop";
            this.Text = "ComputerShop";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxShop;
        private ListBox listBoxMyElement;
        private Button Price;
        private Button priceElement;
        private Button addItem;
        private Button InfoItem;
        private Label label1;
        private TextBox textBox1;
        private Button buttonReadItem;
        private Button buttonPassword;
    }
}