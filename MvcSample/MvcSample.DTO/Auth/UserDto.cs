namespace MvcSample.DTO.Auth
{
    public class UserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }

        public string FullName => string.Format("{0} {1}", Name, Surname);
    }
}
