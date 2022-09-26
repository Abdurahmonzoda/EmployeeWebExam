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
   public interface IManagerService
    {
        Task<Response<List<ManagerDto>>> GetManagers();
        Task<Response<Department_manager>> AddManager(Department_manager manager);  

    }
}
