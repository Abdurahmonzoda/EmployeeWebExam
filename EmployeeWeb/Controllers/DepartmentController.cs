using Domail.Response;
using Domain.Dto;
using Domain.Emtities;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace EmployeeWeb.Controllers
{
    public class DepartmentController
    {
        private IDepartmentService _departmentService;
        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
            
            
        }
        [HttpGet("GetDepartments")]
        public async Task<Response<List<DepartmentDto>>> GetDepartments()
        {
            return await _departmentService.GetDepartments();
        }

        [HttpGet("GetDepartmentById")]
        public async Task<Response<List<DepartmentDto>>> GetDepartmentById(int id)
        {
            return await _departmentService.GetDepartmentById(id);
        }

        [HttpPost("AddDepartment")]
        public async Task<Response<Department>> AddDepartment(Department department)
        {
            return await _departmentService.AddDepartment(department);
        }

        [HttpPut("UpdateDepartment")]
        public async Task<Response<Department>> UpdateDepartment(Department department)
        {
            return await _departmentService.UpdateDepartment(department);
        }
    }
}
