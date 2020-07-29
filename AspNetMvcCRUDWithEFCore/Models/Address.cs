using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetMvcCRUDWithEFCore.Models
{
    public class Address
    {
        public int AddressID { get; set; }
        public string State { get; set; }
        public string CityName { get; set; }
        public virtual City City { get; set; }
    }
}
