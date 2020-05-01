using System;
using System.Linq;
using System.Windows;
using GalaSoft.MvvmLight.CommandWpf;
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
		public RelayCommand BerryClick { get; }
		#endregion

		#region ベリーの固さクリックコマンド
		/// <summary>
		/// ベリーの固さクリックコマンド
		/// </summary>
		public RelayCommand BerryFirmnessClick { get; }
		#endregion

		#region 世代ボタンクリックコマンド
		/// <summary>
		/// 世代ボタンクリックコマンド
		/// </summary>
		public RelayCommand GenerationClick { get; }
		#endregion

		#region ポケモン図鑑クリックコマンド
		/// <summary>
		/// ポケモン図鑑クリックコマンド
		/// </summary>
		public RelayCommand PokedexClick { get; }
		#endregion

		#region バージョンクリックコマンド
		/// <summary>
		/// バージョンクリックコマンド
		/// </summary>
		public RelayCommand VersionClick { get; }
		#endregion

		#region バージョングループクリックコマンド
		/// <summary>
		/// バージョングループクリックコマンド
		/// </summary>
		public RelayCommand VersionGroupClick { get; }
		#endregion

		#region アイテムクリックコマンド
		/// <summary>
		/// アイテムクリックコマンド
		/// </summary>
		public RelayCommand ItemClick { get; }
		#endregion

		#region アイテム属性クリックコマンド
		/// <summary>
		/// アイテム属性クリックコマンド
		/// </summary>
		public RelayCommand ItemAttributeClick { get; }
		#endregion

		#region アイテムカテゴリクリックコマンド
		/// <summary>
		/// アイテムカテゴリクリックコマンド
		/// </summary>
		public RelayCommand ItemCategoryClick { get; }
		#endregion

		#region アイテムフリング効果クリックコマンド
		/// <summary>
		/// アイテムフリング効果クリックコマンド
		/// </summary>
		public RelayCommand ItemFlingEffectClick { get; }
		#endregion

		#region アイテムポケットクリックコマンド
		/// <summary>
		/// アイテムポケットクリックコマンド
		/// </summary>
		public RelayCommand ItemPocketClick { get; }
		#endregion

		#region 言語ボタンクリックコマンド
		/// <summary>
		/// 言語ボタンクリックコマンド
		/// </summary>
		public RelayCommand LanguageClick { get; }
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public MenuViewModel()
		{
			// Berries
			BerryClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ベリー(Berry)", new BerryList(), typeof(Window)));
			BerryFirmnessClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ベリーの固さ(Berry Firmness)", new BerryFirmnessList(), typeof(Window)));

			// Games
			GenerationClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("世代(Generation)", new GenerationList(), typeof(Window)));
			PokedexClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモン図鑑(Pokedex)", new PokedexList(), typeof(Window)));
			VersionClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("バージョン(Version)", new VersionList(), typeof(Window)));
			VersionGroupClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("バージョングループ(VersionGroup)", new VersionGroupList(), typeof(Window)));

			// Items
			ItemClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("アイテム(Item)", new ItemList(), typeof(Window)));
			ItemAttributeClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("アイテム属性(ItemAttribute)", new ItemAttributeList(), typeof(Window)));
			ItemCategoryClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("アイテムカテゴリ(ItemCategory)", new ItemCategoryList(), typeof(Window)));
			ItemFlingEffectClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("アイテムフリング効果(ItemFlingEffect)", new ItemFlingEffectList(), typeof(Window)));
			ItemPocketClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("アイテムポケット(ItemPocket)", new ItemPocketList(), typeof(Window)));

			// Utility
			LanguageClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("言語(Language)", new LanguageList(), typeof(LanguageWindow)));
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
