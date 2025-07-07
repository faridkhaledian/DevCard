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

    [HttpGet]
    public IActionResult Contact()
    {
        var model = new Contact
        {
            Services = new SelectList(_services, "Id", "Name")

        };


       return View(model);
    }

    [HttpPost]
    public IActionResult Contact(Contact model)
    {
        model.Services = new SelectList(_services, "Id", "Name");
        //if(ModelState.IsValid == false)
        if (!ModelState.IsValid)
        {
            ViewBag.error = "اطلاعات وارد شده صحیح نیست. لطفا دوباره تلاش کنید";
            return View(model);
        }

        ModelState.Clear();

        model = new Contact
        {
            Services = new SelectList(_services, "Id", "Name")
        };
        ViewBag.success = "پیغام شما با موفقیت ارسال شد. باتشکر";
        return View(model);
        //return RedirectToAction("Index");
    }





    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
