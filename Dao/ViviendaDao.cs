using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPhotos.Dao
{
    public class ViviendaDao : Dao
    {
        public int guardarVivienda(String numeroCasa, String beneficiario, String cedula, String predio, String provincia, String distrito, String corregimiento)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "insert into T_VIVIENDA (numero_casa, beneficiario,cedula,predio,provincia,distrito,corregimiento) " +
                                    "values ('" + numeroCasa + "','" + beneficiario + "', '" + cedula + "','" + predio + "','" + provincia + "','" + distrito + "','" + corregimiento + "');";

            oleDbCmd.ExecuteNonQuery();

            oleDbCmd.CommandText = "Select @@Identity";

            int temp = (int)oleDbCmd.ExecuteScalar();

            closeConnection(oleDbCmd);

            return temp;
        }

        public void borrarVivienda(String idVivienda)
        {
            OleDbCommand oleDbCmd = openConnection();
 
            oleDbCmd.CommandText = "delete from T_VIVIENDA where ID = " + idVivienda.ToString() + "";

            int temp = oleDbCmd.ExecuteNonQuery();

            closeConnection(oleDbCmd);
        }
        public List<Vivienda> consultarViviendas()
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_VIVIENDA";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            List<Vivienda> listaViviendas = new List<Vivienda>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Vivienda vivienda = new Vivienda();

                    vivienda.Id = reader.GetValue(0).ToString();
                    vivienda.NumeroCasa = reader.GetValue(1).ToString();
                    vivienda.Beneficiario = reader.GetValue(2).ToString();
                    vivienda.Cedula = reader.GetValue(3).ToString();
                    vivienda.Predio = reader.GetValue(4).ToString();
                    vivienda.Provincia = reader.GetValue(5).ToString();
                    vivienda.Distrito = reader.GetValue(6).ToString();
                    vivienda.Corregimiento = reader.GetValue(7).ToString();

                    listaViviendas.Add(vivienda);
                }
            }
            closeConnection(oleDbCmd);

            return listaViviendas;
        }

        public Vivienda consultarVivienda(String id)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_VIVIENDA where ID = " + id + "";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            Vivienda vivienda = new Vivienda();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    vivienda.Id = reader.GetValue(0).ToString();
                    vivienda.NumeroCasa = reader.GetValue(1).ToString();
                    vivienda.Beneficiario = reader.GetValue(2).ToString();
                    vivienda.Cedula = reader.GetValue(3).ToString();
                    vivienda.Predio = reader.GetValue(4).ToString();
                    vivienda.Provincia = reader.GetValue(5).ToString();
                    vivienda.Distrito = reader.GetValue(6).ToString();
                    vivienda.Corregimiento = reader.GetValue(7).ToString();


                }
            }
            closeConnection(oleDbCmd);

            return vivienda;
        }

        public Vivienda consultarViviendaPorNumeroCasa(String numeroCasa)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_VIVIENDA where numero_casa = '" + numeroCasa + "'";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            Vivienda vivienda = new Vivienda();

            if (reader.HasRows)
            {
                while (reader.Read())
                {

                    vivienda.Id = reader.GetValue(0).ToString();
                    vivienda.NumeroCasa = reader.GetValue(1).ToString();
                    vivienda.Beneficiario = reader.GetValue(2).ToString();
                    vivienda.Cedula = reader.GetValue(3).ToString();
                    vivienda.Predio = reader.GetValue(4).ToString();
                    vivienda.Provincia = reader.GetValue(5).ToString();
                    vivienda.Distrito = reader.GetValue(6).ToString();
                    vivienda.Corregimiento = reader.GetValue(7).ToString();


                }
            }
            closeConnection(oleDbCmd);

            return vivienda;
        }

        public List<Vivienda> consultarViviendas(String busqueda)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_VIVIENDA WHERE numero_casa like '%" + busqueda + "%' OR  beneficiario like '%" + busqueda + "%' OR  cedula like '%" + busqueda + "%' OR predio like '%" + busqueda + "%' OR provincia like '%" + busqueda + "%' OR distrito like '%" + busqueda + "%' OR corregimiento like '%" + busqueda + "%'";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            List<Vivienda> listaViviendas = new List<Vivienda>();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Vivienda vivienda = new Vivienda();

                    vivienda.Id = reader.GetValue(0).ToString();
                    vivienda.NumeroCasa = reader.GetValue(1).ToString();
                    vivienda.Beneficiario = reader.GetValue(2).ToString();
                    vivienda.Cedula = reader.GetValue(3).ToString();
                    vivienda.Predio = reader.GetValue(4).ToString();
                    vivienda.Provincia = reader.GetValue(5).ToString();
                    vivienda.Distrito = reader.GetValue(6).ToString();
                    vivienda.Corregimiento = reader.GetValue(7).ToString();

                    listaViviendas.Add(vivienda);
                }
            }
            closeConnection(oleDbCmd);

            return listaViviendas;
        }

    }
}
