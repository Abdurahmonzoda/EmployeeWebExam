using System.Net;
using Domail.Response;
using Domain.Dto;
using Microsoft.AspNetCore.Hosting;


namespace Services.Services;

public class FileService : IFileService
{
    private readonly IWebHostEnvironment _environment;

    public FileService(IWebHostEnvironment environment)
    {
        _environment = environment;
    }

    public async Task<Response<string>> InserFile(FileUploadDto upload)
    {
        try
        {
            if (upload.File != null)
            {
                var rootpath = _environment.WebRootPath;
                var path = Path.Combine(rootpath, "images", upload.File.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await upload.File.CopyToAsync(stream);
                }

                return new Response<string>(HttpStatusCode.OK,path);
            }
            return new Response<string>(HttpStatusCode.OK,"test");
        }
        catch (Exception e)
        {
            return new Response<string>(HttpStatusCode.InternalServerError, e.Message);
        }
    }
}

