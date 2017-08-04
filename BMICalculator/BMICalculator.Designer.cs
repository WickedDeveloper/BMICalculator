namespace BMICalculator
{
    partial class BMICalculatorForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.BMIResultsTextBox = new System.Windows.Forms.TextBox();
            this.BMIProgressBar = new System.Windows.Forms.ProgressBar();
            this.MetricRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightTextBox = new System.Windows.Forms.TextBox();
            this.MyWeightLabel = new System.Windows.Forms.Label();
            this.MyWeightTextBox = new System.Windows.Forms.TextBox();
            this.ImperialRadioButton = new System.Windows.Forms.RadioButton();
            this.MyHeightLabel = new System.Windows.Forms.Label();
            this.CalculateBMIButton = new System.Windows.Forms.Button();
            this.BMIDisplayTextBox = new System.Windows.Forms.TextBox();
            this.BMIFormResetButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.BMIResultsTextBox, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.BMIProgressBar, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.MetricRadioButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.MyWeightLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.MyWeightTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ImperialRadioButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.MyHeightLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.CalculateBMIButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BMIDisplayTextBox, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BMIFormResetButton, 0, 7);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 19.48052F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.493507F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.46753F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.38961F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(280, 418);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // BMIResultsTextBox
            // 
            this.BMIResultsTextBox.BackColor = System.Drawing.Color.LightGray;
            this.BMIResultsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.BMIResultsTextBox, 2);
            this.BMIResultsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIResultsTextBox.ForeColor = System.Drawing.Color.Black;
            this.BMIResultsTextBox.Location = new System.Drawing.Point(3, 267);
            this.BMIResultsTextBox.Multiline = true;
            this.BMIResultsTextBox.Name = "BMIResultsTextBox";
            this.BMIResultsTextBox.ReadOnly = true;
            this.BMIResultsTextBox.Size = new System.Drawing.Size(274, 99);
            this.BMIResultsTextBox.TabIndex = 100;
            // 
            // BMIProgressBar
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.BMIProgressBar, 2);
            this.BMIProgressBar.Location = new System.Drawing.Point(3, 244);
            this.BMIProgressBar.Name = "BMIProgressBar";
            this.BMIProgressBar.Size = new System.Drawing.Size(274, 17);
            this.BMIProgressBar.TabIndex = 8;
            // 
            // MetricRadioButton
            // 
            this.MetricRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.MetricRadioButton.AutoSize = true;
            this.MetricRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MetricRadioButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MetricRadioButton.Location = new System.Drawing.Point(172, 3);
            this.MetricRadioButton.Name = "MetricRadioButton";
            this.MetricRadioButton.Size = new System.Drawing.Size(76, 31);
            this.MetricRadioButton.TabIndex = 5;
            this.MetricRadioButton.TabStop = true;
            this.MetricRadioButton.Text = "Metric";
            this.MetricRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightTextBox
            // 
            this.MyHeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightTextBox.BackColor = System.Drawing.Color.White;
            this.MyHeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightTextBox.ForeColor = System.Drawing.Color.Black;
            this.MyHeightTextBox.Location = new System.Drawing.Point(143, 40);
            this.MyHeightTextBox.Name = "MyHeightTextBox";
            this.MyHeightTextBox.Size = new System.Drawing.Size(134, 26);
            this.MyHeightTextBox.TabIndex = 0;
            this.MyHeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MyWeightLabel
            // 
            this.MyWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightLabel.AutoSize = true;
            this.MyWeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MyWeightLabel.Location = new System.Drawing.Point(3, 74);
            this.MyWeightLabel.Name = "MyWeightLabel";
            this.MyWeightLabel.Size = new System.Drawing.Size(134, 37);
            this.MyWeightLabel.TabIndex = 10;
            this.MyWeightLabel.Text = "My Weight";
            this.MyWeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MyWeightTextBox
            // 
            this.MyWeightTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyWeightTextBox.BackColor = System.Drawing.Color.White;
            this.MyWeightTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyWeightTextBox.ForeColor = System.Drawing.Color.Black;
            this.MyWeightTextBox.Location = new System.Drawing.Point(143, 77);
            this.MyWeightTextBox.Name = "MyWeightTextBox";
            this.MyWeightTextBox.Size = new System.Drawing.Size(134, 26);
            this.MyWeightTextBox.TabIndex = 1;
            this.MyWeightTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ImperialRadioButton
            // 
            this.ImperialRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.ImperialRadioButton.AutoSize = true;
            this.ImperialRadioButton.Checked = true;
            this.ImperialRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ImperialRadioButton.ForeColor = System.Drawing.Color.DodgerBlue;
            this.ImperialRadioButton.Location = new System.Drawing.Point(24, 3);
            this.ImperialRadioButton.Name = "ImperialRadioButton";
            this.ImperialRadioButton.Size = new System.Drawing.Size(91, 31);
            this.ImperialRadioButton.TabIndex = 4;
            this.ImperialRadioButton.TabStop = true;
            this.ImperialRadioButton.Text = "Imperial";
            this.ImperialRadioButton.UseVisualStyleBackColor = true;
            // 
            // MyHeightLabel
            // 
            this.MyHeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MyHeightLabel.AutoSize = true;
            this.MyHeightLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MyHeightLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.MyHeightLabel.Location = new System.Drawing.Point(3, 37);
            this.MyHeightLabel.Name = "MyHeightLabel";
            this.MyHeightLabel.Size = new System.Drawing.Size(134, 37);
            this.MyHeightLabel.TabIndex = 9;
            this.MyHeightLabel.Text = "My Height";
            this.MyHeightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CalculateBMIButton
            // 
            this.CalculateBMIButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CalculateBMIButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.CalculateBMIButton, 2);
            this.CalculateBMIButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalculateBMIButton.ForeColor = System.Drawing.Color.White;
            this.CalculateBMIButton.Location = new System.Drawing.Point(3, 114);
            this.CalculateBMIButton.Name = "CalculateBMIButton";
            this.CalculateBMIButton.Size = new System.Drawing.Size(274, 63);
            this.CalculateBMIButton.TabIndex = 2;
            this.CalculateBMIButton.Text = "CALCULATE BMI";
            this.CalculateBMIButton.UseVisualStyleBackColor = false;
            // 
            // BMIDisplayTextBox
            // 
            this.BMIDisplayTextBox.BackColor = System.Drawing.Color.Gold;
            this.BMIDisplayTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableLayoutPanel1.SetColumnSpan(this.BMIDisplayTextBox, 2);
            this.BMIDisplayTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIDisplayTextBox.ForeColor = System.Drawing.Color.Black;
            this.BMIDisplayTextBox.Location = new System.Drawing.Point(3, 183);
            this.BMIDisplayTextBox.Name = "BMIDisplayTextBox";
            this.BMIDisplayTextBox.ReadOnly = true;
            this.BMIDisplayTextBox.Size = new System.Drawing.Size(274, 55);
            this.BMIDisplayTextBox.TabIndex = 6;
            this.BMIDisplayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMIFormResetButton
            // 
            this.BMIFormResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BMIFormResetButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.tableLayoutPanel1.SetColumnSpan(this.BMIFormResetButton, 2);
            this.BMIFormResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BMIFormResetButton.ForeColor = System.Drawing.Color.White;
            this.BMIFormResetButton.Location = new System.Drawing.Point(3, 382);
            this.BMIFormResetButton.Name = "BMIFormResetButton";
            this.BMIFormResetButton.Size = new System.Drawing.Size(274, 33);
            this.BMIFormResetButton.TabIndex = 3;
            this.BMIFormResetButton.Text = "RESET";
            this.BMIFormResetButton.UseVisualStyleBackColor = false;
            this.BMIFormResetButton.Click += new System.EventHandler(this.BMIFormResetButton_Click);
            // 
            // BMICalculatorForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(304, 442);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.MaximizeBox = false;
            this.Name = "BMICalculatorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMI Calculator";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton MetricRadioButton;
        private System.Windows.Forms.RadioButton ImperialRadioButton;
        private System.Windows.Forms.Label MyHeightLabel;
        private System.Windows.Forms.TextBox BMIResultsTextBox;
        private System.Windows.Forms.ProgressBar BMIProgressBar;
        private System.Windows.Forms.TextBox MyHeightTextBox;
        private System.Windows.Forms.Label MyWeightLabel;
        private System.Windows.Forms.TextBox MyWeightTextBox;
        private System.Windows.Forms.Button CalculateBMIButton;
        private System.Windows.Forms.TextBox BMIDisplayTextBox;
        private System.Windows.Forms.Button BMIFormResetButton;
    }
}

