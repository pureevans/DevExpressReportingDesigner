using DevExpress.DataAccess.Json;
using DevExpress.DataAccess.Web;
using ReportDesigner.Data;

namespace ReportDesigner.Services.JsonService
{
    public class CustomJsonDataConnectionProviderFactory : IJsonDataConnectionProviderFactory
    {
        protected ReportDbContext DbContext { get; }

        public CustomJsonDataConnectionProviderFactory(ReportDbContext dbContext)
        {
            DbContext = dbContext;
        }

        public IJsonDataConnectionProviderService Create()
        {
            return new WebDocumentViewerJsonDataConnectionProvider(DbContext.JsonDataConnections.ToList());
      
        }
    }
}
