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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnXml = new System.Windows.Forms.Button();
            this.btnBestellverwaltung = new System.Windows.Forms.Button();
            this.btnKapazitätsplan = new System.Windows.Forms.Button();
            this.btnDisposition = new System.Windows.Forms.Button();
            this.btnPrognose = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dateiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLImportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLExportierenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.einstellungenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.spracheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deutschToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sCSimStartseiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.infoÜberToolToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
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
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // btnXml
            // 
            this.btnXml.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnXml, "btnXml");
            this.btnXml.Name = "btnXml";
            this.btnXml.UseVisualStyleBackColor = true;
            this.btnXml.Click += new System.EventHandler(this.btnXml_Click);
            // 
            // btnBestellverwaltung
            // 
            this.btnBestellverwaltung.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnBestellverwaltung, "btnBestellverwaltung");
            this.btnBestellverwaltung.Name = "btnBestellverwaltung";
            this.btnBestellverwaltung.UseVisualStyleBackColor = true;
            this.btnBestellverwaltung.Click += new System.EventHandler(this.btnBestellverwaltung_Click);
            // 
            // btnKapazitätsplan
            // 
            this.btnKapazitätsplan.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnKapazitätsplan, "btnKapazitätsplan");
            this.btnKapazitätsplan.Name = "btnKapazitätsplan";
            this.btnKapazitätsplan.UseVisualStyleBackColor = true;
            this.btnKapazitätsplan.Click += new System.EventHandler(this.btnKapazitätsplan_Click);
            // 
            // btnDisposition
            // 
            this.btnDisposition.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnDisposition, "btnDisposition");
            this.btnDisposition.Name = "btnDisposition";
            this.btnDisposition.UseVisualStyleBackColor = true;
            this.btnDisposition.Click += new System.EventHandler(this.btnDisposition_Click);
            // 
            // btnPrognose
            // 
            this.btnPrognose.FlatAppearance.BorderColor = System.Drawing.SystemColors.MenuBar;
            resources.ApplyResources(this.btnPrognose, "btnPrognose");
            this.btnPrognose.Name = "btnPrognose";
            this.btnPrognose.UseVisualStyleBackColor = true;
            this.btnPrognose.Click += new System.EventHandler(this.btnPrognose_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dateiToolStripMenuItem,
            this.einstellungenToolStripMenuItem,
            this.infoToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // dateiToolStripMenuItem
            // 
            this.dateiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xMLImportierenToolStripMenuItem,
            this.xMLExportierenToolStripMenuItem});
            this.dateiToolStripMenuItem.Name = "dateiToolStripMenuItem";
            resources.ApplyResources(this.dateiToolStripMenuItem, "dateiToolStripMenuItem");
            // 
            // xMLImportierenToolStripMenuItem
            // 
            this.xMLImportierenToolStripMenuItem.Name = "xMLImportierenToolStripMenuItem";
            resources.ApplyResources(this.xMLImportierenToolStripMenuItem, "xMLImportierenToolStripMenuItem");
            // 
            // xMLExportierenToolStripMenuItem
            // 
            this.xMLExportierenToolStripMenuItem.Name = "xMLExportierenToolStripMenuItem";
            resources.ApplyResources(this.xMLExportierenToolStripMenuItem, "xMLExportierenToolStripMenuItem");
            // 
            // einstellungenToolStripMenuItem
            // 
            this.einstellungenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spracheToolStripMenuItem});
            this.einstellungenToolStripMenuItem.Name = "einstellungenToolStripMenuItem";
            resources.ApplyResources(this.einstellungenToolStripMenuItem, "einstellungenToolStripMenuItem");
            // 
            // spracheToolStripMenuItem
            // 
            this.spracheToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deutschToolStripMenuItem,
            this.englischToolStripMenuItem});
            this.spracheToolStripMenuItem.Name = "spracheToolStripMenuItem";
            resources.ApplyResources(this.spracheToolStripMenuItem, "spracheToolStripMenuItem");
            // 
            // deutschToolStripMenuItem
            // 
            this.deutschToolStripMenuItem.Name = "deutschToolStripMenuItem";
            resources.ApplyResources(this.deutschToolStripMenuItem, "deutschToolStripMenuItem");
            this.deutschToolStripMenuItem.Click += new System.EventHandler(this.deutschToolStripMenuItem_Click);
            // 
            // englischToolStripMenuItem
            // 
            this.englischToolStripMenuItem.Name = "englischToolStripMenuItem";
            resources.ApplyResources(this.englischToolStripMenuItem, "englischToolStripMenuItem");
            this.englischToolStripMenuItem.Click += new System.EventHandler(this.englischToolStripMenuItem_Click);
            // 
            // infoToolStripMenuItem
            // 
            this.infoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sCSimStartseiteToolStripMenuItem,
            this.infoÜberToolToolStripMenuItem});
            this.infoToolStripMenuItem.Name = "infoToolStripMenuItem";
            resources.ApplyResources(this.infoToolStripMenuItem, "infoToolStripMenuItem");
            // 
            // sCSimStartseiteToolStripMenuItem
            // 
            this.sCSimStartseiteToolStripMenuItem.Name = "sCSimStartseiteToolStripMenuItem";
            resources.ApplyResources(this.sCSimStartseiteToolStripMenuItem, "sCSimStartseiteToolStripMenuItem");
            this.sCSimStartseiteToolStripMenuItem.Click += new System.EventHandler(this.sCSimStartseiteToolStripMenuItem_Click);
            // 
            // infoÜberToolToolStripMenuItem
            // 
            this.infoÜberToolToolStripMenuItem.Name = "infoÜberToolToolStripMenuItem";
            resources.ApplyResources(this.infoÜberToolToolStripMenuItem, "infoÜberToolToolStripMenuItem");
            this.infoÜberToolToolStripMenuItem.Click += new System.EventHandler(this.infoÜberToolToolStripMenuItem_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.ToolStripMenuItem spracheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deutschToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englischToolStripMenuItem;
    }
}

