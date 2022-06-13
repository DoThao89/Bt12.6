using System;
using System.Data.SqlClient;
using System.Data;
using lab5._1;

class Program
{
    static void Main(string[] args)
    {
        CreateData();
        ReadData();
        //EditData();
        DeleteData();


    }
    static void ReadData()
    {
        ConnectionDb connectionDb = new ConnectionDb();
        SqlConnection connection = connectionDb.GetConnection();


        string query = "SELECT * FROM product";
        SqlCommand sqlCommand = new SqlCommand(query, connection);
        connection.Open();

        SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
        while (sqlDataReader.Read())
        {
            Console.WriteLine("Product name: " + sqlDataReader[1] + "desc: " + sqlDataReader[2]
                + "Price" + sqlDataReader[3]);

        }

        connection.Close();
    }
    static void CreateData()
    {

        ConnectionDb connectionDb = new ConnectionDb();
        SqlConnection connection = connectionDb.GetConnection();

        string query = "INSERT INTO product VALUES('Xiaomi5','new 2022',300)";
        SqlCommand sqlCommand = new SqlCommand(query, connection);

        connection.Open();
        int row = sqlCommand.ExecuteNonQuery();


        connection.Close();
        Console.WriteLine("Insert ban ghi thanh cong!");



    }
    public static void EditData()
    {
        ConnectionDb connectionDb = new ConnectionDb();
        SqlConnection connection = connectionDb.GetConnection();

        string query = "UPDATE product SET price = 600 WHERE id = 1005";
        SqlCommand sqlCommand = new SqlCommand(query, connection);

        connection.Open();
        int row = sqlCommand.ExecuteNonQuery();


        connection.Close();
        Console.WriteLine("update ban ghi thanh cong!");
    }

    public static void DeleteData()
    {
        ConnectionDb connectionDb = new ConnectionDb();
        SqlConnection connection = connectionDb.GetConnection();
        string query = "DELETE product SET price = 600 WHERE id = 1005";
        SqlCommand sqlCommand = new SqlCommand(query, connection);

        connection.Open();
        int row = sqlCommand.ExecuteNonQuery();


        connection.Close();
        Console.WriteLine("delete ban ghi thanh cong!");
    }
}
