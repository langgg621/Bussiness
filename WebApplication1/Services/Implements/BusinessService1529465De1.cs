using WebApplication1.Dtos;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DbContexts;
using WebApplication1.Dto;
using WebApplication1.Entities;
using WebApplication1.Exceptions;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Services.Implements
{
    public class BusinessService1529465De1 : IBusinessService1529465De1
    {
        private readonly ApplicationDbContext _context;

        public BusinessService1529465De1(ApplicationDbContext context)
        {
            _context = context;
        }

        public void Create(CreateBusinessDto1529465De1 input)
        {
			if (_context.Businesses.Any(b => b.Name == input.Name))
			{
				throw new Exception("Trùng tên doanh nghiệp");
			}
            if(input.Name == input.TaxId)
			{
				throw new Exception("Tên doanh nghiệp không được trùng với mã số thuế");
			}
			_context.Businesses.Add(new Business1529465De1
			{
				Name = input.Name,
				TaxId = input.TaxId,
                Address = input.Address,

			});

			_context.Businesses.Add(new Business1529465De1
            {
                Name = input.Name,
                TaxId = input.TaxId,
                Address = input.Address,
            });
            _context.SaveChanges(); 
        }

        public void Update(UpdateBusinessDto1529465De1 input)
        {
            var business = _context.Businesses.FirstOrDefault(s => s.Id == input.Id);
      
            if (business == null)
            {
                throw new UserFriendlyException($"Không tìm thấy doanh nghiệp có id = {input.Id}");
            }
			if (_context.Businesses.Any(b => b.Name == input.Name && b.Id != input.Id))
			{
				throw new Exception("Trùng Tên doanh nghiệp");
			}
			business.Name = input.Name;
            business.Address = input.Address;
            _context.SaveChanges(); 
        }
		public void DeleteById(int id)
		{

			var business = _context.Businesses.FirstOrDefault(x => x.Id == id);
			if (business == null)
			{
				throw new Exception("Không tìm thấy thông tin sản phẩm");
			}
			_context.Businesses.Remove(business);
			_context.SaveChanges();
		}
		public BusinessDto1529465De1 GetById(int id)
		{
			var Business = _context.Businesses
				.Select(b => new BusinessDto1529465De1
				{
					BusinessId = b.Id,
                    Name = b.Name,
                    Address = b.Address,
                    TaxId=b.TaxId,
				})
				.FirstOrDefault(x => x.BusinessId == id);
			return Business ?? throw new Exception("Không tìm thấy thông tin sản phẩm");

		}
		public PageResultDto1529465De1<BusinessDto1529465De1> GetAll(BusinessFilterDto1529465De1 input)
		{
			var result = new PageResultDto1529465De1<BusinessDto1529465De1>();
			var query = from business in _context.Businesses
						where (input.Keyword == null || business.Name.Contains(input.Keyword))
							&& (input.TaxId == null || business.TaxId == input.TaxId)
						select business;
			result.TotalItem = query.Count();
			query = query
				.Skip(input.Skip())
				.Take(input.PageSize);
			result.Items = query.Select(p => new BusinessDto1529465De1
			{
				BusinessId = p.Id,
				Name = p.Name,
				TaxId = p.TaxId,
				Address = p.Address
			}).ToList();
			return result;
		}
	}
}
