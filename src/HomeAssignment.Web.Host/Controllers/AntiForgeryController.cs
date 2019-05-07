using Microsoft.AspNetCore.Antiforgery;
using HomeAssignment.Controllers;

namespace HomeAssignment.Web.Host.Controllers
{
    public class AntiForgeryController : HomeAssignmentControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
