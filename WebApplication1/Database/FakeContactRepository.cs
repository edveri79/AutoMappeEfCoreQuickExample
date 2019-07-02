using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Database.Abstract;
using WebApplication1.Entities;


namespace WebApplication1.Database
{
    public class FakeContactRepository : IFakeContactRepository
    {
        public async Task<ContactEntity> GetSingleContactAsync()
        {

            //Here we would have Entity Framework or other Database calls. Again make Async if possible due to performance and 
            //server resources 
            ContactEntity contactEntity = await Task.Run(() =>
            {
                //Simulate long DB call 
                Task.Delay(1000);
                return new ContactEntity { Firstname = "FirstName", Lastname = "LastName", ContactNumber = 666 };
            });

            return contactEntity;
        }
    }
}
