using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrowdOrder.beta.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CrowdOrder.beta.Controllers
{
    [Authorize]
    public class SignUpController : Controller
    {
        private readonly SignUpRepository _signupsRepository;

        public SignUpController(SignUpRepository signupsRepository)
        {
            _signupsRepository = signupsRepository;
        }
        public IActionResult Index()
        {
            var data = _signupsRepository.ListAll();
            return View(data);
        }
    }
}
