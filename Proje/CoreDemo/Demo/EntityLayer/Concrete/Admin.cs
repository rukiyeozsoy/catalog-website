using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }
        public int Username { get; set; }
        public int Password { get; set; }
        public int Image { get; set; }
        public int Role { get; set; }
    }
}
