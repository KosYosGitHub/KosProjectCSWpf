using System.Collections.Generic;

namespace PokeAPI
{
	/// <summary>
	/// ポケモン種族モデル
	/// </summary>
	internal class PokemonSpeciesModel
	{
		// メンバ変数

		#region 孵化歩数
		/// <summary>
		/// 孵化歩数
		/// </summary>
		private int _hatchCounter = 0;
		#endregion

		// プロパティ

		#region ID
		/// <summary>
		/// ID
		/// </summary>
		internal int ID { get; set; } = 0;
		#endregion

		#region 名称
		/// <summary>
		/// 名称
		/// </summary>
		internal string Name { get; set; } = string.Empty;
		#endregion

		#region 順番
		/// <summary>
		/// 順番
		/// </summary>
		internal int Order { get; set; } = 0;
		#endregion

		#region 性別レート
		/// <summary>
		/// 性別レート
		/// </summary>
		internal int GenderRate { get; set; } = -1;
		#endregion

		#region 取得レート
		/// <summary>
		/// 取得レート
		/// </summary>
		internal int CaptureRate { get; set; } = 0;
		#endregion

		#region 基本なつき度
		/// <summary>
		/// 基本なつき度
		/// </summary>
		internal int BaseHapiness { get; set; } = 0;
		#endregion

		#region 赤ちゃんポケモン
		/// <summary>
		/// 赤ちゃんポケモン
		/// </summary>
		internal bool IsBaby { get; set; } = false;
		#endregion

		#region 孵化歩数
		/// <summary>
		/// 孵化歩数
		/// </summary>
		internal int HatchCounter
		{
			get => 255 * (_hatchCounter + 1);
			set => _hatchCounter = value;
		}
		#endregion

		#region 性別による見た目の違いの有無
		/// <summary>
		/// 性別による見た目の違いの有無
		/// </summary>
		internal bool HasGenderDifferences { get; set; } = false;
		#endregion

		#region フォルム変化の有無
		/// <summary>
		/// フォルム変化の有無
		/// </summary>
		internal bool FormsSwitchable { get; set; } = false;
		#endregion

		#region 成長レート
		/// <summary>
		/// 成長レート
		/// </summary>
		internal NamedAPIResource GrowthRate { get; set; } = new NamedAPIResource();
		#endregion

		#region ポケモン図鑑番号リスト
		/// <summary>
		/// ポケモン図鑑番号リスト
		/// </summary>
		internal List<PokemonSpeciesDexEntry> PokedexNumbers { get; } = new List<PokemonSpeciesDexEntry>();
		#endregion

		#region 卵グループリスト
		/// <summary>
		/// 卵グループリスト
		/// </summary>
		internal List<NamedAPIResource> EggGroups { get; } = new List<NamedAPIResource>();
		#endregion

		#region 色
		/// <summary>
		/// 色
		/// </summary>
		internal NamedAPIResource Color { get; } = new NamedAPIResource();
		#endregion

		#region 形
		/// <summary>
		/// 形
		/// </summary>
		internal NamedAPIResource Shape { get; } = new NamedAPIResource();
		#endregion

		#region 進化元ポケモン種族
		/// <summary>
		/// 進化元ポケモン種族
		/// </summary>
		internal NamedAPIResource EvolvesFromSpecies { get; } = new NamedAPIResource();
		#endregion

		#region 進化ルート
		/// <summary>
		/// 進化ルート
		/// </summary>
		internal APIResource EvolutionChain { get; set; } = new APIResource();
		#endregion

		#region 生息地
		/// <summary>
		/// 生息地
		/// </summary>
		internal NamedAPIResource Habitat { get; } = new NamedAPIResource();
		#endregion

		#region 世代
		/// <summary>
		/// 世代
		/// </summary>
		internal NamedAPIResource Generation { get; } = new NamedAPIResource();
		#endregion

		#region 名称リスト
		/// <summary>
		/// 名称リスト
		/// </summary>
		internal List<Name> Names { get; } = new List<Name>();
		#endregion

		#region パルパークエンカウントエリアリスト
		/// <summary>
		/// パルパークエンカウントエリアリスト
		/// </summary>
		internal List<PalParkEncounterArea> PalParkEncounters { get; } = new List<PalParkEncounterArea>();
		#endregion

		#region フレーバーテキストリスト
		/// <summary>
		/// フレーバーテキストリスト
		/// </summary>
		internal List<FlavorText> FlavorTextEntries { get; } = new List<FlavorText>();
		#endregion

		#region フォルム説明リスト
		/// <summary>
		/// フォルム説明リスト
		/// </summary>
		internal List<Description> FormDescriptions { get; } = new List<Description>();
		#endregion

		#region 性格リスト
		/// <summary>
		/// 性格リスト
		/// </summary>
		internal List<Genus> Genus { get; } = new List<Genus>();
		#endregion

		#region バリエーションリスト
		/// <summary>
		/// バリエーションリスト
		/// </summary>
		internal List<PokemonSpeciesVariety> Varieties { get; } = new List<PokemonSpeciesVariety>();
		#endregion
	}
}
