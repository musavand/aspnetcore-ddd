using MediatR;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Contact.Management.Appliaction.Features.Customer.Requests.Queries;
using Contact.Management.Appliaction.DTOs.Customer;
using Contact.Management.Appliaction.Features.Customer.Requests.Commands;
using Contact.Management.Appliaction.Responses;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Contact.Management.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CustomerController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public  async Task<ActionResult<List<CustomerDto>>> Get()
        {
            var customers = await _mediator.Send(new GetCustomerListRequest());
            return Ok(customers);
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerDto>> Get(int id)
        {
            var customer = await _mediator.Send(new GetCustomerDetailRequest { Id = id });
            return Ok(customer);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public async Task<ActionResult<BaseCommonResponse>>  Post([FromBody] CreateCustomerDto customer)
        { 
            var command = new CreateCustomerCommand { customerDto = customer };
            var response = await _mediator.Send(command);
            return Ok(response);
        }

        // PUT api/<CustomerController>/5
        //[HttpPut("{id}")]
        [HttpPut]
        //public async Task<ActionResult>  Put(int id, [FromBody] CreateCustomerDto customer)
        public async Task<ActionResult> Put([FromBody] CreateCustomerDto customer)
        {
            var command = new UpdateCustomerCommand { customerDto = customer };
            var response = await _mediator.Send(command);
            return NoContent();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var command = new DeleteCustomerCommand { Id = id };
            var response = await _mediator.Send(command);
            return NoContent();
        }
    }
}
