using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WCFServicioRecicladoBotellas.AccesoDatos
{
    public class DataBase
    {
        static string connectionString = @"Data Source=BDRecicladoBotellas.mssql.somee.com;Initial Catalog=BDRecicladoBotellas;Persist Security Info=True;User ID=reciclado2020_SQLLogin_1;Password=yx5bpdm7l5";

        public static SqlCommand CreateBasicCommand()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand();
            command.Connection = connection;
            return command;
        }

        public static SqlCommand CreateBasicCommand(string query)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(query);
            command.Connection = connection;
            return command;
        }

        public static List<SqlCommand> CreateNBasicCommand(int n)
        {
            List<SqlCommand> res = new List<SqlCommand>();
            SqlConnection connection = new SqlConnection(connectionString);
            for (int i = 1; i <= n; i++)
            {
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                res.Add(command);
            }

            return res;
        }

        public static string GetGenerateIDTable(string tableName)
        {
            string res = "";
            string query = "SELECT IDENT_CURRENT('"+tableName+"') + IDENT_INCR('"+tableName+"')";
            SqlCommand command = CreateBasicCommand(query);

            try
            {
                command.Connection.Open();
                res = command.ExecuteScalar().ToString();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                command.Connection.Close();
            }
            return res;
        }

        /// <summary>
        /// Insert Update Delete
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static int ExecuteBasicCommand(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                return command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
        }        

        /// <summary>
        /// Select
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        public static DataTable ExecuteDataTableCommand(SqlCommand command)
        {
            DataTable res = new DataTable();
            try
            {
                command.Connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(res);
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                command.Connection.Close();
            }
            return res;
        }

        /// <summary>
        /// No se cierrra la conexion, cerrar al llamar al método
        /// </summary>
        /// <param name="cmd"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteDataReaderCommand(SqlCommand command)
        {
            SqlDataReader dr = null;
            try
            {
                command.Connection.Open();
                dr = command.ExecuteReader();
            }
            catch (Exception ex)
            {

                throw ex;
            }

            return dr;
        }

        public static void ExecuteNBasicCommand(List<SqlCommand> commands)
        {
            SqlTransaction transaction = null;
            SqlCommand command1 = commands[0];
            try
            {
                command1.Connection.Open();
                transaction = command1.Connection.BeginTransaction();
                foreach (SqlCommand item in commands)
                {
                    item.Transaction = transaction;
                    item.ExecuteNonQuery();
                }
                transaction.Commit();
            }
            catch (Exception)
            {
                transaction.Rollback();
                throw;
            }
            finally
            {
                command1.Connection.Close();
            }
        }
    }
}