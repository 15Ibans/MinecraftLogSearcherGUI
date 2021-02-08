using System;

namespace MinecraftLogSearcherGUI
{
    partial class MainForm
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.logDirectory = new System.Windows.Forms.TextBox();
            this.searchTerm = new System.Windows.Forms.TextBox();
            this.fileDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.searchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // logDirectory
            // 
            this.logDirectory.Location = new System.Drawing.Point(70, 65);
            this.logDirectory.Name = "logDirectory";
            this.logDirectory.Size = new System.Drawing.Size(259, 20);
            this.logDirectory.TabIndex = 0;
            // 
            // searchTerm
            // 
            this.searchTerm.Location = new System.Drawing.Point(70, 90);
            this.searchTerm.Name = "searchTerm";
            this.searchTerm.Size = new System.Drawing.Size(259, 20);
            this.searchTerm.TabIndex = 1;
            // 
            // fileDialog
            // 
            this.fileDialog.Location = new System.Drawing.Point(334, 64);
            this.fileDialog.Name = "fileDialog";
            this.fileDialog.Size = new System.Drawing.Size(22, 20);
            this.fileDialog.TabIndex = 2;
            this.fileDialog.Text = "...";
            this.fileDialog.UseVisualStyleBackColor = true;
            this.fileDialog.Click += new System.EventHandler(this.fileDialog_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(187, 153);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(64, 20);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 227);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.fileDialog);
            this.Controls.Add(this.searchTerm);
            this.Controls.Add(this.logDirectory);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox logDirectory;
        private System.Windows.Forms.TextBox searchTerm;
        private System.Windows.Forms.Button fileDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button searchButton;
    }
}

