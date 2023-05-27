using Microsoft.AspNetCore.Http;

namespace Demo.Areas.Admin.Models
{
    public class AddCimstoneImage
    {
        public int Cimstone_ID { get; set; }
        public string Cimstone_Name { get; set; }
        public IFormFile Cimstone_Image { get; set; }
        public bool Cimstone_Status { get; set; }
    }
}
