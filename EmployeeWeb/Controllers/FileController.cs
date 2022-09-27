using Domail.Response;
using Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace EmployeeWeb.Controllers
  
{
    public class FileController : ControllerBase
    {
        private IFileService _fileService;
        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost("AddImage")]
        public async Task<Response<string>> AddFile([FromForm]DtoFile file)
        {
            return await _fileService.AddFile(file); 


        }
    }
}
