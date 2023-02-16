namespace HW_08_Data_transfer
{
    partial class SearchingForm
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
            this.patchPapka = new System.Windows.Forms.Label();
            this.textBoxPatchPapka = new System.Windows.Forms.TextBox();
            this.openPatch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxType = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // patchPapka
            // 
            this.patchPapka.AutoSize = true;
            this.patchPapka.Location = new System.Drawing.Point(105, 69);
            this.patchPapka.Name = "patchPapka";
            this.patchPapka.Size = new System.Drawing.Size(89, 15);
            this.patchPapka.TabIndex = 0;
            this.patchPapka.Text = "Шлях до папки";
            // 
            // textBoxPatchPapka
            // 
            this.textBoxPatchPapka.Location = new System.Drawing.Point(209, 66);
            this.textBoxPatchPapka.Name = "textBoxPatchPapka";
            this.textBoxPatchPapka.ReadOnly = true;
            this.textBoxPatchPapka.Size = new System.Drawing.Size(236, 23);
            this.textBoxPatchPapka.TabIndex = 1;
            // 
            // openPatch
            // 
            this.openPatch.Location = new System.Drawing.Point(451, 66);
            this.openPatch.Name = "openPatch";
            this.openPatch.Size = new System.Drawing.Size(75, 23);
            this.openPatch.TabIndex = 2;
            this.openPatch.Text = "Open";
            this.openPatch.UseVisualStyleBackColor = true;
            this.openPatch.Click += new System.EventHandler(this.openPatch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип файлу ( наприклад \"*.doc\" )";
            // 
            // textBoxType
            // 
            this.textBoxType.Location = new System.Drawing.Point(209, 103);
            this.textBoxType.Name = "textBoxType";
            this.textBoxType.Size = new System.Drawing.Size(236, 23);
            this.textBoxType.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(257, 157);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(118, 23);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Пошук";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // SearchingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 208);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openPatch);
            this.Controls.Add(this.textBoxPatchPapka);
            this.Controls.Add(this.patchPapka);
            this.Name = "SearchingForm";
            this.Text = "SearchingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label patchPapka;
        private TextBox textBoxPatchPapka;
        private Button openPatch;
        private Label label1;
        private TextBox textBoxType;
        private Button buttonSearch;
    }
}