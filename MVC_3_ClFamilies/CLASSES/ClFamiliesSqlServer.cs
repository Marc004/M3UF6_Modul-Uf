using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CLASSES;
namespace CLASSES
{
    public class ClFamiliesSqlServer
    {
        private ClBDSqlServer bd = null;            // IMPORTANT!!!! AQUESTA CLASSE FUNCIONA BASANT-SE EN LA CLASSE ClBdSqlServer FETA EN LA PRÀCTICA ANTERIOR
        public Boolean bdAccessible = false;

        // PROPIETATS CORRESPONENTS ALS CAMPS DE LA TAULA
        public String idFamilia { get; set; }
        public String nomFamilia { get; set; }

        public ClFamiliesSqlServer(ClBDSqlServer xbd)
        {
            bd = xbd;
            bdAccessible = bd.EstaOberta();
        }

        // destructor
        ~ClFamiliesSqlServer()
        {
        }

        public Boolean novaFamilia()
        {
            // *** AQUÍ FALTA CODI ***
            
            String xsql = "INSERT INTO tbFamilies(idFamilia, nomFamilia) VALUES('" + idFamilia + "', '" + nomFamilia + "')";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES QUE HAN D'ACABAR ARRIBANT A LA BD
                                                                    // LES TENS A LES PROPIETATS DE LA CLASSE
           
            return(bd.InserirDades(xsql));
        }

        public Boolean modificarFamilia()
        {
            // *** AQUÍ FALTA CODI ***
            String xsql = "UPDATE tbFamilies SET nomFamilia = '" + nomFamilia +"' WHERE idFamilia = '" + idFamilia + "'";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES QUE HAN D'ACABAR ARRIBANT A LA BD
                                                                    // LES TENS A LES PROPIETATS DE LA CLASSE

            return (bd.ModificarDades(xsql));
        }

        public Boolean suprimirFamilia()
        {
            // *** AQUÍ FALTA CODI ***
            String xsql = "DELETE FROM tbFamilies WHERE idFamilia = '" + idFamilia +"'";   // *** S'HA DE POSAR LA SENTÈNCIA SQL ADEQUADA. TINGUES EN COMPTE QUE LES DADES 
                                                                    // LES TENS A LES PROPIETATS DE LA CLASSE
            return (bd.SuprimirDades(xsql));
        }

        public Boolean getFamilia()
        {
            Boolean xb = false;
            DataSet dset = new DataSet();

            // *** AQUÍ FALTA CODI ***
            // *** TINGUES EN COMPTE QUE L'ID DE LA FAMÍLIA QUE VOLEM BUSCAR A LA BASE DE DADES JA ESTARÀ POSAT A LA PROPIETA idFamilia DE LA CLASSE
            String xsql = "SELECT nomFamilia FROM tbFamilies WHERE idFamilia = '" + idFamilia + "'";          // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            bd.Consulta(xsql, ref dset);
            if (dset.Tables[0].Rows.Count > 0)
            {
                nomFamilia = dset.Tables[0].Rows[0].ItemArray[0].ToString();
                xb = true;
            }
            return (xb);
        }

        public Boolean existeixFamilia()
        {
            // *** AQUÍ FALTA CODI ***
            // *** TINGUES EN COMPTE QUE L'ID DE LA FAMÍLIA QUE VOLEM BUSCAR A LA BASE DE DADES JA ESTARÀ POSAT A LA PROPIETA idFamilia DE LA CLASSE
            String xsql = "SELECT * FROM tbFamilies WHERE idFamilia = '" + idFamilia + "'";      // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql) > 0);
        }

        public void llistaFamilies(ref DataSet dset, int n)
        {
            String xsql = "";

            switch (n)
            {
                case 0: xsql = "SELECT * FROM tbFamilies ORDER BY idFamilia ";      // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***
                    break;

                case 1:
                    xsql = "SELECT * FROM tbFamilies ORDER BY nomFamilia ";  // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***
                    break;
            }
            bd.Consulta(xsql, ref dset);
        }

        public Int32 quantesFamilies()
        {
            String xsql = "SELECT COUNT(idFamilia) FROM tbFamilies";        // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql));
        }

        public Int32 quantesFamiliesXprefix(String prefix)
        {
            String xsql = "SELECT COUNT(idFamilia) FROM tbFamilies WHERE nomFamilia LIKE '" + prefix +"%' " ;  // *** S'HA D'ACABAR D'ESCRIURE LA SENTÈNCIA SELECT ***

            return ((Int32)bd.ConsultaEscalar(xsql));
        }
    }
}
