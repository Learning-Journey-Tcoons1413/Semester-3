
namespace HotelFormApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.GuestListBox = new System.Windows.Forms.ListBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(492, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstNameTextBox.Location = new System.Drawing.Point(190, 52);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(200, 34);
            this.FirstNameTextBox.TabIndex = 2;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(635, 49);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(240, 34);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Check In";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(492, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 29);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check Out";
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(190, 125);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(284, 34);
            this.CheckInDateTimePicker.TabIndex = 6;
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(635, 125);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(322, 34);
            this.CheckOutDateTimePicker.TabIndex = 7;
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddGuestButton.Location = new System.Drawing.Point(48, 196);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(171, 50);
            this.AddGuestButton.TabIndex = 8;
            this.AddGuestButton.Text = "Add Guest";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.AddGuestButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 29);
            this.label5.TabIndex = 9;
            this.label5.Text = "Guest List";
            // 
            // GuestListBox
            // 
            this.GuestListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestListBox.FormattingEnabled = true;
            this.GuestListBox.ItemHeight = 29;
            this.GuestListBox.Location = new System.Drawing.Point(48, 325);
            this.GuestListBox.Name = "GuestListBox";
            this.GuestListBox.Size = new System.Drawing.Size(591, 207);
            this.GuestListBox.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(700, 344);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(192, 63);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save Data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 586);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.GuestListBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox GuestListBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

