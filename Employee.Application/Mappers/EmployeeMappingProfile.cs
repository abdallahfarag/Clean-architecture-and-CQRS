using AutoMapper;
using Employee.Application.Commands;
using Employee.Application.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using Entities = Employee.Core.Entities;

namespace Employee.Application.Mappers
{
    public class EmployeeMappingProfile : Profile
    {
        public EmployeeMappingProfile()
        {
            CreateMap<Entities.Employee, EmployeeResponse>().ReverseMap();
            CreateMap<Entities.Employee, CreateEmployeeCommand>().ReverseMap();
        }
    }
}
