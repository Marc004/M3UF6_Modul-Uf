using CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3_ClFamilies.FORMS
{
    public partial class FrmAMUfs : Form
    {
        public char operacio = ' ';
        public FrmUfs frmPare;
        public Boolean hanfetOK = false;
        public FrmAMUfs()
        {
            InitializeComponent();
        }

        private void FrmAMUfs_Load(object sender, EventArgs e)
        {
            tbId.Enabled = (operacio == 'A');
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlUfs.idUf;
                tbNom.Text = frmPare.ctrlUfs.nomUf;
                cbCicle.SelectedValue = frmPare.ctrlUfs.idCicle;
                cbModul.SelectedValue = frmPare.ctrlUfs.idModul;
            }

            llenarCbCicle();
            llenarCbModul();
        }

        private void llenarCbCicle()
        {
            if (frmPare.ctrlCicle.modelAccessible())
            {
                DataSet dset = new DataSet();
                frmPare.ctrlCicle.llistaXnomCicle(ref dset);
                cbCicle.DataSource = dset.Tables[0];
                cbCicle.DisplayMember = "nomCicle";
                cbCicle.ValueMember = "idCicle";
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void llenarCbModul()
        {
            if (frmPare.ctrlModul.modelAccessible())
            {
                DataSet dset = new DataSet();
                frmPare.ctrlModul.llistaModuls(ref dset);
                cbModul.DataSource = dset.Tables[0];
                cbModul.DisplayMember = "nomModul";
                cbModul.ValueMember = "idModul";
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlUfs.idUf = tbId.Text.Trim();
            frmPare.ctrlUfs.nomUf = tbNom.Text.Trim();
            frmPare.ctrlUfs.idCicle = cbCicle.SelectedValue.ToString();
            frmPare.ctrlUfs.idModul = cbModul.SelectedValue.ToString();
            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlUfs.nouUf();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlUfs.modificarUf();
                    break;
                default: break;
            }
            if (hanfetOK)
            {
                this.Close();
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
