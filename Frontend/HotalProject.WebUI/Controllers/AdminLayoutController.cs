﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotalProject.WebUI.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult _AdminLayout()
           
        {
            return View();
        }

        public PartialViewResult HeadPartial()
        {
            return PartialView();


        }
        public PartialViewResult PreLoaderPartial()
        {
            return PartialView();


        }
        public PartialViewResult NavHeaderPartial()
        {
            return PartialView();


        }
        public PartialViewResult HeaderPartial()
        {
            return PartialView();


        }
        public PartialViewResult SideBarPartial()
        {
            return PartialView();


        }
        public PartialViewResult FooterPartial()
        {
            return PartialView();


        }
        public PartialViewResult ScriptPartial()
        {
            return PartialView();


        }
    }
}
