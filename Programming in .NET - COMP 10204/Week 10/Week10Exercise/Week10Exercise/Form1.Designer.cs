namespace Week10Exercise
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
            this.studentsListBox = new System.Windows.Forms.ListBox();
            this.lastNameButton = new System.Windows.Forms.Button();
            this.gradeOneButton = new System.Windows.Forms.Button();
            this.gradeTwoButton = new System.Windows.Forms.Button();
            this.averageButton = new System.Windows.Forms.Button();
            this.gradeOneGradeTwoButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // studentsListBox
            // 
            this.studentsListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentsListBox.FormattingEnabled = true;
            this.studentsListBox.ItemHeight = 14;
            this.studentsListBox.Location = new System.Drawing.Point(12, 29);
            this.studentsListBox.Name = "studentsListBox";
            this.studentsListBox.Size = new System.Drawing.Size(503, 158);
            this.studentsListBox.TabIndex = 0;
            // 
            // lastNameButton
            // 
            this.lastNameButton.Location = new System.Drawing.Point(59, 195);
            this.lastNameButton.Name = "lastNameButton";
            this.lastNameButton.Size = new System.Drawing.Size(72, 51);
            this.lastNameButton.TabIndex = 1;
            this.lastNameButton.Text = "Sort by last name";
            this.lastNameButton.UseVisualStyleBackColor = true;
            this.lastNameButton.Click += new System.EventHandler(this.lastNameButton_Click);
            // 
            // gradeOneButton
            // 
            this.gradeOneButton.Location = new System.Drawing.Point(137, 195);
            this.gradeOneButton.Name = "gradeOneButton";
            this.gradeOneButton.Size = new System.Drawing.Size(72, 51);
            this.gradeOneButton.TabIndex = 1;
            this.gradeOneButton.Text = "Sort by grade 1";
            this.gradeOneButton.UseVisualStyleBackColor = true;
            this.gradeOneButton.Click += new System.EventHandler(this.gradeOneButton_Click);
            // 
            // gradeTwoButton
            // 
            this.gradeTwoButton.Location = new System.Drawing.Point(215, 195);
            this.gradeTwoButton.Name = "gradeTwoButton";
            this.gradeTwoButton.Size = new System.Drawing.Size(72, 51);
            this.gradeTwoButton.TabIndex = 1;
            this.gradeTwoButton.Text = "Sort by grade 2";
            this.gradeTwoButton.UseVisualStyleBackColor = true;
            this.gradeTwoButton.Click += new System.EventHandler(this.gradeTwoButton_Click);
            // 
            // averageButton
            // 
            this.averageButton.Location = new System.Drawing.Point(293, 195);
            this.averageButton.Name = "averageButton";
            this.averageButton.Size = new System.Drawing.Size(72, 51);
            this.averageButton.TabIndex = 1;
            this.averageButton.Text = "Sort by average";
            this.averageButton.UseVisualStyleBackColor = true;
            this.averageButton.Click += new System.EventHandler(this.averageButton_Click);
            // 
            // gradeOneGradeTwoButton
            // 
            this.gradeOneGradeTwoButton.Location = new System.Drawing.Point(371, 195);
            this.gradeOneGradeTwoButton.Name = "gradeOneGradeTwoButton";
            this.gradeOneGradeTwoButton.Size = new System.Drawing.Size(72, 51);
            this.gradeOneGradeTwoButton.TabIndex = 1;
            this.gradeOneGradeTwoButton.Text = "Grade 1 Grade 2";
            this.gradeOneGradeTwoButton.UseVisualStyleBackColor = true;
            this.gradeOneGradeTwoButton.Click += new System.EventHandler(this.gradeOneGradeTwoButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 338);
            this.Controls.Add(this.gradeOneGradeTwoButton);
            this.Controls.Add(this.averageButton);
            this.Controls.Add(this.gradeTwoButton);
            this.Controls.Add(this.gradeOneButton);
            this.Controls.Add(this.lastNameButton);
            this.Controls.Add(this.studentsListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox studentsListBox;
        private System.Windows.Forms.Button lastNameButton;
        private System.Windows.Forms.Button gradeOneButton;
        private System.Windows.Forms.Button gradeTwoButton;
        private System.Windows.Forms.Button averageButton;
        private System.Windows.Forms.Button gradeOneGradeTwoButton;
    }
}

