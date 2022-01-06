using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetitParis_Launcher
{
    public partial class parametres : Form
    {
        Form1 form1 = new Form1();
        public parametres()
        {
            InitializeComponent();
        }

        private void parametres_Load(object sender, EventArgs e)
        {
            verifCheck();
        }

        private void verifCheck()
        {
            if (Properties.Settings.Default.light_mode == true)
                checkBox_lightMode.Checked = true;
        }

        private void checkBox_lightMode_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_lightMode.Checked)
                Properties.Settings.Default.light_mode = true;
            
            else
                Properties.Settings.Default.light_mode = false;

            Properties.Settings.Default.Save();
            form1.setAffichageLightIcons();

        }

        private void button_foreColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Properties.Settings.Default.buttons_forecolor = colorDialog1.Color;
            Properties.Settings.Default.Save();
        }

        private void button_backColor_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            Properties.Settings.Default.buttons_backcolor = colorDialog1.Color;
            Properties.Settings.Default.Save();
        }

        private void button_police_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (fontDialog1.Font == null)
                Properties.Settings.Default.polices = fontDialog1.Font;

            Properties.Settings.Default.Save();
        }

        private void button_changeBackground_Click(object sender, EventArgs e)
        {
            Form_Background formBackground = new Form_Background();
            formBackground.ShowDialog();
        }
    }
}
