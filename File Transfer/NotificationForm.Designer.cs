﻿namespace File_Transfer
{
    partial class NotificationForm
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
            this.notificationTempLabel = new System.Windows.Forms.Label();
            this.txtSpeed = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // notificationTempLabel
            // 
            this.notificationTempLabel.AutoSize = true;
            this.notificationTempLabel.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notificationTempLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.notificationTempLabel.Location = new System.Drawing.Point(12, 31);
            this.notificationTempLabel.Name = "notificationTempLabel";
            this.notificationTempLabel.Size = new System.Drawing.Size(175, 18);
            this.notificationTempLabel.TabIndex = 3;
            this.notificationTempLabel.Text = "Please wait. File Sending to";
            this.notificationTempLabel.UseWaitCursor = true;
            // 
            // txtSpeed
            // 
            this.txtSpeed.AutoSize = true;
            this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeed.ForeColor = System.Drawing.Color.White;
            this.txtSpeed.Location = new System.Drawing.Point(10, 93);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(181, 29);
            this.txtSpeed.TabIndex = 4;
            this.txtSpeed.Text = "Upload Speed: ";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(568, 131);
            this.Controls.Add(this.txtSpeed);
            this.Controls.Add(this.notificationTempLabel);
            this.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "NotificationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label notificationTempLabel;
        private System.Windows.Forms.Label txtSpeed;
        private System.Windows.Forms.Timer timer1;
    }
}