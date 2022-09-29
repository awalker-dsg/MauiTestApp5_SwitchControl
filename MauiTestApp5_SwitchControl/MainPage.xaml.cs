namespace MauiTestApp5_SwitchControl;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    void OnButton1(object sender, EventArgs e) => ShowAlert("OnButton1");
    void OnButton2(object sender, EventArgs e) => ShowAlert("OnButton2");
    void OnButton3(object sender, EventArgs e) => ShowAlert("OnButton3");
    void OnButton4(object sender, EventArgs e) => ShowAlert("OnButton4");

    void ShowAlert(string msg) => DisplayAlert("Alert", msg, "OK");
}

