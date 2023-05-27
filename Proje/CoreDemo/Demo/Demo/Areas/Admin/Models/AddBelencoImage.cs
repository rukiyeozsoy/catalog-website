using Microsoft.AspNetCore.Http;

namespace Demo.Areas.Admin.Models
{
    public class AddBelencoImage
    { 
        public int Belenco_ID { get; set; }
        public string Belenco_Name { get; set; }
        public IFormFile Belenco_Image { get; set; }
        public bool Belenco_Status { get; set; }
    }
}
