using System;

namespace ProductApi.Models{
    public class Product{
        public int ProductId{get; set;}
        public string Name{get; set;}
        public decimal Price{get; set;}
        public DateTime DateCreated{get; set;}
    }
}