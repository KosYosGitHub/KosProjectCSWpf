using System.Collections.Generic;
using System.Collections.ObjectModel;
using Newtonsoft.Json.Linq;

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
		internal int BaseHappiness { get; set; } = 0;
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
		internal ObservableCollection<PokemonSpeciesDexEntry> PokedexNumbers { get; } = new ObservableCollection<PokemonSpeciesDexEntry>();
		#endregion

		#region 卵グループリスト
		/// <summary>
		/// 卵グループリスト
		/// </summary>
		internal ObservableCollection<NamedAPIResource> EggGroups { get; } = new ObservableCollection<NamedAPIResource>();
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

		#region 取得済フラグ
		/// <summary>
		/// 取得済フラグ
		/// </summary>
		internal bool IsGeted { get; set; } = false;
		#endregion

		// internal メソッド

		#region JSON文字列の解析
		/// <summary>
		/// JSON文字列の解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		internal void GetPokemonSpeciesJson(string json)
		{
			JObject obj = JObject.Parse(json);
			PokemonSpeciesParser pokemonSpeciesParser = new PokemonSpeciesParser();
			NamedAPIResourceParser namedAPIResourceParser = new NamedAPIResourceParser();
			APIResourceParser apiResourceParser = new APIResourceParser();

			ID = (int)obj["id"];
			Name = (obj["name"] as JValue).ToString();
			Order = (int)obj["order"];
			GenderRate = (int)obj["gender_rate"];
			CaptureRate = (int)obj["capture_rate"];
			BaseHappiness = (int)obj["base_happiness"];
			IsBaby = (bool)obj["is_baby"];
			HatchCounter = (int)obj["hatch_counter"];
			HasGenderDifferences = (bool)obj["has_gender_differences"];
			namedAPIResourceParser.ParseNamedAPIResource(obj["growth_rate"], GrowthRate.Model);
			pokemonSpeciesParser.ParsePokemonSpeciesDexEntryList(obj["pokedex_numbers"], PokedexNumbers);
			namedAPIResourceParser.ParseNamedAPIResourceList(obj["egg_groups"], EggGroups);
			namedAPIResourceParser.ParseNamedAPIResource(obj["color"], Color.Model);
			namedAPIResourceParser.ParseNamedAPIResource(obj["shape"], Shape.Model);
			namedAPIResourceParser.ParseNamedAPIResource(obj["evolves_from_species"], EvolvesFromSpecies.Model);
			apiResourceParser.ParseAPIResource(obj["evolution_chain"], EvolutionChain.Model);
			namedAPIResourceParser.ParseNamedAPIResource(obj["habitat"], Habitat.Model);
			namedAPIResourceParser.ParseNamedAPIResource(obj["generation"], Generation.Model);
		}
		#endregion
	}
}
