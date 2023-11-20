using DevExpress.DataAccess.Web;

namespace ReportDesigner.Services
{
    public class ObjectDataSourceWizardCustomTypeProvider : IObjectDataSourceWizardTypeProvider
    {
        public IEnumerable<Type> GetAvailableTypes(string context)
        {
            return new[] { typeof(Type) };
        }
    }
}
