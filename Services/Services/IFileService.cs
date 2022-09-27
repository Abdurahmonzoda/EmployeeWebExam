using Domail.Response;
using Domain.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public interface IFileService
    {
        Task<Response<string>> AddFile(DtoFile file);
    }
}
