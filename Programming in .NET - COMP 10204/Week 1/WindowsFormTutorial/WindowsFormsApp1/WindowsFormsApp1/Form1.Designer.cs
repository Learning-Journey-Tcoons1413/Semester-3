namespace WindowsFormsApp1
{
    partial class MainForm
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
            this.FirstLabel = new System.Windows.Forms.Label();
            this.SecondLabel = new System.Windows.Forms.Label();
            this.FirstTextBox = new System.Windows.Forms.TextBox();
            this.SecondTextBox = new System.Windows.Forms.TextBox();
            this.ResultTextBox = new System.Windows.Forms.TextBox();
            this.SubtractLabel = new System.Windows.Forms.Label();
            this.SubtractButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FirstLabel
            // 
            this.FirstLabel.AutoSize = true;
            this.FirstLabel.Location = new System.Drawing.Point(18, 33);
            this.FirstLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.FirstLabel.Name = "FirstLabel";
            this.FirstLabel.Size = new System.Drawing.Size(115, 25);
            this.FirstLabel.TabIndex = 0;
            this.FirstLabel.Text = "First Value";
            // 
            // SecondLabel
            // 
            this.SecondLabel.AutoSize = true;
            this.SecondLabel.Location = new System.Drawing.Point(18, 79);
            this.SecondLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SecondLabel.Name = "SecondLabel";
            this.SecondLabel.Size = new System.Drawing.Size(146, 25);
            this.SecondLabel.TabIndex = 1;
            this.SecondLabel.Text = "Second Value";
            // 
            // FirstTextBox
            // 
            this.FirstTextBox.Location = new System.Drawing.Point(172, 27);
            this.FirstTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.FirstTextBox.Name = "FirstTextBox";
            this.FirstTextBox.Size = new System.Drawing.Size(196, 31);
            this.FirstTextBox.TabIndex = 2;
            // 
            // SecondTextBox
            // 
            this.SecondTextBox.Location = new System.Drawing.Point(172, 73);
            this.SecondTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SecondTextBox.Name = "SecondTextBox";
            this.SecondTextBox.Size = new System.Drawing.Size(196, 31);
            this.SecondTextBox.TabIndex = 3;
            // 
            // ResultTextBox
            // 
            this.ResultTextBox.Location = new System.Drawing.Point(172, 171);
            this.ResultTextBox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ResultTextBox.Name = "ResultTextBox";
            this.ResultTextBox.ReadOnly = true;
            this.ResultTextBox.Size = new System.Drawing.Size(196, 31);
            this.ResultTextBox.TabIndex = 4;
            // 
            // SubtractLabel
            // 
            this.SubtractLabel.AutoSize = true;
            this.SubtractLabel.Location = new System.Drawing.Point(18, 177);
            this.SubtractLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SubtractLabel.Name = "SubtractLabel";
            this.SubtractLabel.Size = new System.Drawing.Size(92, 25);
            this.SubtractLabel.TabIndex = 5;
            this.SubtractLabel.Text = "Subtract";
            this.SubtractLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // SubtractButton
            // 
            this.SubtractButton.Location = new System.Drawing.Point(24, 271);
            this.SubtractButton.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SubtractButton.Name = "SubtractButton";
            this.SubtractButton.Size = new System.Drawing.Size(278, 46);
            this.SubtractButton.TabIndex = 6;
            this.SubtractButton.Text = "Subtract: Second - First";
            this.SubtractButton.UseVisualStyleBackColor = true;
            this.SubtractButton.Click += new System.EventHandler(this.SubtractButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 465);
            this.Controls.Add(this.SubtractButton);
            this.Controls.Add(this.SubtractLabel);
            this.Controls.Add(this.ResultTextBox);
            this.Controls.Add(this.SecondTextBox);
            this.Controls.Add(this.FirstTextBox);
            this.Controls.Add(this.SecondLabel);
            this.Controls.Add(this.FirstLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "MainForm";
            this.Text = "Week1FormExcercise";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FirstLabel;
        private System.Windows.Forms.Label SecondLabel;
        private System.Windows.Forms.TextBox FirstTextBox;
        private System.Windows.Forms.TextBox SecondTextBox;
        private System.Windows.Forms.TextBox ResultTextBox;
        private System.Windows.Forms.Label SubtractLabel;
        private System.Windows.Forms.Button SubtractButton;
    }
}

