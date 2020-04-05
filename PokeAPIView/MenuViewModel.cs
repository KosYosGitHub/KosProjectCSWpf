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

		#region バージョンクリックコマンド
		/// <summary>
		/// バージョンクリックコマンド
		/// </summary>
		public static readonly RoutedCommand VersionClick = new RoutedCommand("VersionClick", typeof(MenuViewModel));
		#endregion

		#region バージョングループクリックコマンド
		/// <summary>
		/// バージョングループクリックコマンド
		/// </summary>
		public static readonly RoutedCommand VersionGroupClick = new RoutedCommand("VersionClick", typeof(MenuViewModel));
		#endregion

		#region アイテムクリックコマンド
		/// <summary>
		/// アイテムクリックコマンド
		/// </summary>
		public static readonly RoutedCommand ItemClick = new RoutedCommand("ItemClick", typeof(MenuViewModel));
		#endregion

		#region アイテム属性クリックコマンド
		/// <summary>
		/// アイテム属性クリックコマンド
		/// </summary>
		public static readonly RoutedCommand ItemAttributeClick = new RoutedCommand("ItemAttributeClick", typeof(MenuViewModel));
		#endregion

		#region アイテムカテゴリクリックコマンド
		/// <summary>
		/// アイテムカテゴリクリックコマンド
		/// </summary>
		public static readonly RoutedCommand ItemCategoryClick = new RoutedCommand("ItemCategoryClick", typeof(MenuViewModel));
		#endregion

		#region アイテムフリング効果クリックコマンド
		/// <summary>
		/// アイテムフリング効果クリックコマンド
		/// </summary>
		public static readonly RoutedCommand ItemFlingEffectClick = new RoutedCommand("ItemFlingEffectClick", typeof(MenuViewModel));
		#endregion

		#region アイテムポケットクリックコマンド
		/// <summary>
		/// アイテムポケットクリックコマンド
		/// </summary>
		public static readonly RoutedCommand ItemPocketClick = new RoutedCommand("ItemPocketClick", typeof(MenuViewModel));
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

			_ = window.ShowDialog();
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

			_ = window.ShowDialog();
		}
		#endregion

		#region バージョン クリック
		/// <summary>
		/// バージョン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VersionClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("バージョン(Version)", new VersionList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region バージョングループ クリック
		/// <summary>
		/// バージョングループ クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void VersionGroupClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("バージョングループ(VersionGroup)", new VersionGroupList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region アイテムクリック
		/// <summary>
		/// アイテムクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("アイテム(Item)", new ItemList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region アイテム属性クリック
		/// <summary>
		/// アイテム属性クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemAttributeClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("アイテム属性(ItemAttribute)", new ItemAttributeList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region アイテムカテゴリクリック
		/// <summary>
		/// アイテムカテゴリクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemCategoryClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("アイテム属性(ItemAttribute)", new ItemCategoryList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region アイテムフリング効果クリック
		/// <summary>
		/// アイテムフリング効果クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemFlingEffectClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("アイテムフリング効果(ItemFlingEffect)", new ItemFlingEffectList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
		}
		#endregion

		#region アイテムポケットクリック
		/// <summary>
		/// アイテムポケットクリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void ItemPocketClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow("アイテムポケット(ItemPocket)", new ItemPocketList());

			window.Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive);

			_ = window.ShowDialog();
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

			_ = window.ShowDialog();
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
			// Games
			commands.Add(new CommandBinding(GenerationClick, GenerationClickCommand));
			commands.Add(new CommandBinding(PokedexClick, PokedexClickCommand));
			commands.Add(new CommandBinding(VersionClick, VersionClickCommand));
			commands.Add(new CommandBinding(VersionGroupClick, VersionGroupClickCommand));

			// Items
			commands.Add(new CommandBinding(ItemClick, ItemClickCommand));
			commands.Add(new CommandBinding(ItemAttributeClick, ItemAttributeClickCommand));
			commands.Add(new CommandBinding(ItemCategoryClick, ItemCategoryClickCommand));
			commands.Add(new CommandBinding(ItemFlingEffectClick, ItemFlingEffectClickCommand));
			commands.Add(new CommandBinding(ItemPocketClick, ItemPocketClickCommand));

			// Utility
			commands.Add(new CommandBinding(LanguageClick, LanguageClickCommand));
		}
		#endregion
	}
}
