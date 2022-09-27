using Domail.Response;
using Domain.Dto;
using Microsoft.AspNetCore.Mvc;
using Services.Services;

namespace EmployeeWeb.Controllers;

[ApiController]
[Route("[controller]")]
public class FileController:ControllerBase
{
    private readonly IFileService _fileService;

    public FileController(IFileService fileService)
    {
        _fileService = fileService;
    }
    
    [HttpPost]
    public Task<Response<string>> Insert([FromForm] FileUploadDto fileUploadDto)
    {
        return _fileService.InserFile(fileUploadDto);
    }
    
}