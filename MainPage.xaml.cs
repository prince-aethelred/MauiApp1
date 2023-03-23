namespace MauiApp1;


public partial class MainPage : ContentPage
{
	int count = 0;
	int count2 = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void OnCounterClicked2(object sender, EventArgs e)
	{ 
		count2++;

		if (count2 == 1)
			CounterBtn2.Text = $"Yoooo Clicked {count2} time";
		else if (count2 >= 2)
			CounterBtn2.Text = $"Yoooo Clicked {count2} times";

		SemanticScreenReader.Announce(CounterBtn2.Text);
	}

    private async void learn_more_clicked(object sender, EventArgs e)
    {
		// Navigate to the specified URL in the system browser
		await Launcher.Default.OpenAsync("https://aka.ms/maui");
    }
}

