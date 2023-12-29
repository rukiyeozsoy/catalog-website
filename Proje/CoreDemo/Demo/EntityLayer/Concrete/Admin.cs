using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
    }
}
