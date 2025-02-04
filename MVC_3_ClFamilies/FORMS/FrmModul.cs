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
    public partial class FrmModul : Form
    {
        public ClModul ctrlModuls;
        public ClCicles ctrlCicle;

        private ClBDSqlServer bd;
        private DataSet dset = new DataSet();
        public FrmModul(ClBDSqlServer xbd)
        {
            bd = xbd;
            InitializeComponent();
        }
        private void FrmModul_Load(object sender, EventArgs e)
        {
            ctrlModuls = new ClModul(bd);
            ctrlCicle = new ClCicles(bd);
            omplirComboBox();
            getDadesSenseFiltre();
            iniDgrid();
            
        }

        private void omplirComboBox()
        {
            if (ctrlCicle.modelAccessible())
            {
                DataSet dset = new DataSet();
                ctrlCicle.llistaXnomCicle(ref dset);
                cbCicle.DataSource = dset.Tables[0];
                cbCicle.DisplayMember = "nomCicle";
                cbCicle.ValueMember = "idCicle";
            }else
            {
                MessageBox.Show("No hi ha accés a la base de dades", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getDadesAmbFiltre()
        {
            if (ctrlModuls.modelAccessible())
            {
                dset.Clear();
                ctrlModuls.idCicle = cbCicle.SelectedValue.ToString();
                ctrlModuls.llistaXnomModuls(ref dset);
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
            if (ctrlModuls.modelAccessible())
            {
                dset.Clear();
                ctrlModuls.llistaModuls(ref dset);
                dgDades.DataSource = dset.Tables[0];
                dgDades.AutoResizeColumns();
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

        private void btNou_Click(object sender, EventArgs e)
        {
            FrmAMModul frm = new FrmAMModul();

            frm.frmPare = this;
            frm.Text = "Alta d'un Modul";
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
                                where fila.Cells["idModul"].Value.ToString().Trim() == ctrlModuls.idModul
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
                ctrlModuls.idModul = dgDades.SelectedRows[0].Cells["idModul"].Value.ToString().Trim();
                ctrlModuls.nomModul = dgDades.SelectedRows[0].Cells["nomModul"].Value.ToString().Trim();
                if (ctrlModuls.suprimirModul())
                {
                    if (ckbTots.Checked)
                    {
                        getDadesSenseFiltre();
                    }
                    else
                    {
                        getDadesAmbFiltre();
                    }

                    //dgDades.Rows[0].Selected = true;
                }
            }
        }

        private void dgDades_DoubleClick(object sender, EventArgs e)
        {
            Int32 quinafila = 0;
            FrmAMModul frm;

            if (dgDades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cal seleccionar una fila", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                quinafila = dgDades.SelectedRows[0].Index;
                frm = new FrmAMModul();
                frm.frmPare = this;
                frm.Text = "Modificar una família";
                frm.operacio = 'M';
                ctrlModuls.idModul = dgDades.SelectedRows[0].Cells["idModul"].Value.ToString();
                ctrlModuls.nomModul = dgDades.SelectedRows[0].Cells["nomModul"].Value.ToString();
                ctrlModuls.idCicle = dgDades.SelectedRows[0].Cells["idCicle"].Value.ToString();
                ctrlModuls.getModul();
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

        private void cbFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ctrlModuls.modelAccessible())
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
                getDadesSenseFiltre();
            }
            else
            {
                cbCicle.Enabled = true;
                getDadesAmbFiltre();
            }
        }
    }
}
