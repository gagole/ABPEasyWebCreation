using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using ABPEasyWebCreation.Controllers;

namespace ABPEasyWebCreation.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : ABPEasyWebCreationControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
