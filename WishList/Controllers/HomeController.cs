using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
  public class HomeController : Controller
  {
    public IActionResult Index()
    {
      return this.View("Index");
    }

    public IActionResult Error()
    {
      return this.View("Error");
    }
  }
}
