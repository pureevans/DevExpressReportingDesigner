using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using DevExpress.XtraReports.UI;
using ReportDesigner.PredefinedReports;
using ReportDesigner.Data;
using ReportDesigner.Models;
using DevExpress.DataAccess.Json;
using ReportDesigner.Controllers;
using System.Xml.Serialization;

namespace ReportDesigner.Services
{
    public class CustomReportStorageWebExtension : DevExpress.XtraReports.Web.Extensions.ReportStorageWebExtension
    {
        protected ReportDbContext DbContext { get; set; }
        public CustomReportStorageWebExtension(ReportDbContext dbContext)
        {
            this.DbContext = dbContext;
        }
        static JsonSerializerOptions jsonOptions = new()
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            ReferenceHandler = ReferenceHandler.IgnoreCycles,
        };

        public override bool CanSetData(string url)
        {
            // Determines whether a report with the specified URL can be saved.
            // Add custom logic that returns **false** for reports that should be read-only.
            // Return **true** if no valdation is required.
            // This method is called only for valid URLs (if the **IsValidUrl** method returns **true**).

            return true;
        }

        public override bool IsValidUrl(string url)
        {
            // Determines whether the URL passed to the current report storage is valid.
            // Implement your own logic to prohibit URLs that contain spaces or other specific characters.
            // Return **true** if no validation is required.

            return true;
        }

        public override byte[] GetData(string url)
        {
            // Uses a specified URL to return report layout data stored within a report storage medium.
            // This method is called if the **IsValidUrl** method returns **true**.
            // You can use the **GetData** method to process report parameters sent from the client
            // if the parameters are included in the report URL's query string.
            //using var spwmsContext = new _SPWMSContext();
            //var wmsReport = spwmsContext.WmsReports.FirstOrDefault(x => x.CReportName.Equals(url));
            //if (wmsReport != null)
            //{
            //    using var ms = new MemoryStream();
            //    var serializer = new XmlSerializer(typeof(byte[]));
            //    serializer.Serialize(ms, wmsReport.CReportLayoutData);
            //    var xtraReport = new XtraReport();
            //    xtraReport.LoadLayoutFromXml(ms);

            //    return wmsReport.CReportLayoutData;
            //}
            var reportData = DbContext.Reports.FirstOrDefault(x => x.Name == url);
            if (reportData != null)
            {
                using var ms = new MemoryStream();
                var serializer = new XmlSerializer(typeof(byte[]));
                serializer.Serialize(ms, reportData.LayoutData);
                var xtraReport = new XtraReport();
                xtraReport.LoadLayoutFromXml(ms);

                //DevExpressSupport --> the bandCollection for TestReport is empty (Count = 0), where does the magic happen after GetData returns that the report designer still shows the report with its defined bands?
                var bandCollection = xtraReport.Bands;
                return reportData.LayoutData;
            }

            if (ReportsFactory.Reports.TryGetValue(url, out var foundReport))
            {
                using var ms = new MemoryStream();
                using XtraReport report = foundReport();
                report.SaveLayoutToXml(ms);
                var test = report.DataSource;
                return ms.ToArray();
            }
            throw new DevExpress.XtraReports.Web.ClientControls.FaultException(string.Format("Could not find report '{0}'.", url));
        }

        public override Dictionary<string, string> GetUrls()
        {
            // Returns a dictionary that contains the report names (URLs) and display names. 
            // The Report Designer uses this method to populate the Open Report and Save Report dialogs.

            return DbContext.Reports
                .ToList()
                .Select(x => x.Name)
                .Union(ReportsFactory.Reports.Select(x => x.Key))
                .ToDictionary<string, string>(x => x);
        }

        public override void SetData(XtraReport report, string url)
        {
            // Saves the specified report to the report storage with the specified name
            // (saves existing reports only). 
            using var stream = new MemoryStream();
            report.SaveLayoutToXml(stream);

            //using var spwmsContext = new _SPWMSContext();
            //var wmsReport = spwmsContext.WmsReports.FirstOrDefault(x => x.CReportName.Equals(url));
            //if (wmsReport == null)
            //{
            //    spwmsContext.WmsReports.Add(new WmsReport
            //    {
            //        CReportName = url,
            //        CReportLayoutData = stream.ToArray(),
            //        CReportJsonScheme = report.DataSource.ToString()
            //    });
            //}
            //else

            //{
            //    wmsReport.CReportLayoutData = stream.ToArray();
            //    wmsReport.CReportJsonScheme = report.DataSource.ToString();

            //}

            //spwmsContext.SaveChanges();
            var reportData = DbContext.Reports.FirstOrDefault(x => x.Name == url);
            if (reportData == null)
            {
                DbContext.Reports.Add(new ReportItem { Name = url, LayoutData = stream.ToArray() });
            }
            else
            {
                reportData.LayoutData = stream.ToArray();

            }
            DbContext.SaveChanges();

            //PrintRepo.PrintFromDatabase(DbContext, "DevExpressJson");
        }

        public override string SetNewData(XtraReport report, string defaultUrl)
        {
            // Allows you to validate and correct the specified name (URL).
            // This method also allows you to return the resulting name (URL),
            // and to save your report to a storage. The method is called only for new reports.
            SetData(report, defaultUrl);
            return defaultUrl;
        }

        static object CreateObjectFromSchema(JsonSchemaNode schemaNode)
        {
            //if (schemaNode.Type == JsonObjectType.Object)
            //{
            //    var obj = new System.Dynamic.ExpandoObject();
            //    foreach (var property in schemaNode.Properties)
            //    {
            //        ((IDictionary<string, object>)obj)[property.Key] = CreateObjectFromSchema(property.Value);
            //    }
            //    return obj;
            //}
            //else if (schemaNode.Type == JsonObjectType.Array)
            //{
            //    var array = new System.Collections.Generic.List<object>();
            //    if (schemaNode.Items != null)
            //    {
            //        foreach (var item in schemaNode.Items)
            //        {
            //            array.Add(CreateObjectFromSchema(item));
            //        }
            //    }
            //    return array;
            //}
            //else
            //{
            //    // Handle primitive types here, you might want to add more checks and conversions.
            //    if (schemaNode.Type == JsonObjectType.String)
            //    {
            //        return "SampleString";
            //    }
            //    else if (schemaNode.Type == JsonObjectType.Integer)
            //    {
            //        return 42;
            //    }
            //    else if (schemaNode.Type == JsonObjectType.Number)
            //    {
            //        return 3.14;
            //    }
            //    else if (schemaNode.Type == JsonObjectType.Boolean)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return null;
            //    }
            //}
            return new object();
        }
    }
}