using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;

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

        public void Insert(Seller obj)
        {
            // Adiciona um objeto Seller ao banco de dados.
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
