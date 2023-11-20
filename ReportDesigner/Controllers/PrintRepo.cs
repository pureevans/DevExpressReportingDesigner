using DevExpress.DataAccess.Json;
using DevExpress.XtraPrinting;
using DevExpress.XtraReports.UI;
using DevExpress.XtraRichEdit.Import.Html;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json;
using ReportDesigner.Models;
using System.Dynamic;
using System.Xml.Serialization;
using Newtonsoft.Json.Linq;
using ReportDesigner.Data;

namespace ReportDesigner.Controllers
{
    public static class PrintRepo
    {
        public static void PrintFromDatabase(ReportDbContext dbContext, string reportName)
        {
            var xtraReport = new XtraReport();
            using var ms = new MemoryStream();

            var jsonObject = @Path.Combine(Directory.GetCurrentDirectory(), "Json.json");
            JArray jsonArray = JsonConvert.DeserializeObject<JArray>(jsonObject);
            dynamic expando = JsonConvert.DeserializeObject<List<ExpandoObject>>(jsonArray.ToString(), new ExpandoObjectConverter());
            var json = JsonConvert.SerializeObject(expando);

            //            var json = @"[
            //  {
            //    ""id"": ""1"",
            //    ""firstName"": ""Tom"",
            //    ""lastName"": ""Cruise"",
            //    ""photo"": ""https://jsonformatter.org/img/tom-cruise.jpg""
            //  },
            //  {
            //    ""id"": ""2"",
            //    ""firstName"": ""Maria"",
            //    ""lastName"": ""Sharapova"",
            //    ""photo"": ""https://jsonformatter.org/img/Maria-Sharapova.jpg""
            //  },
            //  {
            //    ""id"": ""3"",
            //    ""firstName"": ""Robert"",
            //    ""lastName"": ""Downey Jr."",
            //    ""photo"": ""https://jsonformatter.org/img/Robert-Downey-Jr.jpg""
            //  }
            //]";


            var savedReport = dbContext.Reports.FirstOrDefault(x => x.Name.Equals(reportName));
            if (savedReport != null)
            {
                var jsonDataSource = new JsonDataSource();
                //JObject jsonObject = JsonConvert.DeserializeObject<JObject>(content.ToString());
                //dynamic expando = JsonConvert.DeserializeObject<ExpandoObject>(jsonObject.ToString(), new ExpandoObjectConverter());
                //var json = JsonConvert.SerializeObject(expando);
                jsonDataSource.JsonSource = new CustomJsonSource(json);
                jsonDataSource.Fill();
                var serializer = new XmlSerializer(typeof(byte[]));
                serializer.Serialize(ms, savedReport.LayoutData);
                xtraReport.LoadLayoutFromXml(ms);
                xtraReport.DataSource = jsonDataSource;
                xtraReport.Name = reportName;

                xtraReport.CreateDocument();
                if (xtraReport.PrintingSystem.Document is { IsEmpty: false })
                {
                    xtraReport.PrintingSystem.ExportToPdf(@Path.Combine(Directory.GetCurrentDirectory(), "PrintFromDatabase.pdf"));
                }
            }
        }
    }
}
