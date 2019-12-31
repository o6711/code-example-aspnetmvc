using System.Net;
using System.Web.Mvc;
using WebEncodeMessages.Infrastructure;

namespace WebEncodeMessages.Controllers
{
    public class HomeController : Controller
    {
        private DeliveryMessagesHelper _deliveryMessagesHelper;
        public HomeController()
        {
            _deliveryMessagesHelper = new DeliveryMessagesHelper();
        }

        //perfomance: добавить кэширование в MemoryCache 
        public ActionResult Index()
        {
            return View(_deliveryMessagesHelper.GetAllMessages());
        }

        [HttpPost]
        public ActionResult SendMessage(string message)
        {
            if (string.IsNullOrEmpty(message))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            _deliveryMessagesHelper.SaveMessage(message);

            return RedirectToAction("Index");
        }
    }
}