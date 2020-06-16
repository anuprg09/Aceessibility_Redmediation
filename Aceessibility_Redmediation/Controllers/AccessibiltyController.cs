using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aceessibility_Redmediation.Controllers
{
    public class AccessibiltyController : Controller
    {
        // GET: Accessibilty
        public ActionResult HTMLViewer()
        {
            return View();
        }

        //public ActionResult PDFViewer()
        //{
        //    return View();
        //}
        public ActionResult PDFViewer(string filePath)
        {
            //build the file path here
            filePath = "../../MyPDFs/1001AmazingPlaces.pdf";// + filePath;
            //pass the file path to the View using a viewbag variable
            ViewBag.filePath = filePath;
            //We could also just return a view along with a query string with a file param pointing to the
            //location of the file on our server, for example: "Viewer?file=/MyPDFs/Pdf1.pdf"
            //but here I've just chosen to change the default URL of the viewer object, which is essentially
            //the same thing
            return View();
        }

        public ActionResult WordViewer()
        {
            return View();
        }
        public FileStreamResult GetPDF()
        {
            FileStream fs = new FileStream(@"D:\Anuranjan\project\EB\1001AmazingPlaces.pdf", FileMode.Open, FileAccess.Read);
            return File(fs, "application/pdf");
        }
    }
}