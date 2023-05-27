using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Granit
    {
        [Key]
        public int Granit_ID { get; set; }
        public string Granit_Name { get; set; }
        public string Granit_Image { get; set; }
        public bool Granit_Status { get; set; }
    }
}
