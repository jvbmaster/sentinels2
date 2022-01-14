namespace Sentinels2.Views
{
    partial class EscalaScreen
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkedListBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvPatrimonios = new System.Windows.Forms.DataGridView();
            this.salvar = new System.Windows.Forms.Button();
            this.cancelar = new System.Windows.Forms.Button();
            this.btAddAll = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBox1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(298, 147);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 71);
            this.button1.TabIndex = 2;
            this.button1.Text = "Apenas pares";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 226);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 71);
            this.button2.TabIndex = 3;
            this.button2.Text = "Apenas ímpares";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 56);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 83);
            this.button3.TabIndex = 4;
            this.button3.Text = "Selecionar Todas as Datas";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(299, 305);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(95, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "Desmarcar Todas as Datas";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Controls.Add(this.panel1);
            this.checkedListBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.checkedListBox1.Location = new System.Drawing.Point(1, 1);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Padding = new System.Windows.Forms.Padding(4);
            this.checkedListBox1.Size = new System.Drawing.Size(290, 395);
            this.checkedListBox1.TabIndex = 6;
            this.checkedListBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(7, 30);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(86, 41);
            this.button5.TabIndex = 7;
            this.button5.Text = "Adicionar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.dgvPatrimonios);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Location = new System.Drawing.Point(402, 50);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(442, 342);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patrimônio";
            // 
            // dgvPatrimonios
            // 
            this.dgvPatrimonios.AllowUserToAddRows = false;
            this.dgvPatrimonios.AllowUserToDeleteRows = false;
            this.dgvPatrimonios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPatrimonios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrimonios.Location = new System.Drawing.Point(7, 79);
            this.dgvPatrimonios.Name = "dgvPatrimonios";
            this.dgvPatrimonios.ReadOnly = true;
            this.dgvPatrimonios.RowTemplate.Height = 25;
            this.dgvPatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrimonios.Size = new System.Drawing.Size(424, 256);
            this.dgvPatrimonios.TabIndex = 8;
            // 
            // salvar
            // 
            this.salvar.Location = new System.Drawing.Point(852, 41);
            this.salvar.Margin = new System.Windows.Forms.Padding(4);
            this.salvar.Name = "salvar";
            this.salvar.Size = new System.Drawing.Size(104, 45);
            this.salvar.TabIndex = 7;
            this.salvar.Text = "Salvar";
            this.salvar.UseVisualStyleBackColor = true;
            this.salvar.Click += new System.EventHandler(this.salvar_Click);
            // 
            // cancelar
            // 
            this.cancelar.FlatAppearance.BorderSize = 0;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelar.Location = new System.Drawing.Point(852, 94);
            this.cancelar.Margin = new System.Windows.Forms.Padding(4);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(104, 45);
            this.cancelar.TabIndex = 7;
            this.cancelar.Text = "Cencelar";
            this.cancelar.UseVisualStyleBackColor = true;
            this.cancelar.Click += new System.EventHandler(this.cancelar_Click);
            // 
            // btAddAll
            // 
            this.btAddAll.BackColor = System.Drawing.Color.LightSalmon;
            this.btAddAll.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btAddAll.FlatAppearance.BorderSize = 0;
            this.btAddAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAddAll.Location = new System.Drawing.Point(503, 5);
            this.btAddAll.Margin = new System.Windows.Forms.Padding(4);
            this.btAddAll.Name = "btAddAll";
            this.btAddAll.Size = new System.Drawing.Size(198, 41);
            this.btAddAll.TabIndex = 7;
            this.btAddAll.Text = "Nova Escala Completa";
            this.btAddAll.UseVisualStyleBackColor = false;
            this.btAddAll.Click += new System.EventHandler(this.btAddAll_Click_1);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(282, 365);
            this.panel1.TabIndex = 0;
            // 
            // EscalaScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(969, 397);
            this.Controls.Add(this.cancelar);
            this.Controls.Add(this.btAddAll);
            this.Controls.Add(this.salvar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EscalaScreen";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Escala BS2";
            this.Load += new System.EventHandler(this.EscalaScreen_Load);
            this.checkedListBox1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private GroupBox checkedListBox1;
        private Button button5;
        private GroupBox groupBox1;
        private Button salvar;
        private Button cancelar;
        private DataGridView dgvPatrimonios;
        private Button btAddAll;
        private Panel panel1;
    }
}