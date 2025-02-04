using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using CLASSES;

namespace MVC_3_ClFamilies
{
    public partial class FrmBD : Form
    {
        ClBDSqlServer bd = null;

        public FrmBD(ClBDSqlServer xbd)
        {
            bd = xbd;
            InitializeComponent();
        }

        private void FrmBD_Load(object sender, EventArgs e)
        {
            if (bd != null)
            {
                tbCadena.Text = bd.cadenaConnexioServidor;
            } else
            {
                tbCadena.Text = @"Data Source=127.0.0.1\SQLEXPRESS; Integrated Security = True";
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (tbCadena.Text.Trim().Length > 0)
            {
                ((FrmMain) this.MdiParent).setConnexioString(tbCadena.Text);
                if (((FrmMain)this.MdiParent).connectar(tbCadena.Text)) {
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Has d'introduir una cadena de connexió vàlida per a SQL Server", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Cursor = Cursors.Default;
        }
    }
}
