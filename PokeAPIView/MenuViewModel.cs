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

		#region 技ダメージクラスクリックコマンド
		/// <summary>
		/// 技ダメージクラスクリックコマンド
		/// </summary>
		public RelayCommand MoveDamageClassClick { get; }
		#endregion

		#region 技習得方法クリックコマンド
		/// <summary>
		/// 技習得方法クリックコマンド
		/// </summary>
		public RelayCommand MoveLearnMethodClick { get; }
		#endregion

		#region 技ターゲットクリックコマンド
		/// <summary>
		/// 技ターゲットクリックコマンド
		/// </summary>
		public RelayCommand MoveTargetClick { get; }
		#endregion

		#region 特性クリックコマンド
		/// <summary>
		/// 特性クリックコマンド
		/// </summary>
		public RelayCommand AbilityClick { get; }
		#endregion

		#region 卵グループクリックコマンド
		/// <summary>
		/// 卵グループクリックコマンド
		/// </summary>
		public RelayCommand EggGroupClick { get; }
		#endregion

		#region 性別クリックコマンド
		/// <summary>
		/// 性別クリックコマンド
		/// </summary>
		public RelayCommand GenderClick { get; }
		#endregion

		#region 成長レートクリックコマンド
		/// <summary>
		/// 成長レートクリックコマンド
		/// </summary>
		public RelayCommand GrowthRateClick { get; }
		#endregion

		#region 性格クリックコマンド
		/// <summary>
		/// 性格クリックコマンド
		/// </summary>
		public RelayCommand NatureClick { get; }
		#endregion

		#region ポケアスロンステータスクリックコマンド
		/// <summary>
		/// ポケアスロンステータスクリックコマンド
		/// </summary>
		public RelayCommand PokeathlonStatClick { get; }
		#endregion

		#region ポケモンクリックコマンド
		/// <summary>
		/// ポケモンクリックコマンド
		/// </summary>
		public RelayCommand PokemonClick { get; }
		#endregion

		#region ポケモン色クリックコマンド
		/// <summary>
		/// ポケモン色クリックコマンド
		/// </summary>
		public RelayCommand PokemonColorClick { get; }
		#endregion

		#region ポケモンフォルムクリックコマンド
		/// <summary>
		/// ポケモンフォルムクリックコマンド
		/// </summary>
		public RelayCommand PokemonFormClick { get; }
		#endregion

		#region ポケモン生息地クリックコマンド
		/// <summary>
		/// ポケモン生息地クリックコマンド
		/// </summary>
		public RelayCommand PokemonHabitatClick { get; }
		#endregion

		#region ポケモンの形クリックコマンド
		/// <summary>
		/// ポケモンの形クリックコマンド
		/// </summary>
		public RelayCommand PokemonShapeClick { get; }
		#endregion

		#region ポケモン種族クリックコマンド
		/// <summary>
		/// ポケモン種族クリックコマンド
		/// </summary>
		public RelayCommand PokemonSpeciesClick { get; }
		#endregion

		#region ステータスクリックコマンド
		/// <summary>
		/// ステータスクリックコマンド
		/// </summary>
		public RelayCommand StatClick { get; }
		#endregion

		#region タイプクリックコマンド
		/// <summary>
		/// タイプクリックコマンド
		/// </summary>
		public RelayCommand TypeClick { get; }
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
			MoveDamageClassClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技ダメージクラス(Move Damage Class)", new MoveDamageClassList(), typeof(Window)));
			MoveLearnMethodClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技習得方法(Move Learn Method)", new MoveLearnMethodList(), typeof(Window)));
			MoveTargetClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("技ターゲット(Move Target)", new MoveTargetList(), typeof(Window)));

			// Pokemon
			AbilityClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("特性(Ability)", new AbilityList(), typeof(Window)));
			EggGroupClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("卵グループ(EggGroup)", new EggGroupList(), typeof(Window)));
			GenderClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("性別(Gender)", new GenderList(), typeof(Window)));
			GrowthRateClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("成長レート(GrowthRate)", new GrowthRateList(), typeof(Window)));
			NatureClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("性格(Nature)", new NatureList(), typeof(Window)));
			PokeathlonStatClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケアスロンステータス(PokeathlonStat)", new PokeathlonStatList(), typeof(Window)));
			PokemonClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモン(Pokemon)", new PokemonList(), typeof(Window)));
			PokemonColorClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモン色(PokemonColor)", new PokemonColorList(), typeof(Window)));
			PokemonFormClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモンフォルム(PokemoForm)", new PokemonFormList(), typeof(Window)));
			PokemonHabitatClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモン生息地(PokemonHabitat)", new PokemonHabitatList(), typeof(Window)));
			PokemonShapeClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモンの形(PokemonShape)", new PokemonShapeList(), typeof(Window)));
			PokemonSpeciesClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ポケモン種族(PokemonSpecies)", new PokemonSpeciesList(), typeof(Window)));
			StatClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("ステータス(Stat)", new StatList(), typeof(Window)));
			TypeClick = new RelayCommand(() => ShowNamedAPIResourceListWindow("タイプ(Type)", new TypeList(), typeof(Window)));

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
