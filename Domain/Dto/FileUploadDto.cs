using Microsoft.AspNetCore.Http;

namespace Domain.Dto;

public class FileUploadDto
{
    public IFormFile File { get; set; }
}