namespace PetitParis_Launcher
{
    using System;
    using System.Diagnostics;
    using System.Security;
    using System.ComponentModel;
    public partial class Form1 : Form
    {
        #region
        public Boolean bSteam = false;
        public Boolean bDiscord = false;
        public Boolean bFiveM = false;
        public Boolean bTeamspeak = false;
        #endregion
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //setAffichageLightIcons();
            VerifAll();
            refreshAllDesign();
            timerVerif.Start();
            //label1.Text = Process.GetProcessesByName("discord").Length.ToString();
            //label1.Text = Properties.Settings.Default.fiveM_path + "\\data";

        }

        private void pictureBox_parametres_Click(object sender, EventArgs e)
        {
            parametres parametres = new parametres();
            parametres.ShowDialog();
            refreshAllDesign();
        }

        private void button_jouer_Click(object sender, EventArgs e)
        {
            Process.Start("https://xelyos.fr/redirect/gta-serveur?url=server.petit-paris.ovh:30120");
        }

        private void pictureBox_ts_Click(object sender, EventArgs e)
        {
            Process.Start("ts3server://" + Properties.Settings.Default.teamspeak  + "?password=serverPassword");
        }

        private void toolStripMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        #region "Fonction de vérification"
        public void VerifAll()
        {
            VerifFiveM();
            VerifDiscord();
            VerifSteam();
        }
        public void VerifFiveM()
        {
        }
        public void VerifSteam()
        {
            if (Process.GetProcessesByName("Steam").Length < 0)
            {
                bSteam = true;
            }
            else
                bSteam = false;

            if (bSteam)
            {
                pictureBox_steam.BackgroundImage = Properties.Resources.logosteamon.Clone(
                    new Rectangle(0,0, Properties.Resources.logosteamon.Width, Properties.Resources.logosteamon.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
                );
            }
            else
            {
                pictureBox_steam.BackgroundImage = Properties.Resources.logosteamoff.Clone(
                    new Rectangle(0, 0, Properties.Resources.logosteamoff.Width, Properties.Resources.logosteamoff.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
                );
            }
        }

        public void VerifDiscord()
        {
            
            //if (Process.GetProcessesByName("discord").Length  0)
              //  bDiscord = true;

            if (Process.GetProcessesByName("discord").Length != 0)
            {
                pictureBox_discord.BackgroundImage = Properties.Resources.discord_logo_on.Clone(
                    new Rectangle(0, 0, Properties.Resources.discord_logo_on.Width, Properties.Resources.discord_logo_on.Height), System.Drawing.Imaging.PixelFormat.DontCare
                );
            }
            else
            {
                pictureBox_discord.BackgroundImage = Properties.Resources.discord_logo_off.Clone(
                    new Rectangle(0, 0, Properties.Resources.discord_logo_off.Width, Properties.Resources.discord_logo_off.Height), System.Drawing.Imaging.PixelFormat.DontCare
                );
            }
        }
        #endregion
        public string getIsJobRole(string role)
        {
            //string[] aJobs = new string[5];
            //aJobs["police"] = "police";

            //return aJobs[role];
            return "";
        }

        public void setAffichageLightIcons()
        {
            label1.Text = Properties.Settings.Default.light_mode.ToString();
            if (Properties.Settings.Default.light_mode == true)
            {
                pictureBox_parametres.BackgroundImage = Properties.Resources.settings_light.Clone(
                    new Rectangle(0, 0, Properties.Resources.settings_light.Width, Properties.Resources.settings_light.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
                );
                pictureBox_viewer.BackgroundImage = Properties.Resources.camera_light.Clone(
                    new Rectangle(0, 0, Properties.Resources.camera_light.Width, Properties.Resources.camera_light.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
                );
            }
            else
            {
                pictureBox_parametres.BackgroundImage = Properties.Resources.settings.Clone(
                    new Rectangle(0, 0, Properties.Resources.settings.Width, Properties.Resources.settings.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
                );
                pictureBox_viewer.BackgroundImage = Properties.Resources.camera.Clone(
                    new Rectangle(0, 0, Properties.Resources.camera_light.Width, Properties.Resources.camera_light.Height),
                    System.Drawing.Imaging.PixelFormat.DontCare
);
            }
            label1.Text = Properties.Settings.Default.light_mode.ToString();
        }

        private void button_vider_cache_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.fiveM_path == "")
            {
                folderBrowserDialogFiveM.ShowDialog();
                Properties.Settings.Default.fiveM_path = folderBrowserDialogFiveM.SelectedPath;
                Properties.Settings.Default.Save();
            }
            else
            {
                CacheRemover cacheRemover = new CacheRemover();
                cacheRemover.ShowDialog();
            }
        }

        private void setColorOfButtons()
        {
                button_jouer.ForeColor = Properties.Settings.Default.buttons_forecolor;
                button_voir_jeux.ForeColor = Properties.Settings.Default.buttons_forecolor;
                button_vider_cache.ForeColor = Properties.Settings.Default.buttons_forecolor;

                button_voir_jeux.BackColor = Properties.Settings.Default.buttons_backcolor;
                button_jouer.BackColor = Properties.Settings.Default.buttons_backcolor;
                button_vider_cache.BackColor = Properties.Settings.Default.buttons_backcolor;
        }
        private void setWallpaper()
        {
            if( Properties.Settings.Default.wallpaper != "")
            {
                BackgroundImage = Image.FromFile(Properties.Settings.Default.wallpaper);
            }
        }
        private void refreshAllDesign()
        {
            setAffichageLightIcons();
            setColorOfButtons();
            //setWallpaper();
        }
        private void timerVerif_Tick(object sender, EventArgs e)
        {
            VerifAll();
        }
    }
}