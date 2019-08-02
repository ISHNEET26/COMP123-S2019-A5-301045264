namespace COMP123_S2019_A5_301045264
{
    partial class SplashForm
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
            this.SplashFormLabel = new System.Windows.Forms.Label();
            this.SplashScreenLabel2 = new System.Windows.Forms.Label();
            this.SplashTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // SplashFormLabel
            // 
            this.SplashFormLabel.AutoSize = true;
            this.SplashFormLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SplashFormLabel.Location = new System.Drawing.Point(119, 59);
            this.SplashFormLabel.Name = "SplashFormLabel";
            this.SplashFormLabel.Size = new System.Drawing.Size(410, 31);
            this.SplashFormLabel.TabIndex = 0;
            this.SplashFormLabel.Text = "Welcome To Dollar Computers";
            // 
            // SplashScreenLabel2
            // 
            this.SplashScreenLabel2.AutoSize = true;
            this.SplashScreenLabel2.Location = new System.Drawing.Point(178, 109);
            this.SplashScreenLabel2.Name = "SplashScreenLabel2";
            this.SplashScreenLabel2.Size = new System.Drawing.Size(219, 31);
            this.SplashScreenLabel2.TabIndex = 1;
            this.SplashScreenLabel2.Text = "We Sell For Less";
            // 
            // SplashTimer
            // 
            this.SplashTimer.Interval = 3000;
            this.SplashTimer.Tick += new System.EventHandler(this.SplashTimer_Tick);
            // 
            // SplashForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 461);
            this.ControlBox = false;
            this.Controls.Add(this.SplashScreenLabel2);
            this.Controls.Add(this.SplashFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "SplashForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashForm";
            this.Load += new System.EventHandler(this.SplashForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SplashFormLabel;
        private System.Windows.Forms.Label SplashScreenLabel2;
        private System.Windows.Forms.Timer SplashTimer;
    }
}

