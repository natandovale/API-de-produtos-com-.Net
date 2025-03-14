﻿using System;
using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Model
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        //[Computed]
       // public Cart Cart { get; set; }

        public Product(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Product(int id, string title, decimal price)
        {
            Id = id;
            Title = title;
            Price = price;
        }

        public Product()
        {
        }
   
    }
}
