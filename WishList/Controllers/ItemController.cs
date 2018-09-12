using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using WishList.Data;

namespace WishList.Controllers
{
  public class ItemController : Controller
  {
    private readonly ApplicationDbContext _context;

    public ItemController(ApplicationDbContext context)
    {
      this._context = context;
    }

    public IActionResult Index()
    {
      var model = this._context.Items.ToList();

      return this.View("Index", model);
    }

    [HttpGet]
    public IActionResult Create()
    {
      return this.View("Create");
    }

    [HttpPost]
    public IActionResult Create(Models.Item item)
    {
      _context.Items.Add(item);
      _context.SaveChanges();
      return this.RedirectToAction("Index");
    }

    public IActionResult Delete(int id)
    {
      Models.Item item = this._context.Items.First(e => e.Id == id);
      this._context.Items.Remove(item);
      this._context.SaveChanges();
      return this.RedirectToAction("Index");
    }
  }
}