using SalesWebMVC.Data;
using SalesWebMVC.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Services.Exceptions;

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

        public Seller FindById(int id)
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(obj => obj.Id == id);
        }

        public void Remove(int id)
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }

        public void Update(Seller obj)
        {
            if (!_context.Seller.Any(x => x.Id == obj.Id))
            {
                throw new NotFoundException("Id not found");
            }
            try
            {
                _context.Update(obj);
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException e)
            {
                throw new DbConcurrencyException(e.Message);
            }
            
        }
    }
}
