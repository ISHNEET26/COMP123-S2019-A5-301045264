namespace COMP123_S2019_A5_301045264
{
    partial class SelectForm
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
            this.SelectFormLabel = new System.Windows.Forms.Label();
            this.SelectFormDataGridView = new System.Windows.Forms.DataGridView();
            this.SelectionLabel = new System.Windows.Forms.Label();
            this.SelectionTextBox = new System.Windows.Forms.TextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectFormLabel
            // 
            this.SelectFormLabel.AutoSize = true;
            this.SelectFormLabel.BackColor = System.Drawing.Color.White;
            this.SelectFormLabel.Location = new System.Drawing.Point(12, 30);
            this.SelectFormLabel.Name = "SelectFormLabel";
            this.SelectFormLabel.Size = new System.Drawing.Size(234, 20);
            this.SelectFormLabel.TabIndex = 0;
            this.SelectFormLabel.Text = "Dollar Computer Hardware  List ";
            // 
            // SelectFormDataGridView
            // 
            this.SelectFormDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectFormDataGridView.Location = new System.Drawing.Point(12, 90);
            this.SelectFormDataGridView.Name = "SelectFormDataGridView";
            this.SelectFormDataGridView.Size = new System.Drawing.Size(772, 276);
            this.SelectFormDataGridView.TabIndex = 1;
            // 
            // SelectionLabel
            // 
            this.SelectionLabel.AutoSize = true;
            this.SelectionLabel.Location = new System.Drawing.Point(12, 403);
            this.SelectionLabel.Name = "SelectionLabel";
            this.SelectionLabel.Size = new System.Drawing.Size(113, 20);
            this.SelectionLabel.TabIndex = 2;
            this.SelectionLabel.Text = "Your Selection";
            // 
            // SelectionTextBox
            // 
            this.SelectionTextBox.Location = new System.Drawing.Point(150, 403);
            this.SelectionTextBox.Name = "SelectionTextBox";
            this.SelectionTextBox.Size = new System.Drawing.Size(415, 26);
            this.SelectionTextBox.TabIndex = 3;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(598, 398);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 31);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(698, 398);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 31);
            this.NextButton.TabIndex = 5;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // SelectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.ControlBox = false;
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SelectionTextBox);
            this.Controls.Add(this.SelectionLabel);
            this.Controls.Add(this.SelectFormDataGridView);
            this.Controls.Add(this.SelectFormLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SelectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectForm";
            ((System.ComponentModel.ISupportInitialize)(this.SelectFormDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectFormLabel;
        private System.Windows.Forms.DataGridView SelectFormDataGridView;
        private System.Windows.Forms.Label SelectionLabel;
        private System.Windows.Forms.TextBox SelectionTextBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button NextButton;
    }
}