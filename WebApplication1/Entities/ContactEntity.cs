using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Entities
{
    //Example entity that might be from DB
    public class ContactEntity
    {
        public string Firstname { get; set; }

        public string Lastname { get; set; }

        public int ContactNumber { get; set; }
    }
}
