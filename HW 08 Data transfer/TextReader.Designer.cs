namespace HW_08_Data_transfer
{
    partial class TextReader
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonOpentxt = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(776, 349);
            this.textBox1.TabIndex = 0;
            // 
            // buttonOpentxt
            // 
            this.buttonOpentxt.Location = new System.Drawing.Point(43, 367);
            this.buttonOpentxt.Name = "buttonOpentxt";
            this.buttonOpentxt.Size = new System.Drawing.Size(229, 51);
            this.buttonOpentxt.TabIndex = 1;
            this.buttonOpentxt.Text = "Open";
            this.buttonOpentxt.UseVisualStyleBackColor = true;
            this.buttonOpentxt.Click += new System.EventHandler(this.buttonOpentxt_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(486, 367);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(229, 51);
            this.buttonReadFile.TabIndex = 2;
            this.buttonReadFile.Text = "ReadFile";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // TextReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonReadFile);
            this.Controls.Add(this.buttonOpentxt);
            this.Controls.Add(this.textBox1);
            this.Name = "TextReader";
            this.Text = "TextReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button buttonOpentxt;
        private Button buttonReadFile;
        public TextBox textBox1;
    }
}