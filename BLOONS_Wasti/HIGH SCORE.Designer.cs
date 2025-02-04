namespace BLOONS_Wasti
{
    partial class HIGH_SCORE
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
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.txtShowHighScores = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(38, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(151, 13);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter your name to save score";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(195, 46);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 1;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(41, 81);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(254, 56);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display HighScore";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // txtShowHighScores
            // 
            this.txtShowHighScores.BackColor = System.Drawing.Color.Black;
            this.txtShowHighScores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtShowHighScores.ForeColor = System.Drawing.Color.White;
            this.txtShowHighScores.Location = new System.Drawing.Point(118, 203);
            this.txtShowHighScores.Multiline = true;
            this.txtShowHighScores.Name = "txtShowHighScores";
            this.txtShowHighScores.ReadOnly = true;
            this.txtShowHighScores.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtShowHighScores.Size = new System.Drawing.Size(538, 191);
            this.txtShowHighScores.TabIndex = 25;
            this.txtShowHighScores.WordWrap = false;
            // 
            // HIGH_SCORE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtShowHighScores);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Name = "HIGH_SCORE";
            this.Text = "HIGH_SCORE";
            
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.TextBox txtShowHighScores;
    }
}