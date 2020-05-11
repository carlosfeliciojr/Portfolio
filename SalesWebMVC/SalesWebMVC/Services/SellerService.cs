using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMVC.Services
{
    public class SellerService 
    {
        // Criada dependência do context.
        private readonly SalesWebMVCContext _context;

        public SellerService(SalesWebMVCContext context)
        {
            _context = context;
        }

        // Retorna uma lista com todos os vendedores no banco de dados.
        public List<Seller> FindAll()
        {
            // Acessa a fonte de dados e converte para uma lista.
            return _context.Seller.ToList();
        }
    }
}
