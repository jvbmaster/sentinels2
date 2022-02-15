namespace Sentinels2.Views
{
    partial class EditEscala
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fOS = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fPatrimonio = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fEntrada = new System.Windows.Forms.MaskedTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fSaida = new System.Windows.Forms.MaskedTextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.fVigia = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.fMotivo = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.fTipoPagamento = new System.Windows.Forms.TextBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.fAfastamento = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.fData = new System.Windows.Forms.MaskedTextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btSalvar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fOS);
            this.groupBox1.Location = new System.Drawing.Point(32, 39);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(137, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OS";
            // 
            // fOS
            // 
            this.fOS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fOS.Location = new System.Drawing.Point(3, 25);
            this.fOS.Name = "fOS";
            this.fOS.ReadOnly = true;
            this.fOS.Size = new System.Drawing.Size(131, 29);
            this.fOS.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fPatrimonio);
            this.groupBox2.Location = new System.Drawing.Point(175, 39);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(365, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Patrimônio";
            // 
            // fPatrimonio
            // 
            this.fPatrimonio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fPatrimonio.Location = new System.Drawing.Point(3, 25);
            this.fPatrimonio.Name = "fPatrimonio";
            this.fPatrimonio.Size = new System.Drawing.Size(359, 29);
            this.fPatrimonio.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fEntrada);
            this.groupBox3.Location = new System.Drawing.Point(178, 124);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(191, 62);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Entrada";
            // 
            // fEntrada
            // 
            this.fEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fEntrada.Location = new System.Drawing.Point(3, 25);
            this.fEntrada.Mask = "00/00/0000 90:00";
            this.fEntrada.Name = "fEntrada";
            this.fEntrada.Size = new System.Drawing.Size(185, 29);
            this.fEntrada.TabIndex = 0;
            this.fEntrada.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fSaida);
            this.groupBox4.Location = new System.Drawing.Point(372, 124);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(168, 62);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Saída";
            // 
            // fSaida
            // 
            this.fSaida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fSaida.Location = new System.Drawing.Point(3, 25);
            this.fSaida.Mask = "00/00/0000 90:00";
            this.fSaida.Name = "fSaida";
            this.fSaida.Size = new System.Drawing.Size(162, 29);
            this.fSaida.TabIndex = 0;
            this.fSaida.ValidatingType = typeof(System.DateTime);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.fVigia);
            this.groupBox5.Location = new System.Drawing.Point(29, 201);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(511, 62);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vigia";
            // 
            // fVigia
            // 
            this.fVigia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fVigia.Location = new System.Drawing.Point(3, 25);
            this.fVigia.Name = "fVigia";
            this.fVigia.Size = new System.Drawing.Size(505, 29);
            this.fVigia.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.fMotivo);
            this.groupBox6.Location = new System.Drawing.Point(32, 283);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(508, 62);
            this.groupBox6.TabIndex = 0;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Motivo";
            // 
            // fMotivo
            // 
            this.fMotivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fMotivo.Location = new System.Drawing.Point(3, 25);
            this.fMotivo.Name = "fMotivo";
            this.fMotivo.Size = new System.Drawing.Size(502, 29);
            this.fMotivo.TabIndex = 0;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.fTipoPagamento);
            this.groupBox7.Location = new System.Drawing.Point(32, 372);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(508, 62);
            this.groupBox7.TabIndex = 0;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tipo de Pagamento";
            // 
            // fTipoPagamento
            // 
            this.fTipoPagamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTipoPagamento.Location = new System.Drawing.Point(3, 25);
            this.fTipoPagamento.Name = "fTipoPagamento";
            this.fTipoPagamento.Size = new System.Drawing.Size(502, 29);
            this.fTipoPagamento.TabIndex = 0;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.fAfastamento);
            this.groupBox8.Location = new System.Drawing.Point(32, 448);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(187, 62);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Afastamento";
            // 
            // fAfastamento
            // 
            this.fAfastamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fAfastamento.Location = new System.Drawing.Point(3, 25);
            this.fAfastamento.Name = "fAfastamento";
            this.fAfastamento.Size = new System.Drawing.Size(181, 29);
            this.fAfastamento.TabIndex = 0;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.fData);
            this.groupBox9.Location = new System.Drawing.Point(32, 124);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(137, 62);
            this.groupBox9.TabIndex = 0;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data";
            // 
            // fData
            // 
            this.fData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fData.Location = new System.Drawing.Point(3, 25);
            this.fData.Mask = "00/00/0000 90:00";
            this.fData.Name = "fData";
            this.fData.Size = new System.Drawing.Size(131, 29);
            this.fData.TabIndex = 1;
            this.fData.ValidatingType = typeof(System.DateTime);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(315, 471);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(97, 31);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // btSalvar
            // 
            this.btSalvar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSalvar.Location = new System.Drawing.Point(443, 471);
            this.btSalvar.Name = "btSalvar";
            this.btSalvar.Size = new System.Drawing.Size(97, 31);
            this.btSalvar.TabIndex = 1;
            this.btSalvar.Text = "Salvar";
            this.btSalvar.UseVisualStyleBackColor = true;
            this.btSalvar.Click += new System.EventHandler(this.btSalvar_Click);
            // 
            // EditEscala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 543);
            this.ControlBox = false;
            this.Controls.Add(this.btSalvar);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EditEscala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EDITAR ESCALA";
            this.Load += new System.EventHandler(this.EditEscala_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox fOS;
        private GroupBox groupBox2;
        private TextBox fPatrimonio;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
        private GroupBox groupBox5;
        private TextBox fVigia;
        private GroupBox groupBox6;
        private TextBox fMotivo;
        private GroupBox groupBox7;
        private TextBox fTipoPagamento;
        private GroupBox groupBox8;
        private TextBox fAfastamento;
        private GroupBox groupBox9;
        private Button btCancelar;
        private Button btSalvar;
        private MaskedTextBox fEntrada;
        private MaskedTextBox fSaida;
        private MaskedTextBox fData;
    }
}