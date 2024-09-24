namespace HotelFormAppStart
{
    partial class FormHotel
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
            this.GuestListBox = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AddGuestButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.CheckInDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.CheckOutDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxRooms = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 24);
            this.label2.TabIndex = 0;
            this.label2.Text = "Last Name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(179, 39);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(138, 29);
            this.FirstNameTextBox.TabIndex = 1;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(562, 39);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(158, 29);
            this.LastNameTextBox.TabIndex = 2;
            // 
            // GuestListBox
            // 
            this.GuestListBox.FormattingEnabled = true;
            this.GuestListBox.ItemHeight = 24;
            this.GuestListBox.Location = new System.Drawing.Point(50, 291);
            this.GuestListBox.Name = "GuestListBox";
            this.GuestListBox.Size = new System.Drawing.Size(583, 172);
            this.GuestListBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Guest List";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(46, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "Check In";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(433, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 24);
            this.label5.TabIndex = 0;
            this.label5.Text = "Check Out";
            // 
            // AddGuestButton
            // 
            this.AddGuestButton.Location = new System.Drawing.Point(50, 211);
            this.AddGuestButton.Name = "AddGuestButton";
            this.AddGuestButton.Size = new System.Drawing.Size(133, 39);
            this.AddGuestButton.TabIndex = 6;
            this.AddGuestButton.Text = "Add Guest";
            this.AddGuestButton.UseVisualStyleBackColor = true;
            this.AddGuestButton.Click += new System.EventHandler(this.buttonAddGuest_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(701, 291);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(138, 47);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save Data";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CheckInDateTimePicker
            // 
            this.CheckInDateTimePicker.Location = new System.Drawing.Point(179, 108);
            this.CheckInDateTimePicker.Name = "CheckInDateTimePicker";
            this.CheckInDateTimePicker.Size = new System.Drawing.Size(228, 29);
            this.CheckInDateTimePicker.TabIndex = 8;
            // 
            // CheckOutDateTimePicker
            // 
            this.CheckOutDateTimePicker.Location = new System.Drawing.Point(562, 108);
            this.CheckOutDateTimePicker.Name = "CheckOutDateTimePicker";
            this.CheckOutDateTimePicker.Size = new System.Drawing.Size(234, 29);
            this.CheckOutDateTimePicker.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 24);
            this.label6.TabIndex = 10;
            this.label6.Text = "Room";
            // 
            // comboBoxRooms
            // 
            this.comboBoxRooms.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRooms.FormattingEnabled = true;
            this.comboBoxRooms.Location = new System.Drawing.Point(179, 163);
            this.comboBoxRooms.Name = "comboBoxRooms";
            this.comboBoxRooms.Size = new System.Drawing.Size(121, 32);
            this.comboBoxRooms.TabIndex = 11;
            // 
            // FormHotel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(899, 486);
            this.Controls.Add(this.comboBoxRooms);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CheckOutDateTimePicker);
            this.Controls.Add(this.CheckInDateTimePicker);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AddGuestButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.GuestListBox);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "FormHotel";
            this.Text = "Hotel Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.ListBox GuestListBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button AddGuestButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.DateTimePicker CheckInDateTimePicker;
        private System.Windows.Forms.DateTimePicker CheckOutDateTimePicker;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxRooms;
    }
}

