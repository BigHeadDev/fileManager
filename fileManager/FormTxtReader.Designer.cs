namespace fileManager
{
    partial class FormTxtReader
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTxtReader));
            this.txtReader = new System.Windows.Forms.TextBox();
            this.btnTxtSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtReader
            // 
            this.txtReader.BackColor = System.Drawing.SystemColors.Menu;
            this.txtReader.Font = new System.Drawing.Font("楷体", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReader.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtReader.Location = new System.Drawing.Point(3, 1);
            this.txtReader.Multiline = true;
            this.txtReader.Name = "txtReader";
            this.txtReader.Size = new System.Drawing.Size(413, 329);
            this.txtReader.TabIndex = 0;
            // 
            // btnTxtSave
            // 
            this.btnTxtSave.Location = new System.Drawing.Point(166, 339);
            this.btnTxtSave.Name = "btnTxtSave";
            this.btnTxtSave.Size = new System.Drawing.Size(75, 23);
            this.btnTxtSave.TabIndex = 1;
            this.btnTxtSave.Text = "保存文件";
            this.btnTxtSave.UseVisualStyleBackColor = true;
            this.btnTxtSave.Click += new System.EventHandler(this.btnTxtSave_Click);
            // 
            // FormTxtReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 374);
            this.Controls.Add(this.btnTxtSave);
            this.Controls.Add(this.txtReader);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormTxtReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormTxtReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtReader;
        private System.Windows.Forms.Button btnTxtSave;
    }
}