using CleanArchitectureHR.Application.Features.Employees.Queries.GetAllEmp;
using CleanArchitectureHR.Application.Features.Employees.Queries.GetEmpById;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClearnArchitectureHR.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        //1-
        private readonly IMediator _mediator;

        //2- Constructor
        public EmployeesController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentException(nameof(mediator));
        }

        #region Methods Verbs

        [HttpGet]
        public async Task<ActionResult<List<GetAllEmployeesDto>>> GetAll()
        {
            return await _mediator.Send(new GetAllEmployeesQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<GetEmployeeByIdDto>> GetById(int id)
        {
            return await _mediator.Send(new GetEmployeeByIdQuery(id));
        }

        #endregion
    }
}
