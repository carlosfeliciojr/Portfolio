using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime BirthDate { get; set; }
        public double BaseSalary { get; set; }

        // Implementando e associando Seller a Department.
        public Department Department { get; set; } 

        // Avisando para Entity Framework garantir que o ID irá existir, para que no banco de dados não seja null.
        public int DepartmentId { get; set; } 
        
        // Implementando e associando Seller a SalesRecord.
        public ICollection<SalesRecord> Sales { get; set; } = new List<SalesRecord>(); 

        public Seller()
        {
        }

        public Seller(int id, string name, string email, DateTime birthDate, double baseSalary, Department department)
        {
            Id = id;
            Name = name;
            Email = email;
            BirthDate = birthDate;
            BaseSalary = baseSalary;
            Department = department;
        }

        public void AddSales(SalesRecord sr)
        {
            Sales.Add(sr);
        }

        public void RemoveSales(SalesRecord sr)
        {
            Sales.Remove(sr);
        }

        public double TotalSales(DateTime initial, DateTime final)
        {
            // Procura todo sr entre as datas initial e final e soma a quantia do período.
            return Sales.Where(sr => sr.Date >= initial && sr.Date <= final).Sum(sr => sr.Amount); 
        }
    }
}
