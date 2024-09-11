namespace Exercise2WinForm
{
    partial class Form1
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
            this.ListButton = new System.Windows.Forms.Button();
            this.BestMilesButton = new System.Windows.Forms.Button();
            this.FordButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.OutputTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListButton
            // 
            this.ListButton.Location = new System.Drawing.Point(92, 43);
            this.ListButton.Name = "ListButton";
            this.ListButton.Size = new System.Drawing.Size(119, 38);
            this.ListButton.TabIndex = 0;
            this.ListButton.Text = "List All Cars";
            this.ListButton.UseVisualStyleBackColor = true;
            this.ListButton.Click += new System.EventHandler(this.ListButton_Click);
            // 
            // BestMilesButton
            // 
            this.BestMilesButton.Location = new System.Drawing.Point(92, 96);
            this.BestMilesButton.Name = "BestMilesButton";
            this.BestMilesButton.Size = new System.Drawing.Size(119, 38);
            this.BestMilesButton.TabIndex = 1;
            this.BestMilesButton.Text = "Car with Best Miles";
            this.BestMilesButton.UseVisualStyleBackColor = true;
            this.BestMilesButton.Click += new System.EventHandler(this.BestMilesButton_Click);
            // 
            // FordButton
            // 
            this.FordButton.Location = new System.Drawing.Point(92, 149);
            this.FordButton.Name = "FordButton";
            this.FordButton.Size = new System.Drawing.Size(119, 38);
            this.FordButton.TabIndex = 2;
            this.FordButton.Text = "Cars by Ford";
            this.FordButton.UseVisualStyleBackColor = true;

            // 
            // OutputLabel
            // 
            this.OutputLabel.AutoSize = true;
            this.OutputLabel.Location = new System.Drawing.Point(89, 200);
            this.OutputLabel.Name = "OutputLabel";
            this.OutputLabel.Size = new System.Drawing.Size(39, 13);
            this.OutputLabel.TabIndex = 3;
            this.OutputLabel.Text = "Output";
            // 
            // OutputTextbox
            // 
            this.OutputTextbox.Location = new System.Drawing.Point(92, 216);
            this.OutputTextbox.Multiline = true;
            this.OutputTextbox.Name = "OutputTextbox";
            this.OutputTextbox.Size = new System.Drawing.Size(253, 138);
            this.OutputTextbox.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 434);
            this.Controls.Add(this.OutputTextbox);
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.FordButton);
            this.Controls.Add(this.BestMilesButton);
            this.Controls.Add(this.ListButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ListButton;
        private System.Windows.Forms.Button BestMilesButton;
        private System.Windows.Forms.Button FordButton;
        private System.Windows.Forms.Label OutputLabel;
        private System.Windows.Forms.TextBox OutputTextbox;
    }
}

