using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.Extensions.Logging;
using WebApplication1.Database.Abstract;
using WebApplication1.Services.Abstract;
using WebApplication1.DTO;
using WebApplication1.Entities;
namespace WebApplication1.Services
{
    
    public class ContactService : IContactService
    {
        private readonly IFakeContactRepository _contactRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ContactService> _logger; 
        public ContactService(IFakeContactRepository contactRepository, IMapper mapper,  ILogger<ContactService> logger)
        {
            _contactRepository = contactRepository ?? throw new ArgumentNullException(nameof(contactRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        //make async if possible due to performance, and usage of thread pool IIS. 
        public async Task<ContactDto> GetContactDto()
        {
            //simulate getting an entity from Entity FrameWork 
            var contactEntity = await _contactRepository.GetSingleContactAsync();

            return _mapper.Map<ContactEntity, ContactDto>(contactEntity);

            //Map from entity to 
        }
    }
}
