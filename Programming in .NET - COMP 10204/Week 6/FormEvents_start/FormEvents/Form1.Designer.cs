namespace FormEvents
{
    partial class FormAlbum
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
            this.albumPictureBox = new System.Windows.Forms.PictureBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.previousButton = new System.Windows.Forms.Button();
            this.labelInformation = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.albumListComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.albumTitleTextBox = new System.Windows.Forms.TextBox();
            this.artistTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.increaseButton = new System.Windows.Forms.Button();
            this.decreaseButton = new System.Windows.Forms.Button();
            this.InformationToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxGroupBox = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).BeginInit();
            this.checkBoxGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // albumPictureBox
            // 
            this.albumPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.albumPictureBox.Location = new System.Drawing.Point(404, 241);
            this.albumPictureBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumPictureBox.Name = "albumPictureBox";
            this.albumPictureBox.Size = new System.Drawing.Size(293, 270);
            this.albumPictureBox.TabIndex = 0;
            this.albumPictureBox.TabStop = false;
            this.InformationToolTip.SetToolTip(this.albumPictureBox, "Picture of Cover");
            // 
            // nextButton
            // 
            this.nextButton.Location = new System.Drawing.Point(569, 530);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(128, 37);
            this.nextButton.TabIndex = 2;
            this.nextButton.Text = "Next";
            this.nextButton.UseVisualStyleBackColor = true;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // previousButton
            // 
            this.previousButton.Location = new System.Drawing.Point(404, 530);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(121, 37);
            this.previousButton.TabIndex = 1;
            this.previousButton.Text = "Previous";
            this.previousButton.UseVisualStyleBackColor = true;
            this.previousButton.Click += new System.EventHandler(this.previousButton_Click);
            // 
            // labelInformation
            // 
            this.labelInformation.AutoSize = true;
            this.labelInformation.Location = new System.Drawing.Point(43, 36);
            this.labelInformation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInformation.Name = "labelInformation";
            this.labelInformation.Size = new System.Drawing.Size(86, 16);
            this.labelInformation.TabIndex = 3;
            this.labelInformation.Text = "Select Album";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionRichTextBox.Location = new System.Drawing.Point(47, 241);
            this.descriptionRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.ReadOnly = true;
            this.descriptionRichTextBox.Size = new System.Drawing.Size(320, 270);
            this.descriptionRichTextBox.TabIndex = 4;
            this.descriptionRichTextBox.Text = "";
            this.descriptionRichTextBox.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.descriptionRichTextBox_LinkClicked);
            // 
            // albumListComboBox
            // 
            this.albumListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.albumListComboBox.FormattingEnabled = true;
            this.albumListComboBox.Location = new System.Drawing.Point(236, 32);
            this.albumListComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumListComboBox.Name = "albumListComboBox";
            this.albumListComboBox.Size = new System.Drawing.Size(460, 24);
            this.albumListComboBox.TabIndex = 0;
            this.InformationToolTip.SetToolTip(this.albumListComboBox, "Select Album from the List");
            this.albumListComboBox.SelectedIndexChanged += new System.EventHandler(this.albumListComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 81);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Album Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 121);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Artist";
            // 
            // albumTitleTextBox
            // 
            this.albumTitleTextBox.Location = new System.Drawing.Point(236, 78);
            this.albumTitleTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.albumTitleTextBox.Name = "albumTitleTextBox";
            this.albumTitleTextBox.ReadOnly = true;
            this.albumTitleTextBox.Size = new System.Drawing.Size(320, 22);
            this.albumTitleTextBox.TabIndex = 8;
            // 
            // artistTextBox
            // 
            this.artistTextBox.Location = new System.Drawing.Point(236, 117);
            this.artistTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.artistTextBox.Name = "artistTextBox";
            this.artistTextBox.ReadOnly = true;
            this.artistTextBox.Size = new System.Drawing.Size(320, 22);
            this.artistTextBox.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 207);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Description";
            // 
            // increaseButton
            // 
            this.increaseButton.Location = new System.Drawing.Point(47, 539);
            this.increaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.increaseButton.Name = "increaseButton";
            this.increaseButton.Size = new System.Drawing.Size(39, 28);
            this.increaseButton.TabIndex = 10;
            this.increaseButton.Text = "+";
            this.increaseButton.UseVisualStyleBackColor = true;
            this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
            // 
            // decreaseButton
            // 
            this.decreaseButton.Location = new System.Drawing.Point(93, 539);
            this.decreaseButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.decreaseButton.Name = "decreaseButton";
            this.decreaseButton.Size = new System.Drawing.Size(39, 28);
            this.decreaseButton.TabIndex = 10;
            this.decreaseButton.Text = "-";
            this.decreaseButton.UseVisualStyleBackColor = true;
            this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
            // 
            // InformationToolTip
            // 
            this.InformationToolTip.IsBalloon = true;
            // 
            // checkBoxGroupBox
            // 
            this.checkBoxGroupBox.Controls.Add(this.checkBox3);
            this.checkBoxGroupBox.Controls.Add(this.checkBox2);
            this.checkBoxGroupBox.Controls.Add(this.checkBox1);
            this.checkBoxGroupBox.Location = new System.Drawing.Point(236, 159);
            this.checkBoxGroupBox.Name = "checkBoxGroupBox";
            this.checkBoxGroupBox.Size = new System.Drawing.Size(320, 64);
            this.checkBoxGroupBox.TabIndex = 11;
            this.checkBoxGroupBox.TabStop = false;
            this.checkBoxGroupBox.Text = "groupBox1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 21);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(95, 20);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(107, 21);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(95, 20);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(219, 21);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(95, 20);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 12;
            this.label4.Text = "label4";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(149, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FormAlbum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 620);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.checkBoxGroupBox);
            this.Controls.Add(this.decreaseButton);
            this.Controls.Add(this.increaseButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.artistTextBox);
            this.Controls.Add(this.albumTitleTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.albumListComboBox);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.labelInformation);
            this.Controls.Add(this.previousButton);
            this.Controls.Add(this.nextButton);
            this.Controls.Add(this.albumPictureBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormAlbum";
            this.Text = "Album Catalog";
            ((System.ComponentModel.ISupportInitialize)(this.albumPictureBox)).EndInit();
            this.checkBoxGroupBox.ResumeLayout(false);
            this.checkBoxGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox albumPictureBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Label labelInformation;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.ComboBox albumListComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox albumTitleTextBox;
        private System.Windows.Forms.TextBox artistTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button increaseButton;
        private System.Windows.Forms.Button decreaseButton;
        private System.Windows.Forms.ToolTip InformationToolTip;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.GroupBox checkBoxGroupBox;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

