using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPEasyWebCreation.Controllers;
using ABPEasyWebCreation.Models;
using System.Threading.Tasks;
using ABPEasyWebCreation.Web.Models.Employees;
using ABPEasyWebCreation.Authorization;
using DevExtreme.AspNet.Data.ResponseModel;
using DevExtreme.AspNet.Mvc;
using DevExtreme.AspNet.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System;
using System.Reflection;

namespace ABPEasyWebCreation.Web.Controllers
{
    
    public class EmployeesController : ABPEasyWebCreationControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        [AbpMvcAuthorize(PermissionNames.Pages_Employee_List)]
        public ActionResult Index()
        {
            //var output = await _employeeService.GetAll();
            //var model = new EmployeeListViewModel { Employees= output };
            return View(/*model*/);
        }
	}
}
