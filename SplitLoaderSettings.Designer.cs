namespace LiveSplit.Kacky.SplitLoader
{
    partial class SplitLoaderSettings
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBasePath;
        private System.Windows.Forms.TextBox txtBasePath;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.CheckBox chkAlwaysOnTop;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBasePath = new System.Windows.Forms.Label();
            this.txtBasePath = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.chkAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblBasePath
            // 
            this.lblBasePath.AutoSize = true;
            this.lblBasePath.Location = new System.Drawing.Point(7, 10);
            this.lblBasePath.Name = "lblBasePath";
            this.lblBasePath.Size = new System.Drawing.Size(58, 13);
            this.lblBasePath.TabIndex = 0;
            this.lblBasePath.Text = "Base Path:";
            // 
            // txtBasePath
            // 
            this.txtBasePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                                                                            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBasePath.Location = new System.Drawing.Point(70, 7);
            this.txtBasePath.Name = "txtBasePath";
            this.txtBasePath.Size = new System.Drawing.Size(300, 20);
            this.txtBasePath.TabIndex = 1;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(280, 33);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(90, 23);
            this.btnBrowse.TabIndex = 3;
            this.btnBrowse.Text = "Browse...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // chkAlwaysOnTop
            // 
            this.chkAlwaysOnTop.AutoSize = true;
            this.chkAlwaysOnTop.Location = new System.Drawing.Point(70, 35);
            this.chkAlwaysOnTop.Name = "chkAlwaysOnTop";
            this.chkAlwaysOnTop.Size = new System.Drawing.Size(100, 17);
            this.chkAlwaysOnTop.TabIndex = 2;
            this.chkAlwaysOnTop.Text = "Always on Top";
            this.chkAlwaysOnTop.UseVisualStyleBackColor = true;
            this.chkAlwaysOnTop.CheckedChanged += new System.EventHandler(this.chkAlwaysOnTop_CheckedChanged);
            // 
            // SplitLoaderSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chkAlwaysOnTop);
            this.Controls.Add(this.txtBasePath);
            this.Controls.Add(this.lblBasePath);
            this.Controls.Add(this.btnBrowse);
            this.Name = "SplitLoaderSettings";
            this.Size = new System.Drawing.Size(380, 90);
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
