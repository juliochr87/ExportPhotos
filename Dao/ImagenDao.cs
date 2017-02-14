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
        public void guardarImagen(String rutaImagen, String orden, int idVivienda)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "insert into T_IMAGEN (ruta_imagen, id_vivienda, orden) values ('" + rutaImagen + "','" + idVivienda.ToString() + "','" + orden + "');";

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
      
        public List<Imagen> consultarImagenes(String idVivienda)
        {
            OleDbCommand oleDbCmd = openConnection();

            oleDbCmd.CommandText = "select * from T_IMAGEN where id_vivienda = " + idVivienda + "";

            OleDbDataReader reader = oleDbCmd.ExecuteReader();

            List<Imagen> listaImagenes = new List<Imagen>();

            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Imagen imagen = new Imagen();
                    imagen.Ruta = reader.GetValue(1).ToString();
                    imagen.Orden = reader.GetValue(3).ToString();

                    listaImagenes.Add(imagen);
                }
            }

            closeConnection(oleDbCmd);

            return listaImagenes;
        }
    }
}
