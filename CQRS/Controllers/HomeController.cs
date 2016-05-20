using CQRS.Contracts.AddProduct;
using CQRS.Messaging.Busses.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CQRS.Controllers
{
    public class HomeController : Controller
    {
        //ICommandBus CommandBus { get; }

        //public HomeController(ICommandBus commandBus)
        //{
        //    CommandBus = commandBus;
        //}

        public ActionResult Index()
        {
            //Debug.WriteLine("Hello World");

            //CommandBus.Send(new AddProductCommand { Name = "Hello World", InititalQuantity = 600m, Price = 12.32m });

            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
