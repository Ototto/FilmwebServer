namespace Filmweb.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public bool Admin { get; set; }
        public string Email { get; set; }
        public string Name { get; set; }
        public string Token { get; set; } // dk
        public string Surname { get; set; }
        public string Password { get; set; }
    }
}
