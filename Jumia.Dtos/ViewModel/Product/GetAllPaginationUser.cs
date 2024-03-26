﻿using Jumia.Dtos.ViewModel.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jumia.Dtos.ViewModel.Product
{
    public class GetAllPaginationUser
    {
        public int id { get; set; }
        public string BrandName { get; set; } = "Amazon";
        public ICollection<string> itemscolor { get; set; }
        public virtual ICollection<string> ProductImages { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }

    }
}