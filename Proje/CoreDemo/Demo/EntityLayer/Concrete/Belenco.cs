using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Belenco
    {
        [Key]
        public int Belenco_ID { get; set; }
        public string Belenco_Name { get; set; }
        public string Belenco_Image { get; set; }
        public bool Belenco_Status { get; set; }
    }
}
