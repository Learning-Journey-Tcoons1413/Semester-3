namespace Week11Exercise
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
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.listCarsButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.Label();
            this.selectedVehicleLabel = new System.Windows.Forms.Label();
            this.averageMileageLabel = new System.Windows.Forms.Label();
            this.selectedVehicleTextBox = new System.Windows.Forms.TextBox();
            this.averageMileageTextBox = new System.Windows.Forms.TextBox();
            this.addCarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // resultsListBox
            // 
            this.resultsListBox.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 20;
            this.resultsListBox.Location = new System.Drawing.Point(13, 99);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(526, 324);
            this.resultsListBox.TabIndex = 0;
            this.resultsListBox.MouseCaptureChanged += new System.EventHandler(this.resultsListBox_MouseCaptureChanged);
            // 
            // listCarsButton
            // 
            this.listCarsButton.Location = new System.Drawing.Point(13, 53);
            this.listCarsButton.Name = "listCarsButton";
            this.listCarsButton.Size = new System.Drawing.Size(146, 29);
            this.listCarsButton.TabIndex = 1;
            this.listCarsButton.Text = "Get list of cars";
            this.listCarsButton.UseVisualStyleBackColor = true;
            this.listCarsButton.Click += new System.EventHandler(this.listCarsButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(13, 430);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(84, 16);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = "Staus Label: ";
            // 
            // selectedVehicleLabel
            // 
            this.selectedVehicleLabel.AutoSize = true;
            this.selectedVehicleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectedVehicleLabel.Location = new System.Drawing.Point(609, 150);
            this.selectedVehicleLabel.Name = "selectedVehicleLabel";
            this.selectedVehicleLabel.Size = new System.Drawing.Size(134, 20);
            this.selectedVehicleLabel.TabIndex = 3;
            this.selectedVehicleLabel.Text = "Selected Vehicle";
            // 
            // averageMileageLabel
            // 
            this.averageMileageLabel.AutoSize = true;
            this.averageMileageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageMileageLabel.Location = new System.Drawing.Point(609, 189);
            this.averageMileageLabel.Name = "averageMileageLabel";
            this.averageMileageLabel.Size = new System.Drawing.Size(133, 20);
            this.averageMileageLabel.TabIndex = 4;
            this.averageMileageLabel.Text = "Average Mileage";
            // 
            // selectedVehicleTextBox
            // 
            this.selectedVehicleTextBox.Location = new System.Drawing.Point(758, 150);
            this.selectedVehicleTextBox.Name = "selectedVehicleTextBox";
            this.selectedVehicleTextBox.ReadOnly = true;
            this.selectedVehicleTextBox.Size = new System.Drawing.Size(247, 22);
            this.selectedVehicleTextBox.TabIndex = 5;
            // 
            // averageMileageTextBox
            // 
            this.averageMileageTextBox.Location = new System.Drawing.Point(758, 189);
            this.averageMileageTextBox.Name = "averageMileageTextBox";
            this.averageMileageTextBox.ReadOnly = true;
            this.averageMileageTextBox.Size = new System.Drawing.Size(100, 22);
            this.averageMileageTextBox.TabIndex = 6;
            // 
            // addCarButton
            // 
            this.addCarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCarButton.Location = new System.Drawing.Point(612, 227);
            this.addCarButton.Name = "addCarButton";
            this.addCarButton.Size = new System.Drawing.Size(130, 29);
            this.addCarButton.TabIndex = 7;
            this.addCarButton.Text = "Add Car";
            this.addCarButton.UseVisualStyleBackColor = true;
            this.addCarButton.Click += new System.EventHandler(this.addCarButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 477);
            this.Controls.Add(this.addCarButton);
            this.Controls.Add(this.averageMileageTextBox);
            this.Controls.Add(this.selectedVehicleTextBox);
            this.Controls.Add(this.averageMileageLabel);
            this.Controls.Add(this.selectedVehicleLabel);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.listCarsButton);
            this.Controls.Add(this.resultsListBox);
            this.Name = "MainForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultsListBox;
        private System.Windows.Forms.Button listCarsButton;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label selectedVehicleLabel;
        private System.Windows.Forms.Label averageMileageLabel;
        private System.Windows.Forms.TextBox selectedVehicleTextBox;
        private System.Windows.Forms.TextBox averageMileageTextBox;
        private System.Windows.Forms.Button addCarButton;
    }
}

