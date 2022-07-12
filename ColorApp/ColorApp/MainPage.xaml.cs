namespace ColorApp;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void Button_Clicked(object sender, EventArgs e)
	{

	}

	private void MagentaClicked(object sender, EventArgs e)
	{
		cPage.BackgroundColor = Color.Parse("Magenta");
	}

	private void OrangeClicked(object sender, EventArgs e)
	{
        cPage.BackgroundColor = Color.Parse("Orange");
    }

	private void ResetClicked(object sender, EventArgs e)
	{
        cPage.BackgroundColor = Color.Parse("Black");
    }
}

