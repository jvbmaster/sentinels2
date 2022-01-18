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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.dgvPessoalDisponivel = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTotalDays = new System.Windows.Forms.GroupBox();
            this.opNoturno = new System.Windows.Forms.RadioButton();
            this.opTodos = new System.Windows.Forms.RadioButton();
            this.opDiurno = new System.Windows.Forms.RadioButton();
            this.dgvEscala = new System.Windows.Forms.DataGridView();
            this.plVgm = new System.Windows.Forms.GroupBox();
            this.dgvPlVgm = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoalDisponivel)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.lbTotalDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).BeginInit();
            this.plVgm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).BeginInit();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Black;
            this.calendar.CalendarDimensions = new System.Drawing.Size(1, 3);
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendar.ForeColor = System.Drawing.Color.Silver;
            this.calendar.Location = new System.Drawing.Point(10, 85);
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
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dgvPessoalDisponivel.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPessoalDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoalDisponivel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPessoalDisponivel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPessoalDisponivel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPessoalDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoalDisponivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoalDisponivel.Location = new System.Drawing.Point(957, 92);
            this.dgvPessoalDisponivel.MultiSelect = false;
            this.dgvPessoalDisponivel.Name = "dgvPessoalDisponivel";
            this.dgvPessoalDisponivel.ReadOnly = true;
            this.dgvPessoalDisponivel.RowHeadersVisible = false;
            this.dgvPessoalDisponivel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoalDisponivel.RowTemplate.Height = 25;
            this.dgvPessoalDisponivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoalDisponivel.Size = new System.Drawing.Size(322, 247);
            this.dgvPessoalDisponivel.TabIndex = 5;
            this.dgvPessoalDisponivel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPessoalDisponivel_MouseClick);
            this.dgvPessoalDisponivel.MouseCaptureChanged += new System.EventHandler(this.dgvPessoalDisponivel_MouseCaptureChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 663);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1291, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // lbTotalDays
            // 
            this.lbTotalDays.Controls.Add(this.opNoturno);
            this.lbTotalDays.Controls.Add(this.opTodos);
            this.lbTotalDays.Controls.Add(this.opDiurno);
            this.lbTotalDays.Controls.Add(this.calendar);
            this.lbTotalDays.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbTotalDays.Location = new System.Drawing.Point(0, 0);
            this.lbTotalDays.Name = "lbTotalDays";
            this.lbTotalDays.Size = new System.Drawing.Size(252, 663);
            this.lbTotalDays.TabIndex = 7;
            this.lbTotalDays.TabStop = false;
            // 
            // opNoturno
            // 
            this.opNoturno.AutoSize = true;
            this.opNoturno.Location = new System.Drawing.Point(148, 54);
            this.opNoturno.Name = "opNoturno";
            this.opNoturno.Size = new System.Drawing.Size(87, 25);
            this.opNoturno.TabIndex = 3;
            this.opNoturno.TabStop = true;
            this.opNoturno.Text = "Noturno";
            this.opNoturno.UseVisualStyleBackColor = true;
            this.opNoturno.CheckedChanged += new System.EventHandler(this.opNoturno_CheckedChanged);
            // 
            // opTodos
            // 
            this.opTodos.AutoSize = true;
            this.opTodos.Location = new System.Drawing.Point(10, 27);
            this.opTodos.Name = "opTodos";
            this.opTodos.Size = new System.Drawing.Size(68, 25);
            this.opTodos.TabIndex = 3;
            this.opTodos.TabStop = true;
            this.opTodos.Text = "Todos";
            this.opTodos.UseVisualStyleBackColor = true;
            this.opTodos.CheckedChanged += new System.EventHandler(this.opTodos_CheckedChanged);
            // 
            // opDiurno
            // 
            this.opDiurno.AutoSize = true;
            this.opDiurno.Location = new System.Drawing.Point(148, 25);
            this.opDiurno.Name = "opDiurno";
            this.opDiurno.Size = new System.Drawing.Size(76, 25);
            this.opDiurno.TabIndex = 3;
            this.opDiurno.TabStop = true;
            this.opDiurno.Text = "Diúrno";
            this.opDiurno.UseVisualStyleBackColor = true;
            this.opDiurno.CheckedChanged += new System.EventHandler(this.opDiurno_CheckedChanged);
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
            this.dgvEscala.Size = new System.Drawing.Size(693, 437);
            this.dgvEscala.TabIndex = 8;
            // 
            // plVgm
            // 
            this.plVgm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.plVgm.Controls.Add(this.dgvPlVgm);
            this.plVgm.Location = new System.Drawing.Point(957, 335);
            this.plVgm.Name = "plVgm";
            this.plVgm.Size = new System.Drawing.Size(322, 194);
            this.plVgm.TabIndex = 11;
            this.plVgm.TabStop = false;
            // 
            // dgvPlVgm
            // 
            this.dgvPlVgm.AllowUserToAddRows = false;
            this.dgvPlVgm.AllowUserToDeleteRows = false;
            this.dgvPlVgm.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlVgm.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPlVgm.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPlVgm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlVgm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlVgm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlVgm.Location = new System.Drawing.Point(3, 25);
            this.dgvPlVgm.MultiSelect = false;
            this.dgvPlVgm.Name = "dgvPlVgm";
            this.dgvPlVgm.ReadOnly = true;
            this.dgvPlVgm.RowHeadersVisible = false;
            this.dgvPlVgm.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlVgm.RowTemplate.Height = 25;
            this.dgvPlVgm.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlVgm.Size = new System.Drawing.Size(316, 166);
            this.dgvPlVgm.TabIndex = 3;
            // 
            // WorkflowByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 685);
            this.Controls.Add(this.plVgm);
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
            this.lbTotalDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).EndInit();
            this.plVgm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).EndInit();
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
            //menu.Items.Add(item2); // feriado
            //menu.Items.Add(item3); // lembrete
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
        private GroupBox lbTotalDays;
        private DataGridView dgvEscala;
        private GroupBox plVgm;
        private DataGridView dgvPlVgm;
        private RadioButton opNoturno;
        private RadioButton opTodos;
        private RadioButton opDiurno;
    }
}