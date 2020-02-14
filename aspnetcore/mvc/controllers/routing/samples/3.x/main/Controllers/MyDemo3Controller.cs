﻿//#define MYDEMO4
//#define MYDEMO3

using Microsoft.AspNetCore.Mvc;

// This uses same routes as HomeController, so only one can be defined without setting order
// Test with                     webBuilder.UseStartup<StartupDefaultMVC>();
// or with StartupMap
namespace WebMvcRouting.Controllers
{
#if MYDEMO3
    #region snippet2
    public class MyDemo3Controller : Controller
    {
        [Route("")]
        [Route("Home")]
        [Route("Home/MyIndex")]
        public IActionResult MyIndex() =>
            ControllerContext.ToActionResult();
    }
    #endregion
#endif

#if MYDEMO4
    public class MyDemo3Controller : Controller
    {
    #region snippet3
        [Route("")]
        [Route("Home",Order = 2)]
        [Route("Home/MyIndex")]
        public IActionResult MyIndex()=>
            ControllerContext.ToActionResult();
    #endregion
    }
#endif
}

