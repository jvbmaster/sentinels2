namespace Sentinels2.Views
{
    partial class HomeWindow
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
            this.dgvVigiasDisponiveis = new System.Windows.Forms.DataGridView();
            this.dgvPlantoesVGM = new System.Windows.Forms.DataGridView();
            this.dgvDemanda = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigiasDisponiveis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantoesVGM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendar
            // 
            this.calendar.Location = new System.Drawing.Point(10, 18);
            this.calendar.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.calendar.Name = "calendar";
            this.calendar.TabIndex = 0;
            this.calendar.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateSelected);
            // 
            // dgvVigiasDisponiveis
            // 
            this.dgvVigiasDisponiveis.AllowUserToAddRows = false;
            this.dgvVigiasDisponiveis.AllowUserToDeleteRows = false;
            this.dgvVigiasDisponiveis.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvVigiasDisponiveis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVigiasDisponiveis.Location = new System.Drawing.Point(250, 18);
            this.dgvVigiasDisponiveis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvVigiasDisponiveis.Name = "dgvVigiasDisponiveis";
            this.dgvVigiasDisponiveis.ReadOnly = true;
            this.dgvVigiasDisponiveis.RowTemplate.Height = 25;
            this.dgvVigiasDisponiveis.Size = new System.Drawing.Size(300, 188);
            this.dgvVigiasDisponiveis.TabIndex = 1;
            // 
            // dgvPlantoesVGM
            // 
            this.dgvPlantoesVGM.AllowUserToAddRows = false;
            this.dgvPlantoesVGM.AllowUserToDeleteRows = false;
            this.dgvPlantoesVGM.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvPlantoesVGM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlantoesVGM.Location = new System.Drawing.Point(556, 18);
            this.dgvPlantoesVGM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvPlantoesVGM.Name = "dgvPlantoesVGM";
            this.dgvPlantoesVGM.ReadOnly = true;
            this.dgvPlantoesVGM.RowTemplate.Height = 25;
            this.dgvPlantoesVGM.Size = new System.Drawing.Size(169, 188);
            this.dgvPlantoesVGM.TabIndex = 1;
            // 
            // dgvDemanda
            // 
            this.dgvDemanda.AllowUserToAddRows = false;
            this.dgvDemanda.AllowUserToDeleteRows = false;
            this.dgvDemanda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDemanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDemanda.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemanda.Location = new System.Drawing.Point(29, 228);
            this.dgvDemanda.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDemanda.MultiSelect = false;
            this.dgvDemanda.Name = "dgvDemanda";
            this.dgvDemanda.ReadOnly = true;
            this.dgvDemanda.RowTemplate.Height = 25;
            this.dgvDemanda.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDemanda.Size = new System.Drawing.Size(740, 396);
            this.dgvDemanda.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Demanda";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.calendar);
            this.panel1.Controls.Add(this.dgvPlantoesVGM);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dgvVigiasDisponiveis);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(29, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(737, 218);
            this.panel1.TabIndex = 3;
            // 
            // HomeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(781, 715);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDemanda);
            this.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HomeWindow";
            this.Text = "Sentinels2";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.HomeWindow_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVigiasDisponiveis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlantoesVGM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MonthCalendar calendar;
        private DataGridView dgvVigiasDisponiveis;
        private DataGridView dgvPlantoesVGM;
        private DataGridView dgvDemanda;
        private Label label4;
        private Panel panel1;
    }
}