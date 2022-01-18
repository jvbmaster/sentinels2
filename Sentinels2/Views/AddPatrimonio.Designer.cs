namespace Sentinels2.Views
{
    partial class AddPatrimonio
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
            this.fID = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fTitulo = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.gDuracao = new System.Windows.Forms.GroupBox();
            this.fDuracao = new System.Windows.Forms.NumericUpDown();
            this.lbDefinicaoTIpo = new System.Windows.Forms.Label();
            this.fHoraReferencia = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gDuracao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fDuracao)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fID);
            this.groupBox1.Location = new System.Drawing.Point(39, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(186, 62);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID";
            // 
            // fID
            // 
            this.fID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fID.Location = new System.Drawing.Point(3, 25);
            this.fID.Name = "fID";
            this.fID.Size = new System.Drawing.Size(180, 29);
            this.fID.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fTitulo);
            this.groupBox2.Location = new System.Drawing.Point(234, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 62);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Título";
            // 
            // fTitulo
            // 
            this.fTitulo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.fTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fTitulo.Location = new System.Drawing.Point(3, 25);
            this.fTitulo.Name = "fTitulo";
            this.fTitulo.Size = new System.Drawing.Size(378, 29);
            this.fTitulo.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fHoraReferencia);
            this.groupBox4.Location = new System.Drawing.Point(150, 130);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(178, 62);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Horario de Referência";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 272);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 64);
            this.panel1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.Location = new System.Drawing.Point(497, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "Salvar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(42, 15);
            this.btCancelar.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(118, 37);
            this.btCancelar.TabIndex = 4;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // gDuracao
            // 
            this.gDuracao.Controls.Add(this.fDuracao);
            this.gDuracao.Location = new System.Drawing.Point(39, 130);
            this.gDuracao.Name = "gDuracao";
            this.gDuracao.Size = new System.Drawing.Size(95, 62);
            this.gDuracao.TabIndex = 0;
            this.gDuracao.TabStop = false;
            this.gDuracao.Text = "Duração";
            // 
            // fDuracao
            // 
            this.fDuracao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.fDuracao.Location = new System.Drawing.Point(3, 25);
            this.fDuracao.Margin = new System.Windows.Forms.Padding(4);
            this.fDuracao.Name = "fDuracao";
            this.fDuracao.Size = new System.Drawing.Size(89, 29);
            this.fDuracao.TabIndex = 0;
            this.fDuracao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fDuracao.Leave += new System.EventHandler(this.fDuracao_Leave);
            // 
            // lbDefinicaoTIpo
            // 
            this.lbDefinicaoTIpo.AutoSize = true;
            this.lbDefinicaoTIpo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbDefinicaoTIpo.Location = new System.Drawing.Point(42, 217);
            this.lbDefinicaoTIpo.Name = "lbDefinicaoTIpo";
            this.lbDefinicaoTIpo.Size = new System.Drawing.Size(0, 25);
            this.lbDefinicaoTIpo.TabIndex = 6;
            // 
            // fHoraReferencia
            // 
            this.fHoraReferencia.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.fHoraReferencia.Location = new System.Drawing.Point(27, 25);
            this.fHoraReferencia.Name = "fHoraReferencia";
            this.fHoraReferencia.Size = new System.Drawing.Size(109, 29);
            this.fHoraReferencia.TabIndex = 7;
            this.fHoraReferencia.Value = new System.DateTime(2022, 1, 16, 0, 0, 0, 0);
            // 
            // AddPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 336);
            this.ControlBox = false;
            this.Controls.Add(this.lbDefinicaoTIpo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gDuracao);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Cadastro de Patrimônio";
            this.Load += new System.EventHandler(this.AddPatrimonio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.gDuracao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fDuracao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox fID;
        private GroupBox groupBox2;
        private TextBox fTitulo;
        private GroupBox groupBox4;
        private Panel panel1;
        private Button button3;
        private Button btCancelar;
        private GroupBox gDuracao;
        private NumericUpDown fDuracao;
        private Label lbDefinicaoTIpo;
        private DateTimePicker fHoraReferencia;
    }
}