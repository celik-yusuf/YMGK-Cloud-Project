using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using YMGK_Cloud.Models.Siniflar;

namespace YMGK_Cloud.Controllers
{
    public class HesapController : Controller
    {
        // GET: Hesap
        MContext mContext = new MContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Register (RegisterViewModel model)
        {
            if (!ModelState.IsValid)
            {
                var user = new ApplicationUser
            }
        }
    }
}