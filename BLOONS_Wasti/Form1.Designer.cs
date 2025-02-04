namespace BLOONS_Wasti
{
    partial class MAIN_MENU
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
            this.btnPLAY = new System.Windows.Forms.Button();
            this.btnHighScore = new System.Windows.Forms.Button();
            this.btnHTP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPLAY
            // 
            this.btnPLAY.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLAY.ForeColor = System.Drawing.Color.Cyan;
            this.btnPLAY.Image = global::BLOONS_Wasti.Properties.Resources.BUTTON_ANIMATION;
            this.btnPLAY.Location = new System.Drawing.Point(12, 279);
            this.btnPLAY.Name = "btnPLAY";
            this.btnPLAY.Size = new System.Drawing.Size(122, 49);
            this.btnPLAY.TabIndex = 0;
            this.btnPLAY.Text = "PLAY";
            this.btnPLAY.UseVisualStyleBackColor = true;
            this.btnPLAY.Click += new System.EventHandler(this.btnPLAY_Click);
            // 
            // btnHighScore
            // 
            this.btnHighScore.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighScore.ForeColor = System.Drawing.Color.Cyan;
            this.btnHighScore.Image = global::BLOONS_Wasti.Properties.Resources.BUTTON_ANIMATION;
            this.btnHighScore.Location = new System.Drawing.Point(12, 334);
            this.btnHighScore.Name = "btnHighScore";
            this.btnHighScore.Size = new System.Drawing.Size(230, 49);
            this.btnHighScore.TabIndex = 1;
            this.btnHighScore.Text = "HIGH SCORE";
            this.btnHighScore.UseVisualStyleBackColor = true;
            this.btnHighScore.Click += new System.EventHandler(this.btnHighScore_Click);
            // 
            // btnHTP
            // 
            this.btnHTP.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHTP.ForeColor = System.Drawing.Color.Cyan;
            this.btnHTP.Image = global::BLOONS_Wasti.Properties.Resources.BUTTON_ANIMATION;
            this.btnHTP.Location = new System.Drawing.Point(12, 389);
            this.btnHTP.Name = "btnHTP";
            this.btnHTP.Size = new System.Drawing.Size(286, 49);
            this.btnHTP.TabIndex = 2;
            this.btnHTP.Text = "HOW TO PLAY";
            this.btnHTP.UseVisualStyleBackColor = true;
            this.btnHTP.Click += new System.EventHandler(this.btnHTP_Click);
            // 
            // MAIN_MENU
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BLOONS_Wasti.Properties.Resources.MAINMENU;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHTP);
            this.Controls.Add(this.btnHighScore);
            this.Controls.Add(this.btnPLAY);
            this.Name = "MAIN_MENU";
            this.Text = "MAIN_MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPLAY;
        private System.Windows.Forms.Button btnHighScore;
        private System.Windows.Forms.Button btnHTP;
    }
}

