using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace PokeAPI
{
	/// <summary>
	/// ポケモンモデル
	/// </summary>
	internal class PokemonModel
	{
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

		#region 基本経験値
		/// <summary>
		/// 基本経験値
		/// </summary>
		internal int BaseExperience { get; set; } = 0;
		#endregion

		#region 高さ
		/// <summary>
		/// 高さ
		/// </summary>
		internal int Height { get; set; } = 0;
		#endregion

		#region デフォルト
		/// <summary>
		/// デフォルト
		/// </summary>
		internal bool IsDefault { get; set; } = false;
		#endregion

		#region 順番
		/// <summary>
		/// 順番
		/// </summary>
		internal int Order { get; set; } = 0;
		#endregion

		#region 重さ
		/// <summary>
		/// 重さ
		/// </summary>
		internal int Weight { get; set; } = 0;
		#endregion

		#region 特性リスト
		/// <summary>
		/// 特性リスト
		/// </summary>
		internal ObservableCollection<PokemonAbilityViewModel> Abilities { get; } = new ObservableCollection<PokemonAbilityViewModel>();
		#endregion

		#region フォルムリスト
		/// <summary>
		/// フォルムリスト
		/// </summary>
		internal ObservableCollection<NamedAPIResourceViewModel> Forms { get; } = new ObservableCollection<NamedAPIResourceViewModel>();
		#endregion

		#region 関連するゲームインデックスリスト
		/// <summary>
		/// 関連するゲームインデックスリスト
		/// </summary>
		internal ObservableCollection<VersionGameIndexViewModel> GameIndices { get; } = new ObservableCollection<VersionGameIndexViewModel>();
		#endregion

		#region 取得済
		/// <summary>
		/// 取得済
		/// </summary>
		internal bool IsGeted { get; set; } = false;
		#endregion

		// internal メソッド

		#region JSON文字列解析
		/// <summary>
		/// JSON文字列の解析
		/// </summary>
		/// <param name="json">JSON文字列</param>
		internal void GetPokemonJson(string json)
		{
			JObject obj = JObject.Parse(json);
			PokemonParser pokemonParser = new PokemonParser();
			NamedAPIResourceParser namedAPIResourceParser = new NamedAPIResourceParser();
			VersionGameIndexParser versionGameIndexParser = new VersionGameIndexParser();

			ID = (int)obj["id"];
			Name = (obj["name"] as JValue).ToString();
			BaseExperience = (int)obj["base_experience"];
			Height = (int)obj["height"];
			IsDefault = (bool)obj["is_default"];
			Order = (int)obj["order"];
			Weight = (int)obj["weight"];
			pokemonParser.ParsePokemonAbilityList(obj["abilities"], Abilities);
			namedAPIResourceParser.ParseNamedAPIResourceList(obj["forms"], Forms);
			versionGameIndexParser.ParseVersionGameIndexList(obj["game_indices"], GameIndices);
		}
		#endregion
	}
}
