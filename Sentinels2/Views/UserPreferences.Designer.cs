namespace Sentinels2
{
    partial class UserPreferences
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
            this.btSearchPath = new System.Windows.Forms.Button();
            this.fPathDB = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSearchPath2 = new System.Windows.Forms.Button();
            this.fPathOfficeSuite = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSearchPath);
            this.groupBox1.Controls.Add(this.fPathDB);
            this.groupBox1.Location = new System.Drawing.Point(36, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 49);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Path Database";
            // 
            // btSearchPath
            // 
            this.btSearchPath.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSearchPath.Location = new System.Drawing.Point(272, 19);
            this.btSearchPath.Name = "btSearchPath";
            this.btSearchPath.Size = new System.Drawing.Size(43, 27);
            this.btSearchPath.TabIndex = 1;
            this.btSearchPath.Text = "...";
            this.btSearchPath.UseVisualStyleBackColor = true;
            this.btSearchPath.Click += new System.EventHandler(this.btSearchPath_Click);
            // 
            // fPathDB
            // 
            this.fPathDB.Dock = System.Windows.Forms.DockStyle.Left;
            this.fPathDB.Location = new System.Drawing.Point(3, 19);
            this.fPathDB.Name = "fPathDB";
            this.fPathDB.Size = new System.Drawing.Size(263, 23);
            this.fPathDB.TabIndex = 0;
            // 
            // btSave
            // 
            this.btSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btSave.Location = new System.Drawing.Point(265, 13);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 31);
            this.btSave.TabIndex = 1;
            this.btSave.Text = "Salvar";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancelar.Location = new System.Drawing.Point(22, 13);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 31);
            this.btCancelar.TabIndex = 1;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 269);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(375, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.btSave);
            this.panel1.Controls.Add(this.btCancelar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(375, 50);
            this.panel1.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSearchPath2);
            this.groupBox2.Controls.Add(this.fPathOfficeSuite);
            this.groupBox2.Location = new System.Drawing.Point(36, 135);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 49);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Path Office Suite";
            // 
            // btSearchPath2
            // 
            this.btSearchPath2.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSearchPath2.Location = new System.Drawing.Point(272, 19);
            this.btSearchPath2.Name = "btSearchPath2";
            this.btSearchPath2.Size = new System.Drawing.Size(43, 27);
            this.btSearchPath2.TabIndex = 1;
            this.btSearchPath2.Text = "...";
            this.btSearchPath2.UseVisualStyleBackColor = true;
            this.btSearchPath2.Click += new System.EventHandler(this.btSearchPath2_Click);
            // 
            // fPathOfficeSuite
            // 
            this.fPathOfficeSuite.Dock = System.Windows.Forms.DockStyle.Left;
            this.fPathOfficeSuite.Location = new System.Drawing.Point(3, 19);
            this.fPathOfficeSuite.Name = "fPathOfficeSuite";
            this.fPathOfficeSuite.Size = new System.Drawing.Size(263, 23);
            this.fPathOfficeSuite.TabIndex = 0;
            // 
            // UserPreferences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(375, 291);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UserPreferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserePreferences";
            this.Load += new System.EventHandler(this.UserePreferences_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btSearchPath;
        private TextBox fPathDB;
        private Button btSave;
        private Button btCancelar;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel statusLabel;
        private Panel panel1;
        private GroupBox groupBox2;
        private Button btSearchPath2;
        private TextBox fPathOfficeSuite;
    }
}