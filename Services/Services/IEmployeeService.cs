using Domail.Response;
using Domain.Dto;
using Domain.Emtities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IEmployeeService
    {
        Task<Response<List<EmployeeDto>>> GetEmployees();
        Task<Response<List<EmployeeDto>>> GetEmployeeById(int id);
        Task<Response<Employee>> AddEmployee(Employee employee);
        Task<Response<Employee>> UpdateEmployee(Employee employee); 

    }
}
