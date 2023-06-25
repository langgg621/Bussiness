using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Dtos;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    [Route("api/bussiness")]
    [ApiController]
    public class BusinessController1529465De1 : ControllerBase
    {
        private readonly IBusinessService1529465De1 _businessService;

        public BusinessController1529465De1(IBusinessService1529465De1 businessService)
        {
            _businessService = businessService;
        }

        [HttpPost("create")]
        public IActionResult Create(CreateBusinessDto1529465De1 input)
        {
            try
            {
                _businessService.Create(input);
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut("update")]
        public IActionResult Update(UpdateBusinessDto1529465De1 input)
        {
            try
            {
                _businessService.Update(input);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("get-all")]
		public IActionResult GetAll([FromQuery] BusinessFilterDto1529465De1 input)
		{
			try
			{
				return Ok(_businessService.GetAll(input));
			}
			catch (Exception ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}

		[HttpGet("get-by-id/{id}")]
        public IActionResult GetById( int id)
        {
			try
			{
				return Ok(_businessService.GetById(id));
			}
			catch (Exception ex)
			{
				return BadRequest(new { message = ex.Message });
			}
		}
        [HttpDelete]
		public IActionResult Delete(int id)
		{
			try
			{
				_businessService.DeleteById(id);
				return Ok();
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}
	}
}
