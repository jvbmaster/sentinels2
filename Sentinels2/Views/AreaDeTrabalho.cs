
using Sentinels2.Models;
using Sentinels2.Data;
using Sentinels2.Views;

namespace Sentinels2
{
    public partial class AreaDeTrabalho : Form
    {
        private ContextMenuStrip fruitContextMenuStrip;
        private int daysSum = 0;
        public AreaDeTrabalho()
        {
            this.Visible = false;
            InitializeComponent();
        }

        private void MonthCalendar1_DateChanged(object? sender, DateRangeEventArgs e)
        {
            ContextMenuInitialize();
        }

        public void ContextMenuInitialize()
        {
            // Create a new ContextMenuStrip control.
            fruitContextMenuStrip = new ContextMenuStrip();

            fruitContextMenuStrip.Visible = false;

            // Attach an event handler for the 
            // ContextMenuStrip control's Opening event.
            fruitContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(cms_Opening);

            // Create a new ToolStrip control.
            ToolStrip ts = new ToolStrip();

            // Create a ToolStripDropDownButton control and add it
            // to the ToolStrip control's Items collections.
            ToolStripDropDownButton fruitToolStripDropDownButton = new ToolStripDropDownButton("Fruit", null, null, "Fruit");
            ts.Items.Add(fruitToolStripDropDownButton);

            // Dock the ToolStrip control to the top of the form.
            //ts.Dock = DockStyle.Top;

            // Assign the ContextMenuStrip control as the 
            // ToolStripDropDownButton control's DropDown menu.
            fruitToolStripDropDownButton.DropDown = fruitContextMenuStrip;

            // Create a new MenuStrip control and add a ToolStripMenuItem.
            MenuStrip ms = new MenuStrip();
            ToolStripMenuItem fruitToolStripMenuItem = new ToolStripMenuItem("Fruit", null, null, "Fruit");
            ms.Items.Add(fruitToolStripMenuItem);

            // Dock the MenuStrip control to the top of the form.
            ms.Dock = DockStyle.Top;

            // Assign the MenuStrip control as the 
            // ToolStripMenuItem's DropDown menu.
            fruitToolStripMenuItem.DropDown = fruitContextMenuStrip;

            // Assign the ContextMenuStrip to the form's 
            // ContextMenuStrip property.
            this.ContextMenuStrip = fruitContextMenuStrip;

            // Add the ToolStrip control to the Controls collection.
            this.Controls.Add(ts);

            //Add a button to the form and assign its ContextMenuStrip.
            Button b = new Button();
            b.Location = new System.Drawing.Point(60, 60);
            this.Controls.Add(b);
            b.ContextMenuStrip = fruitContextMenuStrip;

            // Add the MenuStrip control last.
            // This is important for correct placement in the z-order.
            this.Controls.Add(ms);
        }

        void cms_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // Acquire references to the owning control and item.
            Control c = fruitContextMenuStrip.SourceControl as Control;
            ToolStripDropDownItem tsi = fruitContextMenuStrip.OwnerItem as ToolStripDropDownItem;

            // Clear the ContextMenuStrip control's Items collection.
            fruitContextMenuStrip.Items.Clear();

            // Check the source control first.
            if (c != null)
            {
                // Add custom item (Form)
                fruitContextMenuStrip.Items.Add("Source: " + c.GetType().ToString());
            }
            else if (tsi != null)
            {
                // Add custom item (ToolStripDropDownButton or ToolStripMenuItem)
                fruitContextMenuStrip.Items.Add("Source: " + tsi.GetType().ToString());
            }

            // Populate the ContextMenuStrip control with its default items.
            fruitContextMenuStrip.Items.Add("-");
            fruitContextMenuStrip.Items.Add("Apples");
            fruitContextMenuStrip.Items.Add("Oranges");
            fruitContextMenuStrip.Items.Add("Pears");

            // Set Cancel to false. 
            // It is optimized to true based on empty entry.
            e.Cancel = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void test1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                await db.Database.EnsureCreatedAsync();
                Escala escala = new Escala {
                    OS = 0001,
                    Patrimonio = "Estação Cultura",
                    Data = new DateTime(2021, 12, 05),
                    Entrada = new DateTime(2021, 12, 05, 19, 0, 0),
                    Saida = new DateTime(2021, 12, 05, 19, 0, 0).AddHours(12),
                    Vigia = "Barbieri",
                    Motivo = "Risco de Furto Ou Dano",
                    TipoPagamento = "EXTRA",
                    Duracao = 12
                };
                db.Add(escala);
                try
                {
                    await db.SaveChangesAsync();
                    MessageBox.Show("Cool");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"{ex}");
                }
                
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            daysSum = (int) (((monthCalendar1.SelectionRange.End - monthCalendar1.SelectionRange.Start).TotalDays) + 1);

            DateTime entrada = new DateTime(2021, 12, 06, 0, 0, 0);
            DateTime saida = new DateTime(2021, 12, 06, 05, 0, 0);
            double duration = (double)(saida - entrada).TotalHours;
            label17.Text = (daysSum > 1) ? $"{daysSum} dias" : $"{daysSum} dia\n{duration}";
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            label14.Text = monthCalendar1.SelectionStart.ToString("D");
        }

        private void monthCalendar1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            List<string> l = new List<string>();
            l.Add("Escala");
            l.Add("Lembrete");
            l.Add("Afastamento");

            RigthContextMenu menu = new RigthContextMenu(this);
            menu.Items.Clear();
            menu.Items.AddRange(l);
            menu.RightClick();
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            Visible = false;
            if(new BoasVindas().ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }

        private void AreaDeTrabalho_Load(object sender, EventArgs e)
        {
            if(new BoasVindas().ShowDialog() == DialogResult.Cancel)
            {
                Visible = true;
            }
        }
    }
}