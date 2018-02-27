using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace TestProgect.Controllers
{
    public class HomeController : Controller
    {
        private IEnumerable<Test> _test;

        public HomeController()
        {
            this._test = new List<Test>()
            {
                new Test
                {
                    Database = "Database",
                    DatabaseName = "DatabaseName",
                    IndexConnectionString = "IndexConnectionString",
                    IsReady = "IsReady",
                    ServerName = "ServerName",
                    SqlClient = "SqlClient",
                    TextError = "TextError"
                },
                new Test
                {
                    Database = "Database",
                    DatabaseName = "DatabaseName",
                    IndexConnectionString = "IndexConnectionString",
                    IsReady = "IsReady",
                    ServerName = "ServerName",
                    SqlClient = "SqlClient",
                    TextError = "TextError"
                },
            };
        }

        public IActionResult Index()
        {
            return View("Index", (object)JsonConvert.SerializeObject(this._test));
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
            return View();
        }
    }

    class Test
    {
        public string Database { get; set; }

        public string DatabaseName { get; set; }

        public string IndexConnectionString { get; set; }

        public string IsReady { get; set; }

        public string ServerName { get; set; }

        public string SqlClient { get; set; }

        public string TextError { get; set; }
    }
}
