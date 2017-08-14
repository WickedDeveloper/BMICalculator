namespace BMICalculator
{
    partial class BMISplashForm
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
            this.components = new System.ComponentModel.Container();
            this.BMISplashFormTimer = new System.Windows.Forms.Timer(this.components);
            this.BMISplashFormTitleLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMISplashFormAuthorLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BMISplashFormTimer
            // 
            this.BMISplashFormTimer.Enabled = true;
            this.BMISplashFormTimer.Interval = 3000;
            this.BMISplashFormTimer.Tick += new System.EventHandler(this.BMISplashFormTimer_Tick);
            // 
            // BMISplashFormTitleLabel
            // 
            this.BMISplashFormTitleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMISplashFormTitleLabel.AutoSize = true;
            this.BMISplashFormTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMISplashFormTitleLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMISplashFormTitleLabel.Location = new System.Drawing.Point(3, 0);
            this.BMISplashFormTitleLabel.Name = "BMISplashFormTitleLabel";
            this.BMISplashFormTitleLabel.Size = new System.Drawing.Size(290, 183);
            this.BMISplashFormTitleLabel.TabIndex = 0;
            this.BMISplashFormTitleLabel.Text = "BMI\r\nCALCULATOR\r\nv1.0";
            this.BMISplashFormTitleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.BMISplashFormTitleLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.BMISplashFormAuthorLabel, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 89F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(296, 456);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // BMISplashFormAuthorLabel
            // 
            this.BMISplashFormAuthorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMISplashFormAuthorLabel.AutoSize = true;
            this.BMISplashFormAuthorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMISplashFormAuthorLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.BMISplashFormAuthorLabel.Location = new System.Drawing.Point(3, 366);
            this.BMISplashFormAuthorLabel.Name = "BMISplashFormAuthorLabel";
            this.BMISplashFormAuthorLabel.Size = new System.Drawing.Size(290, 90);
            this.BMISplashFormAuthorLabel.TabIndex = 1;
            this.BMISplashFormAuthorLabel.Text = "Version: 1.00\r\nCopyright © DGF Professional Services";
            this.BMISplashFormAuthorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BMISplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.ControlBox = false;
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMISplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMISplashForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer BMISplashFormTimer;
        private System.Windows.Forms.Label BMISplashFormTitleLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label BMISplashFormAuthorLabel;
    }
}