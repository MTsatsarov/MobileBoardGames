using BoardGames.ViewModels;

namespace BoardGames.Pages;

public partial class TicTacToePage : ContentPage
{

	public TicTacToePage(TicTacToeViewModelcs model)
	{
		InitializeComponent();
		this.BindingContext = model;
	}
}