using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Calisco
    {
        [Key]
        public int Calisco_ID { get; set; }
        public string Calisco_Name { get; set; }
        public string Calisco_Image { get; set; }
        public bool Calisco_Status { get; set; }
    }
}
