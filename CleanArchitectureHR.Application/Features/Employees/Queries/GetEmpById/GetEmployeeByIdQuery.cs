using AutoMapper;
using CleanArchitecture.HR.Domain.Entities;
using CleanArchitectureHR.Application.Features.Employees.Queries.GetAllEmp;
using CleanArchitectureHR.Application.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHR.Application.Features.Employees.Queries.GetEmpById
{
    public record GetEmployeeByIdQuery : IRequest<GetEmployeeByIdDto>
    {
        public int Id { get; set; }

        public GetEmployeeByIdQuery()
        {

        }

        public GetEmployeeByIdQuery(int id)
        {
            Id = id;
        }
    }

    //GetEmployeeByIdQuery
    internal class GetEmployeeByIdQueryHandler : IRequestHandler<GetEmployeeByIdQuery,GetEmployeeByIdDto>
    {
        #region Object Reference
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetEmployeeByIdQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion


        #region Ovveride Methods
        public async Task<GetEmployeeByIdDto> Handle(GetEmployeeByIdQuery request, CancellationToken cancellationToken)
        {
            var entity = await _unitOfWork.Repository<Employee>().GetByIdAsync(request.Id);
            return _mapper.Map<GetEmployeeByIdDto>(entity);
        }
        #endregion

    }
}
