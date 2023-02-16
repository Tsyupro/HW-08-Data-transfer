namespace HW_08_Data_transfer
{
    partial class ReadFile
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
            this.textBoxRead = new System.Windows.Forms.TextBox();
            this.buttonRead = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxRead
            // 
            this.textBoxRead.Location = new System.Drawing.Point(12, 12);
            this.textBoxRead.Multiline = true;
            this.textBoxRead.Name = "textBoxRead";
            this.textBoxRead.Size = new System.Drawing.Size(776, 313);
            this.textBoxRead.TabIndex = 0;
            // 
            // buttonRead
            // 
            this.buttonRead.Location = new System.Drawing.Point(12, 331);
            this.buttonRead.Name = "buttonRead";
            this.buttonRead.Size = new System.Drawing.Size(298, 72);
            this.buttonRead.TabIndex = 1;
            this.buttonRead.Text = "Редагувати";
            this.buttonRead.UseVisualStyleBackColor = true;
            this.buttonRead.Click += new System.EventHandler(this.buttonRead_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(451, 331);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(298, 72);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.Text = "Відмінити";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // ReadFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonRead);
            this.Controls.Add(this.textBoxRead);
            this.Name = "ReadFile";
            this.Text = "ReadFile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonRead;
        public TextBox textBoxRead;
        private Button buttonExit;
    }
}