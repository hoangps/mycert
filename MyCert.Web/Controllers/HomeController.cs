using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyCert.Services;
using MyCert.Services.DTO;

namespace MyCert.Web.Controllers
{
    [RequireHttps]
    public class HomeController : Controller
    {
        private readonly IService<QuestionDTO> _questionService;

        public HomeController(QuestionService questionService)
        {
            _questionService = questionService;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}