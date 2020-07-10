using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            string ht = "<html><body>hello world!</body><html>";

            string xml2 = "<?xml version=\"1.0\" encoding=\"utf-8\" ?>\r\n<configuration>\r\n <startup> \r\n <supportedRuntime version=\"v4.0\" sku=\".NETFramework,Version=v4.6.1\" />\r\n </startup>\r\n</configuration>";

            string json = "{\r\n \"name\":\"中国\",\r\n \"province\":[\r\n {\r\n \"名字\":\"黑龙江\",\r\n \"城市\":{\r\n \"城市\":[\"海冰\",\"长春\"]\r\n }\r\n },\r\n {\r\n \"名字\": \"广东\",\r\n \"城市\": {\r\n \"城市\": [ \"广州\", \"深圳\", \"厦门\" ]\r\n }\r\n },\r\n {\r\n \"名字\":\"陕西\",\r\n \"城市\": {\r\n \"城市\": [ \"西安\", \"延安\" ]\r\n }\r\n },\r\n {\r\n \"名字\":\"甘肃\",\r\n \"城市\": {\r\n \"城市\": [ \"兰州\" ]\r\n }\r\n }\r\n]\r\n}\r\n";

            DataTable dt = new DataTable("Table_AX");

            dt.Columns.Add("column0", System.Type.GetType("System.String"));

            DataColumn dc = new DataColumn("column1", System.Type.GetType("System.Boolean"));

            dt.Columns.Add("column2", System.Type.GetType("System.Int32"));

            dt.Columns.Add("column3", System.Type.GetType("System.Guid"));

            dt.Columns.Add(dc);

            Guid guid = new Guid("00000000-0000-0000-0000-000000000000");

            for (int i = 0; i < 50; i++)

            {

                DataRow dr = dt.NewRow();

                dr["column0"] = "AX_" + i;

                dr["column1"] = true;

                dr["column2"] = i;

                dr["column3"] = guid;

                dt.Rows.Add(dr);

            }

            DataRow dr1 = dt.NewRow();

            dt.Rows.Add(dr1);

            int a = 10; //add a breakpoint here
            return View();
        }

        public IActionResult Privacy()
        {
            

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
