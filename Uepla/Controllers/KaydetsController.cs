using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Uepla.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class KaydetsController : Controller
    {
        private readonly FormContext _formContext;

        public KaydetsController(FormContext formContext)
        {
            _formContext = formContext;
        }
        [Route("Save")]
        [HttpPost]
        public IActionResult Save(Form form)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            _formContext.MyForm.Add(form);
                _formContext.SaveChanges();
            return Json(form);
        }
    }
}