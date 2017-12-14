using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace odetofood.Controllers
{
    public class AboutController : Controller
    {
        public String Index()
        {
            return "What's up from the About controller";
        }
    }
}