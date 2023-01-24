namespace MauiExample;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("OTgyMTI0QDMyMzAyZTM0MmUzMGxIb1dsb1FmZk5FcWxkbU9YUy9iSVdkaXIyOE5oWnQ5emowNG5nM2tPdEE9");
		InitializeComponent();

		MainPage = new AppShell();
	}
}
