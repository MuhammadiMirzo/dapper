using Dapper;
using Domain.Entities;
using Npgsql;

namespace Services.Services;

public class ContactService
{
    private string _connectionString;
    public ContactService()
    {
        _connectionString = "Server=127.0.0.1;Port=5432;Database=softdb;User Id=postgres;Password=1234;";
    }
    public int AddContact(Students contact)
    {
        // Add contact to database
        using (NpgsqlConnection connection  = new NpgsqlConnection(_connectionString))
        {
            connection.Open();
            string sql = $"INSERT INTO students (name, phone, message) VALUES ('{contact.Name}', '{contact.Phone}', '{contact.Massage}')";
            var response  = connection.Execute(sql);
            return response;
        }
        
    }

}
