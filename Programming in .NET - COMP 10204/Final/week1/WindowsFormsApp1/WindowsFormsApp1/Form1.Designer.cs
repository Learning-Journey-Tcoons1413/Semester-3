namespace WindowsFormsApp1
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
            this.firstValueLabel = new System.Windows.Forms.Label();
            this.secondValueLabel = new System.Windows.Forms.Label();
            this.firstTextBox = new System.Windows.Forms.TextBox();
            this.secondTextBox = new System.Windows.Forms.TextBox();
            this.subtractionLabel = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.subtractButton = new System.Windows.Forms.Button();
            this.flipButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstValueLabel
            // 
            this.firstValueLabel.AutoSize = true;
            this.firstValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstValueLabel.Location = new System.Drawing.Point(34, 53);
            this.firstValueLabel.Name = "firstValueLabel";
            this.firstValueLabel.Size = new System.Drawing.Size(85, 20);
            this.firstValueLabel.TabIndex = 0;
            this.firstValueLabel.Text = "First Value";
            // 
            // secondValueLabel
            // 
            this.secondValueLabel.AutoSize = true;
            this.secondValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.secondValueLabel.Location = new System.Drawing.Point(34, 93);
            this.secondValueLabel.Name = "secondValueLabel";
            this.secondValueLabel.Size = new System.Drawing.Size(109, 20);
            this.secondValueLabel.TabIndex = 0;
            this.secondValueLabel.Text = "Second Value";
            // 
            // firstTextBox
            // 
            this.firstTextBox.Location = new System.Drawing.Point(198, 53);
            this.firstTextBox.Name = "firstTextBox";
            this.firstTextBox.Size = new System.Drawing.Size(145, 20);
            this.firstTextBox.TabIndex = 1;
            // 
            // secondTextBox
            // 
            this.secondTextBox.Location = new System.Drawing.Point(198, 93);
            this.secondTextBox.Name = "secondTextBox";
            this.secondTextBox.Size = new System.Drawing.Size(145, 20);
            this.secondTextBox.TabIndex = 1;
            // 
            // subtractionLabel
            // 
            this.subtractionLabel.AutoSize = true;
            this.subtractionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtractionLabel.Location = new System.Drawing.Point(34, 140);
            this.subtractionLabel.Name = "subtractionLabel";
            this.subtractionLabel.Size = new System.Drawing.Size(109, 20);
            this.subtractionLabel.TabIndex = 0;
            this.subtractionLabel.Text = "Second Value";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(198, 142);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(145, 20);
            this.resultTextBox.TabIndex = 1;
            // 
            // subtractButton
            // 
            this.subtractButton.Location = new System.Drawing.Point(38, 201);
            this.subtractButton.Name = "subtractButton";
            this.subtractButton.Size = new System.Drawing.Size(140, 33);
            this.subtractButton.TabIndex = 2;
            this.subtractButton.Text = "Subtract Second - First";
            this.subtractButton.UseVisualStyleBackColor = true;
            this.subtractButton.Click += new System.EventHandler(this.subtractButton_Click);
            // 
            // flipButton
            // 
            this.flipButton.Location = new System.Drawing.Point(203, 201);
            this.flipButton.Name = "flipButton";
            this.flipButton.Size = new System.Drawing.Size(140, 33);
            this.flipButton.TabIndex = 2;
            this.flipButton.Text = "Flip Values";
            this.flipButton.UseVisualStyleBackColor = true;
            this.flipButton.Click += new System.EventHandler(this.flipButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(38, 240);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 33);
            this.clearButton.TabIndex = 2;
            this.clearButton.Text = "Clear Values";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(203, 240);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 33);
            this.exitButton.TabIndex = 2;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 351);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.flipButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.subtractButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.secondTextBox);
            this.Controls.Add(this.firstTextBox);
            this.Controls.Add(this.subtractionLabel);
            this.Controls.Add(this.secondValueLabel);
            this.Controls.Add(this.firstValueLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstValueLabel;
        private System.Windows.Forms.Label secondValueLabel;
        private System.Windows.Forms.TextBox firstTextBox;
        private System.Windows.Forms.TextBox secondTextBox;
        private System.Windows.Forms.Label subtractionLabel;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button subtractButton;
        private System.Windows.Forms.Button flipButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
    }
}

