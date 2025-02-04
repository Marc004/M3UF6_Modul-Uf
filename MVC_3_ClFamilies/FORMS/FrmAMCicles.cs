using MVC_3_ClFamilies.CLASSES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3_ClFamilies.FORMS
{
    public partial class FrmAMCicles : Form
    {
        public char operacio = ' ';
        public FrmCicles frmPare;
        public Boolean hanfetOK = false;
        private DataSet dset = new DataSet();

        public FrmAMCicles()
        {
            InitializeComponent();
        }
        private void FrmAMCicles_Load(object sender, EventArgs e)
        {

            DataSet xdset = new DataSet();
            frmPare.ctrlCicles.omplirComboBox(ref xdset);

            if (xdset.Tables.Count > 0 && xdset.Tables[0].Rows.Count > 0)
            {
                if (xdset.Tables[0].Rows.Count > 0)
                {
                    cbFamilia.DataSource = xdset.Tables[0];

                    cbFamilia.DisplayMember = "nomFamilia";
                    cbFamilia.ValueMember = "idFamilia";
                }

            }

            tbId.Enabled = (operacio == 'A');
            if (operacio == 'B')
            {
                tbId.Text = frmPare.ctrlCicles.idCicle;
                tbNom.Text = frmPare.ctrlCicles.nomCicle;
                cbFamilia.SelectedValue = frmPare.ctrlCicles.idFamilia;
                tbId.Enabled = false;
                tbNom.Enabled = false;
                cbFamilia.Enabled = false;
            }
            if (operacio == 'M')
            {
                tbId.Text = frmPare.ctrlCicles.idCicle;
                tbNom.Text = frmPare.ctrlCicles.nomCicle;
                cbFamilia.SelectedValue = frmPare.ctrlCicles.idFamilia;
            }
        }

        private void btNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btOK_Click(object sender, EventArgs e)
        {
            frmPare.ctrlCicles.idCicle = tbId.Text.Trim();
            frmPare.ctrlCicles.nomCicle = tbNom.Text.Trim();

            switch (operacio)
            {
                case 'A':
                    hanfetOK = frmPare.ctrlCicles.novaCicle();
                    break;
                case 'B':
                    hanfetOK = frmPare.ctrlCicles.suprimirCicle();
                    break;
                case 'M':
                    hanfetOK = frmPare.ctrlCicles.modificarCicle();
                    break;
                default: break;
            }
            if (hanfetOK)
            {
                this.Close();
            }
        }

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFamilia.SelectedItem != null)
            {
                String CBidFamilia = ((DataRowView)cbFamilia.SelectedItem)["idFamilia"].ToString();
                frmPare.ctrlCicles.idFamilia = CBidFamilia;

            }
        }
    }
}
