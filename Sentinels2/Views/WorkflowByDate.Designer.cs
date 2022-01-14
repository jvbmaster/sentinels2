namespace Sentinels2.Views
{
    partial class WorkflowByDate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkflowByDate));
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.dgvPessoalDisponivel = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zerarOrdensDeServiçoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTotalDays = new System.Windows.Forms.GroupBox();
            this.dgvEscala = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoalDisponivel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.lbTotalDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Black;
            this.calendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendar.ForeColor = System.Drawing.Color.Silver;
            this.calendar.Location = new System.Drawing.Point(3, 25);
            this.calendar.Margin = new System.Windows.Forms.Padding(12, 10, 12, 10);
            this.calendar.MaxSelectionCount = 365;
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 2;
            this.calendar.TitleBackColor = System.Drawing.Color.AliceBlue;
            this.calendar.TrailingForeColor = System.Drawing.SystemColors.HotTrack;
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            this.calendar.MouseCaptureChanged += new System.EventHandler(this.calendar_MouseCaptureChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(258, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Demanda coberta em:";
            // 
            // lbCurrentDate
            // 
            this.lbCurrentDate.AutoSize = true;
            this.lbCurrentDate.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbCurrentDate.Location = new System.Drawing.Point(266, 56);
            this.lbCurrentDate.Name = "lbCurrentDate";
            this.lbCurrentDate.Size = new System.Drawing.Size(0, 24);
            this.lbCurrentDate.TabIndex = 3;
            // 
            // dgvPessoalDisponivel
            // 
            this.dgvPessoalDisponivel.AllowUserToAddRows = false;
            this.dgvPessoalDisponivel.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPessoalDisponivel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPessoalDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoalDisponivel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPessoalDisponivel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPessoalDisponivel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPessoalDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoalDisponivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoalDisponivel.Location = new System.Drawing.Point(913, 92);
            this.dgvPessoalDisponivel.MultiSelect = false;
            this.dgvPessoalDisponivel.Name = "dgvPessoalDisponivel";
            this.dgvPessoalDisponivel.ReadOnly = true;
            this.dgvPessoalDisponivel.RowHeadersVisible = false;
            this.dgvPessoalDisponivel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoalDisponivel.RowTemplate.Height = 25;
            this.dgvPessoalDisponivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoalDisponivel.Size = new System.Drawing.Size(322, 424);
            this.dgvPessoalDisponivel.TabIndex = 5;
            this.dgvPessoalDisponivel.MouseCaptureChanged += new System.EventHandler(this.dgvPessoalDisponivel_MouseCaptureChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel,
            this.toolStripDropDownButton1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 557);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1247, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zerarOrdensDeServiçoToolStripMenuItem});
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            // 
            // zerarOrdensDeServiçoToolStripMenuItem
            // 
            this.zerarOrdensDeServiçoToolStripMenuItem.Name = "zerarOrdensDeServiçoToolStripMenuItem";
            this.zerarOrdensDeServiçoToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.zerarOrdensDeServiçoToolStripMenuItem.Text = "Zerar Ordens de Serviço";
            this.zerarOrdensDeServiçoToolStripMenuItem.Click += new System.EventHandler(this.zerarOrdensDeServiçoToolStripMenuItem_Click);
            // 
            // lbTotalDays
            // 
            this.lbTotalDays.Controls.Add(this.calendar);
            this.lbTotalDays.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTotalDays.Location = new System.Drawing.Point(0, 0);
            this.lbTotalDays.Name = "lbTotalDays";
            this.lbTotalDays.Size = new System.Drawing.Size(252, 557);
            this.lbTotalDays.TabIndex = 7;
            this.lbTotalDays.TabStop = false;
            // 
            // dgvEscala
            // 
            this.dgvEscala.AllowUserToAddRows = false;
            this.dgvEscala.AllowUserToDeleteRows = false;
            this.dgvEscala.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEscala.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvEscala.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvEscala.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvEscala.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvEscala.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEscala.Location = new System.Drawing.Point(258, 92);
            this.dgvEscala.MultiSelect = false;
            this.dgvEscala.Name = "dgvEscala";
            this.dgvEscala.ReadOnly = true;
            this.dgvEscala.RowHeadersVisible = false;
            this.dgvEscala.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvEscala.RowTemplate.Height = 25;
            this.dgvEscala.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEscala.Size = new System.Drawing.Size(649, 424);
            this.dgvEscala.TabIndex = 8;
            // 
            // WorkflowByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1247, 579);
            this.Controls.Add(this.dgvEscala);
            this.Controls.Add(this.lbTotalDays);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgvPessoalDisponivel);
            this.Controls.Add(this.lbCurrentDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkflowByDate";
            this.Text = "Sentinels2 - Workflow By Date - Barbieri Computer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkflowByDate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoalDisponivel)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.lbTotalDays.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ContextMenuOnCalendar()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Adicionar Plantão");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Adicionar Feriado");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Adicionar Lembrete");
            ToolStripMenuItem item4 = new ToolStripMenuItem("Adicionar Afastamento");
            ToolStripMenuItem item5 = new ToolStripMenuItem("Designar Vigias Fixos");

            item1.Click += AdicionarPlantao;
            item2.Click += AdicionarFeriado;
            item3.Click += AdicionarLembrete;
            item4.Click += AdicionarAfastamento;
            item5.Click += DesignarVigiasFixos;

            menu.Items.Clear();
            menu.Items.Add(item1);
            menu.Items.Add(item5);
            menu.Items.Add(item2);
            menu.Items.Add(item3);
            menu.Items.Add(item4);

            calendar.ContextMenuStrip = menu;
        }

        private void ContextMenuOnPessoalDisponivel()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Escalar como Hora Extra");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Escalar como Dia Normal");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Escalar como Troca de dia Normal");

            item1.Click += EscalarExtra;
            item2.Click += EscalarNormal;
            item3.Click += EscalarTroca;

            menu.Items.Clear();
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);

            dgvPessoalDisponivel.ContextMenuStrip = menu;
        }

        private void calendar_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnCalendar();
        }

        private void dgvPessoalDisponivel_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnPessoalDisponivel();
        }

        

        #endregion
        private MonthCalendar calendar;
        private Label label1;
        private Label lbCurrentDate;
        private ContextMenuStrip menu = new ContextMenuStrip();
        private DataGridView dgvPessoalDisponivel;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem configuraçõesToolStripMenuItem;
        private ToolStripMenuItem zerarOrdensDeServiçoToolStripMenuItem;
        private GroupBox lbTotalDays;
        private DataGridView dgvEscala;
    }
}