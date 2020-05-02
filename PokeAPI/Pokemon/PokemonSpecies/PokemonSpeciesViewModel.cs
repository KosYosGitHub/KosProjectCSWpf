using System.Windows.Data;
using KosGeneric;
using KosMVVM;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族ビューモデル
	/// </summary>
	public class PokemonSpeciesViewModel : KosViewModel
	{
		// private プロパティ

		#region ポケモン種族モデル
		/// <summary>
		/// ポケモン種族モデル
		/// </summary>
		private PokemonSpeciesModel Model { get; } = new PokemonSpeciesModel();
		#endregion

		// public プロパティ

		#region ID
		/// <summary>
		/// ID
		/// </summary>
		public int ID
		{
			get => Model.ID;
			set {
				Model.ID = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		public string Name
		{
			get => Model.Name;
			set {
				Model.Name = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 順番
		/// <summary>
		/// 順番
		/// </summary>
		public int Order
		{
			get => Model.Order;
			set {
				Model.Order = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 性別レート
		/// <summary>
		/// 性別レート
		/// </summary>
		public int GenderRate
		{
			get => Model.GenderRate;
			set {
				Model.GenderRate = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 取得レート
		/// <summary>
		/// 取得レート
		/// </summary>
		public int CaptureRate
		{
			get => Model.CaptureRate;
			set {
				Model.CaptureRate = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 基本なつき度
		/// <summary>
		/// 基本なつき度
		/// </summary>
		public int BaseHappiness
		{
			get => Model.BaseHappiness;
			set {
				Model.BaseHappiness = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 赤ちゃんポケモン
		/// <summary>
		/// 赤ちゃんポケモン
		/// </summary>
		public bool IsBaby
		{
			get => Model.IsBaby;
			set {
				Model.IsBaby = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 孵化歩数
		/// <summary>
		/// 孵化歩数
		/// </summary>
		public int HatchCounter
		{
			get => Model.HatchCounter;
			set {
				Model.HatchCounter = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 性別による見た目の違いの有無
		/// <summary>
		/// 性別による見た目の違いの有無
		/// </summary>
		public bool HasGenderDifferences
		{
			get => Model.HasGenderDifferences;
			set {
				Model.HasGenderDifferences = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region フォルム変化の有無
		/// <summary>
		/// フォルム変化の有無
		/// </summary>
		public bool FormSwitchable
		{
			get => Model.FormsSwitchable;
			set {
				Model.FormsSwitchable = value;
				RaisePropertyChanged();
			}
		}
		#endregion

		#region 成長レート
		/// <summary>
		/// 成長レート
		/// </summary>
		public NamedAPIResourceViewModel GrowthRate => Model.GrowthRate;
		#endregion

		#region ポケモン図鑑番号リスト
		/// <summary>
		/// ポケモン図鑑番号リスト
		/// </summary>
		public ListCollectionView PokedexNumbers { get; }
		#endregion

		#region 卵グループリスト
		/// <summary>
		/// 卵グループリスト
		/// </summary>
		public ListCollectionView EggGroups { get; }
		#endregion

		#region 色
		/// <summary>
		/// 色
		/// </summary>
		public NamedAPIResourceViewModel Color => Model.Color;
		#endregion

		#region 形
		/// <summary>
		/// 形
		/// </summary>
		public NamedAPIResourceViewModel Shape => Model.Shape;
		#endregion

		#region 進化元ポケモン種族
		/// <summary>
		/// 進化元ポケモン種族
		/// </summary>
		public NamedAPIResourceViewModel EvolvesFromSpecies => Model.EvolvesFromSpecies;
		#endregion

		#region 進化ルート
		/// <summary>
		/// 進化ルート
		/// </summary>
		public APIResourceViewModel EvolutionChain => Model.EvolutionChain;
		#endregion

		#region 生息地
		/// <summary>
		/// 生息地
		/// </summary>
		public NamedAPIResourceViewModel Habitat => Model.Habitat;
		#endregion

		#region 世代
		/// <summary>
		/// 世代
		/// </summary>
		public NamedAPIResourceViewModel Generation => Model.Generation;
		#endregion

		#region 名称リスト
		/// <summary>
		/// 名称リスト
		/// </summary>
		public ListCollectionView Names { get; }
		#endregion

		#region パルパークエンカウントエリアリスト
		/// <summary>
		/// パルパークエンカウントエリアリスト
		/// </summary>
		public ListCollectionView PalParkEncounters { get; }
		#endregion

		#region フレーバーテキストリスト
		/// <summary>
		/// フレーバーテキストリスト
		/// </summary>
		public ListCollectionView FlavorTextEntries { get; }
		#endregion

		#region フォルム説明リスト
		/// <summary>
		/// フォルム説明リスト
		/// </summary>
		public ListCollectionView FormDescriptions { get; }
		#endregion

		#region 属性リスト
		/// <summary>
		/// 属性リスト
		/// </summary>
		public ListCollectionView Genera { get; }
		#endregion

		#region バリエーションリスト
		/// <summary>
		/// バリエーションリスト
		/// </summary>
		public ListCollectionView Varieties { get; }
		#endregion

		// イベントハンドラ

		#region コンストラクタ
		/// <summary>
		/// コンストラクタ
		/// </summary>
		public PokemonSpeciesViewModel()
		{
			PokedexNumbers = new ListCollectionView(Model.PokedexNumbers);
			EggGroups = new ListCollectionView(Model.EggGroups);
			Names = new ListCollectionView(Model.Names);
			PalParkEncounters = new ListCollectionView(Model.PalParkEncounters);
			FlavorTextEntries = new ListCollectionView(Model.FlavorTextEntries);
			FormDescriptions = new ListCollectionView(Model.FormDescriptions);
			Genera = new ListCollectionView(Model.Genus);
			Varieties = new ListCollectionView(Model.Varieties);
		}
		#endregion

		// public メソッド

		#region ポケモン種族の取得
		/// <summary>
		/// ポケモン種族の取得
		/// </summary>
		/// <param name="url">URL</param>
		public void GetPokemonSpecies(string url)
		{
			// 取得済
			if(Model.IsGeted) {
				return;
			}

			// JSON文字列の取得
			string json = Singleton<PokeAPIClient>.Instance.GetJson(url);

			// 解析
			Model.GetPokemonSpeciesJson(json);
			Model.IsGeted = true;

			RaisePropertyChanged(nameof(ID));
			RaisePropertyChanged(nameof(Name));
			RaisePropertyChanged(nameof(Order));
			RaisePropertyChanged(nameof(GenderRate));
			RaisePropertyChanged(nameof(CaptureRate));
			RaisePropertyChanged(nameof(BaseHappiness));
			RaisePropertyChanged(nameof(IsBaby));
			RaisePropertyChanged(nameof(HatchCounter));
			RaisePropertyChanged(nameof(HasGenderDifferences));
			RaisePropertyChanged(nameof(GrowthRate));
			RaisePropertyChanged(nameof(PokedexNumbers));
			RaisePropertyChanged(nameof(EggGroups));
			RaisePropertyChanged(nameof(Color));
			RaisePropertyChanged(nameof(Shape));
			RaisePropertyChanged(nameof(EvolvesFromSpecies));
			RaisePropertyChanged(nameof(Habitat));
			RaisePropertyChanged(nameof(Generation));
			RaisePropertyChanged(nameof(Names));
			RaisePropertyChanged(nameof(PalParkEncounters));
			RaisePropertyChanged(nameof(FlavorTextEntries));
			RaisePropertyChanged(nameof(FormDescriptions));
			RaisePropertyChanged(nameof(Genera));
			RaisePropertyChanged(nameof(Varieties));
		}
		#endregion
	}
}
