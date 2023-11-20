using DevExpress.AspNetCore.Reporting;
using Microsoft.EntityFrameworkCore;
using DevExpress.XtraReports.Web.Extensions;
using DevExpress.Security.Resources;
using DevExpress.Blazor.Reporting;
using ReportDesigner.Data;
using ReportDesigner.Services;
using DevExpress.XtraCharts;
using DevExpress.XtraReports.Web.WebDocumentViewer;
using ReportDesigner.Services.JsonService;

var builder = WebApplication.CreateBuilder(args);
// Add services to the container.

builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();
builder.Services.AddDevExpressBlazor();
builder.Services.AddDevExpressServerSideBlazorReportViewer();
builder.Services.Configure<DevExpress.Blazor.Configuration.GlobalOptions>(options =>
{
    options.BootstrapVersion = DevExpress.Blazor.BootstrapVersion.v5;
});
builder.Services.AddTransient<IWebDocumentViewerReportResolver, CustomWebDocumentViewerReportResolver>();

builder.Services.AddDevExpressBlazorReporting();
builder.Services.AddScoped<ReportStorageWebExtension, CustomReportStorageWebExtension>();
builder.Services.AddScoped<JsonCustomizationService>();
builder.Services.ConfigureReportingServices(configurator =>
{
    configurator.ConfigureReportDesigner(designerConfigurator =>
    {
        designerConfigurator.RegisterObjectDataSourceWizardTypeProvider<ObjectDataSourceWizardCustomTypeProvider>();
        designerConfigurator.RegisterDataSourceWizardConfigFileJsonConnectionStringsProvider();
        designerConfigurator.RegisterDataSourceWizardJsonConnectionStorage<CustomDataSourceWizardJsonDataConnectionStorage>();

    });
    configurator.UseAsyncEngine();
    configurator.ConfigureWebDocumentViewer(viewerConfig =>
    {
        viewerConfig.RegisterJsonDataConnectionProviderFactory<CustomJsonDataConnectionProviderFactory>();
    });
});
builder.Services.AddDbContext<ReportDbContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("ReportsDataConnectionString")));
builder.WebHost.UseStaticWebAssets();

var app = builder.Build();

var db = app.Services.GetService<ReportDbContext>();
db.InitializeDatabase();

var contentDirectoryAllowRule = DirectoryAccessRule.Allow(new DirectoryInfo(Path.Combine(app.Environment.ContentRootPath, "..", "Content")).FullName);
AccessSettings.ReportingSpecificResources.TrySetRules(contentDirectoryAllowRule, UrlAccessRule.Allow());
app.UseDevExpressBlazorReporting();
app.UseReporting(builder =>
{
    builder.UserDesignerOptions.DataBindingMode = DevExpress.XtraReports.UI.DataBindingMode.Expressions;
});

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
    endpoints.MapBlazorHub();
    endpoints.MapFallbackToPage("/_Host");
});

string contentPath = app.Environment.ContentRootPath;
AppDomain.CurrentDomain.SetData("DXResourceDirectory", contentPath);

app.Run();