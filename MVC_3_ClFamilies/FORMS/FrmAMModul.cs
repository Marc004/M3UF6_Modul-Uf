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
    public partial class FrmAMModul : Form
    {
        public char operacio = ' ';
        public FrmModul frmPare;
        public Boolean hanfetOK = false;
        public FrmAMModul()
        {
            InitializeComponent();
        }

        private void FrmAMModul_Load(object sender, EventArgs e)
        {
            tbId.Enabled = (operacio == 'A');
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlModuls.idModul;
                tbNom.Text = frmPare.ctrlModuls.nomModul;
                cbCicle.SelectedValue = frmPare.ctrlModuls.idCicle;
            }

            llenarCbCicle();
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
        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlModuls.idModul = tbId.Text.Trim();
            frmPare.ctrlModuls.nomModul = tbNom.Text.Trim();
            frmPare.ctrlModuls.idCicle = cbCicle.SelectedValue.ToString();
            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlModuls.nouModul();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlModuls.modificarModul();
                    break;
                default: break;
            }
            if (hanfetOK)
            {
                this.Close();
            }
        }

        private void cbCicle_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
