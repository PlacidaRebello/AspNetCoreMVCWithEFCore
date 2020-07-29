using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNetMvcCRUDWithEFCore.Models;

namespace AspNetMvcCRUDWithEFCore.Models
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
        }
        
        public DbSet<City> City { get; set; }
        public DbSet<Employee> Employee { get; set; }
        public DbSet<AspNetMvcCRUDWithEFCore.Models.Address> Address { get; set; }
       
    }
}
