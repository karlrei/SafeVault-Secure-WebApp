using MySql.Data.MySqlClient;

public class UserRepository
{
    private string connectionString = "your_connection_string";

    public void InsertUserWithPassword(string username, string email, string passwordHash, string role)
    {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();

        string query = "INSERT INTO Users (Username, Email, PasswordHash, Role) VALUES (@u,@e,@p,@r)";

        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@u", username);
        cmd.Parameters.AddWithValue("@e", email);
        cmd.Parameters.AddWithValue("@p", passwordHash);
        cmd.Parameters.AddWithValue("@r", role);

        cmd.ExecuteNonQuery();
    }

    public User GetUserByUsernameObject(string username)
    {
        using var conn = new MySqlConnection(connectionString);
        conn.Open();

        string query = "SELECT * FROM Users WHERE Username = @u";

        using var cmd = new MySqlCommand(query, conn);
        cmd.Parameters.AddWithValue("@u", username);

        using var reader = cmd.ExecuteReader();
        if (reader.Read())
        {
            return new User
            {
                Username = reader["Username"].ToString(),
                Email = reader["Email"].ToString(),
                PasswordHash = reader["PasswordHash"].ToString(),
                Role = reader["Role"].ToString()
            };
        }
        return null;
    }
}