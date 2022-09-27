using Domail.Response;
using Domain.Dto;
using Domain.Emtities;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace EmployeeWeb.Controllers
{
    public class ManagerController : ControllerBase
    {
        private IManagerService _managerService;
        public ManagerController(IManagerService managerService)
        {
            _managerService = managerService;
        }
        [HttpGet("GetManagers")]
        public async Task<Response<List<ManagerDto>>> GetManagers()
        {
            return await _managerService.GetManagers();
        }
        [HttpPost("AddManager")]
        public async Task<Response<Department_manager>> AddManager(Department_manager department)
        {
            return await _managerService.AddManager(department);
        }
    }
}
