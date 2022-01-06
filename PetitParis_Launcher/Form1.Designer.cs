namespace PetitParis_Launcher
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox_steam = new System.Windows.Forms.PictureBox();
            this.pictureBox_ts = new System.Windows.Forms.PictureBox();
            this.pictureBox_discord = new System.Windows.Forms.PictureBox();
            this.button_jouer = new System.Windows.Forms.Button();
            this.button_vider_cache = new System.Windows.Forms.Button();
            this.button_voir_jeux = new System.Windows.Forms.Button();
            this.nos_sites_picture = new System.Windows.Forms.PictureBox();
            this.pictureBox_viewer = new System.Windows.Forms.PictureBox();
            this.pictureBox_parametres = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialogFiveM = new System.Windows.Forms.FolderBrowserDialog();
            this.timerVerif = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_steam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_discord)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nos_sites_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_viewer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parametres)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_steam
            // 
            this.pictureBox_steam.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_steam.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.logosteamoff;
            this.pictureBox_steam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_steam.Location = new System.Drawing.Point(491, 400);
            this.pictureBox_steam.Name = "pictureBox_steam";
            this.pictureBox_steam.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_steam.TabIndex = 0;
            this.pictureBox_steam.TabStop = false;
            // 
            // pictureBox_ts
            // 
            this.pictureBox_ts.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_ts.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.camera;
            this.pictureBox_ts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_ts.Location = new System.Drawing.Point(532, 400);
            this.pictureBox_ts.Name = "pictureBox_ts";
            this.pictureBox_ts.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_ts.TabIndex = 1;
            this.pictureBox_ts.TabStop = false;
            this.pictureBox_ts.Click += new System.EventHandler(this.pictureBox_ts_Click);
            // 
            // pictureBox_discord
            // 
            this.pictureBox_discord.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_discord.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.discord_logo_off;
            this.pictureBox_discord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_discord.Location = new System.Drawing.Point(450, 400);
            this.pictureBox_discord.Name = "pictureBox_discord";
            this.pictureBox_discord.Size = new System.Drawing.Size(35, 35);
            this.pictureBox_discord.TabIndex = 2;
            this.pictureBox_discord.TabStop = false;
            // 
            // button_jouer
            // 
            this.button_jouer.Location = new System.Drawing.Point(576, 351);
            this.button_jouer.Name = "button_jouer";
            this.button_jouer.Size = new System.Drawing.Size(340, 43);
            this.button_jouer.TabIndex = 3;
            this.button_jouer.Text = "Jouer";
            this.button_jouer.UseVisualStyleBackColor = true;
            this.button_jouer.Click += new System.EventHandler(this.button_jouer_Click);
            // 
            // button_vider_cache
            // 
            this.button_vider_cache.Location = new System.Drawing.Point(576, 400);
            this.button_vider_cache.Name = "button_vider_cache";
            this.button_vider_cache.Size = new System.Drawing.Size(167, 35);
            this.button_vider_cache.TabIndex = 4;
            this.button_vider_cache.Text = "Vider le cache";
            this.button_vider_cache.UseVisualStyleBackColor = true;
            this.button_vider_cache.Click += new System.EventHandler(this.button_vider_cache_Click);
            // 
            // button_voir_jeux
            // 
            this.button_voir_jeux.Location = new System.Drawing.Point(749, 400);
            this.button_voir_jeux.Name = "button_voir_jeux";
            this.button_voir_jeux.Size = new System.Drawing.Size(167, 35);
            this.button_voir_jeux.TabIndex = 5;
            this.button_voir_jeux.Text = "Voir les fichiers du jeu";
            this.button_voir_jeux.UseVisualStyleBackColor = true;
            // 
            // nos_sites_picture
            // 
            this.nos_sites_picture.BackColor = System.Drawing.Color.Transparent;
            this.nos_sites_picture.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.logo_petit_paris;
            this.nos_sites_picture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.nos_sites_picture.Location = new System.Drawing.Point(12, 386);
            this.nos_sites_picture.Name = "nos_sites_picture";
            this.nos_sites_picture.Size = new System.Drawing.Size(50, 50);
            this.nos_sites_picture.TabIndex = 7;
            this.nos_sites_picture.TabStop = false;
            // 
            // pictureBox_viewer
            // 
            this.pictureBox_viewer.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_viewer.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.camera;
            this.pictureBox_viewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_viewer.Location = new System.Drawing.Point(68, 386);
            this.pictureBox_viewer.Name = "pictureBox_viewer";
            this.pictureBox_viewer.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_viewer.TabIndex = 8;
            this.pictureBox_viewer.TabStop = false;
            // 
            // pictureBox_parametres
            // 
            this.pictureBox_parametres.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_parametres.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.settings;
            this.pictureBox_parametres.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_parametres.Location = new System.Drawing.Point(124, 386);
            this.pictureBox_parametres.Name = "pictureBox_parametres";
            this.pictureBox_parametres.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_parametres.TabIndex = 9;
            this.pictureBox_parametres.TabStop = false;
            this.pictureBox_parametres.Click += new System.EventHandler(this.pictureBox_parametres_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 351);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "label1";
            // 
            // timerVerif
            // 
            this.timerVerif.Interval = 1000;
            this.timerVerif.Tick += new System.EventHandler(this.timerVerif_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PetitParis_Launcher.Properties.Resources.Drapeau;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(928, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox_parametres);
            this.Controls.Add(this.pictureBox_viewer);
            this.Controls.Add(this.nos_sites_picture);
            this.Controls.Add(this.button_voir_jeux);
            this.Controls.Add(this.button_vider_cache);
            this.Controls.Add(this.button_jouer);
            this.Controls.Add(this.pictureBox_discord);
            this.Controls.Add(this.pictureBox_ts);
            this.Controls.Add(this.pictureBox_steam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.Name = "Form1";
            this.Text = "Petit Paris Rp";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_steam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_discord)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nos_sites_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_viewer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_parametres)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox_steam;
        private PictureBox pictureBox_ts;
        private PictureBox pictureBox_discord;
        private Button button_jouer;
        private Button button_vider_cache;
        private Button button_voir_jeux;
        private PictureBox nos_sites_picture;
        private PictureBox pictureBox_viewer;
        private PictureBox pictureBox_parametres;
        private Label label1;
        private FolderBrowserDialog folderBrowserDialogFiveM;
        private System.Windows.Forms.Timer timerVerif;
    }
}