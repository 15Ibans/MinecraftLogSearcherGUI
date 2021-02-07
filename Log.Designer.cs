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
            this.logText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lineNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logText
            // 
            this.logText.Location = new System.Drawing.Point(12, 0);
            this.logText.Multiline = true;
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(776, 424);
            this.logText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(351, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // lineNumLabel
            // 
            this.lineNumLabel.Location = new System.Drawing.Point(351, 427);
            this.lineNumLabel.Name = "lineNumLabel";
            this.lineNumLabel.Size = new System.Drawing.Size(100, 23);
            this.lineNumLabel.TabIndex = 2;
            // 
            // Log
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lineNumLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.logText);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Log";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lineNumLabel;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.TextBox logText;
        
        #endregion
    }
}