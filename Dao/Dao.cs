using ExportPhotos.Objects;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;


namespace ExportPhotos.Dao
{
    public class Dao
    {
        private static String STRING_DATABASE_PROPERTY = "DB";

        public static String STRING_CONEXION = ConfigurationManager.ConnectionStrings[STRING_DATABASE_PROPERTY].ToString();

        public OleDbCommand openConnection()
        {
            OleDbCommand oleDbCmd = new OleDbCommand();
            OleDbConnection bookConn = new OleDbConnection(STRING_CONEXION);
            
            bookConn.Open();
             
            oleDbCmd.Connection = bookConn;
           
            return oleDbCmd;

        }

        public void closeConnection(OleDbCommand oleDbCmd)
        {
            oleDbCmd.Connection.Close();
        }
    }
}
