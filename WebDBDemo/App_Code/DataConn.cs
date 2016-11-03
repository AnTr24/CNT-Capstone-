using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

// These Libraries are required to talk to SQL Server
using System.Data.SqlClient;
using System.Data;

/// <summary>
/// Summary description for DataConn
/// </summary>
public static class DataConn
{
    public static List<int> GetData()
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["yli121ConnectionString"].ConnectionString);
        conn.Open();

        SqlCommand command = new SqlCommand();
        command.Connection = conn;

        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "GetData";

        SqlParameter param = new SqlParameter();
        param.Direction = ParameterDirection.Input;
        param.ParameterName = "@key";
        param.SqlDbType = SqlDbType.Int;
        param.Value = 4;

        command.Parameters.Add(param);

        SqlDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
      

        List<int> values = new List<int>();
        while (reader.Read())
            for (int i = 0; i < reader.FieldCount; ++i)
                values.Add((int)reader[i]);

        return values;
    }

    public static void InsertData()
    {
        SqlConnection conn = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["yli121ConnectionString"].ConnectionString);
        conn.Open();

        SqlCommand command = new SqlCommand();
        command.Connection = conn;

        command.CommandType = CommandType.StoredProcedure;
        command.CommandText = "InsertData";

        SqlParameter param = new SqlParameter();
        param.Direction = ParameterDirection.Input;
        param.ParameterName = "@value1";
        param.SqlDbType = SqlDbType.Int;
        param.Value = 4;
        command.Parameters.Add(param);

        param = new SqlParameter();
        param.Direction = ParameterDirection.Input;
        param.ParameterName = "@value2";
        param.SqlDbType = SqlDbType.Int;
        param.Value = 5;
        command.Parameters.Add(param);


        command.ExecuteNonQuery();
    }
    
}