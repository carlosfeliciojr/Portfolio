using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // Implementando e associando Department com Seller.
        ICollection<Seller> Sellers { get; set; } = new List<Seller>(); 

        public Department()
        {
        }

        public Department(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddSeller(Seller seller)
        {
            Sellers.Add(seller);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // Soma o TotalSales de todos os Sellers e retorna o Total no período determinado.
            return Sellers.Sum(seller => seller.TotalSales(initial, final));
        }
    }
}
