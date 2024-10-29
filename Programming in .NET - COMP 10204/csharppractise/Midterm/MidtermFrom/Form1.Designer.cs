namespace MidtermFrom
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
            this.reportCardLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.studentIDLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.studentIDTextBox = new System.Windows.Forms.TextBox();
            this.subjectLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.gradeTextBox = new System.Windows.Forms.TextBox();
            this.subjectListBox = new System.Windows.Forms.ListBox();
            this.gradeListBox = new System.Windows.Forms.ListBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.averageTextBox = new System.Windows.Forms.TextBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportCardLabel
            // 
            this.reportCardLabel.AutoSize = true;
            this.reportCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportCardLabel.Location = new System.Drawing.Point(12, 19);
            this.reportCardLabel.Name = "reportCardLabel";
            this.reportCardLabel.Size = new System.Drawing.Size(162, 31);
            this.reportCardLabel.TabIndex = 0;
            this.reportCardLabel.Text = "Report Card";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(14, 76);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(51, 20);
            this.nameLabel.TabIndex = 1;
            this.nameLabel.Text = "Name";
            // 
            // studentIDLabel
            // 
            this.studentIDLabel.AutoSize = true;
            this.studentIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIDLabel.Location = new System.Drawing.Point(14, 120);
            this.studentIDLabel.Name = "studentIDLabel";
            this.studentIDLabel.Size = new System.Drawing.Size(87, 20);
            this.studentIDLabel.TabIndex = 2;
            this.studentIDLabel.Text = "Student ID";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(104, 76);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(137, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // studentIDTextBox
            // 
            this.studentIDTextBox.Location = new System.Drawing.Point(104, 120);
            this.studentIDTextBox.Name = "studentIDTextBox";
            this.studentIDTextBox.Size = new System.Drawing.Size(137, 20);
            this.studentIDTextBox.TabIndex = 4;
            // 
            // subjectLabel
            // 
            this.subjectLabel.AutoSize = true;
            this.subjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subjectLabel.Location = new System.Drawing.Point(14, 178);
            this.subjectLabel.Name = "subjectLabel";
            this.subjectLabel.Size = new System.Drawing.Size(63, 20);
            this.subjectLabel.TabIndex = 5;
            this.subjectLabel.Text = "Subject";
            // 
            // gradeLabel
            // 
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(179, 178);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(54, 20);
            this.gradeLabel.TabIndex = 6;
            this.gradeLabel.Text = "Grade";
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.Location = new System.Drawing.Point(18, 217);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(134, 20);
            this.subjectTextBox.TabIndex = 7;
            // 
            // gradeTextBox
            // 
            this.gradeTextBox.Location = new System.Drawing.Point(183, 217);
            this.gradeTextBox.Name = "gradeTextBox";
            this.gradeTextBox.Size = new System.Drawing.Size(100, 20);
            this.gradeTextBox.TabIndex = 8;
            // 
            // subjectListBox
            // 
            this.subjectListBox.FormattingEnabled = true;
            this.subjectListBox.Location = new System.Drawing.Point(18, 243);
            this.subjectListBox.Name = "subjectListBox";
            this.subjectListBox.Size = new System.Drawing.Size(134, 186);
            this.subjectListBox.TabIndex = 9;
            // 
            // gradeListBox
            // 
            this.gradeListBox.FormattingEnabled = true;
            this.gradeListBox.Location = new System.Drawing.Point(183, 243);
            this.gradeListBox.Name = "gradeListBox";
            this.gradeListBox.Size = new System.Drawing.Size(100, 186);
            this.gradeListBox.TabIndex = 10;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(309, 215);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 11;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // averageTextBox
            // 
            this.averageTextBox.Location = new System.Drawing.Point(183, 457);
            this.averageTextBox.Name = "averageTextBox";
            this.averageTextBox.Size = new System.Drawing.Size(100, 20);
            this.averageTextBox.TabIndex = 12;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageLabel.Location = new System.Drawing.Point(109, 455);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(68, 20);
            this.averageLabel.TabIndex = 13;
            this.averageLabel.Text = "Average";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 502);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.averageTextBox);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.gradeListBox);
            this.Controls.Add(this.subjectListBox);
            this.Controls.Add(this.gradeTextBox);
            this.Controls.Add(this.subjectTextBox);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.subjectLabel);
            this.Controls.Add(this.studentIDTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.studentIDLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.reportCardLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportCardLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label studentIDLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox studentIDTextBox;
        private System.Windows.Forms.Label subjectLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox gradeTextBox;
        private System.Windows.Forms.ListBox subjectListBox;
        private System.Windows.Forms.ListBox gradeListBox;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox averageTextBox;
        private System.Windows.Forms.Label averageLabel;
    }
}

