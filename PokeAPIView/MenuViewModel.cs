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

		#region ベリーボタンクリックコマンド
		/// <summary>
		/// ベリーボタンクリックコマンド
		/// </summary>
		public static readonly RoutedCommand BerryClick = new RoutedCommand("BerryClick", typeof(MenuViewModel));
		#endregion

		#region ベリーの固さクリックコマンド
		/// <summary>
		/// ベリーの固さクリックコマンド
		/// </summary>
		public static readonly RoutedCommand BerryFirmnessClick = new RoutedCommand("BerryFirmnessClick", typeof(MenuViewModel));
		#endregion

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

		#region ベリーボタン クリック
		/// <summary>
		/// ベリーボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BerryClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			ShowNamedAPIResourceListWindow("ベリー(Berry)", new BerryList(), typeof(Window));
		}
		#endregion

		#region ベリーの固さボタン クリック
		/// <summary>
		/// ベリーの固さボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void BerryFirmnessClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			ShowNamedAPIResourceListWindow("ベリーの固さ(Berry Firmness)", new BerryFirmnessList(), typeof(Window));
		}
		#endregion

		#region 世代ボタン クリック
		/// <summary>
		/// 世代ボタン クリック
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void GenerationClickCommand(object sender, ExecutedRoutedEventArgs e)
		{
			ShowNamedAPIResourceListWindow("世代(Generation)", new GenerationList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("ポケモン図鑑(Pokedex)", new PokedexList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("バージョン(Version)", new VersionList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("バージョングループ(VersionGroup)", new VersionGroupList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("アイテム(Item)", new ItemList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("アイテム属性(ItemAttribute)", new ItemAttributeList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("アイテムカテゴリ(ItemCategory)", new ItemCategoryList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("アイテムフリング効果(ItemFlingEffect)", new ItemFlingEffectList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("アイテムポケット(ItemPocket)", new ItemPocketList(), typeof(Window));
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
			ShowNamedAPIResourceListWindow("言語(Language)", new LanguageList(), typeof(LanguageWindow));
		}
		#endregion

		// public メソッド

		#region コマンドの初期化
		/// <summary>
		/// コマンドの初期化
		/// </summary>
		/// <param name="commands">Command Binding Collection</param>
		public void InitializeCommandBindings(CommandBindingCollection commands)
		{
			// Berries
			_ = commands.Add(new CommandBinding(BerryClick, BerryClickCommand));
			_ = commands.Add(new CommandBinding(BerryFirmnessClick, BerryFirmnessClickCommand));

			// Games
			_ = commands.Add(new CommandBinding(GenerationClick, GenerationClickCommand));
			_ = commands.Add(new CommandBinding(PokedexClick, PokedexClickCommand));
			_ = commands.Add(new CommandBinding(VersionClick, VersionClickCommand));
			_ = commands.Add(new CommandBinding(VersionGroupClick, VersionGroupClickCommand));

			// Items
			_ = commands.Add(new CommandBinding(ItemClick, ItemClickCommand));
			_ = commands.Add(new CommandBinding(ItemAttributeClick, ItemAttributeClickCommand));
			_ = commands.Add(new CommandBinding(ItemCategoryClick, ItemCategoryClickCommand));
			_ = commands.Add(new CommandBinding(ItemFlingEffectClick, ItemFlingEffectClickCommand));
			_ = commands.Add(new CommandBinding(ItemPocketClick, ItemPocketClickCommand));

			// Utility
			_ = commands.Add(new CommandBinding(LanguageClick, LanguageClickCommand));
		}
		#endregion

		// private メソッド

		#region 名前付きリソースリスト画面を表示
		/// <summary>
		/// 名前付きリソースリスト画面を表示
		/// </summary>
		/// <param name="caption">キャプション</param>
		/// <param name="namedAPIResourceList">名前付きリソースリスト</param>
		/// <param name="detailWindowType">詳細画面の型</param>
		private void ShowNamedAPIResourceListWindow(string caption, NamedAPIResourceList namedAPIResourceList, Type detailWindowType)
		{
			NamedAPIResourceListWindow window = new NamedAPIResourceListWindow(caption, namedAPIResourceList, detailWindowType) {
				Owner = Application.Current.Windows.OfType<Window>().SingleOrDefault(x => x.IsActive)
			};

			_ = window.ShowDialog();
		}
		#endregion
	}
}
