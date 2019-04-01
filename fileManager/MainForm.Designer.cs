/*
 * Created by SharpDevelop.
 * User: administrator
 * Date: 2017-10-14
 * Time: 16:23
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace fileManager
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.cBoxDisks = new System.Windows.Forms.ComboBox();
            this.listFiles = new System.Windows.Forms.ListBox();
            this.btnSearchFile = new System.Windows.Forms.Button();
            this.btnDelFile = new System.Windows.Forms.Button();
            this.btnAddFile = new System.Windows.Forms.Button();
            this.btnAddFolder = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPath = new System.Windows.Forms.Label();
            this.btnLastDir = new System.Windows.Forms.Button();
            this.txtNewFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRename = new System.Windows.Forms.Button();
            this.txtRename = new System.Windows.Forms.TextBox();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.gBoxAttri = new System.Windows.Forms.GroupBox();
            this.btnFullCtrl = new System.Windows.Forms.Button();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.gBoxAttri.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxDisks
            // 
            this.cBoxDisks.FormattingEnabled = true;
            this.cBoxDisks.Location = new System.Drawing.Point(244, 17);
            this.cBoxDisks.Name = "cBoxDisks";
            this.cBoxDisks.Size = new System.Drawing.Size(125, 20);
            this.cBoxDisks.TabIndex = 0;
            this.cBoxDisks.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
            // 
            // listFiles
            // 
            this.listFiles.FormattingEnabled = true;
            this.listFiles.ItemHeight = 12;
            this.listFiles.Location = new System.Drawing.Point(12, 86);
            this.listFiles.Name = "listFiles";
            this.listFiles.Size = new System.Drawing.Size(252, 280);
            this.listFiles.TabIndex = 2;
            this.listFiles.Click += new System.EventHandler(this.listFiles_Click);
            this.listFiles.DoubleClick += new System.EventHandler(this.ListFilesDoubleClick);
            // 
            // btnSearchFile
            // 
            this.btnSearchFile.Location = new System.Drawing.Point(420, 106);
            this.btnSearchFile.Name = "btnSearchFile";
            this.btnSearchFile.Size = new System.Drawing.Size(75, 23);
            this.btnSearchFile.TabIndex = 3;
            this.btnSearchFile.Text = "查找文件";
            this.btnSearchFile.UseVisualStyleBackColor = true;
            this.btnSearchFile.Click += new System.EventHandler(this.btnSearchFile_Click);
            // 
            // btnDelFile
            // 
            this.btnDelFile.Location = new System.Drawing.Point(326, 329);
            this.btnDelFile.Name = "btnDelFile";
            this.btnDelFile.Size = new System.Drawing.Size(75, 23);
            this.btnDelFile.TabIndex = 4;
            this.btnDelFile.Text = "删除文件";
            this.btnDelFile.UseVisualStyleBackColor = true;
            this.btnDelFile.Click += new System.EventHandler(this.btnDelFile_Click);
            // 
            // btnAddFile
            // 
            this.btnAddFile.Location = new System.Drawing.Point(420, 219);
            this.btnAddFile.Name = "btnAddFile";
            this.btnAddFile.Size = new System.Drawing.Size(75, 23);
            this.btnAddFile.TabIndex = 5;
            this.btnAddFile.Text = "新建文件";
            this.btnAddFile.UseVisualStyleBackColor = true;
            this.btnAddFile.Click += new System.EventHandler(this.btnAddFile_Click);
            // 
            // btnAddFolder
            // 
            this.btnAddFolder.Location = new System.Drawing.Point(420, 159);
            this.btnAddFolder.Name = "btnAddFolder";
            this.btnAddFolder.Size = new System.Drawing.Size(75, 23);
            this.btnAddFolder.TabIndex = 6;
            this.btnAddFolder.Text = "新建文件夹";
            this.btnAddFolder.UseVisualStyleBackColor = true;
            this.btnAddFolder.Click += new System.EventHandler(this.btnAddFolder_Click);
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(275, 106);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(139, 21);
            this.txtFileName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "当前目录:";
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Location = new System.Drawing.Point(120, 68);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(41, 12);
            this.lblPath.TabIndex = 9;
            this.lblPath.Text = "label2";
            // 
            // btnLastDir
            // 
            this.btnLastDir.Location = new System.Drawing.Point(12, 60);
            this.btnLastDir.Name = "btnLastDir";
            this.btnLastDir.Size = new System.Drawing.Size(34, 23);
            this.btnLastDir.TabIndex = 10;
            this.btnLastDir.Text = "←";
            this.btnLastDir.UseVisualStyleBackColor = true;
            this.btnLastDir.Click += new System.EventHandler(this.BtnLastDirClick);
            // 
            // txtNewFolder
            // 
            this.txtNewFolder.Location = new System.Drawing.Point(275, 161);
            this.txtNewFolder.Name = "txtNewFolder";
            this.txtNewFolder.Size = new System.Drawing.Size(139, 21);
            this.txtNewFolder.TabIndex = 11;
            this.txtNewFolder.Text = "新建文件夹";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(153, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 12;
            this.label2.Text = "当前磁盘：";
            // 
            // btnRename
            // 
            this.btnRename.Location = new System.Drawing.Point(420, 278);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(75, 23);
            this.btnRename.TabIndex = 13;
            this.btnRename.Text = "重命名";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // txtRename
            // 
            this.txtRename.Location = new System.Drawing.Point(275, 280);
            this.txtRename.Name = "txtRename";
            this.txtRename.Size = new System.Drawing.Size(139, 21);
            this.txtRename.TabIndex = 14;
            // 
            // txtNewFile
            // 
            this.txtNewFile.Location = new System.Drawing.Point(275, 221);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(139, 21);
            this.txtNewFile.TabIndex = 15;
            // 
            // gBoxAttri
            // 
            this.gBoxAttri.Controls.Add(this.btnFullCtrl);
            this.gBoxAttri.Controls.Add(this.btnWrite);
            this.gBoxAttri.Controls.Add(this.btnRead);
            this.gBoxAttri.Location = new System.Drawing.Point(12, 377);
            this.gBoxAttri.Name = "gBoxAttri";
            this.gBoxAttri.Size = new System.Drawing.Size(483, 65);
            this.gBoxAttri.TabIndex = 16;
            this.gBoxAttri.TabStop = false;
            this.gBoxAttri.Text = "权限控制";
            // 
            // btnFullCtrl
            // 
            this.btnFullCtrl.Location = new System.Drawing.Point(350, 24);
            this.btnFullCtrl.Name = "btnFullCtrl";
            this.btnFullCtrl.Size = new System.Drawing.Size(127, 23);
            this.btnFullCtrl.TabIndex = 2;
            this.btnFullCtrl.Text = "更改权限:完全控制";
            this.btnFullCtrl.UseVisualStyleBackColor = true;
            this.btnFullCtrl.Click += new System.EventHandler(this.btnFullCtrl_Click);
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(185, 24);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(95, 23);
            this.btnWrite.TabIndex = 1;
            this.btnWrite.Text = "更改权限:可写";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(6, 24);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(97, 23);
            this.btnRead.TabIndex = 0;
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(507, 454);
            this.Controls.Add(this.gBoxAttri);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.txtRename);
            this.Controls.Add(this.btnRename);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewFolder);
            this.Controls.Add(this.btnLastDir);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.btnAddFolder);
            this.Controls.Add(this.btnAddFile);
            this.Controls.Add(this.btnDelFile);
            this.Controls.Add(this.btnSearchFile);
            this.Controls.Add(this.listFiles);
            this.Controls.Add(this.cBoxDisks);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "031540411-操作系统模拟文件管理系统";
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.gBoxAttri.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.Button btnLastDir;
		private System.Windows.Forms.Label lblPath;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtFileName;
		private System.Windows.Forms.Button btnAddFolder;
		private System.Windows.Forms.Button btnAddFile;
		private System.Windows.Forms.Button btnDelFile;
		private System.Windows.Forms.Button btnSearchFile;
		private System.Windows.Forms.ListBox listFiles;
		private System.Windows.Forms.ComboBox cBoxDisks;
        private System.Windows.Forms.TextBox txtNewFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.TextBox txtRename;
        private System.Windows.Forms.TextBox txtNewFile;
        private System.Windows.Forms.GroupBox gBoxAttri;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnFullCtrl;
        private System.Windows.Forms.Button btnWrite;
    }
}
