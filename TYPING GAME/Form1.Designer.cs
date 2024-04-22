namespace TYPING_GAME
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
            this.lblcorrect = new System.Windows.Forms.Label();
            this.lblincorrect = new System.Windows.Forms.Label();
            this.lblpressenter = new System.Windows.Forms.Label();
            this.lblword = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblcorrect
            // 
            this.lblcorrect.AutoSize = true;
            this.lblcorrect.Location = new System.Drawing.Point(12, 23);
            this.lblcorrect.Name = "lblcorrect";
            this.lblcorrect.Size = new System.Drawing.Size(50, 13);
            this.lblcorrect.TabIndex = 0;
            this.lblcorrect.Text = "Correct:0";
            // 
            // lblincorrect
            // 
            this.lblincorrect.AutoSize = true;
            this.lblincorrect.Location = new System.Drawing.Point(730, 23);
            this.lblincorrect.Name = "lblincorrect";
            this.lblincorrect.Size = new System.Drawing.Size(58, 13);
            this.lblincorrect.TabIndex = 0;
            this.lblincorrect.Text = "Incorrect:0";
            // 
            // lblpressenter
            // 
            this.lblpressenter.AutoSize = true;
            this.lblpressenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpressenter.Location = new System.Drawing.Point(356, 396);
            this.lblpressenter.Name = "lblpressenter";
            this.lblpressenter.Size = new System.Drawing.Size(86, 18);
            this.lblpressenter.TabIndex = 0;
            this.lblpressenter.Text = "Press Enter";
            // 
            // lblword
            // 
            this.lblword.AutoSize = true;
            this.lblword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblword.Location = new System.Drawing.Point(360, 151);
            this.lblword.Name = "lblword";
            this.lblword.Size = new System.Drawing.Size(82, 31);
            this.lblword.TabIndex = 0;
            this.lblword.Text = "Word";
            this.lblword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(249, 225);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(324, 38);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.checkGame);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblincorrect);
            this.Controls.Add(this.lblpressenter);
            this.Controls.Add(this.lblword);
            this.Controls.Add(this.lblcorrect);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcorrect;
        private System.Windows.Forms.Label lblincorrect;
        private System.Windows.Forms.Label lblpressenter;
        private System.Windows.Forms.Label lblword;
        private System.Windows.Forms.TextBox textBox1;
    }
}

