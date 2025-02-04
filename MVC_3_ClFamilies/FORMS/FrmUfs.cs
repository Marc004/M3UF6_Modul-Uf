using CLASSES;
using MVC_3_ClFamilies.CLASSES;
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
    public partial class FrmUfs: Form
    {
        public ClCicles ctrlCicle;
        public ClModul ctrlModul;
        public ClUfs ctrlUfs;

        private ClBDSqlServer bd;
        private DataSet dset = new DataSet();

        public FrmUfs(ClBDSqlServer xbd)
        {
            bd = xbd;
            InitializeComponent();
        }

        private void FrmUfs_Load(object sender, EventArgs e)
        {
            ctrlCicle = new ClCicles(bd);
            ctrlModul = new ClModul(bd);
            ctrlUfs = new ClUfs(bd);
            llenarCbCicles();
            llenarCbModul();
            getDadesSenseFiltre();
            iniDgrid();
        }

        private void llenarCbCicles()
        {
            if (ctrlCicle.modelAccessible())
            {
                DataSet dset = new DataSet();
                ctrlCicle.llistaXnomCicle(ref dset);
                cbCicle.DataSource = dset.Tables[0];
                cbCicle.DisplayMember = "nomCicle";
                cbCicle.ValueMember = "idCicle";
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void llenarCbModul()
        {
            if (ctrlModul.modelAccessible())
            {
                DataSet dset = new DataSet();
                ctrlModul.llistaModuls(ref dset);
                cbModul.DataSource = dset.Tables[0];
                cbModul.DisplayMember = "nomModul";
                cbModul.ValueMember = "idModul";
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void getDadesAmbFiltre()
        {
            if (ctrlUfs.modelAccessible() && cbCicle.SelectedValue != null && cbModul.SelectedValue != null)
            {
                dset.Clear();
                ctrlUfs.idCicle = cbCicle.SelectedValue.ToString();
                ctrlUfs.idModul = cbModul.SelectedValue.ToString();
                ctrlUfs.llistaXnomUfs(ref dset);
                dgDades.DataSource = dset.Tables[0];
                dgDades.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void getDadesSenseFiltre()
        {
            if (ctrlUfs.modelAccessible())
            {
                dset.Clear();
                ctrlUfs.llistaUfs(ref dset);
                dgDades.DataSource = dset.Tables[0];
                dgDades.AutoResizeColumns();
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMUfs frm = new FrmAMUfs();

            frm.frmPare = this;
            frm.Text = "Alta d'un nou Ufs";
            frm.operacio = 'A';
            frm.ShowDialog();
            if (frm.hanfetOK)
            {
                if (ckbTots.Checked)
                {
                    getDadesSenseFiltre();
                }
                else
                {
                    getDadesAmbFiltre();
                }

                var quinaFila = from DataGridViewRow fila in dgDades.Rows
                                where fila.Cells["idUf"].Value.ToString().Trim() == ctrlCicle.idCicle
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
                ctrlUfs.idUf = dgDades.SelectedRows[0].Cells["idUf"].Value.ToString().Trim();
                ctrlUfs.nomUf = dgDades.SelectedRows[0].Cells["nomUf"].Value.ToString().Trim();
                if (ctrlUfs.suprimirUf())
                {
                    if (ckbTots.Checked)
                    {
                        getDadesSenseFiltre();
                    }
                    else
                    {
                        getDadesAmbFiltre();
                    }

                    dgDades.Rows[0].Selected = true;
                }
            }
        }

        private void dgDades_DoubleClick(object sender, EventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMUfs frm;

            if (dgDades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgDades.SelectedRows[0].Index;
                frm = new FrmAMUfs();
                frm.frmPare = this;
                frm.Text = "Modificar una UF";
                frm.operacio = 'M';
                ctrlUfs.idUf = dgDades.SelectedRows[0].Cells["idUf"].Value.ToString();
                ctrlUfs.nomUf = dgDades.SelectedRows[0].Cells["nomUf"].Value.ToString();
                ctrlUfs.idCicle = dgDades.SelectedRows[0].Cells["idCicle"].Value.ToString();
                ctrlUfs.idModul = dgDades.SelectedRows[0].Cells["idModul"].Value.ToString();
                ctrlUfs.getUf();
                frm.ShowDialog();
                if (frm.hanfetOK)
                {
                    if (ckbTots.Checked)
                    {
                        getDadesSenseFiltre();
                    }
                    else
                    {
                        getDadesAmbFiltre();
                    }
                }
                dgDades.Rows[quinafila].Selected = true;
                frm = null;
                GC.Collect();
            }
        }

        private void cbCicle_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlUfs.modelAccessible() && cbCicle.SelectedValue != null && cbModul.SelectedValue != null)
            {
                getDadesAmbFiltre();
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbModul_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlCicle.modelAccessible() && cbModul.SelectedValue != null && cbCicle.SelectedValue != null)
            {
                getDadesAmbFiltre();
            }
            else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ckbTots_CheckedChanged(object sender, EventArgs e)
        {
            if (ckbTots.Checked)
            {
                cbCicle.Enabled = false;
                cbModul.Enabled = false;
                getDadesSenseFiltre();
            }
            else
            {
                cbCicle.Enabled = true;
                cbModul.Enabled = true;
                getDadesAmbFiltre();
            }
        }

    }
}
