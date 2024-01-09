using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArchitecture.HR.Domain.Entities;
using CleanArchitectureHR.Application.Interfaces;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureHR.Application.Features.Employees.Queries.GetAllEmp
{
    public record GetAllEmployeesQuery : IRequest<List<GetAllEmployeesDto>>;

    internal class GetAllEmployeesQueryHandler : IRequestHandler<GetAllEmployeesQuery, List<GetAllEmployeesDto>>
    {
        #region Object Reference
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        #endregion

        #region Constructor
        public GetAllEmployeesQueryHandler(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        #endregion


        #region Ovveride Methods
        public async Task<List<GetAllEmployeesDto>> Handle(GetAllEmployeesQuery request, CancellationToken cancellationToken)
        {
            return await _unitOfWork.Repository<Employee>().Entities
                .ProjectTo<GetAllEmployeesDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
        #endregion

    }

}