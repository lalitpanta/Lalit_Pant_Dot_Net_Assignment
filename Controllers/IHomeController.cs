using Microsoft.AspNetCore.Mvc;

namespace Lalit_Pant_Dot_Net_Assignment.Controllers
{
    public interface IHomeController
    {
        IActionResult Donor();
        IActionResult Index();
    }
}