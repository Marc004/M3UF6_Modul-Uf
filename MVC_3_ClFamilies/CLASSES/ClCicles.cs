using CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVC_3_ClFamilies.CLASSES
{
    public class ClCicles
    {
        private ClBDSqlServer bd = null;
        private ClCiclesSQLServer model = null;                           // aquí utilitzarem el model que és la capa que està per sota del controlador

        public String idCicle { get; set; }
        public String nomCicle { get; set; }
        public String idFamilia { get; set; }
        public ClCicles(ClBDSqlServer xbd)
        {
            // *** AQUÍ FALTA CODI ***
            bd = xbd;
            model = new ClCiclesSQLServer(bd);
            if (model.bdAccessible != true)
            {
                model = null;
            }
        }

        ClCicles()
        {
        }

        public void omplirComboBox(ref DataSet dset)
        {
            if (modelAccessible())
            {
                model.omplirComboBox(ref dset);
            }
        }

        public Boolean modelAccessible()
        {
            return (model != null && bd.HiHaConnexio());
        }

        public Boolean novaCicle()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (idCicle == idCicle.ToUpper() && idCicle.Length >= 3 && idCicle.Length >= 5)
                {
                    if (idFamilia == idFamilia.ToUpper() && idFamilia.Length >= 3 && idFamilia.Length >= 5)
                    {
                        if (nomCicle.Trim() != "" && nomCicle.Length <= 100)
                        {
                            model.idCicle = idCicle;
                            model.nomCicle = nomCicle;
                            model.idFamilia = idFamilia;
                            xb = model.novaCicle();
                        }
                        else
                        {
                            MessageBox.Show("No se ha introducido ningun nombre de Familia o a superado al limite de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se ha puesto bien el campo de id entre 3 y 5 letras y en Mayusculas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }else
                {
                    MessageBox.Show("No se ha puesto bien el campo de id entre 3 y 5 letras y en Mayusculas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }
            else
            {
                MessageBox.Show("No es accesible al modelo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return (xb);
        }

        public Boolean modificarCicle()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (nomCicle.Trim() != "" && nomCicle.Length <= 100)
                {
                    if (model.modificarCicle())
                    {
                        model.idCicle = idCicle;
                        model.nomCicle = nomCicle;
                        model.idFamilia = idFamilia;
                        xb = model.modificarCicle();
                    }
                    else
                    {
                        MessageBox.Show("No se ha encontrado la familia especificada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha introducido ningun nombre de Familia o a superado al limite de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("No es accesible al modelo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return (xb);
        }

        public Boolean suprimirCicle()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (getCicle())
                {
                    if (model.suprimirCicle())
                    {
                        xb = model.suprimirCicle();
                    }
                    else
                    {
                        MessageBox.Show("No se ha podido eliminar la familia", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
            else
            {
                MessageBox.Show("No es accesible al modelo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            // *** AQUÍ FALTA CODI ***
            return (xb);
        }

        public Boolean getCicle()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                model.idCicle = idCicle;
                model.nomCicle = nomCicle;
                model.idFamilia = idFamilia;
                if (model.getCicle())
                {
                    xb = true;
                }
                else
                {
                    MessageBox.Show("No se ha encontrado la familia especificada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("No es accesible al modelo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            // *** AQUÍ FALTA CODI ***
            return (xb);
        }

        public Boolean existeixCicle()
        {
            // *** AQUÍ FALTA CODI ***
            return (model.existeixCicle());
        }

        public void llistaCicle(ref DataSet dset)
        {
            // *** AQUÍ FALTA CODI ***
            model.idFamilia = idFamilia;
            model.llistaCicle(ref dset, 1);
        }

        public void llistaXnomCicle(ref DataSet dset)
        {
            // *** AQUÍ FALTA CODI ***
            model.llistaCicle(ref dset, 0);
        }

        public Int32 quantesCicle()
        {

            return ((Int32)model.quantesCicles());// *** AQUÍ FALTA CODI ***);
        }

        public Int32 quantesCiclesXprefix(String prefix)
        {
            return ((Int32)model.quantesCiclesXprefix(prefix));// *** AQUÍ FALTA CODI ***);
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            String xsql = "SELECT * FROM tbCicles WHERE idFamilia = '" + xid + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                xb = true;
            }
            // *** AQUÍ FALTA CODI ***
            return (xb);
        }

        private Boolean verificarNom(String xnom)
        {
            Boolean xb = false;
            DataSet dset = new DataSet();


            String xsql = "SELECT * FROM tbCicles WHERE nomCicle = '" + xnom + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                xb = true;
            }

            // *** AQUÍ FALTA CODI ***
            return (xb);
        }

        private String arreglarString(String xs)
        {
            // Aquesta funció serveix per a evitar els possibles errors que es poden produir si la descripció de la família té un apòstrof
            String xs1 = "";

            xs1 = xs.Replace("'", "''");
            return (xs1);
        }

    }
}
