using System;
using System.Web.Mvc;
using WebEncodeMessages.Infrastructure;

namespace WebEncodeMessages.Controllers
{
    public class GenerateDataController : Controller
    {
        private GeneratorHelper _generatorHelper;
        public GenerateDataController()
        {
            _generatorHelper = new GeneratorHelper();
        }

        // GET: GenerateData
        public ActionResult Index()
        {
            var statusMessage = "Some data has created successfuly.";
            try
            {
                _generatorHelper.GenerateEncryptionSymbolsData();
            }
            catch (Exception)
            {
                statusMessage = "An error occured while creating the data. Probably the data already generated once.";
            }
            ViewBag.StatusMessage = statusMessage;
            return View();
        }
    }
}