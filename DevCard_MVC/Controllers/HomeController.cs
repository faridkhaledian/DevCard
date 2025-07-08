using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers;

public class HomeController : Controller
{
    private readonly List<Service> _services = new List<Service>
    {
        new Service(1, "مس"),
        new Service(2,"طلا"),
        new Service(3 , "آهن"),
        new Service(4 ,"نقره")
    };

    public IActionResult Index()
    {
        return View();
    }
    private void PopulateServices()
    {
        ViewBag.Services = new SelectList(_services, "Id", "Name");
    }

    [HttpGet]
    public IActionResult Contact()
    {
        PopulateServices();
        return View(new Contact());
    }

    [HttpPost]
    public IActionResult Contact(Contact model)
    {

        PopulateServices();

        if (!ModelState.IsValid)
        {
            ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
            return View(model);
        }

        ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
        ModelState.Clear();
        return View(new Contact());

    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
