namespace FBCrashlytics.MAUI;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        throw new InvalidOperationException("Test Exception" + " Should not have clicked this :P");
    }
}


