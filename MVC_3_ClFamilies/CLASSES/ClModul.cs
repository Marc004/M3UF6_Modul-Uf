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
    public class ClModul
    {
        private ClBDSqlServer bd = null;
        private ClModulSQLServer model = null;

        public string idCicle { get; set; }
        public string idModul { get; set; }
        public string nomModul { get; set; }

        public ClModul(ClBDSqlServer xbd)
        {
            bd = xbd;
            model = new ClModulSQLServer(bd);

            if (model.bdAccessible == false )
            {
                model = null;
            }
            idCicle = model.idCicle;

        }

        ClModul()
        {

        }
        public Boolean modelAccessible()
        {
            Boolean xb = false;

            if (model == null)
            {
                xb = false;
            }
            else
            {
                xb = true;
            }

            return (xb);
        }

        public Boolean nouModul()
        {
            Boolean xb = false;

            model.idCicle = idCicle;
            model.nomModul = arreglarString(nomModul);
            model.idModul = idModul;

            if (verificarId(idModul))
            {
                if (verificarNom(nomModul))
                {
                    if (existeixModul() == false)
                    {
                        xb = model.nouModul();
                    }else
                    {
                        MessageBox.Show("El Modul ja existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }else
                {
                    MessageBox.Show("El nom no pot estar buit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La longitud de l'identificador del cicle ha de ser entre 3 i 5 caràcters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return xb;
        }

        public Boolean modificarModul()
        {
            Boolean xb = false;

            model.idCicle = idCicle;
            model.nomModul = arreglarString(nomModul);
            model.idModul = idModul;

            if (existeixModul())
            {
                if (verificarNom(nomModul))
                {
                    xb = model.modificarModul();
                }else
                {
                    MessageBox.Show("El nom no pot estar buit o superar 100 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El Modul no existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb);
        }

        public Boolean suprimirModul()
        {
            Boolean xb = false;

            model.idCicle = idCicle;
            model.nomModul = arreglarString(nomModul);
            model.idModul = idModul;

            if (existeixModul())
            {
                if (MessageBox.Show("Estàs segur que vols suprimir el Modul?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    xb = model.suprimirModul();
                }
            }
            else
            {
                MessageBox.Show("El Modul no existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb);
        }

        public Boolean getModul()
        {
            Boolean xb = false;

            model.idModul = idModul;

            if (existeixModul())
            {
                if (model.getModul())
                {
                    nomModul = model.nomModul;
                    xb = true;
                }
            }

            return xb;
        }

        public Boolean existeixModul()
        {
            model.idModul = idModul;
            return (model.existeixModul());
        }

        public void llistaModuls(ref DataSet dset)
        {
            model.llistaModul(ref dset, 0);
        }

        public void llistaXnomModuls(ref DataSet dset)
        {
            model.idCicle = idCicle;

            model.llistaModul(ref dset, 1);
        }

        private Boolean verificarId(string xid)
        {
            Boolean xb = false;

            if (xid.Length >= 3 && xid.Length <= 5)
            {
                xb = true;
            }

            return (xb);
        }

        private Boolean verificarNom(string xnom)
        {
            Boolean xb = false;

            if (nomModul != "" || nomModul.Length <= 100)
            {
                xb = true;
            }

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
