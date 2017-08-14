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
            this.SuspendLayout();
            // 
            // BMISplashFormTimer
            // 
            this.BMISplashFormTimer.Enabled = true;
            this.BMISplashFormTimer.Interval = 3000;
            this.BMISplashFormTimer.Tick += new System.EventHandler(this.BMISplashFormTimer_Tick);
            // 
            // BMISplashForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 480);
            this.ControlBox = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BMISplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BMISplashForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer BMISplashFormTimer;
    }
}