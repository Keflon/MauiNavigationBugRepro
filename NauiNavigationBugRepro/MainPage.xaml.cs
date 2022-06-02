namespace MauiNavigationBugRepro;

public partial class MainPage : ContentPage
{
    private readonly ChildPage _childPage;
    int count = 0;

	public MainPage()
	{
		InitializeComponent();

		_childPage = new ChildPage();

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

	private void OnNavigateClicked(object sender, EventArgs e)
	{
		App.Current.MainPage.Navigation.PushAsync(_childPage);
    }
}