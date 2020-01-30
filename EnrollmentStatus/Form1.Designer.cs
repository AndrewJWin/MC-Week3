namespace EnrollmentStatus
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
            this.btnWhatStatus = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.txtCredits = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnWhatStatus
            // 
            this.btnWhatStatus.Location = new System.Drawing.Point(88, 84);
            this.btnWhatStatus.Name = "btnWhatStatus";
            this.btnWhatStatus.Size = new System.Drawing.Size(202, 31);
            this.btnWhatStatus.TabIndex = 0;
            this.btnWhatStatus.Text = "What\'s my status?";
            this.btnWhatStatus.UseVisualStyleBackColor = true;
            this.btnWhatStatus.Click += new System.EventHandler(this.btnWhatStatus_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblStatus.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(40, 137);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(299, 23);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status shown here";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtCredits
            // 
            this.txtCredits.Location = new System.Drawing.Point(239, 32);
            this.txtCredits.Name = "txtCredits";
            this.txtCredits.Size = new System.Drawing.Size(100, 22);
            this.txtCredits.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Number of credits";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 206);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCredits);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnWhatStatus);
            this.Name = "Form1";
            this.Text = "Full time, half time?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhatStatus;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.Label label2;
    }
}

