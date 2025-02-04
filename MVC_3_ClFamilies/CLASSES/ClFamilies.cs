using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using CLASSES;
using System.Data.Entity;
namespace CLASSES
{
    public class ClFamilies
    {
        private ClBDSqlServer bd = null;
        private ClFamiliesSqlServer model = null;                           // aquí utilitzarem el model que és la capa que està per sota del controlador

        public String idFamilia { get; set; }
        public String nomFamilia { get; set; }

        public ClFamilies(ClBDSqlServer xbd)
        {
            // *** AQUÍ FALTA CODI ***
            bd = xbd;
            model = new ClFamiliesSqlServer(bd);
            if (model.bdAccessible != true)
            {
                model = null;
            }
        }

        // destructor
        ~ClFamilies()
        {
        }

        public Boolean modelAccessible() {
            return (model != null && bd.HiHaConnexio());
        }

        public Boolean novaFamilia()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (idFamilia == idFamilia.ToUpper() && idFamilia.Length >= 3 && idFamilia.Length >= 5)
                {
                    if (nomFamilia.Trim() != "" && nomFamilia.Length <= 100)
                    {
                        model.idFamilia = idFamilia;
                        model.nomFamilia = nomFamilia;
                        xb = model.novaFamilia();
                    }else
                    {
                        MessageBox.Show("No se ha introducido ningun nombre de Familia o a superado al limite de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha puesto bien el campo de id entre 3 y 5 letras y en Mayusculas", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("No es accesible al modelo","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            
            return (xb);
        }

        public Boolean modificarFamilia()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (nomFamilia.Trim() != "" && nomFamilia.Length <= 100)
                {
                    if (model.modificarFamilia())
                    {
                        model.idFamilia = idFamilia;
                        model.nomFamilia = nomFamilia;
                        xb = model.modificarFamilia();
                    }else
                    {
                        MessageBox.Show("No se ha encontrado la familia especificada", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                else
                {
                    MessageBox.Show("No se ha introducido ningun nombre de Familia o a superado al limite de 100 caracteres", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }else
            {
                MessageBox.Show("No es accesible al modelo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }

            return (xb);
        }

        public Boolean suprimirFamilia()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                if (getFamilia())
                {
                    if (model.suprimirFamilia())
                    {
                        xb = model.suprimirFamilia();
                    }else
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

        public Boolean getFamilia()
        {
            Boolean xb = false;

            if (modelAccessible())
            {
                model.idFamilia = idFamilia;
                model.nomFamilia = nomFamilia;
                if (model.getFamilia())
                {
                    xb = true;
                }else
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

        public Boolean existeixFamilia()
        {
            // *** AQUÍ FALTA CODI ***
            return (model.existeixFamilia());
        }

        public void llistaFamilies(ref DataSet dset)
        {
            // *** AQUÍ FALTA CODI ***
            model.llistaFamilies(ref dset, 0);
        }

        public void llistaXnomFamilies(ref DataSet dset)
        {
            // *** AQUÍ FALTA CODI ***
            model.llistaFamilies(ref dset, 1);
        }

        public Int32 quantesFamilies()
        {

            return ((Int32)model.quantesFamilies());// *** AQUÍ FALTA CODI ***);
        }

        public Int32 quantesFamiliesXprefix(String prefix)
        {
            return ((Int32)model.quantesFamiliesXprefix(prefix));// *** AQUÍ FALTA CODI ***);
        }

        private Boolean verificarId(String xid)
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            String xsql = "SELECT * FROM tbFamilies WHERE idFamilia = '" + idFamilia + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

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


            String xsql = "SELECT * FROM tbFamilies WHERE nomFamilia = '" + xnom + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

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
