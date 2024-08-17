namespace UsersApi.Models
{
    public class VerifyPasswordRequest
    {
        public long UserId { get; set; }
        public string CurrentPassword { get; set; } = null!;
    }

}
