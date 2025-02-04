using CLASSES;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace CLASSES
{

    public class ClBDSqlServer
    {
        public String cadenaConnexioServidor { get; set; }
        public String nomBD { get; set; }

        private SqlConnection connexio { get; set; }

        // constructor
        public ClBDSqlServer(String xconnexio)
        {
            cadenaConnexioServidor = xconnexio;
        }

        // destructor
        ~ClBDSqlServer()
        {
        }

        public Boolean Connectar()
        {
            Boolean xb = true;

            try
            {
                connexio = new SqlConnection(cadenaConnexioServidor);
                connexio.Open();
                xb = (connexio.State == ConnectionState.Open);
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - obrirConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean HiHaConnexio()
        {
            return (connexio != null);
        }

        public Boolean Desconnectar()
        {
            Boolean xb = true;

            try
            {
                connexio.Close();
                xb = (connexio.State == ConnectionState.Closed);
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - tancarConnexio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean ObrirBD(String xnomBD)
        {
            Boolean xb = true;

            try
            {
                nomBD = xnomBD;
                connexio.ChangeDatabase(nomBD);
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - obrirBD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean TancarBD()
        {
            Boolean xb = true;

            try
            {
                connexio.ChangeDatabase("master");
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - TancarBD", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean EstaOberta()
        {
            return (connexio.State == ConnectionState.Open);
        }

        public void Consulta(String xsql, ref DataSet xdset)
        {
            try
            {
                if (xsql.StartsWith("SELECT"))
                {
                    SqlDataAdapter da = new SqlDataAdapter(xsql, connexio);
                    da.Fill(xdset);
                }
                else
                {
                    MessageBox.Show("Error de Sintaxi en la consulta SELECT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - Consulta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public object ConsultaEscalar(String xsql)
        {
            object xresultat = null;

            try
            {
                if (xsql.StartsWith("SELECT"))
                {
                    SqlCommand cmd = new SqlCommand(xsql, connexio);
                    xresultat = cmd.ExecuteScalar();
                }
                else
                {
                    MessageBox.Show("Error de Sintaxi en la consulta SELECT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ConsultaEscalar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xresultat);
        }

        public Boolean InserirDades(String xsql)
        {
            Boolean xb = false;

            try
            {
                if (xsql.StartsWith("INSERT INTO"))
                {
                    xb = executarOrdre(xsql);
                }
                else
                {
                    MessageBox.Show("Error de Sintaxi en la consulta INSERT", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - InserirDades", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean ModificarDades(String xsql)
        {
            Boolean xb = false;

            try
            {
                if (xsql.StartsWith("UPDATE"))
                {
                    xb = executarOrdre(xsql);
                }
                else
                {
                    MessageBox.Show("Error de Sintaxi en la consulta UPDATE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        public Boolean SuprimirDades(String xsql)
        {
            Boolean xb = false;

            try
            {
                if (xsql.StartsWith("DELETE FROM"))
                {
                    xb = executarOrdre(xsql);
                }
                else
                {
                    MessageBox.Show("Error de Sintaxi en la consulta DELETE", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

        private Boolean executarOrdre(String xsql)
        {
            Boolean xb = false;

            try
            {
                SqlCommand cmd = new SqlCommand(xsql, connexio);
                cmd.ExecuteNonQuery();
                xb = true;
            }
            catch (Exception excp)
            {
                MessageBox.Show(excp.Message, "Excepció - ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return (xb);
        }

    }
}