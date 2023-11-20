using DevExpress.DataAccess.Json;

namespace ReportDesigner.Services.JsonService;

public class JsonCustomizationService : IJsonSourceCustomizationService
{
    //https://docs.devexpress.com/XtraReports/401655/web-reporting/asp-net-core-reporting/end-user-report-designer-in-asp-net-applications/use-data-sources-and-connections/json-data-register-connections?utm_source=SupportCenter&utm_medium=website&utm_campaign=docs-feedback&utm_content=T1189222
    public JsonSourceBase CustomizeJsonSource(JsonDataSource jsonDataSource)
    {
        throw new NotImplementedException();
        //return new UriJsonSource("https://northwind.netcore.io/customers.json"));
    }
}