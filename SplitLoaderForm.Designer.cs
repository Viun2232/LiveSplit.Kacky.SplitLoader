using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveSplit.Kacky.SplitLoader
{
    partial class SplitLoaderForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblCurrentFile;
        private System.Windows.Forms.TextBox txtMapNumber;
        private System.Windows.Forms.Button btnLoad;

        private void InitializeComponent()
        {
            this.lblCurrentFile = new System.Windows.Forms.Label();
            this.txtMapNumber = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCurrentFile
            // 
            this.lblCurrentFile.AutoSize = true;
            this.lblCurrentFile.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentFile.Name = "lblCurrentFile";
            this.lblCurrentFile.Size = new System.Drawing.Size(117, 13);
            this.lblCurrentFile.TabIndex = 0;
            this.lblCurrentFile.Text = "Loaded: (No file loaded)";
            // 
            // txtMapNumber
            // 
            this.txtMapNumber.Location = new System.Drawing.Point(12, 35);
            this.txtMapNumber.Name = "txtMapNumber";
            this.txtMapNumber.Size = new System.Drawing.Size(150, 20);
            this.txtMapNumber.TabIndex = 1;
            this.txtMapNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMapNumber_KeyPress);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(168, 33);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // SplitLoaderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 70);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtMapNumber);
            this.Controls.Add(this.lblCurrentFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SplitLoaderForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kacky Split Loader";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
