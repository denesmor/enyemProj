using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enyemProj.Model
{
    public class Auto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public double Weight { get; set; }
        public bool IsAvailable { get; set; }
        public DateTime CreatedAt { get; set; }
    

    public Auto(int id, string name, string description, double price, int stockQuantity, string category, string brand, double weight, bool isAvailable, DateTime createdAt)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
            Category = category;
            Brand = brand;
            Weight = weight;
            IsAvailable = isAvailable;
            CreatedAt = createdAt;
        }
    } 
}


