using CommunityToolkit.Mvvm.ComponentModel;


namespace BoardGames.Models.Chess
{
    public partial class King:Figure
    {
		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private Enums.Color color;

		public King(Enums.Color color, string imagePath, string name)
		{
			this.ImagePath = imagePath;
			this.Name = name;
			this.Color = color;
		}
	}
}
