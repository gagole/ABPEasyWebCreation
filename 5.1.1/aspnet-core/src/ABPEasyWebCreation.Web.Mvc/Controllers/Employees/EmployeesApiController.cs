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
using ABPEasyWebCreation.Models.Employee;
using Abp.UI;

namespace ABPEasyWebCreation.Web.Controllers
{
    [Route("api/[controller]/[action]")]
    public class EmployeesApiController : ABPEasyWebCreationApiControllerBase
    {
        private readonly IEmployeeService _employeeService;

        public EmployeesApiController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        [HttpGet]
        [AbpMvcAuthorize(PermissionNames.Pages_Employee_List)]
        public virtual async Task<object> GetAll(DataSourceLoadOptions loadOptions)
        {
            var x = await DataSourceLoader.LoadAsync( _employeeService.GetAll(),loadOptions);
            return x;
        }

        [HttpPost]
        [AbpMvcAuthorize(PermissionNames.Pages_Employee_Create)]
        public virtual IActionResult Post(string values)
        {
            if (values == null)
                values = Request.GetRawBodyStringAsync().GetAwaiter().GetResult();

            var entity = new Employee();
            JsonConvert.PopulateObject(values, entity);
            _employeeService.UpdateEmployee(entity);

            return Ok(entity);
        }

        [HttpPut, Route("{key?}")]
        [AbpMvcAuthorize(PermissionNames.Pages_Employee_Update)]
        public virtual IActionResult Put(int key, string values)
        {
            if (values == null)
                values = Request.GetRawBodyStringAsync().GetAwaiter().GetResult();

            var entity = _employeeService.GetEmployee(key).GetAwaiter().GetResult();

            JsonConvert.PopulateObject(values, entity);

            _employeeService.UpdateEmployee(entity);
            return Ok(entity);
        }

        [HttpDelete, Route("{key?}")]
        [AbpMvcAuthorize(PermissionNames.Pages_Employee_Delete)]
        public virtual IActionResult Delete(int key)
        {
            _employeeService.DeleteEmployee(key);

            return Ok();
        }
    }
}
