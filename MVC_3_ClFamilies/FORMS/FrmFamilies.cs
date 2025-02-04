using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CLASSES;

namespace MVC_3_ClFamilies
{
    public partial class FrmFamilies : Form
    {
        public ClFamilies ctrlFamilia;                // el controlador el fem públic per a poder-hi accedir des dels subforms de les operacions ABM

        private ClBDSqlServer bd;
        private DataSet dset = new DataSet();

        public FrmFamilies(ClBDSqlServer xbd)
        {
            bd=xbd;
            InitializeComponent();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {
            ctrlFamilia = new ClFamilies(bd);
            getDades();
            iniDgrid();
        }

        private void iniDgrid()
        {
            if (dgDades.Columns.Count > 0)
            {
                dgDades.Columns[0].HeaderText = "id.";
                dgDades.Columns[1].HeaderText = "nom família";
                dgDades.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void getDades()
        {
            if (ctrlFamilia.modelAccessible())
            {
                dset.Clear();
                ctrlFamilia.llistaXnomFamilies(ref dset);
                dgDades.DataSource = dset.Tables[0];
                dgDades.AutoResizeColumns();
            } else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btQuants_Click(object sender, EventArgs e)
        {
            Int32 n = 0;

            if (tbPrefix.Text.Trim() == "")
            {
                MessageBox.Show("Cal introduir una població", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                n = ctrlFamilia.quantesFamiliesXprefix(tbPrefix.Text.Trim());
                MessageBox.Show("Hi ha " + n.ToString().Trim() + " famílies amb el prefix " + tbPrefix.Text.Trim(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMFamilies frm = new FrmAMFamilies();

            frm.frmPare = this;
            frm.Text = "Alta d'una nova família";
            frm.operacio = 'A';
            ctrlFamilia.idFamilia = "";
            ctrlFamilia.nomFamilia = "";
            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                getDades();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                var quinaFila = from DataGridViewRow fila in dgDades.Rows
                                where fila.Cells["idFamilia"].Value.ToString().Trim() == ctrlFamilia.idFamilia
                                select fila.Index;

                dgDades.Rows[quinaFila.First()].Selected = true;
            }
            frm = null;
            GC.Collect();
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if (dgDades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ctrlFamilia.idFamilia = dgDades.SelectedRows[0].Cells["idFamilia"].Value.ToString().Trim();
                if (ctrlFamilia.suprimirFamilia())
                {
                    getDades();
                    dgDades.Rows[0].Selected = true;
                }
            }
        }

        private void dgDades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMFamilies frm;

            if (dgDades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgDades.SelectedRows[0].Index;
                frm = new FrmAMFamilies();
                frm.frmPare = this;
                frm.Text = "Modificar una família";
                frm.operacio = 'M';
                ctrlFamilia.idFamilia = dgDades.SelectedRows[0].Cells["idFamilia"].Value.ToString();
                ctrlFamilia.getFamilia();
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    getDades();
                }
                dgDades.Rows[quinafila].Selected = true;
                frm = null;
                GC.Collect();
            }
        }
    }
}
