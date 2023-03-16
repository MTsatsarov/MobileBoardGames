

using CommunityToolkit.Mvvm.ComponentModel;

namespace BoardGames.Models.Chess
{
	public partial class Pawn : ObservableObject, IFigure
	{
		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		private Enums.Color color;

		public Pawn(Enums.Color color, string imagePath, string name)
		{
			this.ImagePath = imagePath;
			this.Name = name;
			this.Color = color;
		}
	}
}
