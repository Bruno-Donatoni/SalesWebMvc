﻿using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SalesWebMvc.Data;
using SalesWebMvc.Models;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        private readonly SalesWebMvcContext _context;

        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() 
        {
            return _context.Seller.ToList();
        }
        public void Insert(Seller obj) 
        {
            _context.Add(obj);
            _context.SaveChanges();
        }

        public Seller FindByID(int id) 
        {
            return _context.Seller.Include(obj => obj.Department).FirstOrDefault(seller => seller.Id == id);
        }

        public void RemoveSeller(int id) 
        {
            var obj = _context.Seller.Find(id);
            _context.Seller.Remove(obj);
            _context.SaveChanges();
        }
    }
}
