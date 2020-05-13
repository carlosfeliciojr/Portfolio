using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SalesWebMVC.Models
{
    public class Seller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [DataType (DataType.EmailAddress)]
        public string Email { get; set; }

        [Display (Name = "Birth Date")]
        [DataType (DataType.Date)]
        [DisplayFormat (DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime BirthDate { get; set; }

        [Display (Name = "Base Salary")]
        [DisplayFormat (DataFormatString = "{0:F2}")]
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
