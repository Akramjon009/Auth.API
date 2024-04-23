namespace Auth.DTOs
{
    public class RegisterDTO
    {
        public required string FullName { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public string Status { get; set; }
        public int Age { get; set; }
        public List<string> Roles { get; set; }
    }
}
