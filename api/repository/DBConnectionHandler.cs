using System;
using api.models;
using System.Data.SqlClient;
namespace api.repository;

public class ConnectionHandler
{
    public static string GetConnectionString()
    {
        try
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "frncm-aws.cmniog6zdesn.ap-southeast-2.rds.amazonaws.com";
            builder.UserID = "API";
            builder.Password = "!!D3M0CRUD4PP!!";
            builder.InitialCatalog = "DemoCRUDApp";
            return builder.ConnectionString;
        }
        catch (Exception err)
        {
            Console.WriteLine(err);
            throw;
        }
    }
    
}

