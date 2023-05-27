using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Coante
    {
        [Key]
        public int Coante_ID { get; set; }
        public string Coante_Name { get; set; }
        public string Coante_Image { get; set; }
        public bool Coante_Status { get; set; }
    }
}
