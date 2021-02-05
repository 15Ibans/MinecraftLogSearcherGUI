namespace MinecraftLogSearcherGUI
{
    partial class Log
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
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.logText = new System.Windows.Forms.TextBox();
            this.lineNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(44, 450);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(50, 0);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(728, 450);
            this.logText.TabIndex = 1;
            // 
            // lineNumber
            // 
            this.lineNumber.Location = new System.Drawing.Point(12, 9);
            this.lineNumber.Name = "lineNumber";
            this.lineNumber.Size = new System.Drawing.Size(27, 21);
            this.lineNumber.TabIndex = 2;
            this.lineNumber.Text = "1";
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineNumber);
            this.Controls.Add(this.logText);
            this.Controls.Add(this.splitter1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lineNumber;

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.TextBox logText;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}