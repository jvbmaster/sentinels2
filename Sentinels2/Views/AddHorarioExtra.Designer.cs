namespace Sentinels2.Views
{
    partial class AddHorarioExtra
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
            this.fDiaSemana = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.fEntrada = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fSaida = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // fDiaSemana
            // 
            this.fDiaSemana.FormattingEnabled = true;
            this.fDiaSemana.Items.AddRange(new object[] {
            "Domingo",
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado"});
            this.fDiaSemana.Location = new System.Drawing.Point(23, 50);
            this.fDiaSemana.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fDiaSemana.Name = "fDiaSemana";
            this.fDiaSemana.Size = new System.Drawing.Size(192, 33);
            this.fDiaSemana.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dia da Semana";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(278, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fEntrada
            // 
            this.fEntrada.Location = new System.Drawing.Point(237, 50);
            this.fEntrada.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fEntrada.Mask = "00:00";
            this.fEntrada.Name = "fEntrada";
            this.fEntrada.Size = new System.Drawing.Size(77, 33);
            this.fEntrada.TabIndex = 1;
            this.fEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 21);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(324, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Saída";
            // 
            // fSaida
            // 
            this.fSaida.Location = new System.Drawing.Point(324, 50);
            this.fSaida.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.fSaida.Mask = "00:00";
            this.fSaida.Name = "fSaida";
            this.fSaida.Size = new System.Drawing.Size(70, 33);
            this.fSaida.TabIndex = 2;
            this.fSaida.ValidatingType = typeof(System.DateTime);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(25, 15);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 37);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 99);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 64);
            this.panel1.TabIndex = 4;
            // 
            // AddHorarioExtra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 163);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fSaida);
            this.Controls.Add(this.fEntrada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fDiaSemana);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddHorarioExtra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DEMANDA ADICIONAL DO PATRIMÔNIO";
            this.Load += new System.EventHandler(this.AddHorarioExtra_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox fDiaSemana;
        private Label label1;
        private Button button1;
        private MaskedTextBox fEntrada;
        private Label label2;
        private Label label3;
        private MaskedTextBox fSaida;
        private Button btCancelar;
        private Panel panel1;
    }
}