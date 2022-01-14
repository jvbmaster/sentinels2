namespace Sentinels2.Views
{
    partial class SetPatrimonio
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
            this.fSearch = new System.Windows.Forms.TextBox();
            this.dgvPatrimonios = new System.Windows.Forms.DataGridView();
            this.dgvHorarios = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btSetAll = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // fSearch
            // 
            this.fSearch.Location = new System.Drawing.Point(8, 31);
            this.fSearch.Margin = new System.Windows.Forms.Padding(4);
            this.fSearch.Name = "fSearch";
            this.fSearch.PlaceholderText = "Digite aqui sua busca por nome de prédio";
            this.fSearch.Size = new System.Drawing.Size(360, 29);
            this.fSearch.TabIndex = 0;
            this.fSearch.TextChanged += new System.EventHandler(this.fSearch_TextChanged);
            // 
            // dgvPatrimonios
            // 
            this.dgvPatrimonios.AllowUserToAddRows = false;
            this.dgvPatrimonios.AllowUserToDeleteRows = false;
            this.dgvPatrimonios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPatrimonios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvPatrimonios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrimonios.Location = new System.Drawing.Point(8, 72);
            this.dgvPatrimonios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvPatrimonios.Name = "dgvPatrimonios";
            this.dgvPatrimonios.ReadOnly = true;
            this.dgvPatrimonios.RowTemplate.Height = 25;
            this.dgvPatrimonios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPatrimonios.Size = new System.Drawing.Size(361, 235);
            this.dgvPatrimonios.TabIndex = 1;
            this.dgvPatrimonios.SelectionChanged += new System.EventHandler(this.dgvPatrimonios_SelectionChanged);
            this.dgvPatrimonios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.dgvPatrimonios_MouseClick);
            // 
            // dgvHorarios
            // 
            this.dgvHorarios.AllowUserToAddRows = false;
            this.dgvHorarios.AllowUserToDeleteRows = false;
            this.dgvHorarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHorarios.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvHorarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHorarios.Location = new System.Drawing.Point(8, 41);
            this.dgvHorarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgvHorarios.Name = "dgvHorarios";
            this.dgvHorarios.ReadOnly = true;
            this.dgvHorarios.RowTemplate.Height = 25;
            this.dgvHorarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHorarios.Size = new System.Drawing.Size(250, 235);
            this.dgvHorarios.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.fSearch);
            this.groupBox1.Controls.Add(this.dgvPatrimonios);
            this.groupBox1.Location = new System.Drawing.Point(10, 58);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(373, 321);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Patrimônios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvHorarios);
            this.groupBox2.Location = new System.Drawing.Point(386, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(280, 290);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Horários";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.button1.Location = new System.Drawing.Point(674, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 32);
            this.button1.TabIndex = 5;
            this.button1.Text = "Selecionar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(674, 170);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 32);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(10, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(554, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Selecione o prédio e o horário para adicionar ao plantão";
            // 
            // btSetAll
            // 
            this.btSetAll.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btSetAll.FlatAppearance.BorderSize = 0;
            this.btSetAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSetAll.Location = new System.Drawing.Point(674, 305);
            this.btSetAll.Margin = new System.Windows.Forms.Padding(4);
            this.btSetAll.Name = "btSetAll";
            this.btSetAll.Size = new System.Drawing.Size(96, 60);
            this.btSetAll.TabIndex = 5;
            this.btSetAll.Text = "Selecione Tudo";
            this.btSetAll.UseVisualStyleBackColor = true;
            this.btSetAll.Visible = false;
            this.btSetAll.Click += new System.EventHandler(this.btSetAll_Click);
            // 
            // SetPatrimonio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(817, 411);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btSetAll);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SetPatrimonio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Selecionar Patrimônio";
            this.Load += new System.EventHandler(this.SetPatrimonio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrimonios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHorarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox fSearch;
        private DataGridView dgvPatrimonios;
        private DataGridView dgvHorarios;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button1;
        private Button button2;
        private Label label1;
        private Button btSetAll;
    }
}