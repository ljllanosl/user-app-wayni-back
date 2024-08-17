namespace UsersApi.Models
{
    public class UserDTO
    {
        public long Id { get; set; }

        public string Name { get; set; } = null!;

        public string Username { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? Phone { get; set; }
    }
}
