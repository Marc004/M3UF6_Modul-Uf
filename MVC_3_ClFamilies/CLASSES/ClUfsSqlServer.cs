using CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_3_ClFamilies.CLASSES
{
    public class ClUfsSqlServer
    {
        private ClBDSqlServer bd = null;
        public Boolean bdAccessible = false;

        public String idCicle { get; set; }
        public String idModul { get; set; }
        public String idUf { get; set; }
        public String nomUf { get; set; }
        public int nHores { get; set; }
        public ClUfsSqlServer(ClBDSqlServer xbd)
        {
            bd = xbd;
            bdAccessible = bd.EstaOberta();
        }

        ClUfsSqlServer()
        {
        }

        public Boolean nouUf()
        {
            String xsql = "INSERT INTO tbUfs (idCicle, idModul, idUf, nomUf, nHores) VALUES ('" + idCicle + "', '" + idModul + "', '" + idUf + "', '"+ nomUf + "', "+ nHores +")";

            return (bd.InserirDades(xsql));
        }

        public Boolean modificarUf()
        {
            String xsql = "UPDATE tbUfs SET nomUf = '" + nomUf + ", idCicle = '" + idCicle + "', idModul = '" + idModul + "' WHERE idUf = '" + idUf + "'";

            return (bd.ModificarDades(xsql));
        }

        public Boolean suprimirUf()
        {
            String xsql = "DELETE FROM tbUfs WHERE idUf = '" + idUf + "'";

            return (bd.SuprimirDades(xsql));
        }

        public Boolean getUf()
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            String xsql = "SELECT * FROM tbUfs WHERE idUf = '" + idUf + "'";

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                idCicle = dset.Tables[0].Rows[0].ItemArray[1].ToString();
                idModul = dset.Tables[0].Rows[0].ItemArray[2].ToString();
                nomUf = dset.Tables[0].Rows[0].ItemArray[3].ToString();
                nHores = (int)dset.Tables[0].Rows[0].ItemArray[4];
                xb = true;
            }
            return (xb);
        }

        public Boolean existeixUf()
        {
            String xsql = "SELECT COUNT(*) FROM tbUfs WHERE idUf = '" + idUf + "'";

            return ((Int32)bd.ConsultaEscalar(xsql) > 0);
        }

        public void llistaUfs(ref DataSet dset, int n)
        {
            String xsql = "";

            switch (n)
            {
                case 0:
                    xsql = "SELECT * FROM tbUfs ORDER BY idUf";
                    break;

                case 1:
                    xsql = "SELECT * FROM tbUfs WHERE idCicle = '" + idCicle + "' AND idModul = '" + idModul + "'";
                    break;
            }
            bd.Consulta(xsql, ref dset);
        }
    }
}
