using CLASSES;
using MVC_3_ClFamilies.CLASSES;
using MVC_3_ClFamilies.FORMS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3_ClFamilies
{
    public partial class FrmMain : Form
    {
        const String nomFitxerCfg = "CFGBD.TXT";
        const String nomBD = "bdCicles";

        private ClBDSqlServer bd = null;

        Boolean esticSortint = false;

        // formularis
        FrmBD fBD = null;
        FrmFamilies fFamilies = null;
        FrmCicles fCicles = null;
        FrmUfs fUfs = null;
        FrmModul fModul = null;

        public FrmMain()
        {
            InitializeComponent();
        }

        #region "---- EVENTS ----"
        private void FrmMain_Load(object sender, EventArgs e)
        {
            String xconn = getConnexioString(nomFitxerCfg);

            lbEstat.Top = this.Height - lbEstat.Height - 10;

            if (xconn != "")
            {
                connectar(xconn);
            }
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!esticSortint)
            {
                if (MessageBox.Show("Segur que vols sortir?", "Finalitzar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        #endregion

        #region "---- OPCIONS DE MENU ---"

        private void connexióSQLServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmBD")))
            {
                fBD = new FrmBD(bd);
                fBD.MdiParent = this;          
            }
            fBD.WindowState = FormWindowState.Normal;
            fBD.Show();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void famíliesDeCiclesFormatiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmFamilies")))
            {
                fFamilies = new FrmFamilies(bd);
                fFamilies.MdiParent = this;
            }
            fFamilies.WindowState = FormWindowState.Normal;
            fFamilies.Show();
        }

        #endregion

        #region "--- ALTRES FUNCIONS ---"
        private void opcionsMenuGestio(Boolean xb)
        {
            gestióToolStripMenuItem.Enabled = xb;
            consultesToolStripMenuItem.Enabled = xb;
            famíliesDeCiclesFormatiusToolStripMenuItem.Enabled = xb;
        }

        private String getConnexioString(String xnomFitxer)
        {
            StreamReader fcfg;
            String xs = "";

            if (File.Exists(xnomFitxer))
            {
                fcfg = new StreamReader(nomFitxerCfg);
                xs = fcfg.ReadToEnd().Trim();
                fcfg.Close();
            }
            return (xs);
        }

        public void setConnexioString(String xs)
        {
            StreamWriter fcfg;

            fcfg = new StreamWriter(nomFitxerCfg, false);
            fcfg.WriteLine(xs);
            fcfg.Close();
        }

        Boolean ja_està_obert(String xnom_frm)
        {

            int x1 = 0;
            Boolean xb = false;

            while ((x1 < this.MdiChildren.Length) && (!(xb)))
            {
                xb = (this.MdiChildren[x1].Name == xnom_frm);
                x1++;
            }
            return (xb);
        }

        public Boolean connectar(String xconn)
        {
            Boolean xb = false;

            bd = new ClBDSqlServer(xconn);
            bd.Connectar();
            if ((bd.HiHaConnexio()) && (bd.ObrirBD(nomBD)))
            {
                lbEstat.Text = "connectat a SQL Server : " + nomBD;
                opcionsMenuGestio(true);
                xb = true;
            }
            else
            {
                MessageBox.Show("No hi ha connexió amb la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbEstat.Text = "Sense connexió";
                opcionsMenuGestio(false);
            }
            return (xb);
        }

        #endregion

        private void ciclesFormatiusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmCicles")))
            {
                fCicles = new FrmCicles(bd);
                fCicles.MdiParent = this;
            }
            fCicles.WindowState = FormWindowState.Normal;
            fCicles.Show();
        }

        private void ufsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmUfs")))
            {
                fUfs = new FrmUfs(bd);
                fUfs.MdiParent = this;
            }
            fUfs.WindowState = FormWindowState.Normal;
            fUfs.Show();
        }

        private void modulsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!(ja_està_obert("FrmModul")))
            {
                fModul = new FrmModul(bd);
                fModul.MdiParent = this;
            }
            fModul.WindowState = FormWindowState.Normal;
            fModul.Show();
        }
    }
}
