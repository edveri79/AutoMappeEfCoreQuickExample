using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Database.Abstract
{
    public interface IFakeContactRepository
    {
        Task<ContactEntity> GetSingleContactAsync();
    }
}
