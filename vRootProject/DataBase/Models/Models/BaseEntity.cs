﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreLayer.Models
{
    public class BaseEntity
    {
        public bool ?IsActive { get; set; } 
        public bool? IsDeleted { get; set; } 
        public DateTime? CreateDate { get; set; } 
        public DateTime? UpdateDate { get; set; }
    }
}
