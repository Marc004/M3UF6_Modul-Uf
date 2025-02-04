using CLASSES;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_3_ClFamilies.CLASSES
{
    public class ClCiclesSQLServer
    {
        private ClBDSqlServer bd = null;            // IMPORTANT!!!! AQUESTA CLASSE FUNCIONA BASANT-SE EN LA CLASSE ClBdSqlServer FETA EN LA PRÀCTICA ANTERIOR
        public Boolean bdAccessible = false;

        // PROPIETATS CORRESPONENTS ALS CAMPS DE LA TAULA
        public String idCicle { get; set; }
        public String nomCicle { get; set; }
        public String idFamilia { get; set; }


        public ClCiclesSQLServer(ClBDSqlServer xbd)
        {
            bd = xbd;
            bdAccessible = bd.EstaOberta();
        }

        // destructor
        ~ClCiclesSQLServer()
        {
        }

        public void omplirComboBox(ref DataSet dset)
        {

            String xsql = "SELECT * FROM tbFamilies";

            bd.Consulta(xsql, ref dset);
        }

        public Boolean novaCicle()
        {
            // *** AQUÍ FALTA CODI ***

            String xsql = "INSERT INTO tbCicles(idCicle, nomCicle, idFamilia) VALUES('" + idCicle + "', '" + nomCicle + "', '" + idFamilia + "')";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES QUE HAN D'ACABAR ARRIBANT A LA BD
                                                                                                                               // LES TENS A LES PROPIETATS DE LA CLASSE

            return (bd.InserirDades(xsql));
        }

        public Boolean modificarCicle()
        {
            // *** AQUÍ FALTA CODI ***
            String xsql = "UPDATE tbCicles SET nomCicle = '" + nomCicle + "', idFamilia = '" + idFamilia + "' WHERE idCicle = '" + idCicle + "'";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES QUE HAN D'ACABAR ARRIBANT A LA BD
                                                                                                                             // LES TENS A LES PROPIETATS DE LA CLASSE

            return (bd.ModificarDades(xsql));
        }

        public Boolean suprimirCicle()
        {
            // *** AQUÍ FALTA CODI ***
            String xsql = "DELETE FROM tbCicles WHERE idCicle = '" + idCicle + "'";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES 
                                                                                            // LES TENS A LES PROPIETATS DE LA CLASSE
            return (bd.SuprimirDades(xsql));
        }

        public Boolean getCicle()
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            // *** AQUÍ FALTA CODI ***
            // *** TINGUES EN COMPTE QUE L'ID DE LA FAMÍLIA QUE VOLEM BUSCAR A LA BASE DE DADES JA ESTARÀ POSAT A LA PROPIETA idFamilia DE LA CLASSE
            String xsql = "SELECT idCicle, nomCicle FROM tbCicles WHERE idCicle = '" + idCicle + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                nomCicle = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                xb = true;
            }
            return (xb);
        }

        public Boolean existeixCicle()
        {
            // *** AQUÍ FALTA CODI ***
            // *** TINGUES EN COMPTE QUE L'ID DE LA FAMÍLIA QUE VOLEM BUSCAR A LA BASE DE DADES JA ESTARÀ POSAT A LA PROPIETA idFamilia DE LA CLASSE
            String xsql = "SELECT * FROM tbCicles WHERE idCicle = '" + idCicle + "'";      // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql) > 0);
        }

        public void llistaCicle(ref DataSet dset, int n)
        {
            String xsql = "";

            switch (n)
            {
                case 0:
                    xsql = "SELECT tbF.nomFamilia , tbC.idCicle , tbC.nomCicle FROM tbCicles tbC JOIN tbFamilies tbF ON (tbC.idFamilia = tbF.idFamilia)";      // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***
                    break;

                case 1:
                    xsql = "SELECT tbF.nomFamilia , tbC.idCicle , tbC.nomCicle FROM tbCicles tbC JOIN tbFamilies tbF ON (tbC.idFamilia = tbF.idFamilia) WHERE tbC.idFamilia = '" + idFamilia + "'";  // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***
                    break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public Int32 quantesCicles()
        {
            String xsql = "SELECT COUNT(idCicle) FROM tbCicles";        // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql));
        }

        public Int32 quantesCiclesXprefix(String prefix)
        {
            String xsql = "SELECT COUNT(idCicle) FROM tbCicles WHERE nomCicle LIKE '" + prefix + "%' ";  // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql));
        }

    }
}
