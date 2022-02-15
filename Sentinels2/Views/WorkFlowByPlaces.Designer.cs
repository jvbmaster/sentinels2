namespace Sentinels2.Views
{
    partial class WorkFlowByPlaces
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
            this.dgvPlaces = new System.Windows.Forms.DataGridView();
            this.dgvDates = new System.Windows.Forms.DataGridView();
            this.dgvPersons = new System.Windows.Forms.DataGridView();
            this.fSearch = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.plVgm = new System.Windows.Forms.GroupBox();
            this.dgvPlVgm = new System.Windows.Forms.DataGridView();
            this.opNoturno = new System.Windows.Forms.RadioButton();
            this.opTodos = new System.Windows.Forms.RadioButton();
            this.opDiurno = new System.Windows.Forms.RadioButton();
            this.btAdd = new System.Windows.Forms.Button();
            this.gSubstituicoes = new System.Windows.Forms.GroupBox();
            this.lbSubsituicao = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fDataInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fDataFinal = new System.Windows.Forms.DateTimePicker();
            this.todosVigias = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.plVgm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).BeginInit();
            this.gSubstituicoes.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPlaces
            // 
            this.dgvPlaces.AllowUserToAddRows = false;
            this.dgvPlaces.AllowUserToDeleteRows = false;
            this.dgvPlaces.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlaces.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPlaces.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPlaces.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPlaces.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlaces.Location = new System.Drawing.Point(12, 73);
            this.dgvPlaces.MultiSelect = false;
            this.dgvPlaces.Name = "dgvPlaces";
            this.dgvPlaces.ReadOnly = true;
            this.dgvPlaces.RowHeadersVisible = false;
            this.dgvPlaces.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPlaces.RowTemplate.Height = 25;
            this.dgvPlaces.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlaces.Size = new System.Drawing.Size(331, 376);
            this.dgvPlaces.TabIndex = 3;
            this.dgvPlaces.SelectionChanged += new System.EventHandler(this.dgvPlaces_SelectionChanged);
            this.dgvPlaces.MouseCaptureChanged += new System.EventHandler(this.dgvPlaces_MouseCaptureChanged);
            // 
            // dgvDates
            // 
            this.dgvDates.AllowUserToAddRows = false;
            this.dgvDates.AllowUserToDeleteRows = false;
            this.dgvDates.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDates.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDates.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDates.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDates.Location = new System.Drawing.Point(349, 38);
            this.dgvDates.MultiSelect = false;
            this.dgvDates.Name = "dgvDates";
            this.dgvDates.ReadOnly = true;
            this.dgvDates.RowHeadersVisible = false;
            this.dgvDates.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDates.RowTemplate.Height = 25;
            this.dgvDates.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDates.Size = new System.Drawing.Size(568, 411);
            this.dgvDates.TabIndex = 3;
            this.dgvDates.SelectionChanged += new System.EventHandler(this.dgvDates_SelectionChanged);
            this.dgvDates.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvDates_MouseClick);
            this.dgvDates.MouseCaptureChanged += new System.EventHandler(this.dgvDates_MouseCaptureChanged);
            // 
            // dgvPersons
            // 
            this.dgvPersons.AllowUserToAddRows = false;
            this.dgvPersons.AllowUserToDeleteRows = false;
            this.dgvPersons.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPersons.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPersons.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPersons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersons.Location = new System.Drawing.Point(923, 160);
            this.dgvPersons.MultiSelect = false;
            this.dgvPersons.Name = "dgvPersons";
            this.dgvPersons.ReadOnly = true;
            this.dgvPersons.RowHeadersVisible = false;
            this.dgvPersons.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPersons.RowTemplate.Height = 25;
            this.dgvPersons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPersons.Size = new System.Drawing.Size(352, 289);
            this.dgvPersons.TabIndex = 3;
            this.dgvPersons.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPersons_MouseClick);
            this.dgvPersons.MouseCaptureChanged += new System.EventHandler(this.dgvPersons_MouseCaptureChanged);
            // 
            // fSearch
            // 
            this.fSearch.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fSearch.Location = new System.Drawing.Point(12, 38);
            this.fSearch.Name = "fSearch";
            this.fSearch.PlaceholderText = "Buscar por patrimônios";
            this.fSearch.Size = new System.Drawing.Size(257, 29);
            this.fSearch.TabIndex = 8;
            this.fSearch.TextChanged += new System.EventHandler(this.fSearch_TextChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 634);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1369, 22);
            this.statusStrip1.TabIndex = 9;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // plVgm
            // 
            this.plVgm.Controls.Add(this.dgvPlVgm);
            this.plVgm.Location = new System.Drawing.Point(923, 455);
            this.plVgm.Name = "plVgm";
            this.plVgm.Size = new System.Drawing.Size(352, 158);
            this.plVgm.TabIndex = 10;
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
            this.dgvPlVgm.Size = new System.Drawing.Size(346, 130);
            this.dgvPlVgm.TabIndex = 3;
            // 
            // opNoturno
            // 
            this.opNoturno.AutoSize = true;
            this.opNoturno.Location = new System.Drawing.Point(252, 7);
            this.opNoturno.Name = "opNoturno";
            this.opNoturno.Size = new System.Drawing.Size(87, 25);
            this.opNoturno.TabIndex = 11;
            this.opNoturno.TabStop = true;
            this.opNoturno.Text = "Noturno";
            this.opNoturno.UseVisualStyleBackColor = true;
            this.opNoturno.CheckedChanged += new System.EventHandler(this.opNoturno_CheckedChanged);
            // 
            // opTodos
            // 
            this.opTodos.AutoSize = true;
            this.opTodos.Location = new System.Drawing.Point(12, 7);
            this.opTodos.Name = "opTodos";
            this.opTodos.Size = new System.Drawing.Size(68, 25);
            this.opTodos.TabIndex = 12;
            this.opTodos.TabStop = true;
            this.opTodos.Text = "Todos";
            this.opTodos.UseVisualStyleBackColor = true;
            this.opTodos.CheckedChanged += new System.EventHandler(this.opTodos_CheckedChanged);
            // 
            // opDiurno
            // 
            this.opDiurno.AutoSize = true;
            this.opDiurno.Location = new System.Drawing.Point(128, 7);
            this.opDiurno.Name = "opDiurno";
            this.opDiurno.Size = new System.Drawing.Size(76, 25);
            this.opDiurno.TabIndex = 13;
            this.opDiurno.TabStop = true;
            this.opDiurno.Text = "Diúrno";
            this.opDiurno.UseVisualStyleBackColor = true;
            this.opDiurno.CheckedChanged += new System.EventHandler(this.opDiurno_CheckedChanged);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(275, 38);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(68, 29);
            this.btAdd.TabIndex = 14;
            this.btAdd.Text = "Novo";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // gSubstituicoes
            // 
            this.gSubstituicoes.Controls.Add(this.lbSubsituicao);
            this.gSubstituicoes.Location = new System.Drawing.Point(12, 455);
            this.gSubstituicoes.Name = "gSubstituicoes";
            this.gSubstituicoes.Size = new System.Drawing.Size(905, 155);
            this.gSubstituicoes.TabIndex = 15;
            this.gSubstituicoes.TabStop = false;
            // 
            // lbSubsituicao
            // 
            this.lbSubsituicao.AutoSize = true;
            this.lbSubsituicao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbSubsituicao.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbSubsituicao.Location = new System.Drawing.Point(3, 25);
            this.lbSubsituicao.Name = "lbSubsituicao";
            this.lbSubsituicao.Size = new System.Drawing.Size(0, 25);
            this.lbSubsituicao.TabIndex = 0;
            this.lbSubsituicao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.fDataInicial);
            this.groupBox1.Location = new System.Drawing.Point(961, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 70);
            this.groupBox1.TabIndex = 16;
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
            this.groupBox2.Location = new System.Drawing.Point(1101, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 70);
            this.groupBox2.TabIndex = 17;
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
            // todosVigias
            // 
            this.todosVigias.AutoSize = true;
            this.todosVigias.Location = new System.Drawing.Point(923, 129);
            this.todosVigias.Name = "todosVigias";
            this.todosVigias.Size = new System.Drawing.Size(171, 25);
            this.todosVigias.TabIndex = 18;
            this.todosVigias.Text = "Mostrar todos vigias";
            this.todosVigias.UseVisualStyleBackColor = true;
            // 
            // WorkFlowByPlaces
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1369, 656);
            this.Controls.Add(this.todosVigias);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gSubstituicoes);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.opNoturno);
            this.Controls.Add(this.opTodos);
            this.Controls.Add(this.opDiurno);
            this.Controls.Add(this.plVgm);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.fSearch);
            this.Controls.Add(this.dgvPersons);
            this.Controls.Add(this.dgvDates);
            this.Controls.Add(this.dgvPlaces);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "WorkFlowByPlaces";
            this.Text = "WorkFlowByAgents";
            this.Load += new System.EventHandler(this.WorkFlowByPlaces_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlaces)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersons)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.plVgm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlVgm)).EndInit();
            this.gSubstituicoes.ResumeLayout(false);
            this.gSubstituicoes.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void ContextMenuOnPersons()
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

            dgvPersons.ContextMenuStrip = menu;
        }

        private void ContextMenuOnPlaces()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Editar");

            item1.Click += EditarPatrimonio;

            menu.Items.Clear();
            menu.Items.Add(item1);

            dgvPlaces.ContextMenuStrip = menu;
        }

        #endregion

        private DataGridView dgvPlaces;
        private DataGridView dgvDates;
        private DataGridView dgvPersons;
        private TextBox fSearch;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private GroupBox plVgm;
        private DataGridView dgvPlVgm;
        private RadioButton opNoturno;
        private RadioButton opTodos;
        private RadioButton opDiurno;
        private Button btAdd;
        private GroupBox gSubstituicoes;
        private Label lbSubsituicao;
        private GroupBox groupBox1;
        private DateTimePicker fDataInicial;
        private GroupBox groupBox2;
        private DateTimePicker fDataFinal;
        private CheckBox todosVigias;
    }
}