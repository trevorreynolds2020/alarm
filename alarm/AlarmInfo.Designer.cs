namespace alarm
{
    partial class AlarmInfo
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.selectedTime = new System.Windows.Forms.DateTimePicker();
            this.onButton = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(51, 85);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(82, 33);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 85);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 33);
            this.button2.TabIndex = 1;
            this.button2.Text = "Set";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.SetButton);
            // 
            // selectedTime
            // 
            this.selectedTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.selectedTime.Location = new System.Drawing.Point(51, 33);
            this.selectedTime.Name = "selectedTime";
            this.selectedTime.Size = new System.Drawing.Size(200, 20);
            this.selectedTime.TabIndex = 2;
            this.selectedTime.ValueChanged += new System.EventHandler(this.SelectedTime_ValueChanged);
            // 
            // onButton
            // 
            this.onButton.AutoSize = true;
            this.onButton.Location = new System.Drawing.Point(258, 33);
            this.onButton.Name = "onButton";
            this.onButton.Size = new System.Drawing.Size(39, 17);
            this.onButton.TabIndex = 3;
            this.onButton.TabStop = true;
            this.onButton.Text = "On";
            this.onButton.UseVisualStyleBackColor = true;
            this.onButton.CheckedChanged += new System.EventHandler(this.OnChecked);
            // 
            // AlarmInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(312, 141);
            this.Controls.Add(this.onButton);
            this.Controls.Add(this.selectedTime);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cancelButton);
            this.Name = "AlarmInfo";
            this.Text = "AlarmInfo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DateTimePicker selectedTime;
        private System.Windows.Forms.RadioButton onButton;
    }
}