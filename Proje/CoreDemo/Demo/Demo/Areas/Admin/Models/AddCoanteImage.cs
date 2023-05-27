using Microsoft.AspNetCore.Http;

namespace Demo.Areas.Admin.Models
{
    public class AddCoanteImage
    {
        public int Coante_ID { get; set; }
        public string Coante_Name { get; set; }
        public IFormFile Coante_Image { get; set; }
        public bool Coante_Status { get; set; }
    }
}
