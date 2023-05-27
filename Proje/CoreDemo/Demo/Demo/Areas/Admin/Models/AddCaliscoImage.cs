using Microsoft.AspNetCore.Http;

namespace Demo.Areas.Admin.Models
{
    public class AddCaliscoImage
    {
        public int Calisco_ID { get; set; }
        public string Calisco_Name { get; set; }
        public IFormFile Calisco_Image { get; set; }
        public bool Calisco_Status { get; set; }
    }
}
