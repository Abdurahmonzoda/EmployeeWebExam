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
  public  interface  IDepartmentService
    {
        Task<Response<List<DepartmentDto>>> GetDepartments();
        Task<Response<List<DepartmentDto>>> GetDepartmentById(int id);
        Task<Response<Department>> AddDepartment(Department department);
        Task<Response<Department>> UpdateDepartment(Department department); 

    }
}
