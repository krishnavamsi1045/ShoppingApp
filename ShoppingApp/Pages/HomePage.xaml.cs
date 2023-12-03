using ShoppingApp.ViewModel;

namespace ShoppingApp.Pages;

public partial class HomePage : ContentPage

{
	private readonly HomeViewModel _viewmodel;
	public HomePage(HomeViewModel viewmodel)
	{
		InitializeComponent();

            _viewmodel = viewmodel;
	}

	protected override async void OnAppearing()
	{
		base.OnAppearing();
		await _viewmodel.IntializeAsync();
	}
}