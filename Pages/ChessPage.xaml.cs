using BoardGames.ViewModels;

namespace BoardGames.Pages;

public partial class ChessPage : ContentPage
{
	public ChessPage(ChessViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}