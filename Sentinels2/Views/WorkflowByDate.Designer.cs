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
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.lbCurrentDate = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.lbTotalDays = new System.Windows.Forms.GroupBox();
            this.opNoturno = new System.Windows.Forms.RadioButton();
            this.opTodos = new System.Windows.Forms.RadioButton();
            this.opDiurno = new System.Windows.Forms.RadioButton();
            this.dgvEscala = new System.Windows.Forms.DataGridView();
            this.plVgm = new System.Windows.Forms.GroupBox();
            this.dgvPlVgm = new System.Windows.Forms.DataGridView();
            this.dgvPessoalDisponivel = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fDataInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fDataFinal = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1.SuspendLayout();
            this.lbTotalDays.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).BeginInit();
            this.plVgm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoalDisponivel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.BackColor = System.Drawing.Color.Black;
            this.calendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.calendar.ForeColor = System.Drawing.Color.Silver;
            this.calendar.Location = new System.Drawing.Point(10, 92);
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
            this.opDiurno.Location = new System.Drawing.Point(148, 27);
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
            this.dgvEscala.MouseCaptureChanged += new System.EventHandler(this.dgvEscala_MouseCaptureChanged);
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
            // dgvPessoalDisponivel
            // 
            this.dgvPessoalDisponivel.AllowUserToAddRows = false;
            this.dgvPessoalDisponivel.AllowUserToDeleteRows = false;
            this.dgvPessoalDisponivel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPessoalDisponivel.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPessoalDisponivel.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPessoalDisponivel.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPessoalDisponivel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoalDisponivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoalDisponivel.Location = new System.Drawing.Point(960, 92);
            this.dgvPessoalDisponivel.MultiSelect = false;
            this.dgvPessoalDisponivel.Name = "dgvPessoalDisponivel";
            this.dgvPessoalDisponivel.ReadOnly = true;
            this.dgvPessoalDisponivel.RowHeadersVisible = false;
            this.dgvPessoalDisponivel.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoalDisponivel.RowTemplate.Height = 25;
            this.dgvPessoalDisponivel.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoalDisponivel.Size = new System.Drawing.Size(319, 237);
            this.dgvPessoalDisponivel.TabIndex = 12;
            this.dgvPessoalDisponivel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPessoalDisponivel_MouseClick);
            this.dgvPessoalDisponivel.MouseCaptureChanged += new System.EventHandler(this.dgvPessoalDisponivel_MouseCaptureChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fDataInicial);
            this.groupBox1.Location = new System.Drawing.Point(983, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 70);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Ínicial";
            // 
            // fDataInicial
            // 
            this.fDataInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fDataInicial.Location = new System.Drawing.Point(3, 25);
            this.fDataInicial.Name = "fDataInicial";
            this.fDataInicial.Size = new System.Drawing.Size(128, 29);
            this.fDataInicial.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.fDataFinal);
            this.groupBox2.Location = new System.Drawing.Point(1123, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 70);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Final";
            // 
            // fDataFinal
            // 
            this.fDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fDataFinal.Location = new System.Drawing.Point(3, 25);
            this.fDataFinal.Name = "fDataFinal";
            this.fDataFinal.Size = new System.Drawing.Size(128, 29);
            this.fDataFinal.TabIndex = 5;
            // 
            // WorkflowByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1291, 685);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvPessoalDisponivel);
            this.Controls.Add(this.plVgm);
            this.Controls.Add(this.dgvEscala);
            this.Controls.Add(this.lbTotalDays);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lbCurrentDate);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkflowByDate";
            this.Text = "Sentinels2 - Workflow By Date - Barbieri Computer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkflowByDate_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.lbTotalDays.ResumeLayout(false);
            this.lbTotalDays.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEscala)).EndInit();
            this.plVgm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoalDisponivel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
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
            //calendar.AccessibilityObject.HitTest(MousePosition.X, MousePosition.Y).Select(AccessibleSelection.TakeSelection);
            ContextMenuOnCalendar();
        }

        private void dgvPessoalDisponivel_MouseCaptureChanged(object sender, EventArgs e)
        {
            dgvPessoalDisponivel.AccessibilityObject.HitTest(MousePosition.X, MousePosition.Y).Select(AccessibleSelection.TakeSelection);
            ContextMenuOnPessoalDisponivel();
            LoadPlantoesPorVGM();
        }

        

        #endregion
        private MonthCalendar calendar;
        private Label label1;
        private Label lbCurrentDate;
        private ContextMenuStrip menu = new ContextMenuStrip();
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private GroupBox lbTotalDays;
        private DataGridView dgvEscala;
        private GroupBox plVgm;
        private DataGridView dgvPlVgm;
        private RadioButton opNoturno;
        private RadioButton opTodos;
        private RadioButton opDiurno;
        private DataGridView dgvPessoalDisponivel;
        private GroupBox groupBox1;
        private DateTimePicker fDataInicial;
        private GroupBox groupBox2;
        private DateTimePicker fDataFinal;
    }
}