using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using KosMVVM;
using PokeAPI;

namespace PokeAPIView
{
	public class MenuViewModel : KosViewModel
	{
		// コマンド

		#region 世代ボタンクリックコマンド
		/// <summary>
		/// 世代ボタンクリックコマンド
		/// </summary>
		public static readonly RoutedCommand GenerationClick = new RoutedCommand("GenerationClick", typeof(MenuViewModel));
		#endregion

		#region ポケモン図鑑クリックコマンド
		/// <summary>
		/// ポケモン図鑑クリックコマンド
		/// </summary>
		public static readonly RoutedCommand PokedexClick = new RoutedCommand("PokedexClick", typeof(MenuViewModel));
		#endregion

		#region 言語ボタンクリックコマンド
		/// <summary>
		/// 言語ボタンクリックコマンド
		/// </summary>
		public static readonly RoutedCommand LanguageClick = new RoutedCommand("LanguageClick", typeof(MenuViewModel));
		#endregion

		// イベントハンドラ

		#region 世代ボタン クリック
		/// <summary>
		/// 世代ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GenerationClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("世代(Generation)", new GenerationList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			window.ShowDialog();
		}
		#endregion

		#region ポケモン図鑑ボタン クリック
		/// <summary>
		/// ポケモン図鑑ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void PokedexClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("ポケモン図鑑(Pokedex)", new PokedexList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			window.ShowDialog();
		}
		#endregion

		#region 言語ボタン クリック
		/// <summary>
		/// 言語ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void LanguageClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("言語(Language)", new LanguageList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			window.ShowDialog();
		}
		#endregion

		// メソッド

		#region コマンドの初期化
		/// <summary>
		/// コマンドの初期化
		/// </summary>
		/// <param name="commands">Command Binding Collection</param>
		public void InitializeCommandBindings(CommandBindingCollection commands)
		{
			commands.Add(new CommandBinding(GenerationClick, GenerationClickCommand));
			commands.Add(new CommandBinding(PokedexClick, PokedexClickCommand));
			commands.Add(new CommandBinding(LanguageClick, LanguageClickCommand));
		}
		#endregion
	}
}
