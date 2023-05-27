using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Cimstone
    {
        [Key]
        public int Cimstone_ID { get; set; }
        public string Cimstone_Name { get; set; }
        public string Cimstone_Image { get; set; }
        public bool Cimstone_Status { get; set; }
    }
}
