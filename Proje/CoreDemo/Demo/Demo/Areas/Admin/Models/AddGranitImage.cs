using Microsoft.AspNetCore.Http;

namespace Demo.Areas.Admin.Models
{
    public class AddGranitImage
    {
        public int Granit_ID { get; set; }
        public string Granit_Name { get; set; }
        public IFormFile Granit_Image { get; set; }
        public bool Granit_Status { get; set; }
    }
}
