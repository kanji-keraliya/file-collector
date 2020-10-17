namespace FileCollector
{
    partial class frmCollectFiles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCollectFiles));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkSearch = new System.Windows.Forms.CheckBox();
            this.txtFileNames = new System.Windows.Forms.RichTextBox();
            this.btnRename = new System.Windows.Forms.Button();
            this.btnMoveFiles = new System.Windows.Forms.Button();
            this.txtFileExt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDestinationPath = new System.Windows.Forms.TextBox();
            this.txtFileDirectoryPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCollect = new System.Windows.Forms.Button();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkSearch);
            this.groupBox2.Controls.Add(this.txtFileNames);
            this.groupBox2.Controls.Add(this.btnRename);
            this.groupBox2.Controls.Add(this.btnMoveFiles);
            this.groupBox2.Controls.Add(this.txtFileExt);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtDestinationPath);
            this.groupBox2.Controls.Add(this.txtFileDirectoryPath);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnCollect);
            this.groupBox2.Location = new System.Drawing.Point(5, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(743, 412);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // chkSearch
            // 
            this.chkSearch.AutoSize = true;
            this.chkSearch.Checked = true;
            this.chkSearch.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSearch.Location = new System.Drawing.Point(142, 90);
            this.chkSearch.Name = "chkSearch";
            this.chkSearch.Size = new System.Drawing.Size(229, 17);
            this.chkSearch.TabIndex = 16;
            this.chkSearch.Text = "Search in directory if not exist at exact path";
            this.chkSearch.UseVisualStyleBackColor = true;
            // 
            // txtFileNames
            // 
            this.txtFileNames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileNames.Location = new System.Drawing.Point(7, 111);
            this.txtFileNames.Name = "txtFileNames";
            this.txtFileNames.Size = new System.Drawing.Size(730, 263);
            this.txtFileNames.TabIndex = 15;
            this.txtFileNames.Text = "";
            this.txtFileNames.WordWrap = false;
            // 
            // btnRename
            // 
            this.btnRename.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRename.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnRename.Location = new System.Drawing.Point(290, 382);
            this.btnRename.Name = "btnRename";
            this.btnRename.Size = new System.Drawing.Size(145, 23);
            this.btnRename.TabIndex = 14;
            this.btnRename.Text = "Rename Files";
            this.btnRename.UseVisualStyleBackColor = true;
            this.btnRename.Click += new System.EventHandler(this.btnRename_Click);
            // 
            // btnMoveFiles
            // 
            this.btnMoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMoveFiles.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnMoveFiles.Location = new System.Drawing.Point(441, 382);
            this.btnMoveFiles.Name = "btnMoveFiles";
            this.btnMoveFiles.Size = new System.Drawing.Size(145, 23);
            this.btnMoveFiles.TabIndex = 13;
            this.btnMoveFiles.Text = "Move Files";
            this.btnMoveFiles.UseVisualStyleBackColor = true;
            this.btnMoveFiles.Click += new System.EventHandler(this.btnMoveFiles_Click);
            // 
            // txtFileExt
            // 
            this.txtFileExt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileExt.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtFileExt.Location = new System.Drawing.Point(142, 38);
            this.txtFileExt.Name = "txtFileExt";
            this.txtFileExt.Size = new System.Drawing.Size(595, 21);
            this.txtFileExt.TabIndex = 12;
            this.txtFileExt.Text = "{0}";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label4.Location = new System.Drawing.Point(7, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "File Extension :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label3.Location = new System.Drawing.Point(7, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "File Names : ";
            // 
            // txtDestinationPath
            // 
            this.txtDestinationPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDestinationPath.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtDestinationPath.Location = new System.Drawing.Point(142, 64);
            this.txtDestinationPath.Name = "txtDestinationPath";
            this.txtDestinationPath.Size = new System.Drawing.Size(595, 21);
            this.txtDestinationPath.TabIndex = 9;
            // 
            // txtFileDirectoryPath
            // 
            this.txtFileDirectoryPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFileDirectoryPath.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.txtFileDirectoryPath.Location = new System.Drawing.Point(142, 11);
            this.txtFileDirectoryPath.Name = "txtFileDirectoryPath";
            this.txtFileDirectoryPath.Size = new System.Drawing.Size(595, 21);
            this.txtFileDirectoryPath.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Destination Directory :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.label1.Location = new System.Drawing.Point(7, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Directory Path: ";
            // 
            // btnCollect
            // 
            this.btnCollect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCollect.Font = new System.Drawing.Font("Verdana", 8.25F);
            this.btnCollect.Location = new System.Drawing.Point(592, 382);
            this.btnCollect.Name = "btnCollect";
            this.btnCollect.Size = new System.Drawing.Size(145, 23);
            this.btnCollect.TabIndex = 4;
            this.btnCollect.Text = "Collect Files";
            this.btnCollect.UseVisualStyleBackColor = true;
            this.btnCollect.Click += new System.EventHandler(this.btnCopyFiles_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(608, 421);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(140, 13);
            this.linkLabel2.TabIndex = 3;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Developed By Kanji Keraliya";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // frmCollectFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 441);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCollectFiles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File collector";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmCollectFiles_FormClosing);
            this.Load += new System.EventHandler(this.frmCollectFiles_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDestinationPath;
        private System.Windows.Forms.TextBox txtFileDirectoryPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCollect;
        private System.Windows.Forms.TextBox txtFileExt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnMoveFiles;
        private System.Windows.Forms.Button btnRename;
        private System.Windows.Forms.RichTextBox txtFileNames;
        private System.Windows.Forms.CheckBox chkSearch;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}

