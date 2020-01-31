namespace alarm
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
            this.uxEdit = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.alarmsList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxEdit
            // 
            this.uxEdit.Enabled = false;
            this.uxEdit.Location = new System.Drawing.Point(54, 12);
            this.uxEdit.Name = "uxEdit";
            this.uxEdit.Size = new System.Drawing.Size(76, 39);
            this.uxEdit.TabIndex = 0;
            this.uxEdit.Text = "Edit";
            this.uxEdit.UseVisualStyleBackColor = true;
            this.uxEdit.Click += new System.EventHandler(this.UxEdit_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(136, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 40);
            this.button2.TabIndex = 1;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.AddButton);
            // 
            // alarmsList
            // 
            this.alarmsList.FormattingEnabled = true;
            this.alarmsList.Location = new System.Drawing.Point(54, 58);
            this.alarmsList.Name = "alarmsList";
            this.alarmsList.ScrollAlwaysVisible = true;
            this.alarmsList.Size = new System.Drawing.Size(157, 160);
            this.alarmsList.TabIndex = 2;
            this.alarmsList.SelectedIndexChanged += new System.EventHandler(this.AlarmsList_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(54, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Snooze";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(136, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 36);
            this.button4.TabIndex = 4;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 336);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.alarmsList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.uxEdit);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button uxEdit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox alarmsList;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

