using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EndPointData;

namespace EndPointSolution.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      EndPointViewModel vm = new EndPointViewModel();

      vm.HandleRequest();

      return View(vm);
    }

    [HttpPost]
    public ActionResult Index(EndPointViewModel vm)
    {
      vm.IsValid = ModelState.IsValid;
      vm.HandleRequest();

      if (vm.IsValid)
      {
        // NOTE: Must clear the model state in order to bind
        //       the @Html helpers to the new model values
        ModelState.Clear();
      }
      else
      {
        foreach (KeyValuePair<string, string> item in vm.ValidationErrors)
        {
          ModelState.AddModelError(item.Key, item.Value);
        }
      }

      return View(vm);
    }

  }
}