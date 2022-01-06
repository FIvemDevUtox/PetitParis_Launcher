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
    public partial class Form_Background : Form
    {
        public Form_Background()
        {
            InitializeComponent();
        }

        private void Form_Background_Load(object sender, EventArgs e)
        {
            var files = Directory.GetFiles("C:\\Users\\Florian\\Pictures\\FiveM", "*.JPG");
            comboBox1.Items.Add("Par défaut");
            foreach (var file in files)
            {
                comboBox1.Items.Add(Path.GetFileName(file));
            }
        }
    }
}
