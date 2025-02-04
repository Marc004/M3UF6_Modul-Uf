namespace MVC_3_ClFamilies
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.baseDeDadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connexióSQLServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.famíliesDeCiclesFormatiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ciclesFormatiusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.finestresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbEstat = new System.Windows.Forms.Label();
            this.ufsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modulsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMain
            // 
            this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.baseDeDadesToolStripMenuItem,
            this.gestióToolStripMenuItem,
            this.consultesToolStripMenuItem,
            this.finestresToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.MdiWindowListItem = this.finestresToolStripMenuItem;
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.mnuMain.Size = new System.Drawing.Size(1394, 28);
            this.mnuMain.TabIndex = 1;
            this.mnuMain.Text = "menuStrip1";
            // 
            // baseDeDadesToolStripMenuItem
            // 
            this.baseDeDadesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexióSQLServerToolStripMenuItem,
            this.toolStripSeparator1,
            this.sortirToolStripMenuItem});
            this.baseDeDadesToolStripMenuItem.Name = "baseDeDadesToolStripMenuItem";
            this.baseDeDadesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.baseDeDadesToolStripMenuItem.Text = "Base de &Dades";
            // 
            // connexióSQLServerToolStripMenuItem
            // 
            this.connexióSQLServerToolStripMenuItem.Name = "connexióSQLServerToolStripMenuItem";
            this.connexióSQLServerToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.connexióSQLServerToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.connexióSQLServerToolStripMenuItem.Text = "Connexió SQL Server";
            this.connexióSQLServerToolStripMenuItem.Click += new System.EventHandler(this.connexióSQLServerToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(277, 6);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(280, 26);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // gestióToolStripMenuItem
            // 
            this.gestióToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.famíliesDeCiclesFormatiusToolStripMenuItem,
            this.ciclesFormatiusToolStripMenuItem,
            this.ufsToolStripMenuItem,
            this.modulsToolStripMenuItem});
            this.gestióToolStripMenuItem.Name = "gestióToolStripMenuItem";
            this.gestióToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.gestióToolStripMenuItem.Text = "&Gestió";
            // 
            // famíliesDeCiclesFormatiusToolStripMenuItem
            // 
            this.famíliesDeCiclesFormatiusToolStripMenuItem.Name = "famíliesDeCiclesFormatiusToolStripMenuItem";
            this.famíliesDeCiclesFormatiusToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.famíliesDeCiclesFormatiusToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.famíliesDeCiclesFormatiusToolStripMenuItem.Text = "Famílies de cicles formatius";
            this.famíliesDeCiclesFormatiusToolStripMenuItem.Click += new System.EventHandler(this.famíliesDeCiclesFormatiusToolStripMenuItem_Click);
            // 
            // ciclesFormatiusToolStripMenuItem
            // 
            this.ciclesFormatiusToolStripMenuItem.Name = "ciclesFormatiusToolStripMenuItem";
            this.ciclesFormatiusToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.ciclesFormatiusToolStripMenuItem.Text = "Cicles Formatius";
            this.ciclesFormatiusToolStripMenuItem.Click += new System.EventHandler(this.ciclesFormatiusToolStripMenuItem_Click);
            // 
            // consultesToolStripMenuItem
            // 
            this.consultesToolStripMenuItem.Name = "consultesToolStripMenuItem";
            this.consultesToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.consultesToolStripMenuItem.Text = "&Consultes";
            // 
            // finestresToolStripMenuItem
            // 
            this.finestresToolStripMenuItem.Name = "finestresToolStripMenuItem";
            this.finestresToolStripMenuItem.Size = new System.Drawing.Size(80, 24);
            this.finestresToolStripMenuItem.Text = "&Finestres";
            // 
            // lbEstat
            // 
            this.lbEstat.AutoSize = true;
            this.lbEstat.BackColor = System.Drawing.Color.Transparent;
            this.lbEstat.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEstat.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lbEstat.Location = new System.Drawing.Point(22, 633);
            this.lbEstat.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbEstat.Name = "lbEstat";
            this.lbEstat.Size = new System.Drawing.Size(46, 18);
            this.lbEstat.TabIndex = 8;
            this.lbEstat.Text = "estat";
            // 
            // ufsToolStripMenuItem
            // 
            this.ufsToolStripMenuItem.Name = "ufsToolStripMenuItem";
            this.ufsToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.ufsToolStripMenuItem.Text = "Ufs";
            this.ufsToolStripMenuItem.Click += new System.EventHandler(this.ufsToolStripMenuItem_Click);
            // 
            // modulsToolStripMenuItem
            // 
            this.modulsToolStripMenuItem.Name = "modulsToolStripMenuItem";
            this.modulsToolStripMenuItem.Size = new System.Drawing.Size(322, 26);
            this.modulsToolStripMenuItem.Text = "Moduls";
            this.modulsToolStripMenuItem.Click += new System.EventHandler(this.modulsToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1394, 686);
            this.Controls.Add(this.lbEstat);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuMain;
            this.Name = "FrmMain";
            this.Text = "Gestió de Cicles Formatius";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem baseDeDadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connexióSQLServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem famíliesDeCiclesFormatiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem finestresToolStripMenuItem;
        private System.Windows.Forms.Label lbEstat;
        private System.Windows.Forms.ToolStripMenuItem ciclesFormatiusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ufsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modulsToolStripMenuItem;
    }
}

