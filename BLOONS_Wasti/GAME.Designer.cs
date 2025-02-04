namespace BLOONS_Wasti
{
    partial class GAME
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
            this.pcbblimp3 = new System.Windows.Forms.PictureBox();
            this.gametmr = new System.Windows.Forms.Timer(this.components);
            this.lblAMMO = new System.Windows.Forms.Label();
            this.lblSCORE = new System.Windows.Forms.Label();
            this.lblHEALTH = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.pcbplayer = new System.Windows.Forms.PictureBox();
            this.pcbblimp2 = new System.Windows.Forms.PictureBox();
            this.pcbblimp1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbplayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbblimp3
            // 
            this.pcbblimp3.BackColor = System.Drawing.Color.Transparent;
            this.pcbblimp3.Image = global::BLOONS_Wasti.Properties.Resources.zup;
            this.pcbblimp3.Location = new System.Drawing.Point(381, 466);
            this.pcbblimp3.Name = "pcbblimp3";
            this.pcbblimp3.Size = new System.Drawing.Size(71, 71);
            this.pcbblimp3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbblimp3.TabIndex = 7;
            this.pcbblimp3.TabStop = false;
            this.pcbblimp3.Tag = "blimp";
            // 
            // gametmr
            // 
            this.gametmr.Enabled = true;
            this.gametmr.Interval = 25;
            this.gametmr.Tick += new System.EventHandler(this.gameEngine);
            // 
            // lblAMMO
            // 
            this.lblAMMO.AutoSize = true;
            this.lblAMMO.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAMMO.Location = new System.Drawing.Point(12, 9);
            this.lblAMMO.Name = "lblAMMO";
            this.lblAMMO.Size = new System.Drawing.Size(124, 25);
            this.lblAMMO.TabIndex = 0;
            this.lblAMMO.Text = "AMMO: 0";
            // 
            // lblSCORE
            // 
            this.lblSCORE.AutoSize = true;
            this.lblSCORE.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSCORE.Location = new System.Drawing.Point(317, 9);
            this.lblSCORE.Name = "lblSCORE";
            this.lblSCORE.Size = new System.Drawing.Size(140, 25);
            this.lblSCORE.TabIndex = 1;
            this.lblSCORE.Text = "SCORE: 0";
            // 
            // lblHEALTH
            // 
            this.lblHEALTH.AutoSize = true;
            this.lblHEALTH.BackColor = System.Drawing.Color.White;
            this.lblHEALTH.Font = new System.Drawing.Font("ROG Fonts", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHEALTH.Location = new System.Drawing.Point(625, 9);
            this.lblHEALTH.Name = "lblHEALTH";
            this.lblHEALTH.Size = new System.Drawing.Size(131, 25);
            this.lblHEALTH.TabIndex = 2;
            this.lblHEALTH.Text = "HEALTH:";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(762, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(149, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // pcbplayer
            // 
            this.pcbplayer.BackColor = System.Drawing.Color.Transparent;
            this.pcbplayer.Location = new System.Drawing.Point(381, 272);
            this.pcbplayer.Name = "pcbplayer";
            this.pcbplayer.Size = new System.Drawing.Size(100, 100);
            this.pcbplayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbplayer.TabIndex = 4;
            this.pcbplayer.TabStop = false;
            // 
            // pcbblimp2
            // 
            this.pcbblimp2.BackColor = System.Drawing.Color.Transparent;
            this.pcbblimp2.Image = global::BLOONS_Wasti.Properties.Resources.zdown;
            this.pcbblimp2.Location = new System.Drawing.Point(690, 145);
            this.pcbblimp2.Name = "pcbblimp2";
            this.pcbblimp2.Size = new System.Drawing.Size(71, 71);
            this.pcbblimp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbblimp2.TabIndex = 5;
            this.pcbblimp2.TabStop = false;
            this.pcbblimp2.Tag = "blimp";
            // 
            // pcbblimp1
            // 
            this.pcbblimp1.BackColor = System.Drawing.Color.Transparent;
            this.pcbblimp1.Image = global::BLOONS_Wasti.Properties.Resources.zdown1;
            this.pcbblimp1.Location = new System.Drawing.Point(131, 145);
            this.pcbblimp1.Name = "pcbblimp1";
            this.pcbblimp1.Size = new System.Drawing.Size(71, 71);
            this.pcbblimp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbblimp1.TabIndex = 6;
            this.pcbblimp1.TabStop = false;
            this.pcbblimp1.Tag = "blimp";
            // 
            // GAME
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 666);
            this.Controls.Add(this.pcbblimp3);
            this.Controls.Add(this.pcbblimp1);
            this.Controls.Add(this.pcbblimp2);
            this.Controls.Add(this.pcbplayer);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblHEALTH);
            this.Controls.Add(this.lblSCORE);
            this.Controls.Add(this.lblAMMO);
            this.Name = "GAME";
            this.Tag = "";
            this.Text = "GAME";
            this.Load += new System.EventHandler(this.GAME_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbplayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbblimp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbblimp3;
        private System.Windows.Forms.Timer gametmr;
        private System.Windows.Forms.Label lblAMMO;
        private System.Windows.Forms.Label lblSCORE;
        private System.Windows.Forms.Label lblHEALTH;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pcbplayer;
        private System.Windows.Forms.PictureBox pcbblimp2;
        private System.Windows.Forms.PictureBox pcbblimp1;
    }
}