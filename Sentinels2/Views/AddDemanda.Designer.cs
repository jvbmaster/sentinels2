namespace Sentinels2.Views
{
    partial class AddDemanda
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
            this.btAdicionar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbPatrimonio = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.opOrdinaria = new System.Windows.Forms.RadioButton();
            this.opExtra = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fEntrada = new System.Windows.Forms.MaskedTextBox();
            this.fSaida = new System.Windows.Forms.MaskedTextBox();
            this.dgvDemanda = new System.Windows.Forms.DataGridView();
            this.sabado = new System.Windows.Forms.CheckBox();
            this.sexta = new System.Windows.Forms.CheckBox();
            this.quinta = new System.Windows.Forms.CheckBox();
            this.quarta = new System.Windows.Forms.CheckBox();
            this.terca = new System.Windows.Forms.CheckBox();
            this.segunda = new System.Windows.Forms.CheckBox();
            this.domingo = new System.Windows.Forms.CheckBox();
            this.diasSemana = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).BeginInit();
            this.diasSemana.SuspendLayout();
            this.SuspendLayout();
            // 
            // btAdicionar
            // 
            this.btAdicionar.Location = new System.Drawing.Point(174, 287);
            this.btAdicionar.Name = "btAdicionar";
            this.btAdicionar.Size = new System.Drawing.Size(149, 34);
            this.btAdicionar.TabIndex = 0;
            this.btAdicionar.Text = "Adicionar";
            this.btAdicionar.UseVisualStyleBackColor = true;
            this.btAdicionar.Click += new System.EventHandler(this.btAdicionar_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(618, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(98, 34);
            this.button2.TabIndex = 0;
            this.button2.Text = "Fechar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbPatrimonio);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.btAdicionar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.fEntrada);
            this.groupBox1.Controls.Add(this.fSaida);
            this.groupBox1.Controls.Add(this.dgvDemanda);
            this.groupBox1.Location = new System.Drawing.Point(30, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(568, 338);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // lbPatrimonio
            // 
            this.lbPatrimonio.AutoSize = true;
            this.lbPatrimonio.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbPatrimonio.Location = new System.Drawing.Point(6, 0);
            this.lbPatrimonio.Name = "lbPatrimonio";
            this.lbPatrimonio.Size = new System.Drawing.Size(0, 32);
            this.lbPatrimonio.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.opOrdinaria);
            this.groupBox2.Controls.Add(this.opExtra);
            this.groupBox2.Location = new System.Drawing.Point(174, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(149, 100);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tipo de demanda";
            // 
            // opOrdinaria
            // 
            this.opOrdinaria.AutoSize = true;
            this.opOrdinaria.Location = new System.Drawing.Point(18, 28);
            this.opOrdinaria.Name = "opOrdinaria";
            this.opOrdinaria.Size = new System.Drawing.Size(94, 25);
            this.opOrdinaria.TabIndex = 7;
            this.opOrdinaria.TabStop = true;
            this.opOrdinaria.Text = "Ordinária";
            this.opOrdinaria.UseVisualStyleBackColor = true;
            // 
            // opExtra
            // 
            this.opExtra.AutoSize = true;
            this.opExtra.Location = new System.Drawing.Point(18, 59);
            this.opExtra.Name = "opExtra";
            this.opExtra.Size = new System.Drawing.Size(125, 25);
            this.opExtra.TabIndex = 7;
            this.opExtra.TabStop = true;
            this.opExtra.Text = "Extraordinária";
            this.opExtra.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 5;
            this.label2.Text = "Saída";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Entrada";
            // 
            // fEntrada
            // 
            this.fEntrada.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fEntrada.Location = new System.Drawing.Point(262, 184);
            this.fEntrada.Mask = "00:00";
            this.fEntrada.Name = "fEntrada";
            this.fEntrada.Size = new System.Drawing.Size(61, 35);
            this.fEntrada.TabIndex = 4;
            this.fEntrada.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // fSaida
            // 
            this.fSaida.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fSaida.Location = new System.Drawing.Point(262, 225);
            this.fSaida.Mask = "00:00";
            this.fSaida.Name = "fSaida";
            this.fSaida.Size = new System.Drawing.Size(61, 35);
            this.fSaida.TabIndex = 4;
            this.fSaida.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fSaida.ValidatingType = typeof(System.DateTime);
            // 
            // dgvDemanda
            // 
            this.dgvDemanda.AllowUserToAddRows = false;
            this.dgvDemanda.AllowUserToDeleteRows = false;
            this.dgvDemanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDemanda.BackgroundColor = System.Drawing.Color.White;
            this.dgvDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemanda.Location = new System.Drawing.Point(349, 47);
            this.dgvDemanda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDemanda.MultiSelect = false;
            this.dgvDemanda.Name = "dgvDemanda";
            this.dgvDemanda.ReadOnly = true;
            this.dgvDemanda.RowTemplate.Height = 25;
            this.dgvDemanda.Size = new System.Drawing.Size(205, 274);
            this.dgvDemanda.TabIndex = 3;
            // 
            // sabado
            // 
            this.sabado.AutoSize = true;
            this.sabado.Location = new System.Drawing.Point(18, 237);
            this.sabado.Name = "sabado";
            this.sabado.Size = new System.Drawing.Size(81, 25);
            this.sabado.TabIndex = 6;
            this.sabado.Text = "Sábado";
            this.sabado.UseVisualStyleBackColor = true;
            this.sabado.CheckedChanged += new System.EventHandler(this.sabado_CheckedChanged);
            // 
            // sexta
            // 
            this.sexta.AutoSize = true;
            this.sexta.Location = new System.Drawing.Point(18, 206);
            this.sexta.Name = "sexta";
            this.sexta.Size = new System.Drawing.Size(66, 25);
            this.sexta.TabIndex = 6;
            this.sexta.Text = "Sexta";
            this.sexta.UseVisualStyleBackColor = true;
            this.sexta.CheckedChanged += new System.EventHandler(this.sexta_CheckedChanged);
            // 
            // quinta
            // 
            this.quinta.AutoSize = true;
            this.quinta.Location = new System.Drawing.Point(18, 175);
            this.quinta.Name = "quinta";
            this.quinta.Size = new System.Drawing.Size(76, 25);
            this.quinta.TabIndex = 6;
            this.quinta.Text = "Quinta";
            this.quinta.UseVisualStyleBackColor = true;
            this.quinta.CheckedChanged += new System.EventHandler(this.quinta_CheckedChanged);
            // 
            // quarta
            // 
            this.quarta.AutoSize = true;
            this.quarta.Location = new System.Drawing.Point(18, 144);
            this.quarta.Name = "quarta";
            this.quarta.Size = new System.Drawing.Size(77, 25);
            this.quarta.TabIndex = 6;
            this.quarta.Text = "Quarta";
            this.quarta.UseVisualStyleBackColor = true;
            this.quarta.CheckedChanged += new System.EventHandler(this.quarta_CheckedChanged);
            // 
            // terca
            // 
            this.terca.AutoSize = true;
            this.terca.Location = new System.Drawing.Point(18, 113);
            this.terca.Name = "terca";
            this.terca.Size = new System.Drawing.Size(64, 25);
            this.terca.TabIndex = 6;
            this.terca.Text = "Terça";
            this.terca.UseVisualStyleBackColor = true;
            this.terca.CheckedChanged += new System.EventHandler(this.terca_CheckedChanged);
            // 
            // segunda
            // 
            this.segunda.AutoSize = true;
            this.segunda.Location = new System.Drawing.Point(18, 82);
            this.segunda.Name = "segunda";
            this.segunda.Size = new System.Drawing.Size(90, 25);
            this.segunda.TabIndex = 6;
            this.segunda.Text = "Segunda";
            this.segunda.UseVisualStyleBackColor = true;
            this.segunda.CheckedChanged += new System.EventHandler(this.segunda_CheckedChanged);
            // 
            // domingo
            // 
            this.domingo.AutoSize = true;
            this.domingo.Location = new System.Drawing.Point(18, 51);
            this.domingo.Name = "domingo";
            this.domingo.Size = new System.Drawing.Size(94, 25);
            this.domingo.TabIndex = 6;
            this.domingo.Text = "Domingo";
            this.domingo.UseVisualStyleBackColor = true;
            this.domingo.CheckedChanged += new System.EventHandler(this.domingo_CheckedChanged);
            // 
            // diasSemana
            // 
            this.diasSemana.Controls.Add(this.domingo);
            this.diasSemana.Controls.Add(this.segunda);
            this.diasSemana.Controls.Add(this.sabado);
            this.diasSemana.Controls.Add(this.terca);
            this.diasSemana.Controls.Add(this.sexta);
            this.diasSemana.Controls.Add(this.quarta);
            this.diasSemana.Controls.Add(this.quinta);
            this.diasSemana.Location = new System.Drawing.Point(30, 68);
            this.diasSemana.Name = "diasSemana";
            this.diasSemana.Size = new System.Drawing.Size(140, 280);
            this.diasSemana.TabIndex = 9;
            this.diasSemana.TabStop = false;
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(618, 74);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(98, 34);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Excluir";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // AddDemanda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(744, 377);
            this.Controls.Add(this.btDelete);
            this.Controls.Add(this.diasSemana);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddDemanda";
            this.Text = "AddDemanda";
            this.Load += new System.EventHandler(this.AddDemanda_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).EndInit();
            this.diasSemana.ResumeLayout(false);
            this.diasSemana.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btAdicionar;
        private Button button2;
        private GroupBox groupBox1;
        private CheckBox sabado;
        private CheckBox sexta;
        private CheckBox quinta;
        private CheckBox quarta;
        private CheckBox terca;
        private CheckBox segunda;
        private CheckBox domingo;
        private Label label2;
        private Label label1;
        private MaskedTextBox fEntrada;
        private MaskedTextBox fSaida;
        private DataGridView dgvDemanda;
        private GroupBox groupBox2;
        private RadioButton opOrdinaria;
        private RadioButton opExtra;
        private GroupBox diasSemana;
        private Label lbPatrimonio;
        private Button btDelete;
    }
}