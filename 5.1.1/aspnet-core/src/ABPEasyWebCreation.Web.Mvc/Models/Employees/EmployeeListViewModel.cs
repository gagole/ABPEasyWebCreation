using System.Collections.Generic;
using ABPEasyWebCreation.Models.Employee;
using ABPEasyWebCreation.Roles.Dto;

namespace ABPEasyWebCreation.Web.Models.Employees
{
    public class EmployeeListViewModel
    {
        public IReadOnlyList<Employee> Employees { get; set; }

    }
}
