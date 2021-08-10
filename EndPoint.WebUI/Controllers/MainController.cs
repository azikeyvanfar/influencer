using Domain.Contracts;
using Domain.Entities.Commons;
using Domain.Entities.FSYS;
using EndPoint.WebUI.App_Class;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace EndPoint.WebUI.Controllers
{
    public class MainController : BaseController<MainController>
    {
        private readonly ISettingRepository _SettingRepo;
        private readonly IHostingEnvironment _env;
        private readonly IConfiguration _config;

        public MainController(ILogger<MainController> logger, ISettingRepository SettingRepo, IHostingEnvironment env, IConfiguration config, IHttpContextAccessor httpContextAccessor) : base(config, httpContextAccessor, logger)
        {

            _SettingRepo = SettingRepo;
            _env = env;
            _config = config;
        }
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetCompanySettings()
        {
            Guid companyId = Guid.Parse(HttpContext.Request.Cookies["CompanyId"]);
            List<Setting> companySetting = _SettingRepo.Select("CompanySettings", companyId);
            if (companySetting.Count == 0)
            {
                companySetting = _SettingRepo.Select("CompanySettingsDefualt", Guid.Empty);
            }

            if (companySetting.Count == 0)
            {
                return Json(new CompanySettings());
            }
            else
            {
                System.Xml.XmlDocument doc = new System.Xml.XmlDocument();
                doc.LoadXml(companySetting[0].Value);
                CompanySettings cs = new CompanySettings()
                {
                    TemporaryDisconnectedThreshold = int.Parse(doc.ChildNodes[0].Attributes["TemporaryDisconnectedThreshold"].Value),
                    DisconnectedThreshold = int.Parse(doc.ChildNodes[0].Attributes["DisconnectedThreshold"].Value),
                    DisplayItem = doc.ChildNodes[0].Attributes["DisplayItem"] != null ? doc.ChildNodes[0].Attributes["DisplayItem"].Value : "Driver"
                };
                return Json(new { cs });
            }
        }
        [HttpPost]
        public bool SaveCompanySettings(CompanySettings companySettings)
        {
            Guid companyId = Guid.Parse(HttpContext.Request.Cookies["CompanyId"]);
            string content = string.Format(@"<CompanySetting TemporaryDisconnectedThreshold=""{0}"" DisconnectedThreshold=""{1}"" DisplayItem=""{2}"" />",
                companySettings.TemporaryDisconnectedThreshold, companySettings.DisconnectedThreshold, companySettings.DisplayItem);


            int res = _SettingRepo.ExecuteUpdate(content, "CompanySettings", companyId);
            bool result;
            if (res != 1)
            {
                result = false;
                Setting sm = new Setting();
                sm.Code = "CompanySettings";
                sm.Value = content;
                sm.CompanyId = companyId;
                long r = _SettingRepo.Insert(sm);
                if (r == 0)
                {
                    result = true;
                }
            }
            else
            {
                result = true;
            }
            return result;
        }
        [HttpPost]
        public string GetLocationFromOpenStreet(double latitude, double longitude, string refId)
        {
            string res = GetLocationFromStreetMap(latitude, longitude);
            return string.Format("{{\"refId\":\"{0}\", \"address\":\"{1}\"}}", refId, res);
        }
        public string GetLocationFromStreetMap(double latitude, double longitude)
        {
            string OpenStreetMapUrl = "https://nominatim.openstreetmap.org/reverse?format=json&lat={0}&lon={1}&zoom={2}&addressdetails=0";
            string url = string.Format(OpenStreetMapUrl, latitude.ToString(), longitude.ToString(), 18);
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.ServicePoint.ConnectionLimit = 50;
                request.Proxy = WebRequest.DefaultWebProxy;
                request.UserAgent = "Opera/9.62 (Windows NT 5.1; U; en) Presto/2.1.1";
                request.Timeout = 10000; // Timeout;
                request.ReadWriteTimeout = 60000; // Timeout * 6;

                request.KeepAlive = true;
                string geo;

                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader read = new StreamReader(responseStream))
                        {
                            geo = read.ReadToEnd();
                        }
                    }
                }
                JObject jObject = JObject.Parse(geo);
                return ((JValue)(jObject["display_name"])).Value.ToString().Replace("ی", "ي");
            }
            catch
            {
                //StringBuilder str = new StringBuilder();
                //str.AppendLine(ex.Message);
                //str.AppendLine(ex.StackTrace);
                //File.WriteAllText(String.Format(@"D:\Temp\{0}", DateTime.Now.ToString("yyyMMdd HHmmssfff")), str.ToString());
                //Trace.WriteLine("GetLocations: " + ex.ToString());
            }
            return string.Empty;
        }
        //public string ExcelOutput(Guid vehicleId, DateTime dateFrom, DateTime dateTo)
        //{
        //    if (vehicleId != Guid.Empty || vehicleId != null)
        //    {
        //        //DateTime endCreditDatetime = bModule.GetEndCreditDatetime(new Guid(moduleId));
        //        DateTime endCreditDatetime = new DateTime(2020, 10, 04, 23, 12, 20);
        //        if (endCreditDatetime < DateTime.Now.Date)
        //        {
        //            return String.Empty;
        //        }
        //        List<VehiclePoint> pointsList = _VehiclePointRepo.Select(vehicleId, dateFrom, dateTo);

        //        string pathTemplate = _env.ContentRootPath + @"\wwwroot\Files\Report\PointListTemplate.xlsx";// HttpContext.Current.Server.MapPath("~/Files/Report/PointListTemplate.xlsx");
        //        String destFile = String.Format("PointList - {0}.xlsx", DateTime.Now.ToString("yyyyMMdd HHmmss"));
        //        String destFilePath = _env.ContentRootPath + String.Format(@"\wwwroot\Files\Temporary\{0}", destFile);
        //        //_fileProvider.Copy(pathTemplate, destFilePath);

        //        if (System.IO.File.Exists(pathTemplate) && System.IO.File.Exists(destFilePath))
        //        {
        //            int j = 2;
        //            //PointLatLng tmpPoint = PointLatLng.Empty;
        //            using (ExcelPackage pck = new ExcelPackage(new FileInfo(destFilePath)))
        //            {
        //                ExcelWorksheet workSheet = pck.Workbook.Worksheets["Sheet1"];
        //                int index = 1;
        //                foreach (VehiclePoint item in pointsList)
        //                {
        //                    //tmpPoint = new PointLatLng((Double)item["Latitude"], (Double)item["Longitude"]);
        //                    //String utm = Handle.LatLngToUTM(tmpPoint);
        //                    workSheet.Cells[j, 1].Value = index++;
        //                    workSheet.Cells[j, 2].Value = item.DateTime.ToPersian(PersianDateTimeFormat.yyyyMMddHHmmss); /*Common.DateTimeToPersian((DateTime)item["DateTime"], DateTimeFormat.YYYYMMDDHHMMSS);*/
        //                    workSheet.Cells[j, 3].Value = item.Latitude;
        //                    workSheet.Cells[j, 4].Value = item.Longitude;
        //                    //workSheet.Cells[j, 5].Value = Handle.LatLngToUTM(tmpPoint);

        //                    j++;
        //                }

        //                pck.Save();

        //                //this.RegisterStartupScript("pageLoad();");

        //                //HttpContext.Current.Response.Redirect(pathTemplate);
        //                return String.Format("../Files/Temporary/{0}", destFile);

        //            }
        //        }
        //        return "../Files/Temporary/Book1.xlsx";

        //    }

        //    return "../Files/Temporary/Book1.xlsx";
        //}

    }
}