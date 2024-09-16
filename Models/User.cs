namespace Users_Login_Api.Models
{
    using BCrypt.Net;

    public class User
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PasswordHashed { get; set; }

        public void HashPassword(string password)
        {
            PasswordHashed = BCrypt.HashPassword(password);
        }

        public bool VerifyPassword(string password)
        {
            return BCrypt.Verify(password, PasswordHashed);
        }
    }
}
