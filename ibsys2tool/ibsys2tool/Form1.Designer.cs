namespace ibsys2tool
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCSimStartseiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoÜberToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnBestellverwaltung = new System.Windows.Forms.Button();
            this.btnKapazitätsplan = new System.Windows.Forms.Button();
            this.btnDisposition = new System.Windows.Forms.Button();
            this.btnPrognose = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.infoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(743, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLImportierenToolStripMenuItem,
            this.xMLExportierenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            this.dateiToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.dateiToolStripMenuItem.Text = "Datei";
            // 
            // xMLImportierenToolStripMenuItem
            // 
            this.xMLImportierenToolStripMenuItem.Name = "xMLImportierenToolStripMenuItem";
            this.xMLImportierenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.xMLImportierenToolStripMenuItem.Text = "XML importieren";
            // 
            // xMLExportierenToolStripMenuItem
            // 
            this.xMLExportierenToolStripMenuItem.Name = "xMLExportierenToolStripMenuItem";
            this.xMLExportierenToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.xMLExportierenToolStripMenuItem.Text = "XML exportieren";
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            this.einstellungenToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.einstellungenToolStripMenuItem.Text = "Einstellungen";
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sCSimStartseiteToolStripMenuItem,
            this.infoÜberToolToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            this.infoToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.infoToolStripMenuItem.Text = "Info";
            this.infoToolStripMenuItem.Click += new System.EventHandler(this.infoToolStripMenuItem_Click);
            // 
            // sCSimStartseiteToolStripMenuItem
            // 
            this.sCSimStartseiteToolStripMenuItem.Name = "sCSimStartseiteToolStripMenuItem";
            this.sCSimStartseiteToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.sCSimStartseiteToolStripMenuItem.Text = "SCSim-Startseite";
            this.sCSimStartseiteToolStripMenuItem.Click += new System.EventHandler(this.sCSimStartseiteToolStripMenuItem_Click);
            // 
            // infoÜberToolToolStripMenuItem
            // 
            this.infoÜberToolToolStripMenuItem.Name = "infoÜberToolToolStripMenuItem";
            this.infoÜberToolToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.infoÜberToolToolStripMenuItem.Text = "Infos zum Tool";
            this.infoÜberToolToolStripMenuItem.Click += new System.EventHandler(this.infoÜberToolToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer1.Panel1.Controls.Add(this.btnXml);
            this.splitContainer1.Panel1.Controls.Add(this.btnBestellverwaltung);
            this.splitContainer1.Panel1.Controls.Add(this.btnKapazitätsplan);
            this.splitContainer1.Panel1.Controls.Add(this.btnDisposition);
            this.splitContainer1.Panel1.Controls.Add(this.btnPrognose);
            this.splitContainer1.Size = new System.Drawing.Size(743, 468);
            this.splitContainer1.SplitterDistance = 127;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 1;
            // 
            // btnXml
            // 
            this.btnXml.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnXml.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXml.Location = new System.Drawing.Point(11, 141);
            this.btnXml.Margin = new System.Windows.Forms.Padding(2);
            this.btnXml.Name = "btnXml";
            this.btnXml.Size = new System.Drawing.Size(104, 28);
            this.btnXml.TabIndex = 12;
            this.btnXml.Text = "XML";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnBestellverwaltung
            // 
            this.btnBestellverwaltung.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnBestellverwaltung.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestellverwaltung.Location = new System.Drawing.Point(11, 109);
            this.btnBestellverwaltung.Margin = new System.Windows.Forms.Padding(2);
            this.btnBestellverwaltung.Name = "btnBestellverwaltung";
            this.btnBestellverwaltung.Size = new System.Drawing.Size(104, 28);
            this.btnBestellverwaltung.TabIndex = 11;
            this.btnBestellverwaltung.Text = "Bestellverwaltung";
            this.btnBestellverwaltung.UseVisualStyleBackColor = true;
            this.btnBestellverwaltung.Click += new System.EventHandler(this.btnBestellverwaltung_Click);
            // 
            // btnKapazitätsplan
            // 
            this.btnKapazitätsplan.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnKapazitätsplan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapazitätsplan.Location = new System.Drawing.Point(11, 77);
            this.btnKapazitätsplan.Margin = new System.Windows.Forms.Padding(2);
            this.btnKapazitätsplan.Name = "btnKapazitätsplan";
            this.btnKapazitätsplan.Size = new System.Drawing.Size(104, 28);
            this.btnKapazitätsplan.TabIndex = 10;
            this.btnKapazitätsplan.Text = "Kapazitätsplan";
            this.btnKapazitätsplan.UseVisualStyleBackColor = true;
            this.btnKapazitätsplan.Click += new System.EventHandler(this.btnKapazitätsplan_Click);
            // 
            // btnDisposition
            // 
            this.btnDisposition.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnDisposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDisposition.Location = new System.Drawing.Point(11, 45);
            this.btnDisposition.Margin = new System.Windows.Forms.Padding(2);
            this.btnDisposition.Name = "btnDisposition";
            this.btnDisposition.Size = new System.Drawing.Size(104, 28);
            this.btnDisposition.TabIndex = 9;
            this.btnDisposition.Text = "Disposition Eigenfertigung";
            this.btnDisposition.UseVisualStyleBackColor = true;
            this.btnDisposition.Click += new System.EventHandler(this.btnDisposition_Click);
            // 
            // btnPrognose
            // 
            this.btnPrognose.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnPrognose.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            this.btnPrognose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrognose.Location = new System.Drawing.Point(11, 13);
            this.btnPrognose.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrognose.Name = "btnPrognose";
            this.btnPrognose.Size = new System.Drawing.Size(104, 28);
            this.btnPrognose.TabIndex = 8;
            this.btnPrognose.Text = "Prognose";
            this.btnPrognose.UseVisualStyleBackColor = true;
            this.btnPrognose.Click += new System.EventHandler(this.btnPrognose_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 492);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Ibsys2 Tool";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dateiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLImportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLExportierenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem einstellungenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnXml;
        private System.Windows.Forms.Button btnBestellverwaltung;
        private System.Windows.Forms.Button btnKapazitätsplan;
        private System.Windows.Forms.Button btnDisposition;
        private System.Windows.Forms.Button btnPrognose;
        private System.Windows.Forms.ToolStripMenuItem sCSimStartseiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem infoÜberToolToolStripMenuItem;
    }
}

