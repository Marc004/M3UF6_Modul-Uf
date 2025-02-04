using CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_3_ClFamilies.CLASSES
{
    internal class ClModulSQLServer
    {
        private ClBDSqlServer bd = null;
        public Boolean bdAccessible = false;

        public string idCicle { get; set; }
        public string idModul { get; set; }
        public string nomModul { get; set; }

        public ClModulSQLServer(ClBDSqlServer xbd)
        {
            bd = xbd;
            bdAccessible = bd.EstaOberta();
        }

        ClModulSQLServer()
        {

        }

        public Boolean nouModul()
        {
            String xsql = "INSERT INTO tbModuls (idCicle, idModul, nomModul) VALUES ('" + idCicle + "', '" + idModul + "', '" + nomModul + "')";

            return (bd.InserirDades(xsql));
        }


        public Boolean modificarModul()
        {
            String xsql = "UPDATE tbModuls SET nomModul = '" + nomModul + ", idCicle = '" + idCicle + "' WHERE idModul = '" + idModul + "'";

            return (bd.ModificarDades(xsql));
        }

        public Boolean suprimirModul()
        {
            String xsql = "DELETE FROM tbModuls WHERE idModul = '" + idModul + "'";

            return (bd.SuprimirDades(xsql));
        }

        public Boolean getModul()
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            String xsql = "SELECT * FROM tbModuls WHERE idModul = '" + idModul + "'";

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                idModul = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                nomModul = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                xb = true;
            }
            return (xb);
        }

        public Boolean existeixModul()
        {
            String xsql = "SELECT COUNT(*) FROM tbModuls WHERE idModul = '" + idModul + "'";

            return ((Int32)bd.ConsultaEscalar(xsql) > 0);
        }

        public void llistaModul(ref DataSet dset, int n)
        {
            String xsql = "";

            switch (n)
            {
                case 0:
                    xsql = "SELECT * FROM tbModuls ORDER BY idModul";
                    break;

                case 1:
                    xsql = "SELECT * FROM tbModuls WHERE idCicle = '" + idCicle + "'";
                    break;
            }
            bd.Consulta(xsql, ref dset);
        }
    }
}
