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
    public partial class CacheRemover : Form
    {
        public CacheRemover()
        {
            InitializeComponent();
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            String sCaption = "Confirmer la suppression du cache";
            String sMsg = "Etes vous sûr ? L'action est irréversible";
            MessageBoxButtons messageBoxButtons = MessageBoxButtons.YesNo;
            var sResult = MessageBox.Show(sMsg, sCaption, messageBoxButtons, MessageBoxIcon.Warning);

            if (sResult == DialogResult.Yes)
            {
                deleteCache();
                refreshCacheRemove();
            }
            else
                Close();
        }

        private void CacheRemover_Load(object sender, EventArgs e)
        {
            String path = Properties.Settings.Default.fiveM_path + "\\data";

            if (Directory.Exists(path) == true && Properties.Settings.Default.fiveM_path != "")
            {
                foreach (string directory in Directory.GetDirectories(path))
                {
                    checkedListBox1.Items.Add(directory);
                }
            }
            else
            {
                String sMsg = "Erreur : veuillez sélectionner un chemin valide pour FiveM";
                String sTitle = "Chemin du cache invalide";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                var sResult = MessageBox.Show(sMsg, sTitle, buttons, MessageBoxIcon.Warning);
                
                if (sResult != DialogResult.Yes) 
                    Close();
            }
        }
        private void refreshCacheRemove()
        {
            String path = Properties.Settings.Default.fiveM_path + "\\data";

            if (Directory.Exists(path) == true && Properties.Settings.Default.fiveM_path != "")
            {
                foreach (string directory in Directory.GetDirectories(path))
                {
                    checkedListBox1.Items.Add(directory);
                }
            }
        }
        private void deleteCache()
        {
            var checkedItems = checkedListBox1.CheckedItems;
            int iCptCompteur = 0;

            foreach (var directory in checkedItems)
            {
                if (directory != null)
                {
                    Directory.Delete(directory.ToString(), true);
                    iCptCompteur++;
                }
            }

        }
    }
}
