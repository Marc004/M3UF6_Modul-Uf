using CLASSES;
using MVC_3_ClFamilies.CLASSES;
using MVC_3_ClFamilies.FORMS;
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
    public partial class FrmCicles : Form
    {
        public ClCicles ctrlCicles;                // el controlador el fem públic per a poder-hi accedir des dels subforms de les operacions ABM

        private ClBDSqlServer bd;
        private DataSet dset = new DataSet();

        public FrmCicles(ClBDSqlServer xbd)
        {
            bd = xbd;
            InitializeComponent();
        }

        private void FrmCicles_Load(object sender, EventArgs e)
        {
            ctrlCicles = new ClCicles(bd);
            DataSet xdset = new DataSet();
            ctrlCicles.omplirComboBox(ref xdset);

            if (xdset.Tables.Count > 0 && xdset.Tables[0].Rows.Count > 0)
            {
                if (xdset.Tables[0].Rows.Count > 0)
                {
                    cbFamilia.DataSource = xdset.Tables[0];

                    cbFamilia.DisplayMember = "nomFamilia";
                    cbFamilia.ValueMember = "idFamilia";
                }

            }

            getDades();
            iniDgrid();
        }
        private void iniDgrid()
        {
            if (dgDades.Columns.Count > 0)
            {
                dgDades.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgDades.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dgDades.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }

        private void getDades()
        {
            if (ctrlCicles.modelAccessible())
            {
                dset.Clear();
                ctrlCicles.llistaXnomCicle(ref dset);
                dgDades.DataSource = dset.Tables[0];
                dgDades.AutoResizeColumns();
            }
            else
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
                n = ctrlCicles.quantesCiclesXprefix(tbPrefix.Text.Trim());
                MessageBox.Show("Hi ha " + n.ToString().Trim() + " cicles formatius amb el prefix " + tbPrefix.Text.Trim(), "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMCicles frm = new FrmAMCicles();

            frm.frmPare = this;
            frm.Text = "Alta d'un nou cicle formatiu";
            frm.operacio = 'A';
            ctrlCicles.idCicle = "";
            ctrlCicles.idFamilia = "";
            ctrlCicles.nomCicle = "";
            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                getDades();

                // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                var quinaFila = from DataGridViewRow fila in dgDades.Rows
                                where fila.Cells["idCicle"].Value.ToString().Trim() == ctrlCicles.idCicle
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
                ctrlCicles.idCicle = dgDades.SelectedRows[0].Cells["idCicle"].Value.ToString().Trim();
                ctrlCicles.nomCicle = dgDades.SelectedRows[0].Cells["nomCicle"].Value.ToString().Trim();
                FrmAMCicles frm = new FrmAMCicles();

                frm.frmPare = this;
                frm.Text = "Baixa d'una nou cicle";
                frm.operacio = 'B';
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    getDades();

                    // apliquem LINQ per a trobar al DataGridView la fila on és la familia que s'acaba d'inserir
                    var quinaFila = from DataGridViewRow fila in dgDades.Rows
                                    where fila.Cells["idCicle"].Value.ToString().Trim() == ctrlCicles.idCicle
                                    select fila.Index;

                    dgDades.Rows[quinaFila.First()].Selected = true;
                }
                frm = null;
                GC.Collect();

            }
        }

        private void dgDades_DoubleClick(object sender, EventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMCicles frm;

            if (dgDades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgDades.SelectedRows[0].Index;
                frm = new FrmAMCicles();
                frm.frmPare = this;
                frm.Text = "Modificar un Cicle Formatiu";
                frm.operacio = 'M';
                ctrlCicles.idCicle = dgDades.SelectedRows[0].Cells["idCicle"].Value.ToString();
                ctrlCicles.getCicle();
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

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFamilia.SelectedItem != null)
            {
                String CBidFamilia = ((DataRowView)cbFamilia.SelectedItem)["idFamilia"].ToString();
                ctrlCicles.idFamilia = CBidFamilia;
                if (ctrlCicles.modelAccessible())
                {
                    dset.Clear();
                    ctrlCicles.llistaCicle(ref dset);
                    dgDades.DataSource = dset.Tables[0];
                    dgDades.AutoResizeColumns();
                }
                else
                {
                    MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

    }
}
