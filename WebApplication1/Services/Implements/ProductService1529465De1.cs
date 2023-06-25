using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;
using WebApplication1.DbContexts;
using WebApplication1.Dto.Values;
using WebApplication1.Entities;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implements
{
    public class ProductService1529465De1 : IProductService1529465De1
    {
        private readonly ApplicationDbContext _context;

        public ProductService1529465De1(ApplicationDbContext context)
        {
            _context = context;
        }
		public void CreateProduct(CreateProductDto1529465De1 input)
		{
			if (_context.Products.Any(b => b.Name == input.Name))
			{
				throw new Exception("Trùng tên Sản phẩm");
			}

			_context.Products.Add(new Product1529465De1
			{
				Name = input.Name,
				ImportDate = input.ImportDate,
			});
			_context.SaveChanges();
		}
	}
}
