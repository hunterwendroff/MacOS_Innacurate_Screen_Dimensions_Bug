namespace MacOS_Innacurate_Screen_Dimensions_Bug;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();

		var theseHeightsAndWidthsAreInnacurate = DeviceDisplay.Current.MainDisplayInfo;
    }
}

