﻿using System;
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

		#region ベリーの味クリックコマンド
		/// <summary>
		/// ベリーの味クリックコマンド
		/// </summary>
		public RelayCommand BerryFlavorClick { get; }
		#endregion

		#region コンテストタイプクリックコマンド
		/// <summary>
		/// コンテストタイプクリックコマンド
		/// </summary>
		public RelayCommand ContestTypeClick { get; }
		#endregion

		#region エンカウントの方法クリックコマンド
		/// <summary>
		/// エンカウントの方法クリックコマンド
		/// </summary>
		public RelayCommand EncounterMethodClick { get; }
		#endregion

		#region エンカウント条件クリックコマンド
		/// <summary>
		/// エンカウント条件クリックコマンド
		/// </summary>
		public RelayCommand EncounterConditionClick { get; }
		#endregion

		#region エンカウント条件値クリックコマンド
		/// <summary>
		/// エンカウント条件値クリックコマンド
		/// </summary>
		public RelayCommand EncounterConditionValueClick { get; }
		#endregion

		#region 進化トリガークリックコマンド
		/// <summary>
		/// 進化トリガークリックコマンド
		/// </summary>
		public RelayCommand EvolutionTriggerClick { get; }
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

		#region 場所クリックコマンド
		/// <summary>
		/// 場所クリックコマンド
		/// </summary>
		public RelayCommand LocationClick { get; }
		#endregion

		#region 場所エリアクリックコマンド
		/// <summary>
		/// 場所エリアクリックコマンド
		/// </summary>
		public RelayCommand LocationAreaClick { get; }
		#endregion

		#region パルパークエリアクリックコマンド
		/// <summary>
		/// パルパークエリアクリックコマンド
		/// </summary>
		public RelayCommand PalParkAreaClick { get; }
		#endregion

		#region 地方クリックコマンド
		/// <summary>
		/// 地方クリックコマンド
		/// </summary>
		public RelayCommand RegionClick { get; }
		#endregion

		#region 技クリックコマンド
		/// <summary>
		/// 技クリックコマンド
		/// </summary>
		public RelayCommand MoveClick { get; }
		#endregion

		#region ステータス異常技クリックコマンド
		/// <summary>
		/// ステータス異常技クリックコマンド
		/// </summary>
		public RelayCommand MoveAilmentClick { get; }
		#endregion

		#region 技スタイルクリックコマンド
		/// <summary>
		/// 技スタイルクリックコマンド
		/// </summary>
		public RelayCommand MoveBattleStyleClick { get; }
		#endregion

		#region 技カテゴリクリックコマンド
		/// <summary>
		/// 技カテゴリクリックコマンド
		/// </summary>
		public RelayCommand MoveCategoryClick { get; }
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
			BerryFirmnessClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ベリーの固さ(BerryFirmness)", new BerryFirmnessList(), typeof(Window)));
			BerryFlavorClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ベリーの味(BerryFlavor)", new BerryFlavorList(), typeof(Window)));

			// Contests
			ContestTypeClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("コンテストタイプ(ContestType)", new ContestTypeList(), typeof(Window)));

			// Encounters
			EncounterMethodClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("エンカウントの方法(EncounterMethod)", new EncounterMethodList(), typeof(Window)));
			EncounterConditionClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("エンカウント条件(EncounterCondition)", new EncounterConditionList(), typeof(Window)));
			EncounterConditionValueClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("エンカウント条件値(EncounterConditionValue)", new EncounterConditionValueList(), typeof(Window)));

			// Evolution
			EvolutionTriggerClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("進化トリガー(EvolutionTrigger)", new EvolutionTriggerList(), typeof(Window)));

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

			// Locations
			LocationClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("場所(Location)", new LocationList(), typeof(Window)));
			LocationAreaClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("場所エリア(LocationArea)", new LocationAreaList(), typeof(Window)));
			PalParkAreaClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("パルパークエリア(PalParkArea)", new PalParkAreaList(), typeof(Window)));
			RegionClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("地方(Region)", new RegionList(), typeof(Window)));

			// Moves
			MoveClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技(Move)", new MoveList(), typeof(Window)));
			MoveAilmentClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ステータス異常技(Move Ailment)", new MoveAilmentList(), typeof(Window)));
			MoveBattleStyleClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技スタイル(Move Battle Style)", new MoveBattleStyleList(), typeof(Window)));
			MoveCategoryClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技カテゴリ(Move Category)", new MoveCategoryList(), typeof(Window)));

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
