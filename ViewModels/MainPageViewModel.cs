

using BoardGames.Models;
using BoardGames.Pages;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace BoardGames.ViewModels
{
	public partial class MainPageViewModel : BaseViewModel
	{
		[ObservableProperty]
		LoginModel loginModel;

		public MainPageViewModel()
		{
			this.Title = "Sign In";
        }

        [RelayCommand]
        public async Task GoToRegister()
        {
            await Shell.Current.GoToAsync(nameof(RegisterPage), true);
        }

		[RelayCommand]
		public async Task GoToGamesList()
		{
			await Shell.Current.GoToAsync(nameof(GamesList), true);
		}

		[RelayCommand]
        public async Task SignIn()
        {
        
        }
    }
}
