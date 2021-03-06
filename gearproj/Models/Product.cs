﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace gearproj.Models
{
    public class Product
    {

        public int productId { get; set; }
        [Required]
        [StringLength(255,MinimumLength = 2)]   
        public string ProductName { get; set; }
        [Required]
        [StringLength(45, MinimumLength = 2)]
        public string PlaceOfOrigin { get; set; }
        [Required]
        public DateTime DateOfPublish { get; set; }
        public List<Image> Imgs { get; set; }
        public float Price { get; set; }
        public float Discount { get; set; }
        public int Quantity { get; set; }
        [ForeignKey("cpy")]
        public int CompanyId { get; set; }
        [ForeignKey("cats")]
        public int CategoryId { get; set; }
        public int Rate { get; set; }

        public Company cpy { get; set; }
        public Categories cats { get; set; }

        public virtual List<FeedBack> feeds { get; set; }


        [ForeignKey("bra")]
        public int BrandId { get; set; }
        [ForeignKey("mod")]
        public int ModelId { get; set; }

        
        public Brand bra { get; set; }
        public Model mod { get; set; }
        public virtual List<OrderDetails> Orders { get; set; }

        public virtual List<SimilaritiesProducts> needs { get; set; }



    }
}
