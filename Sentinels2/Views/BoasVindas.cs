using System.Diagnostics;
using Word = Microsoft.Office.Interop.Word;
using Microsoft.Office.Interop.Word;
using Sentinels2.Rules;
using Sentinels2.Models;
using Sentinels2.Data;

namespace Sentinels2.Views
{
    public partial class BoasVindas : Form
    {
        private Form w = null;

        internal List<Escala> EscaCRUD { get; private set; }

        public BoasVindas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(w != null)
            {
                w.Dispose();
            }
            panelContent.Controls.Clear();
            w = new WorkflowByDate();
            w.TopLevel = false;
            w.AutoScroll = true;
            w.FormBorderStyle = FormBorderStyle.None;
            w.WindowState = FormWindowState.Maximized;
            w.Parent = panelContent;
            
            panelContent.Controls.Add(w);
            w.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (w != null)
            {
                w.Dispose();
            }
            panelContent.Controls.Clear();
            w = new WorkflowByPerson();
            w = new WorkflowByPerson();
            w.TopLevel = false;
            w.AutoScroll = true;
            w.FormBorderStyle = FormBorderStyle.None;
            w.WindowState = FormWindowState.Maximized;
            w.Parent = panelContent;

            panelContent.Controls.Add(w);
            w.Show();
        }

        private void BoasVindas_Load(object sender, EventArgs e)
        {
           
        }

        private void testesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Repo().Show();
        }

        private void testeProcessStartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process p = Process.Start("C:\\Program Files\\LibreOffice\\program\\swriter.exe");
            p.WaitForInputIdle();
        }

        private void wordInteropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (w != null)
            {
                w.Dispose();
            }
            panelContent.Controls.Clear();

            w = new WorkFlowByPlaces();
            w.TopLevel = false;
            w.AutoScroll = true;
            w.FormBorderStyle = FormBorderStyle.None;
            w.WindowState = FormWindowState.Maximized;
            w.Parent = panelContent;
            
            panelContent.Controls.Add(w);
            w.Show();
        }

        private void preferênciasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new UserPreferences().ShowDialog();
        }

        private void gerenteDeDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("Tools\\SQLiteDatabaseBrowserPortable.exe", GlobalsPathApplication.ReaderFileJSON("Globals\\userconfig.json").DatabasePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Não foi possível executar a aplicaçãao externa\nERRO: {ex.Message}");
            }
        }
    }
}
