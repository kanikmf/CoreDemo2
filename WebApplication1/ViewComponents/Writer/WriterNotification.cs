using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.ViewComponents.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
