using Sentinels2.Data;
using Sentinels2.Views;

namespace Sentinels2
{
    partial class WorkflowByPerson
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.btFrequencia = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbApelido = new System.Windows.Forms.Label();
            this.btEditar = new System.Windows.Forms.Button();
            this.btNovo = new System.Windows.Forms.Button();
            this.lbNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPessoal = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fDataInicial = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fDataFinal = new System.Windows.Forms.DateTimePicker();
            this.opDiasTrabalhados = new System.Windows.Forms.RadioButton();
            this.opHoraExtra = new System.Windows.Forms.RadioButton();
            this.opAfastamento = new System.Windows.Forms.RadioButton();
            this.btSend = new System.Windows.Forms.Button();
            this.btnRport = new System.Windows.Forms.Button();
            this.dgvDataPerson = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoal)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPerson)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Buscar nome ou apelido";
            this.textBox1.Size = new System.Drawing.Size(185, 33);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.btnSendMsg);
            this.panel1.Controls.Add(this.btFrequencia);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.lbApelido);
            this.panel1.Controls.Add(this.btEditar);
            this.panel1.Controls.Add(this.btNovo);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 244);
            this.panel1.TabIndex = 5;
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(299, 200);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(217, 41);
            this.btnSendMsg.TabIndex = 3;
            this.btnSendMsg.Text = "Avisar Plantões à Todos";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // btFrequencia
            // 
            this.btFrequencia.Location = new System.Drawing.Point(191, 200);
            this.btFrequencia.Name = "btFrequencia";
            this.btFrequencia.Size = new System.Drawing.Size(102, 41);
            this.btFrequencia.TabIndex = 3;
            this.btFrequencia.Text = "Frequência";
            this.btFrequencia.UseVisualStyleBackColor = true;
            this.btFrequencia.Click += new System.EventHandler(this.btFrequencia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(864, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(231, 244);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCargo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCargo.Location = new System.Drawing.Point(25, 56);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(59, 21);
            this.lbCargo.TabIndex = 1;
            this.lbCargo.Text = "Cargo";
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbApelido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbApelido.Location = new System.Drawing.Point(25, 77);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(64, 21);
            this.lbApelido.TabIndex = 1;
            this.lbApelido.Text = "Apelido";
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btEditar.Location = new System.Drawing.Point(92, 200);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(93, 41);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btNovo.Location = new System.Drawing.Point(3, 200);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(86, 41);
            this.btNovo.TabIndex = 2;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // lbNome
            // 
            this.lbNome.AutoSize = true;
            this.lbNome.Font = new System.Drawing.Font("Yu Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbNome.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbNome.Location = new System.Drawing.Point(16, 19);
            this.lbNome.Name = "lbNome";
            this.lbNome.Size = new System.Drawing.Size(391, 27);
            this.lbNome.TabIndex = 1;
            this.lbNome.Text = "Nome Completo do Vigia Selecionado";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 474);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1095, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvPessoal);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 244);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 230);
            this.panel2.TabIndex = 9;
            // 
            // dgvPessoal
            // 
            this.dgvPessoal.AllowUserToAddRows = false;
            this.dgvPessoal.AllowUserToDeleteRows = false;
            this.dgvPessoal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPessoal.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvPessoal.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPessoal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvPessoal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPessoal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPessoal.Location = new System.Drawing.Point(0, 33);
            this.dgvPessoal.MultiSelect = false;
            this.dgvPessoal.Name = "dgvPessoal";
            this.dgvPessoal.ReadOnly = true;
            this.dgvPessoal.RowHeadersVisible = false;
            this.dgvPessoal.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvPessoal.RowTemplate.Height = 25;
            this.dgvPessoal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPessoal.Size = new System.Drawing.Size(185, 197);
            this.dgvPessoal.TabIndex = 8;
            this.dgvPessoal.SelectionChanged += new System.EventHandler(this.dgvPessoal_SelectionChanged);
            this.dgvPessoal.MouseCaptureChanged += new System.EventHandler(this.dgvPessoal_MouseCaptureChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.opDiasTrabalhados);
            this.panel3.Controls.Add(this.opHoraExtra);
            this.panel3.Controls.Add(this.opAfastamento);
            this.panel3.Controls.Add(this.btSend);
            this.panel3.Controls.Add(this.btnRport);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(185, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 91);
            this.panel3.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fDataInicial);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 70);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Ínicial";
            // 
            // fDataInicial
            // 
            this.fDataInicial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDataInicial.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fDataInicial.Location = new System.Drawing.Point(3, 29);
            this.fDataInicial.Name = "fDataInicial";
            this.fDataInicial.Size = new System.Drawing.Size(128, 33);
            this.fDataInicial.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fDataFinal);
            this.groupBox2.Location = new System.Drawing.Point(146, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(134, 70);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Final";
            // 
            // fDataFinal
            // 
            this.fDataFinal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDataFinal.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fDataFinal.Location = new System.Drawing.Point(3, 29);
            this.fDataFinal.Name = "fDataFinal";
            this.fDataFinal.Size = new System.Drawing.Size(128, 33);
            this.fDataFinal.TabIndex = 5;
            // 
            // opDiasTrabalhados
            // 
            this.opDiasTrabalhados.AutoSize = true;
            this.opDiasTrabalhados.Location = new System.Drawing.Point(644, 6);
            this.opDiasTrabalhados.Name = "opDiasTrabalhados";
            this.opDiasTrabalhados.Size = new System.Drawing.Size(155, 25);
            this.opDiasTrabalhados.TabIndex = 4;
            this.opDiasTrabalhados.TabStop = true;
            this.opDiasTrabalhados.Text = "Dias Trabalhados";
            this.opDiasTrabalhados.UseVisualStyleBackColor = true;
            this.opDiasTrabalhados.CheckedChanged += new System.EventHandler(this.opDiasTrabalhados_CheckedChanged);
            // 
            // opHoraExtra
            // 
            this.opHoraExtra.AutoSize = true;
            this.opHoraExtra.Location = new System.Drawing.Point(485, 6);
            this.opHoraExtra.Name = "opHoraExtra";
            this.opHoraExtra.Size = new System.Drawing.Size(108, 25);
            this.opHoraExtra.TabIndex = 4;
            this.opHoraExtra.TabStop = true;
            this.opHoraExtra.Text = "Hora Extra";
            this.opHoraExtra.UseVisualStyleBackColor = true;
            this.opHoraExtra.CheckedChanged += new System.EventHandler(this.opHoraExtra_CheckedChanged);
            // 
            // opAfastamento
            // 
            this.opAfastamento.AutoSize = true;
            this.opAfastamento.Location = new System.Drawing.Point(300, 6);
            this.opAfastamento.Name = "opAfastamento";
            this.opAfastamento.Size = new System.Drawing.Size(131, 25);
            this.opAfastamento.TabIndex = 4;
            this.opAfastamento.TabStop = true;
            this.opAfastamento.Text = "Afastamentos";
            this.opAfastamento.UseVisualStyleBackColor = true;
            this.opAfastamento.CheckedChanged += new System.EventHandler(this.opAfastamento_CheckedChanged);
            // 
            // btSend
            // 
            this.btSend.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btSend.Location = new System.Drawing.Point(805, 46);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(93, 41);
            this.btSend.TabIndex = 3;
            this.btSend.Text = "Enviar";
            this.btSend.UseVisualStyleBackColor = false;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btnRport
            // 
            this.btnRport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRport.Location = new System.Drawing.Point(805, 3);
            this.btnRport.Name = "btnRport";
            this.btnRport.Size = new System.Drawing.Size(93, 41);
            this.btnRport.TabIndex = 3;
            this.btnRport.Text = "Imprimir";
            this.btnRport.UseVisualStyleBackColor = false;
            this.btnRport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // dgvDataPerson
            // 
            this.dgvDataPerson.AllowUserToAddRows = false;
            this.dgvDataPerson.AllowUserToDeleteRows = false;
            this.dgvDataPerson.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDataPerson.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDataPerson.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDataPerson.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDataPerson.Location = new System.Drawing.Point(185, 335);
            this.dgvDataPerson.MultiSelect = false;
            this.dgvDataPerson.Name = "dgvDataPerson";
            this.dgvDataPerson.ReadOnly = true;
            this.dgvDataPerson.RowHeadersVisible = false;
            this.dgvDataPerson.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvDataPerson.RowTemplate.Height = 25;
            this.dgvDataPerson.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDataPerson.Size = new System.Drawing.Size(910, 139);
            this.dgvDataPerson.TabIndex = 11;
            this.dgvDataPerson.MultiSelectChanged += new System.EventHandler(this.dgvDataPerson_MultiSelectChanged);
            this.dgvDataPerson.MouseCaptureChanged += new System.EventHandler(this.dgvDataPerson_MouseCaptureChanged);
            // 
            // WorkflowByPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 496);
            this.Controls.Add(this.dgvDataPerson);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "WorkflowByPerson";
            this.Text = "Sentinels2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.WorkflowByPerson_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoal)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataPerson)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void dgvPessoal_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnPersons();
        }

        private void dgvDataPerson_MouseCaptureChanged(object sender, EventArgs e)
        {
            ContextMenuOnData();
        }

        private void ContextMenuOnPersons()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Editar");
            item1.Click += (object sender, EventArgs e) => {
                try
                {
                    VigiaCRUD.Load(vigia.Id);

                    new NewVigia().ShowDialog();
                }
                catch (Exception ex)
                {
                    statusLabel.Text = $"LOAD_VGM: {ex.Message}";
                }
            };

            menu.Items.Clear();
            menu.Items.Add(item1);

            dgvPessoal.ContextMenuStrip = menu;
        }

        private void ContextMenuOnData()
        {
            ToolStripMenuItem item1 = new ToolStripMenuItem("Gerar Ordem de Serviço");
            ToolStripMenuItem item2 = new ToolStripMenuItem("Enviar para Telefone");
            ToolStripMenuItem item3 = new ToolStripMenuItem("Imprimir Documento Selecionado");

            item1.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            item2.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            item3.Click += (object sender, EventArgs e) => {
                MessageBox.Show("Hello");
            };

            menu.Items.Clear();
            menu.Items.Add(item1);
            menu.Items.Add(item2);
            menu.Items.Add(item3);

            dgvDataPerson.ContextMenuStrip = menu;
        }

        #endregion
        private Panel panel1;
        private Label lbCargo;
        private Label lbApelido;
        private Label lbNome;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Panel panel2;
        private DataGridView dgvPessoal;
        private Button btNovo;
        private Button btEditar;
        private Panel panel3;
        private Button btnRport;
        private DataGridView dgvDataPerson;
        private RadioButton opHoraExtra;
        private RadioButton opAfastamento;
        private GroupBox groupBox1;
        private DateTimePicker fDataInicial;
        private GroupBox groupBox2;
        private DateTimePicker fDataFinal;
        private RadioButton opDiasTrabalhados;
        private Button btFrequencia;
        private Button btnSendMsg;
        private Button btSend;
    }
}