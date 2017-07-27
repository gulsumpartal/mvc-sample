using System.ComponentModel.DataAnnotations.Schema;
using MvcSample.Domain.Abstracts;

namespace MvcSample.Domain.Users
{
    [Table("User",Schema = "auth")]
    public class User : EntityBase
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
