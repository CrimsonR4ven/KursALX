using System.Data;
using System.Data.SqlClient;


namespace ADODemo
{
    public class ADODemos
    { 
        public void Run(string connectionString,string val, string val2)
        {
            var queryString = "select @a from Movie m";
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                var command = new SqlCommand(queryString, conn);
                SqlParameter param = new SqlParameter();
                param.ParameterName = "@a";
                param.Value = val;
                param.SqlDbType = SqlDbType.Xml;
                command.Parameters.Add(param);
                try
                {
                    conn.Open();
                    var reader = command.ExecuteReader();
                    while (reader.Read()) { 
                    Console.WriteLine(reader.GetString(0));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.StackTrace);
                }
            }
        }

    }
}
