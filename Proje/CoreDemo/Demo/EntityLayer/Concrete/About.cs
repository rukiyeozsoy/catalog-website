﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int About_ID { get; set; }
        public string About_Details { get; set; }
        public string About_Image { get; set; }
        public string About_MapLocation { get; set; }
        public bool About_Status { get; set; }
    }
}
