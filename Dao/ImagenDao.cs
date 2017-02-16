using ExportPhotos.Objects;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExportPhotos.Dao
{
    public class ImagenDao : Dao
    {
        public void guardarImagen(String rutaImagen, String orden, int idVivienda, String tipo)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "insert into T_IMAGEN (ruta_imagen, id_vivienda, orden,reporte) values ('" + rutaImagen + "','" + idVivienda.ToString() + "','" + orden + "','" + tipo + "');";

            int temp = oleDbCmd.ExecuteNonQuery();

            closeConnection(oleDbCmd);
        }

        public void borrarImagen(String idVivienda, String reporte)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "delete from T_IMAGEN where id_vivienda = " + idVivienda.ToString() + " and reporte='" + reporte + "'";

            int temp = oleDbCmd.ExecuteNonQuery();

            closeConnection(oleDbCmd);
        }

        public void borrarImagen(String idVivienda)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "delete from T_IMAGEN where id_vivienda = " + idVivienda.ToString() + "";

            int temp = oleDbCmd.ExecuteNonQuery();

            closeConnection(oleDbCmd);
        }
        public List<Imagen> consultarImagenes(String idVivienda,String reporte)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_IMAGEN where id_vivienda = " + idVivienda + " and reporte='"+reporte+"'";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            List<Imagen> listaImagenes = new List<Imagen>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Ruta = reader.GetValue(1).ToString();
                    imagen.Orden = reader.GetValue(3).ToString();
                    imagen.Reporte = reader.GetValue(4).ToString();

                    listaImagenes.Add(imagen);
                }
            }

            closeConnection(oleDbCmd);

            return listaImagenes;
        }
    }
}
