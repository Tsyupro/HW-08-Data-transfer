namespace HW_08_Data_transfer
{
    partial class StartProgram
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
            this.search = new System.Windows.Forms.Button();
            this.ComputerOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(227, 69);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(252, 62);
            this.search.TabIndex = 0;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // ComputerOpen
            // 
            this.ComputerOpen.Location = new System.Drawing.Point(227, 137);
            this.ComputerOpen.Name = "ComputerOpen";
            this.ComputerOpen.Size = new System.Drawing.Size(252, 45);
            this.ComputerOpen.TabIndex = 1;
            this.ComputerOpen.Text = "Computer";
            this.ComputerOpen.UseVisualStyleBackColor = true;
            this.ComputerOpen.Click += new System.EventHandler(this.ComputerOpen_Click);
            // 
            // StartProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ComputerOpen);
            this.Controls.Add(this.search);
            this.Name = "StartProgram";
            this.Text = "StartProgram";
            this.ResumeLayout(false);

        }

        #endregion

        private Button search;
        private Button ComputerOpen;
    }
}