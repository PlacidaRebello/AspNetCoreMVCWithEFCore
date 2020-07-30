using System.Threading.Tasks;
using AspNetMvcCRUDWithEFCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query;

namespace AspNetMvcCRUDWithEFCore.DataAccess
{
    public interface IEmployeeDataAccess
    {
        Task<Employee> GetEmployeeDetails(int id);
        IIncludableQueryable<Employee, City> GetCities();
    }

    public class EmployeeDataAccess : IEmployeeDataAccess
    {
        private readonly DataContext _context;
        
        public EmployeeDataAccess(DataContext context)
        {
            _context = context;
        }

        public async Task<Employee> GetEmployeeDetails(int id)
        {
            return await _context.Employee
                .Include(e => e.City)
                .FirstOrDefaultAsync(m => m.EmployeeID == id);
        }
        
        public IIncludableQueryable<Employee, City> GetCities()
        {
            return _context.Employee.Include(e => e.City);
        }
    }
}