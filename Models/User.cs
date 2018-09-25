namespace userlibrary.Models
{
    public class User
    {
        public string Username { get; set; }
        private string Password { get; set; }

        public bool ValidatePassword(string password)
        {
            return password == Password;
        }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}