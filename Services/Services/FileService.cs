using Domail.Response;
using Domain.Dto;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class FileService : IFileService
    {
        private readonly IWebHostEnvironment _environment;
        public FileService(IWebHostEnvironment environment)
        {
            _environment = environment;
        }

        public async Task<Response< string>> AddFile(DtoFile file)
        {
            try
            {
                if(file.File != null)
                {
                    var rootpath = _environment.WebRootPath; 
                    var path = Path.Combine(rootpath , "images" , file.File.FileName);
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        await file.File.CopyToAsync(stream);
                    }
                    return new Response<string>(System.Net.HttpStatusCode.OK, path); 

                }
                return new Response<string>(HttpStatusCode.OK, "test");
            }
            catch(Exception ex)
            {
                return new Response<string>(System.Net.HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
