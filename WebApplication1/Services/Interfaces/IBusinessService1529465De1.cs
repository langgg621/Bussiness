

using WebApplication1.Dto;
using WebApplication1.Dtos;

namespace WebApplication1.Services.Interfaces
{
    public interface IBusinessService1529465De1
    {
        void Create(CreateBusinessDto1529465De1 input);
        void Update(UpdateBusinessDto1529465De1 input);
        BusinessDto1529465De1 GetById(int id);
        void DeleteById(int id);
        PageResultDto1529465De1<BusinessDto1529465De1> GetAll(BusinessFilterDto1529465De1 input);


	}
}
