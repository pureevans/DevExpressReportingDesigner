using DevExpress.DataAccess.Json;
using ReportDesigner.Data;

namespace ReportDesigner.Services.JsonService
{
    public class WebDocumentViewerJsonDataConnectionProvider : IJsonDataConnectionProviderService
    {
        private readonly IEnumerable<DataConnection> _jsonDataConnections;
        public WebDocumentViewerJsonDataConnectionProvider(IEnumerable<DataConnection> jsonDataConnections)
        {
            _jsonDataConnections = jsonDataConnections;
        }
        public JsonDataConnection GetJsonDataConnection(string name)
        {
            var connection = _jsonDataConnections.FirstOrDefault(x => x.Name == name);
            if (connection == null)
                throw new InvalidOperationException();
            return CustomDataSourceWizardJsonDataConnectionStorage.CreateJsonDataConnectionFromString(connection);
        }
    }
}
