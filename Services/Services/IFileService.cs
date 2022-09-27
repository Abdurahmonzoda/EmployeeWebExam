using Domail.Response;
using Domain.Dto;

namespace Services.Services;

public interface IFileService
{
    Task<Response<string>> InserFile(FileUploadDto upload);
}