using BoardGames.Models.Chess.Interfaces;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace BoardGames.Models.Chess
{
	public abstract partial class Figure : ObservableObject, IMoving
	{
		[ObservableProperty]
		private string imagePath;

		[ObservableProperty]
		private string name;

		[ObservableProperty]
		public Enums.Color color;

        public virtual bool HasMoved { get; set; }

        public virtual Dictionary<int, List<int>> AvailableMoves( ObservableCollection<Square> board,int a,int b)
		{
			return new Dictionary<int, List<int>>();
		}
	}
}

