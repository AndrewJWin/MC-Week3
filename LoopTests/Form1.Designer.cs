namespace LoopTests
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
            this.btnWhile = new System.Windows.Forms.Button();
            this.btnDoWhile = new System.Windows.Forms.Button();
            this.btnForLoop = new System.Windows.Forms.Button();
            this.trkLoops = new System.Windows.Forms.TrackBar();
            this.lblForLoop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trkLoops)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWhile
            // 
            this.btnWhile.Location = new System.Drawing.Point(87, 65);
            this.btnWhile.Name = "btnWhile";
            this.btnWhile.Size = new System.Drawing.Size(163, 23);
            this.btnWhile.TabIndex = 0;
            this.btnWhile.Text = "While Loop";
            this.btnWhile.UseVisualStyleBackColor = true;
            this.btnWhile.Click += new System.EventHandler(this.btnWhile_Click);
            // 
            // btnDoWhile
            // 
            this.btnDoWhile.Location = new System.Drawing.Point(305, 65);
            this.btnDoWhile.Name = "btnDoWhile";
            this.btnDoWhile.Size = new System.Drawing.Size(163, 23);
            this.btnDoWhile.TabIndex = 1;
            this.btnDoWhile.Text = "Do While Loop";
            this.btnDoWhile.UseVisualStyleBackColor = true;
            this.btnDoWhile.Click += new System.EventHandler(this.btnDoWhile_Click);
            // 
            // btnForLoop
            // 
            this.btnForLoop.Location = new System.Drawing.Point(528, 65);
            this.btnForLoop.Name = "btnForLoop";
            this.btnForLoop.Size = new System.Drawing.Size(163, 23);
            this.btnForLoop.TabIndex = 2;
            this.btnForLoop.Text = "For Loop";
            this.btnForLoop.UseVisualStyleBackColor = true;
            this.btnForLoop.Click += new System.EventHandler(this.btnForLoop_Click);
            // 
            // trkLoops
            // 
            this.trkLoops.Location = new System.Drawing.Point(528, 94);
            this.trkLoops.Maximum = 15;
            this.trkLoops.Minimum = 1;
            this.trkLoops.Name = "trkLoops";
            this.trkLoops.Size = new System.Drawing.Size(132, 56);
            this.trkLoops.TabIndex = 3;
            this.trkLoops.Value = 1;
            this.trkLoops.Scroll += new System.EventHandler(this.trkLoops_Scroll);
            // 
            // lblForLoop
            // 
            this.lblForLoop.AutoSize = true;
            this.lblForLoop.Location = new System.Drawing.Point(666, 108);
            this.lblForLoop.Name = "lblForLoop";
            this.lblForLoop.Size = new System.Drawing.Size(16, 17);
            this.lblForLoop.TabIndex = 4;
            this.lblForLoop.Text = "1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 146);
            this.Controls.Add(this.lblForLoop);
            this.Controls.Add(this.trkLoops);
            this.Controls.Add(this.btnForLoop);
            this.Controls.Add(this.btnDoWhile);
            this.Controls.Add(this.btnWhile);
            this.Name = "Form1";
            this.Text = "Loop Examples";
            ((System.ComponentModel.ISupportInitialize)(this.trkLoops)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWhile;
        private System.Windows.Forms.Button btnDoWhile;
        private System.Windows.Forms.Button btnForLoop;
        private System.Windows.Forms.TrackBar trkLoops;
        private System.Windows.Forms.Label lblForLoop;
    }
}

