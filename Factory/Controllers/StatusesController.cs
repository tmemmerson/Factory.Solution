using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Factory.Models;

namespace Factory.Controllers
{
  public class StatusesController : Controller
  {
    private readonly FactoryContext _db;

    public StatusesController(FactoryContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      List<Status> model = _db.Statuses.Include(status => status.Machine).ToList();
      return View(model);
    }
  }
}