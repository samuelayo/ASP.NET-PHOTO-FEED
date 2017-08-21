using PusherServer;
using Real_time_photo_feed.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Real_time_photo_feed.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
           var me = db.FeedModel.AsQueryable();
            //return Json(me, JsonRequestBehavior.AllowGet);
            return View(me);
        }
        [HttpPost]
        public async Task<ActionResult> Index(PhotoFeed feed, HttpPostedFileBase upload)
        {

            if (ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    var FileName = System.IO.Path.GetFileName(upload.FileName);
                    var newpath = Path.Combine(HttpContext.Server.MapPath("~/UploadedFiles"), FileName);
                    upload.SaveAs(newpath);
                    PhotoFeed setdata = new PhotoFeed();
                    setdata.Comment = feed.Comment;
                    setdata.Imagepath = "/UploadedFiles/"+FileName;
                    db.FeedModel.Add(setdata);
                    db.SaveChanges();

                    var options = new PusherOptions();
                    options.Cluster = "XXX_APP_CLUSTER";
                    var pusher = new Pusher("XXx_APP_ID", "XXX_APP_KEY", "XXx_APP_SECRET", options);
                    ITriggerResult result = await pusher.TriggerAsync("a_channel", "an_event", setdata);
                }
            }
                return Content("ok");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}