using System;
using System.Web.Mvc;
using Tweetinvi;
using Tweetinvi.Core.Authentication;
using Tweetinvi.Core.Enum;
using Tweetinvi.Core.Parameters;
using Tweetinvi.Json;
using System.Text;
using System.IO;
using System.Net;
namespace gbf.Controllers
{
    public class indexController : Controller
    {
        // GET: index
        const string TWITTERAPPACCESSTOKEN = "";
        const string TWITTERAPPACCESSTOKENSECRET = "";
        const string TWITTERAPPAPIKEY = "";
        const string TWITTERAPPAPISECRET = "";
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult datapage()
        {
            Auth.SetUserCredentials(TWITTERAPPAPIKEY, TWITTERAPPAPISECRET, TWITTERAPPACCESSTOKEN, TWITTERAPPACCESSTOKENSECRET);
            string userJson = TwitterAccessor.ExecuteJsonGETQuery("https://api.twitter.com/1.1/search/tweets.json?q=参加者募集！参戦ID:&result_type=recent&count=20");
            return Content(userJson);
        }
    }
}