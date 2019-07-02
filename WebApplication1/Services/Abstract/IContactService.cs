using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.DTO;
using WebApplication1.Entities;

namespace WebApplication1.Services.Abstract
{
    public interface IContactService
    {
        Task<ContactDto> GetContactDto();
    }
}
