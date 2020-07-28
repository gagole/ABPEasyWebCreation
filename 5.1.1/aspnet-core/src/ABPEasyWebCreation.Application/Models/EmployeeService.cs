using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.Linq.Extensions;
using ABPEasyWebCreation.Authorization;
using Microsoft.EntityFrameworkCore;

namespace ABPEasyWebCreation.Models
{

    public class EmployeeService : IEmployeeService
    {
        private readonly IRepository<Employee.Employee,int> _empRepo;
        public EmployeeService(IRepository<Employee.Employee,int> empRepo)
        {
            _empRepo = empRepo;
        }

        public async Task<Employee.Employee> GetEmployee(int id)
        {
            return await _empRepo.GetAsync(id);
        }
        public IQueryable<Employee.Employee> GetAll()
        {
            return _empRepo.GetAll();
        }
       
        public async Task<Employee.Employee> InsertEmployee(Employee.Employee employee)
        {
            return await _empRepo.InsertAsync(employee);
        }

        public async Task<Employee.Employee> UpdateEmployee(Employee.Employee employee)
        {
            return await _empRepo.UpdateAsync(employee);
        }

        public async void DeleteEmployee(int id)
        {
            await _empRepo.DeleteAsync(id);
        }


    }
}
