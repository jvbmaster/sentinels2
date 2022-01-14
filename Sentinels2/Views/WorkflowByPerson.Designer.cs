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
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbIdade = new System.Windows.Forms.Label();
            this.lbCargo = new System.Windows.Forms.Label();
            this.lbTempoDeCasa = new System.Windows.Forms.Label();
            this.lbAdimissao = new System.Windows.Forms.Label();
            this.lbApelido = new System.Windows.Forms.Label();
            this.lbNome = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgvPessoal = new System.Windows.Forms.DataGridView();
            this.btNovo = new System.Windows.Forms.Button();
            this.btEditar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnRport = new System.Windows.Forms.Button();
            this.dgvAfastamentos = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPessoal)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfastamentos)).BeginInit();
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
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lbIdade);
            this.panel1.Controls.Add(this.lbCargo);
            this.panel1.Controls.Add(this.lbTempoDeCasa);
            this.panel1.Controls.Add(this.lbAdimissao);
            this.panel1.Controls.Add(this.lbApelido);
            this.panel1.Controls.Add(this.lbNome);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1095, 244);
            this.panel1.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label7.Location = new System.Drawing.Point(16, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 21);
            this.label7.TabIndex = 1;
            this.label7.Text = "Idade";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(16, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "Desde:";
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
            // lbIdade
            // 
            this.lbIdade.AutoSize = true;
            this.lbIdade.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbIdade.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbIdade.Location = new System.Drawing.Point(16, 216);
            this.lbIdade.Name = "lbIdade";
            this.lbIdade.Size = new System.Drawing.Size(180, 21);
            this.lbIdade.TabIndex = 1;
            this.lbIdade.Text = "x anos, x meses, x dias";
            // 
            // lbCargo
            // 
            this.lbCargo.AutoSize = true;
            this.lbCargo.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbCargo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbCargo.Location = new System.Drawing.Point(16, 87);
            this.lbCargo.Name = "lbCargo";
            this.lbCargo.Size = new System.Drawing.Size(59, 21);
            this.lbCargo.TabIndex = 1;
            this.lbCargo.Text = "Cargo";
            // 
            // lbTempoDeCasa
            // 
            this.lbTempoDeCasa.AutoSize = true;
            this.lbTempoDeCasa.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTempoDeCasa.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbTempoDeCasa.Location = new System.Drawing.Point(233, 151);
            this.lbTempoDeCasa.Name = "lbTempoDeCasa";
            this.lbTempoDeCasa.Size = new System.Drawing.Size(121, 21);
            this.lbTempoDeCasa.TabIndex = 1;
            this.lbTempoDeCasa.Text = "n anos de casa";
            // 
            // lbAdimissao
            // 
            this.lbAdimissao.AutoSize = true;
            this.lbAdimissao.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbAdimissao.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbAdimissao.Location = new System.Drawing.Point(16, 151);
            this.lbAdimissao.Name = "lbAdimissao";
            this.lbAdimissao.Size = new System.Drawing.Size(90, 21);
            this.lbAdimissao.TabIndex = 1;
            this.lbAdimissao.Text = "xx/xx/xxxx";
            // 
            // lbApelido
            // 
            this.lbApelido.AutoSize = true;
            this.lbApelido.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbApelido.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lbApelido.Location = new System.Drawing.Point(16, 51);
            this.lbApelido.Name = "lbApelido";
            this.lbApelido.Size = new System.Drawing.Size(64, 21);
            this.lbApelido.TabIndex = 1;
            this.lbApelido.Text = "Apelido";
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
            // 
            // btNovo
            // 
            this.btNovo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btNovo.Location = new System.Drawing.Point(3, 3);
            this.btNovo.Name = "btNovo";
            this.btNovo.Size = new System.Drawing.Size(93, 41);
            this.btNovo.TabIndex = 2;
            this.btNovo.Text = "Novo";
            this.btNovo.UseVisualStyleBackColor = false;
            this.btNovo.Click += new System.EventHandler(this.btNovo_Click);
            // 
            // btEditar
            // 
            this.btEditar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btEditar.Location = new System.Drawing.Point(102, 3);
            this.btEditar.Name = "btEditar";
            this.btEditar.Size = new System.Drawing.Size(93, 41);
            this.btEditar.TabIndex = 2;
            this.btEditar.Text = "Editar";
            this.btEditar.UseVisualStyleBackColor = false;
            this.btEditar.Click += new System.EventHandler(this.btEditar_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.btnRport);
            this.panel3.Controls.Add(this.btNovo);
            this.panel3.Controls.Add(this.btEditar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(185, 244);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(910, 47);
            this.panel3.TabIndex = 10;
            // 
            // btnRport
            // 
            this.btnRport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRport.Location = new System.Drawing.Point(201, 3);
            this.btnRport.Name = "btnRport";
            this.btnRport.Size = new System.Drawing.Size(93, 41);
            this.btnRport.TabIndex = 3;
            this.btnRport.Text = "Imprimir";
            this.btnRport.UseVisualStyleBackColor = false;
            this.btnRport.Click += new System.EventHandler(this.btReport_Click);
            // 
            // dgvAfastamentos
            // 
            this.dgvAfastamentos.AllowUserToAddRows = false;
            this.dgvAfastamentos.AllowUserToDeleteRows = false;
            this.dgvAfastamentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvAfastamentos.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAfastamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAfastamentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAfastamentos.GridColor = System.Drawing.Color.WhiteSmoke;
            this.dgvAfastamentos.Location = new System.Drawing.Point(185, 291);
            this.dgvAfastamentos.MultiSelect = false;
            this.dgvAfastamentos.Name = "dgvAfastamentos";
            this.dgvAfastamentos.ReadOnly = true;
            this.dgvAfastamentos.RowHeadersVisible = false;
            this.dgvAfastamentos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvAfastamentos.RowTemplate.Height = 25;
            this.dgvAfastamentos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAfastamentos.Size = new System.Drawing.Size(910, 183);
            this.dgvAfastamentos.TabIndex = 11;
            // 
            // WorkflowByPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1095, 496);
            this.Controls.Add(this.dgvAfastamentos);
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvAfastamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Panel panel1;
        private Label label7;
        private Label label4;
        private Label lbIdade;
        private Label lbCargo;
        private Label lbAdimissao;
        private Label lbApelido;
        private Label lbNome;
        private PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ContextMenuStrip contextMenuStrip1;
        private Label lbTempoDeCasa;
        private TextBox textBox1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Panel panel2;
        private DataGridView dgvPessoal;
        private Button btNovo;
        private Button btEditar;
        private Panel panel3;
        private Button btnRport;
        private DataGridView dgvAfastamentos;
    }
}