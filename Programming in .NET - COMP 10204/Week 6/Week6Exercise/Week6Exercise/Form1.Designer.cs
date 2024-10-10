namespace Week6Exercise
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
            this.tripToTheMoonLabel = new System.Windows.Forms.Label();
            this.astronautNameLabel = new System.Windows.Forms.Label();
            this.astronautNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bookTripButton = new System.Windows.Forms.Button();
            this.tripListLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tripListBox = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tripToTheMoonLabel
            // 
            this.tripToTheMoonLabel.AutoSize = true;
            this.tripToTheMoonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripToTheMoonLabel.Location = new System.Drawing.Point(13, 13);
            this.tripToTheMoonLabel.Name = "tripToTheMoonLabel";
            this.tripToTheMoonLabel.Size = new System.Drawing.Size(353, 42);
            this.tripToTheMoonLabel.TabIndex = 0;
            this.tripToTheMoonLabel.Text = "A Trip to the Moon!";
            // 
            // astronautNameLabel
            // 
            this.astronautNameLabel.AutoSize = true;
            this.astronautNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.astronautNameLabel.Location = new System.Drawing.Point(20, 78);
            this.astronautNameLabel.Name = "astronautNameLabel";
            this.astronautNameLabel.Size = new System.Drawing.Size(125, 20);
            this.astronautNameLabel.TabIndex = 1;
            this.astronautNameLabel.Text = "Astronaut Name";
            // 
            // astronautNameTextBox
            // 
            this.astronautNameTextBox.Location = new System.Drawing.Point(152, 78);
            this.astronautNameTextBox.Name = "astronautNameTextBox";
            this.astronautNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.astronautNameTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Departure Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Departs the first Saturday of every Month (must be in the future)";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(25, 182);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 5;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // bookTripButton
            // 
            this.bookTripButton.Location = new System.Drawing.Point(25, 356);
            this.bookTripButton.Name = "bookTripButton";
            this.bookTripButton.Size = new System.Drawing.Size(99, 37);
            this.bookTripButton.TabIndex = 6;
            this.bookTripButton.Text = "Book Trip!";
            this.bookTripButton.UseVisualStyleBackColor = true;
            this.bookTripButton.Click += new System.EventHandler(this.bookTripButton_Click);
            // 
            // tripListLabel
            // 
            this.tripListLabel.AutoSize = true;
            this.tripListLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tripListLabel.Location = new System.Drawing.Point(409, 116);
            this.tripListLabel.Name = "tripListLabel";
            this.tripListLabel.Size = new System.Drawing.Size(64, 20);
            this.tripListLabel.TabIndex = 7;
            this.tripListLabel.Text = "Trip List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Max 3 Astronauts on trip!";
            // 
            // tripListBox
            // 
            this.tripListBox.FormattingEnabled = true;
            this.tripListBox.Location = new System.Drawing.Point(416, 182);
            this.tripListBox.Name = "tripListBox";
            this.tripListBox.Size = new System.Drawing.Size(425, 160);
            this.tripListBox.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-23, -46);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Week6Exercise.Properties.Resources.moon;
            this.pictureBox2.Location = new System.Drawing.Point(714, 27);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(127, 109);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(866, 419);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tripListBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tripListLabel);
            this.Controls.Add(this.bookTripButton);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.astronautNameTextBox);
            this.Controls.Add(this.astronautNameLabel);
            this.Controls.Add(this.tripToTheMoonLabel);
            this.Name = "Form1";
            this.Text = "Let\'s Go to the Moon!";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label tripToTheMoonLabel;
        private System.Windows.Forms.Label astronautNameLabel;
        private System.Windows.Forms.TextBox astronautNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bookTripButton;
        private System.Windows.Forms.Label tripListLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox tripListBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

