using CommunityToolkit.Mvvm.ComponentModel;

namespace BoardGames.Models.Chess
{
	public partial class Knight:Figure
	{
		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private Enums.Color color;

		public Knight(Enums.Color color, string imagePath, string name)
		{
			this.ImagePath = imagePath;
			this.Name = name;
			this.Color = color;
		}
	}
}
