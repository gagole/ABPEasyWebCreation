using Abp.Application.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPEasyWebCreation.Models
{
    public interface IEmployeeService: IApplicationService
    {
        Task<Employee.Employee> GetEmployee(int id);
        IQueryable<Employee.Employee> GetAll();
        Task<Employee.Employee> InsertEmployee(Employee.Employee employee);
        Task<Employee.Employee> UpdateEmployee(Employee.Employee employee);
        void DeleteEmployee(int id);


    }
}
