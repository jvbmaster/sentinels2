using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sentinels2.Models;

namespace Sentinels2
{
    public partial class UserPreferences : Form
    {
        public UserPreferences()
        {
            InitializeComponent();
        }

        private void btSearchPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if(ofd.ShowDialog() == DialogResult.OK)
            {
                fPathDB.Text = ofd.FileName;
            }
        }

        private void btSearchPath2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                fPathOfficeSuite.Text = ofd.FileName;
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (GlobalsPathApplication pdb = new GlobalsPathApplication())
                {
                    pdb.DatabasePath = fPathDB.Text;
                    pdb.OfficeApplicationPath = fPathOfficeSuite.Text;
                    pdb.SaveFileJSON("Globals\\userconfig.json");
                    MessageBox.Show("Cool");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível salvar as preferências\nErro: {ex.Message}");
            }
        }

        private void UserePreferences_Load(object sender, EventArgs e)
        {
            try
            {
                fPathDB.Text = GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").DatabasePath;
                fPathOfficeSuite.Text = GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").OfficeApplicationPath;
            }
            catch (Exception ex)
            {
                statusLabel.Text = $"{ex.Message}";
            }
        }

    }
}
