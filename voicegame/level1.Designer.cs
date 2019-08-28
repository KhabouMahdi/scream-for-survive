namespace voicegame
{
    partial class level1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(level1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.hPigeon = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.h1 = new System.Windows.Forms.PictureBox();
            this.h2 = new System.Windows.Forms.PictureBox();
            this.h3 = new System.Windows.Forms.PictureBox();
            this.lblgameover = new System.Windows.Forms.Label();
            this.htop = new System.Windows.Forms.PictureBox();
            this.hbas = new System.Windows.Forms.PictureBox();
            this.hfinal = new System.Windows.Forms.PictureBox();
            this.hYourImg = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnScQui = new System.Windows.Forms.Button();
            this.btnScrLoud = new System.Windows.Forms.Button();
            this.lbllev1 = new System.Windows.Forms.Label();
            this.hanyimg = new System.Windows.Forms.PictureBox();
            this.btnPigean = new System.Windows.Forms.Button();
            this.btnYourImg = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hPigeon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.htop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hfinal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYourImg)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hanyimg)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(70, 19);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(453, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(576, 64);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // hPigeon
            // 
            this.hPigeon.BackColor = System.Drawing.Color.Transparent;
            this.hPigeon.Image = ((System.Drawing.Image)(resources.GetObject("hPigeon.Image")));
            this.hPigeon.Location = new System.Drawing.Point(90, 196);
            this.hPigeon.Name = "hPigeon";
            this.hPigeon.Size = new System.Drawing.Size(128, 89);
            this.hPigeon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hPigeon.TabIndex = 3;
            this.hPigeon.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // h1
            // 
            this.h1.BackColor = System.Drawing.Color.Peru;
            this.h1.Image = ((System.Drawing.Image)(resources.GetObject("h1.Image")));
            this.h1.Location = new System.Drawing.Point(281, 386);
            this.h1.Name = "h1";
            this.h1.Size = new System.Drawing.Size(94, 352);
            this.h1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h1.TabIndex = 4;
            this.h1.TabStop = false;
            // 
            // h2
            // 
            this.h2.BackColor = System.Drawing.Color.Peru;
            this.h2.Image = ((System.Drawing.Image)(resources.GetObject("h2.Image")));
            this.h2.Location = new System.Drawing.Point(392, 470);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(95, 268);
            this.h2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h2.TabIndex = 5;
            this.h2.TabStop = false;
            // 
            // h3
            // 
            this.h3.BackColor = System.Drawing.Color.Peru;
            this.h3.Image = ((System.Drawing.Image)(resources.GetObject("h3.Image")));
            this.h3.Location = new System.Drawing.Point(608, 219);
            this.h3.Name = "h3";
            this.h3.Size = new System.Drawing.Size(138, 519);
            this.h3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.h3.TabIndex = 6;
            this.h3.TabStop = false;
            // 
            // lblgameover
            // 
            this.lblgameover.AutoSize = true;
            this.lblgameover.BackColor = System.Drawing.Color.Black;
            this.lblgameover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblgameover.Font = new System.Drawing.Font("Snap ITC", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameover.ForeColor = System.Drawing.Color.Red;
            this.lblgameover.Location = new System.Drawing.Point(306, 294);
            this.lblgameover.Name = "lblgameover";
            this.lblgameover.Size = new System.Drawing.Size(612, 123);
            this.lblgameover.TabIndex = 7;
            this.lblgameover.Text = "game over";
            this.lblgameover.Visible = false;
            this.lblgameover.Click += new System.EventHandler(this.lblgameover_Click);
            // 
            // htop
            // 
            this.htop.Location = new System.Drawing.Point(12, 3);
            this.htop.Name = "htop";
            this.htop.Size = new System.Drawing.Size(1279, 10);
            this.htop.TabIndex = 8;
            this.htop.TabStop = false;
            this.htop.Click += new System.EventHandler(this.v_Click);
            // 
            // hbas
            // 
            this.hbas.Location = new System.Drawing.Point(12, 737);
            this.hbas.Name = "hbas";
            this.hbas.Size = new System.Drawing.Size(1290, 10);
            this.hbas.TabIndex = 9;
            this.hbas.TabStop = false;
            // 
            // hfinal
            // 
            this.hfinal.BackColor = System.Drawing.Color.Black;
            this.hfinal.Image = ((System.Drawing.Image)(resources.GetObject("hfinal.Image")));
            this.hfinal.Location = new System.Drawing.Point(964, 12);
            this.hfinal.Name = "hfinal";
            this.hfinal.Size = new System.Drawing.Size(136, 726);
            this.hfinal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hfinal.TabIndex = 10;
            this.hfinal.TabStop = false;
            // 
            // hYourImg
            // 
            this.hYourImg.Image = ((System.Drawing.Image)(resources.GetObject("hYourImg.Image")));
            this.hYourImg.Location = new System.Drawing.Point(90, 196);
            this.hYourImg.Name = "hYourImg";
            this.hYourImg.Size = new System.Drawing.Size(128, 89);
            this.hYourImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hYourImg.TabIndex = 13;
            this.hYourImg.TabStop = false;
            this.hYourImg.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lbllev1);
            this.panel1.Controls.Add(this.hanyimg);
            this.panel1.Controls.Add(this.btnPigean);
            this.panel1.Controls.Add(this.btnYourImg);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnStartGame);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 744);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnScQui);
            this.panel2.Controls.Add(this.btnScrLoud);
            this.panel2.Location = new System.Drawing.Point(932, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(193, 105);
            this.panel2.TabIndex = 12;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnScQui
            // 
            this.btnScQui.BackColor = System.Drawing.Color.Tan;
            this.btnScQui.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScQui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScQui.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScQui.Location = new System.Drawing.Point(42, 17);
            this.btnScQui.Name = "btnScQui";
            this.btnScQui.Size = new System.Drawing.Size(99, 31);
            this.btnScQui.TabIndex = 1;
            this.btnScQui.Text = "scream quietly";
            this.btnScQui.UseVisualStyleBackColor = false;
            this.btnScQui.Click += new System.EventHandler(this.btnScQui_Click);
            // 
            // btnScrLoud
            // 
            this.btnScrLoud.BackColor = System.Drawing.Color.White;
            this.btnScrLoud.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnScrLoud.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScrLoud.Font = new System.Drawing.Font("Arial", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScrLoud.ForeColor = System.Drawing.Color.Black;
            this.btnScrLoud.Location = new System.Drawing.Point(42, 54);
            this.btnScrLoud.Name = "btnScrLoud";
            this.btnScrLoud.Size = new System.Drawing.Size(99, 31);
            this.btnScrLoud.TabIndex = 0;
            this.btnScrLoud.Text = "scream loudly";
            this.btnScrLoud.UseVisualStyleBackColor = false;
            this.btnScrLoud.Click += new System.EventHandler(this.btnScrLoud_Click);
            // 
            // lbllev1
            // 
            this.lbllev1.AutoSize = true;
            this.lbllev1.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllev1.ForeColor = System.Drawing.Color.Tan;
            this.lbllev1.Location = new System.Drawing.Point(521, 247);
            this.lbllev1.Name = "lbllev1";
            this.lbllev1.Size = new System.Drawing.Size(258, 81);
            this.lbllev1.TabIndex = 11;
            this.lbllev1.Text = "Level 1";
            // 
            // hanyimg
            // 
            this.hanyimg.Location = new System.Drawing.Point(654, 573);
            this.hanyimg.Name = "hanyimg";
            this.hanyimg.Size = new System.Drawing.Size(117, 72);
            this.hanyimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hanyimg.TabIndex = 9;
            this.hanyimg.TabStop = false;
            // 
            // btnPigean
            // 
            this.btnPigean.BackColor = System.Drawing.Color.Tan;
            this.btnPigean.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPigean.BackgroundImage")));
            this.btnPigean.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPigean.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPigean.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPigean.Location = new System.Drawing.Point(429, 563);
            this.btnPigean.Name = "btnPigean";
            this.btnPigean.Size = new System.Drawing.Size(162, 91);
            this.btnPigean.TabIndex = 7;
            this.btnPigean.UseVisualStyleBackColor = false;
            this.btnPigean.Click += new System.EventHandler(this.btnPigean_Click);
            // 
            // btnYourImg
            // 
            this.btnYourImg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYourImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnYourImg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYourImg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYourImg.Location = new System.Drawing.Point(650, 563);
            this.btnYourImg.Name = "btnYourImg";
            this.btnYourImg.Size = new System.Drawing.Size(178, 91);
            this.btnYourImg.TabIndex = 6;
            this.btnYourImg.Text = "pick pict";
            this.btnYourImg.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYourImg.UseVisualStyleBackColor = false;
            this.btnYourImg.Click += new System.EventHandler(this.btnYourImg_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 71.99999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Tan;
            this.label1.Location = new System.Drawing.Point(262, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(777, 98);
            this.label1.TabIndex = 3;
            this.label1.Text = "Scream for survive";
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.Tan;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartGame.Location = new System.Drawing.Point(429, 365);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(399, 148);
            this.btnStartGame.TabIndex = 2;
            this.btnStartGame.Text = " Start game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(468, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Pick your active mic";
            // 
            // level1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1303, 750);
            this.Controls.Add(this.lblgameover);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hfinal);
            this.Controls.Add(this.hbas);
            this.Controls.Add(this.htop);
            this.Controls.Add(this.h3);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.h1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.hPigeon);
            this.Controls.Add(this.hYourImg);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "level1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "level1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hPigeon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.htop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hbas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hfinal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hYourImg)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hanyimg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox hPigeon;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.PictureBox h1;
        private System.Windows.Forms.PictureBox h2;
        private System.Windows.Forms.PictureBox h3;
        private System.Windows.Forms.Label lblgameover;
        private System.Windows.Forms.PictureBox htop;
        private System.Windows.Forms.PictureBox hbas;
        private System.Windows.Forms.PictureBox hfinal;
        private System.Windows.Forms.PictureBox hYourImg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPigean;
        private System.Windows.Forms.Button btnYourImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStartGame;
        private System.Windows.Forms.PictureBox hanyimg;
        private System.Windows.Forms.Label lbllev1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnScQui;
        private System.Windows.Forms.Button btnScrLoud;
        private System.Windows.Forms.Label label2;
    }
}

