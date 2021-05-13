using System;
using System.Data;
using Microsoft.Data.SqlClient;

var connectionString =
    "Server=tcp:orderspocdbserver.database.windows.net,1433;Initial Catalog=AdventureWorks;Persist Security Info=False;User ID=marcin.jagiela;Password=Qwer!234;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

var queryString = @"
SELECT * FROM SalesLT.Product p
JOIN SalesLT.ProductCategory pc
ON pc.ProductCategoryID = p.ProductCategoryID";

await using var connection = new SqlConnection(connectionString);
connection.Open();

await using var command = new SqlCommand(queryString, connection);

command.CommandType = CommandType.Text;
var reader = await command.ExecuteReaderAsync();

while (reader.Read()) 
    Console.WriteLine(reader.GetInt32(0));


