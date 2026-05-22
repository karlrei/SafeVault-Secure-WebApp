using BCrypt.Net;

public class AuthService
{
    private readonly UserRepository repo;

    public AuthService(UserRepository repo)
    {
        this.repo = repo;
    }

    public void Register(string username, string email, string password, string role = "user")
    {
        string hash = BCrypt.Net.BCrypt.HashPassword(password);
        repo.InsertUserWithPassword(username, email, hash, role);
    }

    public bool Authenticate(string username, string password)
    {
        var user = repo.GetUserByUsernameObject(username);
        if (user == null) return false;
        return BCrypt.Net.BCrypt.Verify(password, user.PasswordHash);
    }
}