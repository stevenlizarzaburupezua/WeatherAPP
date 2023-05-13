using WeatherAPP.MVVM.Views;

namespace WeatherAPP;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new WeatherView();
	}
}
