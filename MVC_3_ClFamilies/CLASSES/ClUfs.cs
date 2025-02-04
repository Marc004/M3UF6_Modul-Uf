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
    public class ClUfs
    {
        private ClBDSqlServer bd = null;
        private ClUfsSqlServer model = null;
        
        public String idCicle { get; set; }
        public String idModul { get; set; }
        public String idUf { get; set; }
        public String nomUf { get; set; }
        public int nHores { get; set; }

        public ClUfs(ClBDSqlServer xbd)
        {
            bd = xbd;
            model = new ClUfsSqlServer(bd);

            if (model.bdAccessible == false)
            {
                model = null;
            }

            idCicle = model.idCicle;
        }

        ClUfs() { 
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

        public Boolean nouUf()
        {
            Boolean xb = false;

            model.idUf = idUf;
            model.idCicle = idCicle;
            model.idModul = idModul;
            model.nomUf = arreglarString(nomUf);

            if (verificarId(idUf))
            {
                //xb = model.novaCicle();
                if (verificarNom(nomUf))
                {
                    if (existeixUf() == false)
                    {
                        xb = model.nouUf();
                    }
                    else
                    {
                        MessageBox.Show("La Uf ja existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El nom no pot estar buit", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La longitud de l'identificador del cicle ha de ser entre 3 i 5 caràcters", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb);

        }

        public Boolean modificarUf()
        {
            Boolean xb = false;

            model.idUf = idUf;
            model.idCicle = idCicle;
            model.idModul = idModul;
            model.nomUf = arreglarString(nomUf);

            if (existeixUf())
            {
                if (verificarNom(nomUf))
                {
                    xb = model.modificarUf();
                }
                else
                {
                    MessageBox.Show("El nom no pot estar buit o superar 100 caracteres", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("La Uf no existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb);
        }

        public Boolean suprimirUf()
        {
            Boolean xb = false;

            model.idUf = idUf;
            model.nomUf = arreglarString(nomUf);

            if (existeixUf())
            {
                if (MessageBox.Show("Estàs segur que vols suprimir la UF?", "ATENCIÓ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    xb = model.suprimirUf();
                }
            }
            else
            {
                MessageBox.Show("La Uf no existeix", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return (xb);
        }

        public Boolean getUf()
        {
            Boolean xb = false;

            model.idCicle = idCicle;

            if (existeixUf())
            {
                if (model.getUf())
                {
                    nomUf = model.nomUf;
                    xb = true;
                }
            }

            return xb;
        }

        public Boolean existeixUf()
        {
            model.idUf = idUf;
            return (model.existeixUf());
        }

        public void llistaUfs(ref DataSet dset)
        {
            //Obté la llista de les famílies ordenades per codi.Deixa les dades obtingudes en un DataSet que s’haurà de retornar passant-lo per referència.
            model.llistaUfs(ref dset, 0);
        }

        public void llistaXnomUfs(ref DataSet dset)
        {
            model.idCicle = idCicle;
            model.idModul = idModul;

            model.llistaUfs(ref dset, 1);
        }


        private Boolean verificarId(String xid)
        {
            Boolean xb = false;

            if (xid.Length >= 3 && xid.Length <= 5)
            {
                xb = true;
            }

            return (xb);
        }

        private Boolean verificarNom(String xnom)
        {
            Boolean xb = false;

            if (nomUf != "" || nomUf.Length <= 100)
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
